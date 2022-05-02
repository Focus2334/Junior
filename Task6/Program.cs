using System;

class Program
{
    static void Main(string[] args)
    {
        int picturesInRow = 3;
        int allPictures = 52;
        int rows = allPictures / picturesInRow;
        int remainder = allPictures % picturesInRow;
        Console.WriteLine("Всего рядов: " + rows + ", картин сверх меры: " + remainder);
    }
}
