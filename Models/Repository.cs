using System;

namespace BtkAkademiProje.Models;

public class Repository // veri tutmak için
{
    private static List<Candidate> applications = new();
    public static IEnumerable<Candidate> Applications => applications; // get only

    public static void Add(Candidate candidate)
    {
        applications.Add(candidate); // add to list
    }
}
