using System.ComponentModel.DataAnnotations;

namespace GestionSpectacle.DAL.Entities;

public class BilletHistorique
{
    public DateTime DateBillet;

    [Key] public int Id { get; set; }
    public int? IdBillet { get; set; }

    public virtual Billet? IdBilletNavigation { get; set; }
}