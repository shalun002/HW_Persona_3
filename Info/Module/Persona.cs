using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.Module
{
    public abstract class Persona
    {
        public Persona() : this(" ") { }

        public Persona(string Surname) : this(Surname, DateTime.MinValue) { }

        public Persona(string Surname, DateTime DateOfBirth)
        {
            this.Surname = Surname;
            this.DateOfBirth = DateOfBirth;
        }

        /// <summary>
        /// фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        public TimeSpan getAge()
        {
            return DateTime.Now.Subtract(this.DateOfBirth);
        }

        public virtual void Show()
        {
            Console.WriteLine("Имя: " + this.Surname);
            Console.WriteLine("Дата рождения: " + this.DateOfBirth.ToString());
            Console.WriteLine("Возраст: " + this.getAge().ToString());
        }
    }
}
