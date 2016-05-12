using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_bubblesort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vector=GetNumbers();
            int max=vector.Length;
            for (int i = 0; i < max-1; i++)
            {
                for (int j = max-2; j >=i; j--)
                {
                    if (vector[j] > vector[j + 1]) Swap(ref vector[j], ref vector[j + 1]);
                }
            }
            TBoutput.Text = "";
            foreach (int i in vector)
            {
                TBoutput.Text += i.ToString()+",";
            }
        }
        private int[] GetNumbers()
        {
            string data;
            data = TBinput.Text;
            string[]stringNumbers=data.Split(',');
            
            int[] vector=new int[stringNumbers.Length];
            int i=0;
            foreach (string number in stringNumbers) 
            {
                vector[i] = Convert.ToInt32(number);
                i++;
            }
            return vector;
        }

        private void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        
    }
}
