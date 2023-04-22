using System;

namespace ClockReiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, minutes;
            const int MINUTES_PER_HOUR = 60;
            const int DEGREES_PER_HOUR = 30;
            const int DEGREES_PER_MINUTE = 6;

            // get user input
            Console.Write("Enter the hour (0-23): ");
            hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the minute (0-59): ");
            minutes = int.Parse(Console.ReadLine());

            // calculate angle between hands
            double hourAngle = (hours % 12 + (double)minutes / MINUTES_PER_HOUR) * DEGREES_PER_HOUR;
            double minuteAngle = minutes * DEGREES_PER_MINUTE;
            double angle = Math.Abs(hourAngle - minuteAngle);
            if (angle > 180) {
                angle = 360 - angle;
            }

            // output result
            Console.WriteLine("The lesser angle between the hour and minute hands is: {0} degrees.", angle);
            Console.ReadLine(); // added to prevent the console from closing immediately
        }
    }
}
