using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Создать производные классы: Преподавать(фамилия, дата рождения, факультет, должность, стаж), со своими методами вывода информации на экран, и определения возраста.*/

namespace Info.Module
{
    /// <summary>
    /// производный класс "Преподаватель"
    /// </summary>
    public class Teacher : Persona
    {
        public enum PositionType { Аспирант, Ассистент, Докторант, Доцент, Стажер, Профессор, Преподаватель, Научный_сотрудник, Старший_преподаватель }

        public Teacher(string _Surname, DateTime _DateOfBirth, FacultyNames faculty, PositionType position, int Experience) : base (_Surname, _DateOfBirth) { }

        /// <summary>
        /// Факультет
        /// </summary>
        public FacultyNames faculty { get; set; }
        
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Стаж
        /// </summary>
        public int Experience { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: " + faculty);
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Стаж: " + Experience.ToString());
        }

        public override int getAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}