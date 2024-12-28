using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = CreateArray();
            AcceptInfo(students);

            Console.WriteLine("\nOriginal Student Information:");
            PrintInfo(students);

            Student[] reversedStudents = new Student[students.Length];
            ReverseArray(students, reversedStudents);

            Console.WriteLine("\nReversed Student Information:");
            PrintInfo(reversedStudents);
        }

        public static Student[] CreateArray()
        {
            Console.Write("Enter the number of students: ");
            int size = int.Parse(Console.ReadLine());

            return new Student[size];
        }

        public static void AcceptInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nEntering details for Student {i + 1}:");

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Gender (true for Male, false for Female): ");
                bool gender = bool.Parse(Console.ReadLine());

                Console.Write("Enter Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter Standard: ");
                int std = int.Parse(Console.ReadLine());

                Console.Write("Enter Division: ");
                char div = char.Parse(Console.ReadLine());

                Console.Write("Enter Marks: ");
                double marks = double.Parse(Console.ReadLine());

                students[i] = new Student(name, gender, age, std, div, marks);
            }
        }

        public static void PrintInfo(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void ReverseArray(Student[] original, Student[] reversed)
        {
            int n = original.Length;
            for (int i = 0; i < n; i++)
            {
                reversed[i] = original[n - i - 1];
            }
        }
    }

    class Student
    {
        public string name;
        public bool gender;
        public int age;
        public int std;
        public char div;
        public double marks;

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public override string ToString()
        {
            string gend = gender ? "Male" : "Female";
            return $"Name: {name}, Gender: {gend}, Age: {age}, Standard: {std}, Division: {div}, Marks: {marks}";
        }
    }
}
