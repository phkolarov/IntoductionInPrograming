using System;

    class BirthdayAfterTen
    {
        static void Main(string[] args)
        {
            string suobshtenie = "Напиши твоите години";

            Console.WriteLine(suobshtenie);

            int godini = Convert.ToInt32(Console.ReadLine());

            int rezultat = godini + 10;

            Console.WriteLine("След 10 години ще бъдеш на " + rezultat);

        }
    }