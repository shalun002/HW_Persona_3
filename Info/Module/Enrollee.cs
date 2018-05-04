using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.Module
{
    /// <summary>
    /// Абитуриент
    /// </summary>
    public class Enrollee :Persona
    {
        /// <summary>
        /// Факультет
        /// </summary>
        public string Faculty { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: " + this.Faculty);
        }
    }
}
