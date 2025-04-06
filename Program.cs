using System;
namespace StornoStrategie
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Beispiel für die Verwendung der Klassen
            Reise sr = new StandardReise(1000,DateTime.Now); // Standardreise mit Grundpreis 1000 und Reisebeginn heute
            Console.WriteLine($"Stornokosten für Standardreise: {sr.ExecuteStornoBerechnen()}");

           sr.SetStornoAlgorithmus(new KulanterStornoAlgorithmus()); // Ändern des Storno Algorithmus
            Console.WriteLine($"Stornokosten für Standardreise mit flexiblem Algorithmus: {sr.ExecuteStornoBerechnen()}");

            Reise pr = new PremiumReise(2000, DateTime.Now); // Premiumreise mit Grundpreis 2000 und Reisebeginn heute
            Console.WriteLine($"Stornokosten für Premiumreise: {pr.ExecuteStornoBerechnen()}");

            pr.SetStornoAlgorithmus(new StrengerStornoAlgorithmus()); // Ändern des Storno Algorithmus
            Console.WriteLine($"Stornokosten für Premiumreise mit strengen Algorithmus: {pr.ExecuteStornoBerechnen()}");
        }
    }
}