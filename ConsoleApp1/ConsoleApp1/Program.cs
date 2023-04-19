using System;
using System.IO;

namespace ConsoleApp1
{
    struct Subjet
    {
        string name;
        string famprep;
        int semestr;
    };
    class PlanControl
    {
        int[] mas;
        PlanControl(int size)
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
            for(int)
            //сортир по семестру и по названию
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
