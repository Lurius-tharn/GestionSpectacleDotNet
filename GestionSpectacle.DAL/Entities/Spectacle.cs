using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionSpectacle.DAL.Entities;

[Table("Spectacle")]
public class Spectacle
{
    [Key] public int Id { get; set; }

    public string? Titre { get; set; }
    public string? Date { get; set; }
    public string? Lieu { get; set; }
    public int? NbPlace { get; set; }


    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Titre)}: {Titre}, {nameof(Date)}: {Date}, {nameof(Lieu)}: {Lieu}, {nameof(NbPlace)}: {NbPlace}";
    }
}