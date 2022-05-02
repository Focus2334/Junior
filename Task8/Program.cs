using System;

class Program
{
    static void Main(string[] args)
    {
        int timeForOnePerson = 10;
        int minutesInHour = 60
        Console.WriteLine("Введите кол-во старушек:");
        int numberOfPerson = int.Parse(Console.ReadLine());
        int timeForWaitInMinutes = timeForOnePerson * numberOfPerson;
        int timeForWaitInHours = timeForWaitInMinutes / minutesInHour;
        timeForWaitInMinutes = timeForWaitInMinutes - (timeForWaitInHours * minutesInHour);
        if (timeForWaitInHours != 0 & timeForWaitInMinutes != 0)
        {
            Console.WriteLine("Вы должны отстоять в очереди {0} часа и {1} минут.", timeForWaitInHours, timeForWaitInMinutes);
        }
        else
        {
            if (timeForWaitInMinutes != 0)
            {
                Console.WriteLine("Вы должны отстоять в очереди {0} минут.", timeForWaitInMinutes);
            }
            else
            {
                Console.WriteLine("Вы должны отстоять в очереди {0} часа.", timeForWaitInHours);
            }
        }


    }
}
