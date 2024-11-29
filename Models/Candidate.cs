using System;

namespace BtkAkademiProje.Models;

public class Candidate
{
    public string Email { get; set; } = string.Empty; // string yazma sebebi null olmaması için
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string? FullName => $"{Name} {Surname.ToUpper()}"; // null olabilir
    public int? Age { get; set; }
    public string? SelectedCourse { get; set; } // null olabilir
    public DateTime ApplyAt { get; set; }

    public Candidate()
    {
        ApplyAt = DateTime.Now;
    }
}