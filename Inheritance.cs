using System;

namespace CSharp
{
    public interface IPerson
    {
        string Name { get; set; }
        string Email { get; set; }
        void ShowName();
    }
    public class Person: IPerson
    {
        private string _name;
        private string _email;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; } 
        }

        public void ShowName()
        {
            Console.WriteLine($"Person's Name: { Name }");
        }
    }

    public class Student : IPerson
    {
        private string _name;
        private string _email;
        private string[] _grades;
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string[] Grades { get => _grades; set => _grades = value; }

        public void ShowName()
        {
            Console.WriteLine($"Students's Name: { Name }");
        }
    }

    // An abstract class is a special type of class that cannot be instantiated.
    // An abstract class is designed to be inherited by subclasses that either implement or override its methods.
    // black boxing.
    public abstract class Teacher : IPerson
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }  
        public string[] Students { get; set; }

        public void ShowName()
        {
            Console.WriteLine($"Teacher's Name: { Name }");
        }
        // every teacher begins the profession teaching a subject
        // but this can be changed as time goes on.
        // virtual methods have and implementation with it, not just a definition.
        // they can be overridden.
        public virtual void ShowSubject()
        {
            Console.WriteLine($"Subject name: { Subject }");
        }

        // until a teacher gets hired the school they work for is an abstract fact about them.
        // in time they will get a job.
        // abstract methods cannot have an implementation.
        // provide implementation in overridden methods.
        public abstract void ShowSchool();

        // same as Subject, until a teacher gets hired the students they have are and abstract concept.
        public abstract void ShowStudents();
       
    }

    public class PrivateTeacher : Teacher
    {
        public override void ShowSchool()
        {
            Console.WriteLine($"This teacher is a private tutor, he/she does not work for a school.");
        }

        public override void ShowStudents()
        {
            TeacherHelper.ShowStudents(Students);   
        }
    }

    public class PublicTeacher : Teacher
    {
        // a public school teacher will work for a school, a private tutor will not. 
        // School property only needs to belong to PublicTeacher, so it does.
        public string School { get; set; }
        public override void ShowSchool()
        {
            Console.WriteLine($"School name: { School }");
        }

        public override void ShowStudents()
        {
            TeacherHelper.ShowStudents(Students);
        }
    }

    // since both types of teachers need to implement ShowStudents make helper class to cut down on code copying.
    // class marked as static so its methods can be called globally within the namespace without having to create the object.
    public static class TeacherHelper
    {
        public static void ShowStudents(string[] students)
        {
            foreach(var student in students)
            {
                Console.WriteLine($"student: { student }");
            }
        }
    }

}
