using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*	Создать производные классы: Абитуриент(фамилия, дата рождения, факультет)*/

namespace Info.Module
{
    /// <summary>
    /// производный класс Абитуриент
    /// </summary>
    public class Enrollee : Persona
    {
        public Enrollee(string _Surname, DateTime _DateOfBirth, FacultyNames Faculty) : base(_Surname, _DateOfBirth) { }

        /// <summary>
        /// Факультет
        /// </summary>
        public string Faculty { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: " + Faculty);
            Console.WriteLine();
        }

        public override int getAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}
