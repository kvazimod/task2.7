using System;

    internal class Program
    {
        static void Main()
        {
        Random rand = new Random();

        Console.WriteLine($"Введите email ученика");
        string Email = Console.ReadLine();

        Console.WriteLine($"Введите ФИО ученика");
        string FuelName = Console.ReadLine();

        Console.WriteLine($"Введите возраст ученика");
        double Age = Convert.ToDouble(Console.ReadLine());

        double Programming = rand.Next(0, 100 + 1);
        double Math = rand.Next(0, 100 + 1);
        double Fizik = rand.Next(0, 100 + 1);

        Console.WriteLine($"\nНажмите любую кнопку для вывода информации");

        Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Ученик: {FuelName} \nВозраст: {Age} \nEmail {Email} \nБаллы: \nПрограммирование: {Programming} \nМатематика: {Math} \nФизика: {Fizik}");

        Console.WriteLine($"\nПоказать средний балл \nУченик: {FuelName}");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"Средний балл \nУченик: {FuelName}: \n{(Programming + Math + Fizik) / 3}");
        Console.ReadLine();

    }
    }
