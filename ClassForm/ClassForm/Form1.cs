using ClassMassInt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int length = Convert.ToInt32(textBox1.Text);

                Сmass a = new Сmass(length);

                //свойство определяет длину массива
                string str = Convert.ToString(a.getLengthMassIn);
                //индексатор позволяет получить доступ к элементу 
                string str1 = "0";

                //Метод вычисляет максимальный элемент во всем массиве
                string str2 = Convert.ToString(a.searchMax());

                //Метод вычисляет максимальный элемент во всем массиве
                string str3 = "0";

                MessageBox.Show("Свойство длина массива: " + str + "" + "\nИндексатор: " + str1 + "\nМетод вычисляет макс. элемент в массиве: " + str2 + "\nМетод вычисляет макс. элемент в интервале: 0");
            }
            catch
            {
                MessageBox.Show("Увы, у вас ошибка! Программист ленивый, поэтому сами ищите ее!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int length = dataGridView2.ColumnCount = Convert.ToInt32(textBox2.Text);
                dataGridView2.RowCount = 1; //Количество строк
            }
            catch
            {
                MessageBox.Show("Увы, у вас ошибка! Программист ленивый, поэтому сами ищите ее!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                try
                {
                    int length = Convert.ToInt32(textBox2.Text);

            int[] mass = new int[length];

            for (int i = 0; i < length; i++)
            {
                mass[i] = Convert.ToInt32(dataGridView2[i, 0].Value);
            }

            Сmass b = new Сmass(mass);

            string str3 = textBox3.Text;
            string str4 = textBox4.Text;
            string str5 = textBox5.Text;
          
            int index = 0;
            string str1 = "";

            if (str3 != "" && str4 != "")
            {


                int nach = Convert.ToInt32(textBox3.Text);
                int conch = Convert.ToInt32(textBox4.Text);
                str3 = Convert.ToString(b.searchMax(nach, conch));


            }
            else
            {
                str3 = "";
                str4 = "";
            }

           if (str5 != "")
            {
                index = Convert.ToInt32(textBox5.Text);
                str1 = Convert.ToString(b[index]);
            }
            //свойство определяет длину массива
            string str = Convert.ToString(b.getLengthMassIn);
            //индексатор позволяет получить доступ к элементу 
            

            //Метод вычисляет максимальный элемент во всем массиве
            string str2 = Convert.ToString(b.searchMax());

            //Метод вычисляет максимальный элемент во всем массиве
           

            MessageBox.Show("Свойство длина массива: " + str + "" + "\nИндексатор: " + str1 + "\nМетод вычисляет макс. элемент в массиве: " + str2 + "\nМетод вычисляет макс. элемент в интервале: "+str3);
            }
            catch
            {
                MessageBox.Show("Увы, у вас ошибка! Программист ленивый, поэтому сами ищите ее!");
            }
        }

       


    }
}
