using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info.Module;

/*
1.	Создать абстрактный класс Persona с методами, позволяющим вывести на экран информацию о персоне, а также определить ее возраст(на момент текущей даты).

2.	Создать производные классы: Абитуриент(фамилия, дата рождения, факультет), Студент(фамилия, дата рождения, факультет, курс), Преподавать(фамилия, дата рождения, факультет, должность, стаж), 
    со своими методами вывода информации на экран, и определения возраста.

3.	Создать базу(массив) из n персон, вывести полную информацию из базы на экран, а также организовать поиск персон, чей возраст попадает в заданный диапазон.
*/

namespace HW_Module_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();
            gen.GenerateTeacher();
            gen.GenerateStudents();
            gen.GenerateEnrollee();

            gen.PrintAll();

            gen.Find(2);
        }
    }
}