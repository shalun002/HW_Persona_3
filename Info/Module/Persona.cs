using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.	Создать абстрактный класс Persona с методами, позволяющим вывести на экран информацию о персоне, а также определить ее возраст(на момент текущей даты).*/

namespace Info.Module
{
    public abstract class Persona
    {
        public enum FacultyNames { ФМФ, ФИЯ, ФФ, ТЭФ, ФДиНО, ИФ, ЕГФ, АСФ, ГИ, ФИТ, ЮИ, ИПМИБН, ФРЭМТ, ИЭИМ, МТФ, ИФКС, ИМиСБ }

        /// <summary>
        /// фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        public Persona(string _Surname, DateTime _DateOfBirth)
        {
            this.Surname = _Surname;
            this.DateOfBirth = _DateOfBirth;
        }

        public abstract int getAge();

        public void Print()
        {
            if (String.IsNullOrEmpty(Surname))
                Console.WriteLine("Фамилия отсутствует");
            else
                Console.WriteLine("Фамилия - {0}, возраст - {1}", Surname, getAge().ToString() + " лет"); 
        }

        public virtual void Show()
        {
            Console.WriteLine("Имя: " + Surname);
            Console.WriteLine("Дата рождения: " + DateOfBirth.ToString());
            Console.WriteLine("Возраст: " + getAge().ToString() + " лет");
        }
    }
}
