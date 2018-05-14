using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*	Создать производные классы: Студент(фамилия, дата рождения, факультет, курс) */
namespace Info.Module
{
    /// <summary>
    /// производный класс Студент
    /// </summary>
    public class Student : Persona
    {
        
        public Student(string _Surname, DateTime _DateOfBirth, FacultyNames Faculty, int Cource) : base (_Surname, _DateOfBirth) { }

        /// <summary>
        /// Факультет
        /// </summary>
        public FacultyNames faculty { get; set; }

        /// <summary>
        /// Курс
        /// </summary>
        public int Cource { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: " + faculty);
            Console.WriteLine("Курс: " + Cource);
        }

        public override int getAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}