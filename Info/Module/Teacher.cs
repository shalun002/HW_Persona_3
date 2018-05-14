using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Создать производные классы: Преподавать(фамилия, дата рождения, факультет, должность, стаж), со своими методами вывода информации на экран, и определения возраста.*/

namespace Info.Module
{
    public class Teacher : Persona
    {
        public string Faculty  { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public override void Show()
        {
            Console.WriteLine("Имя: " + Surname);
            Console.WriteLine("Дата рождения: " + DateOfBirth);
            Console.WriteLine("Имя: " + Surname);
            Console.WriteLine("Возраст: " + getAge());
            Console.WriteLine("Факультет: " + Faculty);
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Стаж: " + Experience.ToString());
            Console.WriteLine();
        }

        public override int getAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}