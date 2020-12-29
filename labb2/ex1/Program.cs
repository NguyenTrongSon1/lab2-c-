using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int id;
            string birthDate;
            //int age = (DateTime.Today.Subtract(birthDate)).Days / 365;
            string gender;
            int year;
            Console.Write("Enter the ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Name: ");
            name = Console.ReadLine();
            Console.Write("Enter date of birth[DD/MM/YYYY]: ");
            birthDate = Console.ReadLine();
            Console.Write("Enter Gender[M/F]: ");
            gender = Console.ReadLine();
           
            int choice;
            Console.WriteLine("Select designaction (choose the number): ");
            Console.WriteLine("1. Maganer\n2. System\n3. Deverloper\n4. Accontant");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice: " + choice);
            Console.Write("Enter the tunere in year: ");
            year = Convert.ToInt32(Console.ReadLine());
            
            
            switch (choice)
            {

                case 1:
                    Console.WriteLine("Employee ID: " + id);
                    Console.WriteLine("Employee Name: " + name);
                    break;
                case 2:
                    Console.WriteLine("2. System Analyst");
                    break;
                case 3:
                    Console.WriteLine("3. Developer");
                    break;
                case 4:
                    Console.WriteLine("4. Accountant");
                    break;






            }

        }
    }
}
