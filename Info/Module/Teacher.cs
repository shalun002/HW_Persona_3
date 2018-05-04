using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.Module
{
    /// <summary>
    /// производный класс "Преподаватель"
    /// </summary>
    public class Teacher : Persona
    {
        public enum PositionType { Аспирант, Ассистент, Докторант, Доцент, Стажер, Профессор, Преподаватель, Научный_сотрудник, Старший_преподаватель }

        /// <summary>
        /// Факультет
        /// </summary>
        public string Faculty { get; set; }

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
            Console.WriteLine("Факультет: " + this.Faculty);
            Console.WriteLine("Должность: " + this.Position);
            Console.WriteLine("Стаж: " + this.Experience.ToString());
        }
    }
}
