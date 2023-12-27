using System.ComponentModel.DataAnnotations;

namespace GestionSpectacle.DAL.Entities;

public class BilletHistorique
{
    public DateTime DateSuppression;

    [Key] public int? Id { get; set; }

    public int? IdSpectacle { get; set; }

    public int? IdUtilisateur { get; set; }

    public string? Statut { get; set; }

    public virtual Spectacle? IdSpectacleNavigation { get; set; }
    public virtual Utilisateur? IdUtilisateurNavigation { get; set; }
    public int numeroBillet { get; set; }
}