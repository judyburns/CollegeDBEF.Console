using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace CollegeDBEF
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNbr { get; set; }
        public virtual List<Class> Classes_ID { get; set; }
    }

    public class Class
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public string Instructor { get; set; }
        public virtual List<Score> Scores_ID { get; set; }
    }
    public class Score
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateSubmitted { get; set; }
        public int PointsEarned { get; set; }
        public int PointsPossible { get; set; }
    }
    public class CollegeDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Score> Scores { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CollegeDBContext())
            {
                String dateAssigned = "2018-03-05";
                DateTime parsedAssigned = DateTime.Parse(dateAssigned);

                String dateDue = "2018-03-09";
                DateTime parsedDue = DateTime.Parse(dateDue);

                String dateSubmitted = "2018-03-09";
                DateTime parsedSubmitted = DateTime.Parse(dateSubmitted);

                // Instantiate Student and add to the database

                // create and add student1 to the database

                /*
                Student student1 = new Student
                {
                    FName = "Bob",
                    LName = "Barker",
                    SSN = 123456789,
                    Address = "111 Barker Lane",
                    City = "Sin City",
                    State = "OH",
                    Zip = 44070,
                    PhoneNbr = 2165551212,
                    Classes_ID = new List<Class>()
                };
                db.Students.Add(student1);

                // create and add student2 to the database
                Student student2 = new Student
                {
                    FName = "John",
                    LName = "Doe",
                    SSN = 234567891,
                    Address = "222 Doe Lane",
                    City = "Sin City",
                    State = "OH",
                    Zip = 44070,
                    PhoneNbr = 2165551212,
                    Classes_ID = new List<Class>()
                };
                db.Students.Add(student2);

                // create and add student3 to the database
                Student student3 = new Student
                {
                    FName = "Sally",
                    LName = "Jones",
                    SSN = 345678912,
                    Address = "333 Jones Lane",
                    City = "Sin City",
                    State = "OH",
                    Zip = 44070,
                    PhoneNbr = 2165551212,
                    Classes_ID = new List<Class>()
                };
                db.Students.Add(student3);

                */

                // create and add student4 to the database
                Student student4 = new Student
                {
                    FName = "Marcus",
                    LName = "Garvey",
                    SSN = 456789123,
                    Address = "444 Garvey Lane",
                    City = "New Reality",
                    State = "OH",
                    Zip = 44070,
                    PhoneNbr = 2165551212,
                    Classes_ID = new List<Class>()
                };
                db.Students.Add(student4);

                // Instantiate Classes and add to student's classes collection

                // add class1 to student1 classes collection

                /*
                var class1 = new Class
                {
                    Title = "Algebra",
                    Number = "101",
                    Department = "Math",
                    Scores_ID = new List<Score>()
                };
                student1.Classes_ID.Add(class1);

                // add class2 to student2 classes collection
                var class2 = new Class
                {
                    Title = "Geometry",
                    Number = "102",
                    Department = "Math",
                    Scores_ID = new List<Score>()
                };
                student2.Classes_ID.Add(class2);

                // add class3 to student3 classes collection
                var class3 = new Class
                {
                    Title = "Trigonometry",
                    Number = "103",
                    Department = "Math",
                    Scores_ID = new List<Score>()
                };
                student3.Classes_ID.Add(class3);
                */

                // add class4 to student4 classes collection
                var class4 = new Class
                {
                    Title = "African History",
                    Number = "104",
                    Department = "History",
                    Instructor = "Booker T. Washington",
                    Scores_ID = new List<Score>()
                };
                student4.Classes_ID.Add(class4);

                // add class5 to student4 classes collection
                var class5 = new Class
                {
                    Title = "African American History",
                    Number = "105",
                    Department = "History",
                    Instructor = "Malcolm X",
                    Scores_ID = new List<Score>()
                };
                student4.Classes_ID.Add(class5);


                // Instantiate Scores and add to class's scores collection

                // add score1 to class1 scores collection

                /*
                var score1 = new Score
                {
                    Type = "HW",
                    Description = "Home Work",
                    DateAssigned = parsedAssigned,
                    DateDue = parsedDue,
                    DateSubmitted = parsedSubmitted,
                    PointsEarned = 100,
                    PointsPossible = 100,
                };
                class1.Scores_ID.Add(score1);

                // add score2 to class2 scores collection
                var score2 = new Score
                {
                    Type = "QZ",
                    Description = "Quiz1",
                    DateAssigned = parsedAssigned,
                    DateDue = parsedDue,
                    DateSubmitted = parsedSubmitted,
                    PointsEarned = 75,
                    PointsPossible = 100,
                };
                class2.Scores_ID.Add(score2);

                // add score3 to class3 scores collection
                var score3 = new Score
                {
                    Type = "QZ",
                    Description = "Quiz2",
                    DateAssigned = parsedAssigned,
                    DateDue = parsedDue,
                    DateSubmitted = parsedSubmitted,
                    PointsEarned = 85,
                    PointsPossible = 100,
                };
                class3.Scores_ID.Add(score3);
                */

                // add score4 to class4 scores collection
                var score4 = new Score
                {
                    Type = "QZ",
                    Description = "African History",
                    DateAssigned = parsedAssigned,
                    DateDue = parsedDue,
                    DateSubmitted = parsedSubmitted,
                    PointsEarned = 100,
                    PointsPossible = 100,
                };
                class4.Scores_ID.Add(score4);

                // add score5 to class4 scores collection
                var score5 = new Score
                {
                    Type = "QZ",
                    Description = "African American History",
                    DateAssigned = parsedAssigned,
                    DateDue = parsedDue,
                    DateSubmitted = parsedSubmitted,
                    PointsEarned = 100,
                    PointsPossible = 100,
                };
                class5.Scores_ID.Add(score5);

                // save database changes
                db.SaveChanges();

                var query = from student in db.Students
                            orderby student.LName, student.FName
                            select student;

                Console.WriteLine("College Student/Class Report:");
                Console.WriteLine();

                // list classes for each student
                foreach (var student in query)
                {
                    Console.WriteLine($"{student.FName + " " + student.LName} located at {student.Address}");
                    foreach (Class course in student.Classes_ID) {
                        Console.WriteLine($"- Title: {course.Title}");
                        Console.WriteLine($"- Number: {course.Number}");
                        Console.WriteLine($"- Department: {course.Department}");
                    }
                }

                Console.WriteLine("Press a key to exit...");
                Console.ReadKey();
            }
        }
    }
}