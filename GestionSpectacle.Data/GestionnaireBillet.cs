using EFCoreConsoleApp.DAL.Context;
using GestionSpectacle.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionSpectacle.Data;

public delegate void AnnulationBilletDelegate(Billet billet, Spectacle spectacle);

public delegate void ReservationDelegate(Spectacle spectacle, Utilisateur utilisateur, int nombreBillets);

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

    public void ReserverBillets(Spectacle spectacle, Utilisateur utilisateur, int nombreBillets)
    {
        if (spectacle.NbPlace >= nombreBillets)
        {
            var billet = new Billet
            {
                IdSpectacle = spectacle.Id,
                IdUtilisateur = utilisateur.Id,
                Statut = ReservationStatus.Reserve.ToString()
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
        _context.Entry(billet).State = EntityState.Detached;

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