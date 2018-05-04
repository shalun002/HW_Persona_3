using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.Module
{
    /// <summary>
    /// производный класс Студент
    /// </summary>
    public class Student : Persona
    {
        /// <summary>
        /// Факультет
        /// </summary>
        public string Faculty { get; set; }

        /// <summary>
        /// Курс
        /// </summary>
        public string Cource { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: " + this.Faculty);
            Console.WriteLine("Курс: " + this.Cource);
        }
    }
}