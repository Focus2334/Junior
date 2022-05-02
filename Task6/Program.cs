using System;

class Program
{
    static void Main(string[] args)
    {
        int row = 3;
        int allPictures = 52;
        Console.WriteLine("Всего рядов: " + (allPictures / row) + ", картин сверх меры: " + (allPictures % row));
    }
}
