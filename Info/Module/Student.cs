using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*	Создать производные классы: Студент(фамилия, дата рождения, факультет, курс) */

namespace Info.Module
{
    public class Student : Persona
    {
        public string Faculty { get; set; }
        public int Cource { get; set; }

        public override void Show()
        {
            Console.WriteLine("Имя: " + Surname);
            Console.WriteLine("Дата рождения: " + DateOfBirth);
            Console.WriteLine("Возраст: " + getAge());
            Console.WriteLine("Факультет: " + Faculty);
            Console.WriteLine("Курс: " + Cource);
            Console.WriteLine();
        }

        public override int getAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}