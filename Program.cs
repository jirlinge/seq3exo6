using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("renseignez votre nom : ");
            string Name = Console.ReadLine();
            Console.WriteLine("renseignez votre prénom : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("renseignez votre age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Votre fiche de renseignement\nNom : {Name}\nPrénom : {FirstName}\nAge : {age}");
        }
    }
}
