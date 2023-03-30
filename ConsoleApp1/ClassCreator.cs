﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        //public static ClassAA ClassAA()
        //{
        //    Console.WriteLine("Имя");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Второе Имя");
        //    string lastname = Console.ReadLine();
        //    return new ClassAA(name, lastname);
        //}

        public static Занятие Занятие()
        {
            Console.WriteLine($"Введите текущую дату: ");
            string ДатаПроведения = Console.ReadLine();
            return new Занятие(ДатаПроведения, Дисциплина(), Сотрудник(), Аудитория(), Группа(), Пара(), ВидЗанятия());
        }
        public static Аудитория Аудитория()
        {
            for (uint i = 0; i < 1; i++)
                try
                {
                    Console.Write("Введите название: ");
                    string название = Console.ReadLine();

                    Console.Write("Введите количесвто посадочных мест: ");
                    uint количесвтоПосадочныхМест = uint.Parse(Console.ReadLine());

                    Console.Write("Введите количесвто окон: ");
                    uint количесвтоОкон = uint.Parse(Console.ReadLine());

                    List<Оборудование> списокОборудования = new List<Оборудование>();

                    return new Аудитория(название, Сотрудник(), количесвтоПосадочныхМест, количесвтоОкон, списокОборудования);
                }
                catch (Exception)
                {
                    --i;
                }
            return null;
        }
        public static ВидЗанятия ВидЗанятия()
        {
            return new ВидЗанятия();
        }
        public static Группа Группа()
        {
            Console.WriteLine("Введите название: ");
            string название = Console.ReadLine();
            Console.WriteLine("Введите сокращение: ");
            string сокращение = Console.ReadLine();
            int численность;
            int годПоступления;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите численность: ");
                    численность = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите год поступления: ");
                    годПоступления = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Числа!");                   
                }                
                                            
            }                    
            return new Группа(название, сокращение, численность, годПоступления, Специальность(), Сотрудник());
        }
        public static Дисциплина Дисциплина()
        {
            Console.WriteLine("Введите название дисциплины: ");
            string Название = Console.ReadLine();

            Console.WriteLine("Введите сокращенное название дисциплины: ");
            string Сокращение = Console.ReadLine();
            return new Дисциплина(Название, Сокращение);
        }
        public static Пара Пара()
        {
            Console.Write("Введите начало пары: ");
            string BeginPara = Console.ReadLine();
            Console.Write("Введите конец пары: ");
            string EndPara = Console.ReadLine();
            Console.Write("Введите начало перемены: ");
            string BeginBreak = Console.ReadLine();
            Console.Write("Введите конец перемены: ");
            string EndBreak = Console.ReadLine();
            return new Пара(BeginPara, EndPara, BeginBreak, EndBreak, смена());
        }
        public static Смена смена()
        {
            return new Смена();
        }
        public static Должность Должность()
        {
            return new Должность();
        }
        public static Сотрудник Сотрудник()
        {
            Console.WriteLine("Введите Фамилию: ");
            string фамилия = Console.ReadLine();
            Console.WriteLine("Введите Имя: ");
            string имя = Console.ReadLine();
            Console.WriteLine("Введите Отчество: ");
            string отчество = Console.ReadLine();
            return new Сотрудник(фамилия, имя, отчество, Должность());
        }
        public static Оборудование Оборудование()
        {
            return new Оборудование();
        }
        public static Специальность Специальность()
        {
            Console.WriteLine("Введите название: ");
            string Название = Console.ReadLine();
            Console.WriteLine("Введите сокращение: ");
            string Сокращение = Console.ReadLine();
            return new Специальность(Название, Сокращение);
        }
    }
}
