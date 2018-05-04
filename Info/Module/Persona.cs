using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.Module
{
    public abstract class Persona
    {
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
