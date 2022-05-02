using System;

class Program
{
    static void Main(string[] args)
    {
        int picturesInRow = 3;
        int allPictures = 52;
        int fullyFilledRowsOfPictures = allPictures / picturesInRow;
        int remainderOfPicturesBeyondMeasure = allPictures % picturesInRow;
        Console.WriteLine("Всего рядов: " + fullyFilledRowsOfPictures + ", картин сверх меры: " + remainderOfPicturesBeyondMeasure);
    }
}
