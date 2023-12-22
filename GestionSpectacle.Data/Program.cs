using System.Security.Cryptography;
using GestionSpectacle.DAL.Context;
using GestionSpectacle.DAL.Entities;
using GestionSpectacle.Data;

namespace EFCoreConsoleApp;

internal class Program
{
    public delegate void MyDelegate(string msg); // declare a delegate

// set target method
    private static void Main()
    {
        var dbContext = new MyDbContext();
        var gestionnaireBillet = new GestionnaireBillet();
        var spectacle = new Spectacle
        {
            Titre = "Spectacle A",
            Date = "20/10/2015",
            Lieu = "",
            NbPlace = 10
        };
        var utilisateur = new Utilisateur
        {
            Nom = "GOGNIAT Pierre",
            Password = "Password",
            UserName = "Pierre"
        };

        utilisateur.Salt = RandomNumberGenerator.GetBytes(128 / 8);

        dbContext.Spectacles.Add(spectacle);
        dbContext.SaveChanges();
        dbContext.Utilisateurs.Add(utilisateur);
        dbContext.SaveChanges();


        ;
        //
        // gestionnaireBillet.ReserverBillets(spectacle, utilisateur, 2);
        //
        // Console.WriteLine($"Places disponibles après réservation : {spectacle.NbPlace}");
        //
        // var dernierBillet = dbContext.Billets.First();
        //
        // gestionnaireBillet.AnnulerReservation(dernierBillet, spectacle);
        //
        // Console.WriteLine($"Places disponibles après annulation : {spectacle.NbPlace}");
        //
        // var spectacleEtListeBillet = dbContext.Billets.ToList();
        // var spectacles = dbContext.Spectacles.Where(spectacle1 => spectacle1.Date.Equals("22/22/2022")).ToList();
        //
        // spectacles.ForEach(spectacle1 => Console.WriteLine(spectacle1.ToString()));
    }
}