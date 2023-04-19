using System;
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
        int[] mas;
        Subject sub = new Subject();
        public PlanControl(int size)
        {
            mas = new int[size];
            
        }
        public void Save()
        {
            StreamWriter str = new StreamWriter("Sinus.txt");
            for (int i = 0; i < mas.Length; i++)
            {
                str.WriteLine(mas[i]);
            }
            str.Close();
        }

        public void sortVoz()
        {
            //for(int)
            //сортир по семестру и по названию
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            PlanControl pc = new PlanControl(size);
            
        }
    }
}
