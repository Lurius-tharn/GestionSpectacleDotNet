using GestionSpectacle.DAL.Context;
using GestionSpectacle.DAL.Entities;

namespace GestionSpectacle.Data;

public delegate void AnnulationBilletDelegate(Billet billet, Spectacle spectacle);

public delegate void ReservationDelegate(Spectacle spectacle, int utilisateur, int nombreBillets);

public class GestionnaireBillet
{
    private readonly MyDbContext _context;
    public AnnulationBilletDelegate AnnulerReservationDelegate;

    public ReservationDelegate ReserverBilletsDelegate;


    public GestionnaireBillet()
    {
        _context = new MyDbContext();
        ReserverBilletsDelegate = ReserverBillets;
        AnnulerReservationDelegate = AnnulerReservation;
    }

    public void ReserverBillets(Spectacle spectacle, int Idutilisateur, int nombreBillets)
    {
        _context.Spectacles.Add(spectacle);
        _context.SaveChanges();

        var spectacleId = spectacle.Id;

        if (spectacle.NbPlace >= nombreBillets)
            for (var i = 1; i <= nombreBillets; i++)
            {
                var billet = new Billet
                {
                    IdSpectacle = spectacleId,
                    IdUtilisateur = Idutilisateur,
                    Statut = ReservationStatus.Reserve.ToString(),
                    numeroBillet = i
                };

                _context.Billets.Add(billet);
                spectacle.NbPlace -= nombreBillets;
                _context.Spectacles.Update(spectacle);
                _context.SaveChanges();
                Console.WriteLine($"Réservation réussie pour le spectacle {spectacle.Titre} le {spectacle.Date}.");
            }
    }

    public void AnnulerReservation(Billet billet, Spectacle spectacle)
    {
        _context.Billets.Remove(billet);
        ++spectacle.NbPlace;
        _context.Spectacles.Update(spectacle);
        _context.SaveChanges();

        Console.WriteLine("Réservation annulée avec succès.");
    }
}

public enum ReservationStatus
{
    Reserve
}