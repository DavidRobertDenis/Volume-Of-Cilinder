using System;

class Program
{
    static void Main()
    {
        // Definirea variabilelor
        double raza = 10;
        double inaltime = 50;

        // Calcularea volumului cilindrului
        double volum = Math.PI * Math.Pow(raza, 2) * inaltime;

        // Afișarea rezultatului
        Console.WriteLine($"Volumul cilindrului cu raza {raza} și înălțimea {inaltime} este: {volum}");
    }
}
