using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionSpectacle.DAL.Entities;

[Table("Billet")]
public class Billet
{
    [Key] public int? Id { get; set; }

    public int? IdSpectacle { get; set; }

    public int? IdUtilisateur { get; set; }

    public string? Statut { get; set; }

    public virtual Spectacle? IdSpectacleNavigation { get; set; }
    public virtual Utilisateur? IdUtilisateurNavigation { get; set; }
}