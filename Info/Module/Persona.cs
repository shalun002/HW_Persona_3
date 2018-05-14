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
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public abstract void Show();
        public abstract int getAge();
    }
}