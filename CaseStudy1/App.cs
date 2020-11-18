using System;


namespace CaseStudy1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }

        internal Student(int Id, string Name, string Date)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateOfBirth = Date;
        }

    }

    class Info
    {
        public void Display(Student student)
        {
            Console.WriteLine("Student ID : {0}", student.Id);
            Console.WriteLine("Student Name : {0}", student.Name);
            Console.WriteLine("Student BirthDate : {0}", student.DateOfBirth);
            Console.WriteLine();
        }

        public void Display(Course course)
        {
            Console.WriteLine("Course ID : {0}", course.Id);
            Console.WriteLine("Course Name : {0}", course.Name);
            Console.WriteLine("Course Duration : {0}", course.Duration);
            Console.WriteLine("Course Fees : {0}", course.Fees);
            Console.WriteLine();
        }
    }

    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Fees { get; set; }

        internal Course(int Id, string Name, int Duration, int Fees)
        {
            this.Id = Id;
            this.Name = Name;
            this.Duration = Duration;
            this.Fees = Fees;
        }
    }

    class App
    {
        void Scenario1()
        {
            Student student = new Student(1, "Anna", "23-09-1998");
            new Student(2, "Wayne", "12-02-1997");

            Console.WriteLine("------------------Scenario 1--------------------");

            Info info = new Info();
            info.Display(student);            
        }

        void Scenario2()
        {
            Student[] studentarray = new Student[3];
            studentarray[0] = new Student(101, "Sara", "12-06-1989");
            studentarray[1] = new Student(102, "Sean", "31-04-1999");
            studentarray[2] = new Student(103, "Clara", "01-01-1909");

            Console.WriteLine("------------------Scenario 2--------------------");
            
            Info info = new Info();
            foreach (Student student in studentarray)
                info.Display(student);
        }

        void scenario3()
        {
            int n, Id;
            string Name, Date;
            Console.Write("Enter number of students : ");
            n = Convert.ToInt32(Console.ReadLine());
            Student[] studentarray = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Id {0} : ", (i+1));
                Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name {0} : ", (i + 1));
                Name = Console.ReadLine();
                Console.Write("Enter BirthDate {0} : ", (i + 1));
                Date = Console.ReadLine();
                Console.WriteLine();
                studentarray[i] = new Student(Id, Name, Date);
            }

            Console.WriteLine("------------------Scenario 3--------------------");

            Info info = new Info();
            foreach (Student student in studentarray)
                info.Display(student);
        }

        void scenario4()
        {
            Course course = new Course(10001, "Computer", 4, 100000);

            Console.WriteLine("------------------Scenario 4--------------------");
            
            Info info = new Info();
            info.Display(course);

        }

        static void Main()
        {
            App app = new App();
            app.Scenario1();            
            app.Scenario2();            
            app.scenario3();            
            app.scenario4();
            
            Console.WriteLine("Hi");
            Console.Read();
        }
    }
}


