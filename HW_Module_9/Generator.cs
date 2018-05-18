using Info.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_9
{
    public enum FacultyNames { Facult1, Facult2, Facult3, Facult4, Facult5, Facult6, Facult7, Facult8, Facult9, Facult10, Facult11, Facult12, Facult13, Facult14, Facult15, Facult16, Facult17 }
    public enum PositionType { Position1, Position2, Position3, Position4, Position5, Position6, Position7, Position8, Position9 }
    public enum Names { name1, name2, name3, name4, name5 }

    public class Generator
    {
        private Random rand = new Random();
        public List<Persona> persona;

        public Generator()
        {
            persona = new List<Persona>();
        }

        public void GenerateTeacher()
        {
            Teacher teacher = new Teacher();
            teacher.Surname = ((Names)rand.Next(1, 5)).ToString();
            teacher.DateOfBirth = DateTime.Now.AddMonths(-rand.Next(10, 30)); 
            teacher.Position = ((PositionType)rand.Next(0, 9)).ToString();
            teacher.Faculty = ((FacultyNames)rand.Next(0, 17)).ToString();
            teacher.Experience = rand.Next(1, 45);

            persona.Add(teacher);
        }

        public void GenerateStudents()
        {
            Student student = new Student();
            student.Surname = ((Names)rand.Next(1, 5)).ToString();
            student.DateOfBirth = DateTime.Now.AddMonths(-rand.Next(10, 30));
            student.Faculty = ((FacultyNames)rand.Next(0, 17)).ToString();
            student.Cource = rand.Next(0, 7);

            persona.Add(student);
        }

        public void GenerateEnrollee()
        {
            Enrollee enrollee = new Enrollee();
            enrollee.Surname = ((Names)rand.Next(1, 5)).ToString();
            enrollee.DateOfBirth = DateTime.Now.AddMonths(-rand.Next(10, 30));
            enrollee.Faculty = ((FacultyNames)rand.Next(0, 17)).ToString();

            persona.Add(enrollee);
        }

        public void PrintAll()
        {
            foreach (Persona item in persona)
            {
                item.Show();
            }
        }

        public void Find(int age)
        {

            foreach (Persona item in persona)
            {
                if (item.getAge() > age)
                    Console.WriteLine("Имя - {0}, возраст - {1}", item.Surname, item.getAge());
                else
                    Console.WriteLine("Нет такого человека");
            }
        }
    }
}