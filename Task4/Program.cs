using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("как вас зовут?: ");
        string name = Console.ReadLine();
        Console.WriteLine("ваш знак зодиака: ");
        string sigh = Console.ReadLine();
        Console.WriteLine("ваш возраст: ");
        string age = Console.ReadLine();
        Console.WriteLine("ваш город: ");
        string town = Console.ReadLine();
        Console.WriteLine("Вас зовут " + name + ", ваш знак зодиака " + sigh + ", вам " + age + " лет, а живёте вы в городе " + town + ".");
    }
}
