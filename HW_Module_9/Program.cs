using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info.Module;

/*
1.	Создать абстрактный класс Persona с методами, позволяющим вывести на экран информацию о персоне, а также определить ее возраст(на момент текущей даты).

2.	Создать производные классы: Абитуриент(фамилия, дата рождения, факультет), Студент(фамилия, дата рождения, факультет, курс), Преподавать(фамилия, дата рождения, факультет, должность, стаж), 
    со своими методами вывода информации на экран, и определения возраста.

3.	Создать базу(массив) из n персон, вывести полную информацию из базы на экран, а также организовать поиск персон, чей возраст попадает в заданный диапазон.
*/

namespace HW_Module_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persons = new List<Persona>();
            Random rand = new Random();

            persons.Add(new Student("Иван", new DateTime(1992, 2, 23), (Persona.FacultyNames)rand.Next(1, 17), 4));
            Console.WriteLine();
            persons.Add(new Enrollee("Петр", new DateTime(1999, 2, 10), (Persona.FacultyNames)rand.Next(1, 17)));
            Console.WriteLine();
            persons.Add(new Teacher("Василий", new DateTime(1980, 2, 23), (Persona.FacultyNames)rand.Next(1, 17), (Teacher.PositionType)rand.Next(1, 10), 22));
            Console.WriteLine();

            foreach (Persona p in persons)
            {
                if (p is Student)
                    Console.Write("Студент ");
                else if (p is Enrollee)
                    Console.Write("Абитуриент ");
                else
                    Console.Write("Преподаватель ");
                p.Show();
            }

            Console.WriteLine();
            Console.WriteLine("Персоны старше 20 лет ");
            Console.WriteLine();

            foreach (Persona p in persons)
            {
                if (p.getAge() > 20)
                    p.Show();
            }
        }
    }
}