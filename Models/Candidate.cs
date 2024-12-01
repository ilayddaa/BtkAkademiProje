using System.ComponentModel.DataAnnotations;

namespace BtkAkademiProje.Models;

public class Candidate
{
    [Required(ErrorMessage = "Email is required")] // zorunlu alan
    public string Email { get; set; } = string.Empty; // string yazma sebebi null olmaması için

    [Required(ErrorMessage = "Name is required")] // name zorunlu alan
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Surname is required")] // surname zorunlu alan
    public string Surname { get; set; } = string.Empty;

    public string? FullName => $"{Name} {Surname.ToUpper()}";
    public int? Age { get; set; }
    public string? SelectedCourse { get; set; } = String.Empty; // null olabilir
    public DateTime ApplyAt { get; set; }

    public Candidate()
    {
        ApplyAt = DateTime.Now;
    }
}