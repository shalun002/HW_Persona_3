using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Создать производные классы: Преподавать(фамилия, дата рождения, факультет, должность, стаж), со своими методами вывода информации на экран, и определения возраста.*/
namespace Info.Module
{
    /// <summary>
    /// производный класс "Преподаватель"
    /// </summary>
    public class Teacher : Persona
    {
        public enum PositionType { Аспирант, Ассистент, Докторант, Доцент, Стажер, Профессор, Преподаватель, Научный_сотрудник, Старший_преподаватель }

        public Teacher()

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
