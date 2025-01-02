using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_250102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] array;
            setArray(out array);
            foreach (int i in array)
            {
                textBox_print.Text += i.ToString()+"\r\n";
            }
            
            changearray(ref array);
            textBox_print.Text += "바꾼 후:";
            foreach (int i in array)
            {
                textBox_print.Text += i.ToString() + "\r\n";
            }
        }
        void setArray(out int[] array)
        {
            int num = 5;
            array = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
        void changearray(ref int[] array)
        {
            foreach (int i in array)
            {
                array[i] = 2;
            }
        }
    }
}
