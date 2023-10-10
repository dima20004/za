using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMassInt
{
    public class mass
    {
        private int[] massIn; //Массив целых чисел

        public int getLengthMassIn //Свойство для определения длины массива
        {
            get { return massIn.Length; }
        }

        public int this[int i]   //Индексатор для доступа к элементам поля-массива, 
        {
            get { return massIn[i]; }
            set { massIn[i] = value; }
        }

        public mass(int length) //Конструктор с одним параметром –  длина массива
        {

            massIn = new int[length];
        }

        public mass(int[] massIntChis) //Конструктор с одним параметром – массив целых чисел
        {
            massIn = new int[massIntChis.Length];
            massIn = massIntChis;
        }

        //перегруженные методы для поиска максимального элемента во всем массиве и
        //для поиска максимального элемента в части массива,
        //ограниченной начальным и конечным значениями индекса, передаваемых в метод в качестве параметров

        public int searchMax() //Метод для поиска максимального элемента во всем массиве
        {
            int max = massIn[0];

            for (int i = 1; i < massIn.Length; i++)
            {
                if (max < massIn[i])
                {
                    max = massIn[i];
                }
            }
            return max;
        }

        public int searchMax(int nach, int conch) //Метод для поиска максимального элемента, ограниченный
        {                                         //начальным и конечный значениями индекса
            int max = massIn[nach];

            for (int i = nach + 1; i <= conch; i++)
            {
                if (max < massIn[i])
                {
                    max = massIn[i];
                }
            }
            return max;
        }


    }
    public class ClassMassInt
    {
    }
}
