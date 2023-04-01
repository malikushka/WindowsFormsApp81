﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp81
{
    public partial class Form2 : Form
    {
        private Random random = new Random();
        public static Form1 form1;
        public Form2()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context.array = new int[trackBar1.Value];
            for (int i = 0; i < Context.array.Length; i++)
            {
                Context.array[i] = random.Next(0, 100);
            }

            form1.listBox1.Items.Add("");
            foreach (var item in Context.array)
            {
                form1.listBox1.Items[form1.count] += Convert.ToString(item) + " ";
            }
            form1.count++;

            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(trackBar1.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int flag = 0;
            if (!(int.TryParse(textBox1.Text, out flag)))
            {
                label1.Text = "Введенно некорректное значение";
                this.Height = 150;
            }
            else if (!(int.Parse(textBox1.Text) > trackBar1.Maximum))
            {
                label1.Text = "";
                this.Height = 150;
                trackBar1.Value = int.Parse(textBox1.Text);
            }
            else if ((int.Parse(textBox1.Text) > trackBar1.Maximum) || (int.Parse(textBox1.Text) < trackBar1.Minimum))
            {
                label1.Text = "Введенное значение вышло за допустимый интервал";
                this.Height = 150;
            }

        }
    }
}
