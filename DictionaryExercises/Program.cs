using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudentName;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            do
            {
                Console.WriteLine("Name: ");
                string input = Console.ReadLine();
                newStudentName = input;

                if (!Equals(newStudentName, ""))
                {
                    Console.WriteLine("ID: ");
                    string inputID = Console.ReadLine();
                    int newStudentID = int.Parse(inputID);
                    students.Add(newStudentID, newStudentName);
                }
            }
            while (!Equals(newStudentName, ""));

            Console.WriteLine("/nClass Roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

        }
    }
}
