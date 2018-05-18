using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*	Создать производные классы: Абитуриент(фамилия, дата рождения, факультет)*/

namespace Info.Module
{
    public class Enrollee : Persona
    {
        public string Faculty { get; set; }

        public override void Show()
        {
            Console.WriteLine("Имя: {0}", Surname);
            Console.WriteLine("Дата рождения: {0}", DateOfBirth);
            Console.WriteLine("Возраст: {0}", getAge());
            Console.WriteLine("Факультет: {0}", Faculty);
            Console.WriteLine();
        }

        public override int getAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}
