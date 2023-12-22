using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionSpectacle.DAL.Entities;

[Table("Utilisateur")]
public class Utilisateur
{
    [Key] public int Id { get; set; }

    public string? Nom { get; set; }

    public string? UserName { get; set; }


    public string? Password { get; set; }

    [MaxLength(16)] public byte[]? Salt { get; set; }
}