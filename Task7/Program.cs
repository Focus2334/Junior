using System;

class Program
{
    static void Main(string[] args)
    {
        int cristallPrice = 15;
        Console.WriteLine("Сколько у вас золота?");
        int totalGold = int.Parse(Console.ReadLine());
        Console.WriteLine("Сколько кристаллов вы хотите купить за золото по цене {0}?", cristallPrice);
        int numberOfCristallToBuy = int.Parse(Console.ReadLine());
        int remainGold = totalGold - (cristallPrice * numberOfCristallToBuy);
        Console.WriteLine("Вы купили {0} кристаллов", numberOfCristallToBuy);
        Console.WriteLine("У вас осталось {0} золота", remainGold);

    }
}
