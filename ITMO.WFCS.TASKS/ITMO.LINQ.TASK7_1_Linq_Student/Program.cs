using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.LINQ.TASK7_1_Linq_Student
{
    class Program
    {

        static List<Student> students = new List<Student>
            {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Student {First="Vasya", Last="Pupkin", ID=115, Scores= new List<int> {36, 73, 92, 71}},
            new Student {First="Kolya", Last="Ivanov", ID=115, Scores= new List<int> {150, 45, 85, 75}},
            };



        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
               from student in students
               where student.Scores[0] > 90 && student.Scores[3] < 80
               select student;
                foreach (Student student in studentQuery)
                {
                    Console.WriteLine("{0}, {1}", student.Last, student.First);
                }
            int studentCount = (
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                select student).Count();

            int studentCountW = students.Where(st => st.Scores[0] > 90 && st.Scores[3] < 80).Count();
            Console.WriteLine("Количество студентов: {0}, {1}", studentCount, studentCountW);
            var studentList = (
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                orderby student.Last descending
                select student).ToList();
            Console.WriteLine("---------------------------");


            var studentQuery2 =
                from student in students
                group student by student.Last[0];
            foreach (Student student in studentList)
            {
                Console.WriteLine("{0}, {1} {2}", student.Last, student.First, student.Scores[0]);
            }
            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine(" {0}, {1}",
                    student.Last, student.First);
                }
            }
            Console.WriteLine("---------------------------");
            var studentQuery3 =
            from student in students
            group student by student.Last[0];
            foreach (var groupOfStudents in studentQuery3)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine(" {0}, {1}",
                    student.Last, student.First);
                }
            }
            Console.WriteLine("---------------------------");
            var studentQuery4 =
                from student in students
                group student by student.Last[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;
            foreach (var groupOfStudents in studentQuery4)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine(" {0}, {1}",
                    student.Last, student.First);
                }
            }
            Console.WriteLine("---------------------------");
            var studentQuery5 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] +
                student.Scores[2] + student.Scores[3]
                where totalScore / 4 < student.Scores[0]
                select student.Last + " " + student.First;
            foreach (string s in studentQuery5)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------------------");
            var studentQuery6 =
                    from student in students
                    let totalScore = student.Scores[0] + student.Scores[1] +
                    student.Scores[2] + student.Scores[3]
                    select totalScore;
            double averageScore = studentQuery6.Average();
            Console.WriteLine("Class average score = {0}", averageScore);
            Console.WriteLine("---------------------------");

            IEnumerable<string> studentQuery7 =
                from student in students
                where student.Last == "Garcia"
                select student.First;
            Console.WriteLine("The Garcias in the class are:");
            foreach (string s in studentQuery7)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------------------");

            var studentQuery8 =
                from student in students
                let x = student.Scores[0] + student.Scores[1] +
                student.Scores[2] + student.Scores[3]
                where x > averageScore
                select new { id = student.ID, score = x };
            foreach (var item in studentQuery8)
            {
                Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
            }

            Console.Read();
        }
    }
}
