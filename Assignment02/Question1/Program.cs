namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.acceptStudent();
            s.displayStudents();
        }
        public struct Student
        {
            public string name;
            public bool gender;
            public int age;
            public int std;
            public char div;
            public double marks;

            public Student()
            {
                string name = "";
                bool gender = true;
                int age = 0;
                int std = 0;
                char div = 'A';
                double marks = 0;
            }

            public Student(string name, bool gender, int age, int std, char div, double marks)
            {
                this.name = name;
                this.gender = gender;
                this.age = age;
                this.std = std;
                this.div = div;
                this.marks = marks;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public bool Gender
            {
                get { return gender; }
                set { gender = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public int Std
            {
                get { return std; }
                set { std = value; }
            }

            public char Div
            {
                get { return div; }
                set { div = value; }
            }

            public double Marks
            {
                get { return marks; }
                set { marks = value; }
            }

            public void acceptStudent()
            {
                Console.WriteLine("\nEnter Student Name - ");
                name = Console.ReadLine();
                Console.WriteLine("\nEnter Student Gender - ");
                gender = bool.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter Student Age - ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter Student Standard");
                std = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter Students Division - ");
                div = char.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter Students Marks - ");
                marks = double.Parse(Console.ReadLine());
            }

            public void displayStudents()
            {
                Console.WriteLine("Name = " + name);
                Console.WriteLine("Gender = " + gender);
                Console.WriteLine("Age = " + age);
                Console.WriteLine("Standard = " + std);
                Console.WriteLine("Division = " + div);
                Console.WriteLine("Marks = " + marks);
            }
        }
    }
}
