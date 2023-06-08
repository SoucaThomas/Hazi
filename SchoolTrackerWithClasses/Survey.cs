using System;

namespace SchoolTrackerWithClasses
{
    public class Survey
    {
        public string name { get; set; }
        public int note { get; set; }

        public static Survey AskStudentDetails()
        {
            Survey student = new Survey();

            Console.WriteLine("Add meg a diák nevét!");
            student.name = Console.ReadLine();

            Console.WriteLine("Add meg a diák jegyét!");
            student.note = GetValidInt();

            return student;
        }

        public static bool NewStudent()
        {
            Console.WriteLine("Van még diák? y/n");
            return GetValidYN();
        }

        public static void Display( Survey student)
        {
            Console.WriteLine($"Diák: {student.name}; Jegye: {student.note}");
        }

        private static int GetValidInt()
        {
            bool success = false;
            int val = new int();

            while(!success)
            {
                try
                {
                    val = int.Parse(Console.ReadLine());
                    success = true;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Adj meg egy számot mint jegy értek!");
                }
            }
            return val;
        }

        private static bool GetValidYN()
        {
            bool success = false;
            bool val = new bool();

            while (!success)
            {
                string console = Console.ReadLine().ToLower();
                if(console == "y")
                {
                    val = true;
                    success = true;
                }
                else if(console == "n")
                {
                    val = false;
                    success = true;
                }
                else
                {
                    Console.WriteLine("Adj meg egy Y vagy N karakter értéket!");
                }
            }
            return val;
        }
    }
}