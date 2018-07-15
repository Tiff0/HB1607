using System;
using System.Drawing;
using static System.Console;
using static System.Threading.Thread;

namespace HB1607
{
    internal class Program
    {
        private const int Red = 244;
        private const int Green = 212;
        private const int Blue = 255;
        private const int DotCount = 100;
        private const int SleepTime = 40;

        private static void Main(string[] args)
        {
            DrawLine("Loading", Red, Green, Blue);
            DrawDots();
            DrawLine("Date: " + DateTime.Now.Date.ToShortDateString(), Red, Green, Blue);
            DrawLine("Name: Philip", Red, Green, Blue);
            DrawDots();
            Clear();
            DrawLine("Happy Birthday Philip!", Red, Green, Blue);
            ReadKey(true);
        }

        private static void DrawDots()
        {
            for (var i = 0; i < DotCount; i++)
            {
                Write(".");
                Sleep(SleepTime);

                if (i == DotCount - 1)
                {
                    WriteLine(Environment.NewLine);
                }
            }
        }

        private static void DrawLine(string line, int da, int v, int id)
        {
            Colorful.Console.WriteAscii(line, Color.FromArgb(da, v, id));
            Sleep(SleepTime);
        }
    }
}