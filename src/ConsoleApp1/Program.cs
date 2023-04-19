using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    struct Subject
    {
        public string name;
        public string famprep;
        public int semestr;
    };
     class PlanControl
    {
        Subject[] mas;
        Subject sub = new Subject();
        public PlanControl(int size)
        {
            try
            {
                mas = new Subject[size];
                strucFuller(size);
            }
            catch(Exception ex) { Console.WriteLine(ex.ToString()); }
            
        }
        public void strucFuller(int size)
        {
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Введите название дисциплины "+i+ ": ");
                    sub.name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите фамилию преподавателя "  + i+ ": ");
                    sub.famprep = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите семестр: ");
                    sub.semestr = Convert.ToInt32(Console.ReadLine());
                    mas[i] = sub;
                }
            } 
            catch(Exception ex) { Console.WriteLine(ex.ToString()); }
            
        }
        public void Save()
        {
            try
            {
                string path = @"D:\Users\stu-pksp119\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\Sinus.txt";
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    for (int i = 0; i < mas.Length; i++)
                    {
                        writer.WriteLine(mas[i].name +" "+ mas[i].famprep +" "+ mas[i].semestr);
                    }
                    writer.Close();
                }
                
            }
            catch(Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        
        public void sortVoz()
        {
            try
            {
                Subject s;
                for (int i = 0; i < mas.Length - 1; i++)
                    for (int j = i; j >= 0; j--)
                        if (String.Compare(mas[j].name, mas[j + 1].name) > 0 || mas[j].semestr > mas[j + 1].semestr) // функция Compare()
                        {
                            // поменять значения местами
                            s = mas[j];
                            mas[j] = mas[j + 1];
                            mas[j + 1] = s;
                        }
                //сортир по семестру и по названию
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размер массива: ");
                int size = Convert.ToInt32(Console.ReadLine());
                PlanControl pc = new PlanControl(size);
                pc.sortVoz();
                pc.Save();
            } 
            catch(Exception ex) { Console.WriteLine(ex.ToString()); }
            
        }
    }
}
