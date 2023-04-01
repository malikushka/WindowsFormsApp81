using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsApp81
{
   
    public partial class Form1 : Form
    {
        public Context context;
        public int count = 0;
        public Form1()
        {
           
            InitializeComponent();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Allfiles(*.*) | *.* ";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|Allfiles(*.*) | *.* ";
            IOFile.form1 = this;
            Methods.form1 = this;
            BubbleSort.form1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Context.array != null)
            {
                if (radioButton1.Checked == true)
                {
                    this.context = new Context(new BubbleSort());
                    context.ExecuteAlgorithm();
                    this.listBox1();
                    IOFile.SaveData();
                    button1.Enabled = false;
                }
                if (radioButton2.Checked == true)
                {
                    this.context = new Context(new Methods());
                    context.ExecuteAlgorithm();
                    this.listBox1();
                    IOFile.SaveData();
                    button1.Enabled = false;
                }
                IOFile.content = "";
            }
            else
            {
                MessageBox.Show("Ошибка! Массив пуст!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Context.array == null)
            {
                Form2 setGenerator = new Form2();
                Form2.form1 = this;
                setGenerator.Show();

                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ошибка! Необходимо очистить старый набор !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            listBox1.Items.Clear();
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            Form3.NumberOfPermutations = 0;
            Form3.Comparison = 0;
            Context.array = null;
            this.count = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("");
            foreach (var item in Context.array)
            {
                if (item == f || item == s)
                {
                    listBox1.Items[count] += '[' + Convert.ToString(item) + ']' + " ";
                }
                else
                {
                    listBox1.Items[count] += Convert.ToString(item) + " ";
                }
            }
            count++;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            IOFile.LoadData();

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            Form3 comparativeAnalysis = new Form3();
            comparativeAnalysis.Show();
        }
    }

    
}
