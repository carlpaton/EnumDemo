using EnumDemo.Enum;
using System;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize with two flags using bitwise OR.
            var meetingDays = Days.Tuesday | Days.Thursday | Days.Friday;
            Console.WriteLine($"Meeting days are {meetingDays} with flag value {(int)meetingDays}");
            // Meeting days are Tuesday, Thursday, Friday with flag value 52

            // Toggle a flag using bitwise XOR, this will remove `Days.Tuesday` from `meetingDays`
            meetingDays = meetingDays ^ Days.Tuesday;
            Console.WriteLine($"Meeting days are {meetingDays} with flag value {(int)meetingDays}");
            // Meeting days are Thursday, Friday with flag value 48

            // Test value of flags using bitwise AND, this is checking for the existance of `Days.Thursday` in `meetingDays`
            bool test = (meetingDays & Days.Thursday) == Days.Thursday;
            Console.WriteLine($"Thursday {(test == true ? "is" : "is not")} a meeting day.");
            // Thursday is a meeting day.
        }
    }
}
