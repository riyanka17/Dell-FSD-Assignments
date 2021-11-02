using System;
using System.IO;

namespace Dell_FSD_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Rainbow School!\nThis system will allow you to store and retrieve teacher data");
            int ch;
            do
            {
                Console.WriteLine("What do you want to do?\n1. Store data\n2.Retrieve data\nEnter your choice:");
                int choice = int.Parse(Console.ReadLine());
                TeacherData td = new TeacherData();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Store teacher data");
                        td.storeData();
                        break;
                    case 2:
                        Console.WriteLine("Retrieve teacher data");
                        td.retrieveData();
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                Console.WriteLine("Do you want to continue?\n1-Yes\n0-No\nEnter your choice:");
                ch = int.Parse(Console.ReadLine());
            } while (ch == 1);
            Console.ReadKey();
        }
    }
    public class TeacherData
    {
        public void storeData()
        {
            string tdata = @"E:\Dell-FSD-Assignments\Assignment 1\Dell-FSD-Project-1\Dell-FSD-Project-1\TeacherData.txt";

            string[] info = new string[5];
            Console.WriteLine("Enter ID:");
            info[0] = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            info[1] = Console.ReadLine();
            Console.WriteLine("Enter Class:");
            info[2] = Console.ReadLine();
            Console.WriteLine("Enter Section:");
            info[3] = Console.ReadLine();
            info[4] = "\n";

            using (StreamWriter writer = File.AppendText(tdata))
            {
                foreach (string td in info)
                {
                    writer.WriteLine(td);
                }

            }
        }

        public void retrieveData()
        {
            string tdata = @"E:\Dell-FSD-Assignments\Assignment 1\Dell-FSD-Project-1\Dell-FSD-Project-1\TeacherData.txt";
            if (File.Exists(tdata))
            {
                StreamReader teacherdata = new StreamReader(tdata);
                string line;
                while ((line = teacherdata.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                teacherdata.Close();
                Console.WriteLine("Teacher Data Retrieved");
                Console.WriteLine();
            }

        }
    }
}
