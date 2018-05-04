using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.Module
{
    /// <summary>
    /// производный класс Абитуриент
    /// </summary>
    public class Faculty : Persona
    {
        public enum FacultyNames { ФМФ, ФИЯ, ФФ, ТЭФ, ФДиНО, ИФ, ЕГФ, АСФ, ГИ, ФИТ, ЮИ, ИПМИБН, ФРЭМТ, ИЭИМ, МТФ, ИФКС, ИМиСБ }

        public Faculty() : this("") { }

        public Faculty(string FacultyName) : base()
        {
            this.FacultyName = FacultyName;
        }

        /// <summary>
        /// Факультет
        /// </summary>
        public string FacultyName { get; set; }

        public FacultyNames facultyName
        {
            get
            {
                return facultyName;
            }
            set
            {
                if(FacultyNames == value)
            }
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: " + this.FacultyName);
        }
    }
}
