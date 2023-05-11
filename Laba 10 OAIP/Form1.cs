using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Laba_10_OAIP
{
    public partial class Form1 : Form
    {
        public Context context;
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*) | *.* ";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*) | *.* ";
            IOFile.form1 = this;
            ShellSort.form1 = this;
            BubbleSort.form1 = this;
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonМВыб_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonСорт_Click(object sender, EventArgs e)
        {
            if (Context.array != null)
            {
                if (radioButtonМВыб.Checked == true)
                {
                    this.context = new Context(new BubbleSort());
                    context.ExecuteAlgorithm();
                    this.AddItemsListBox();
                    IOFile.SaveData();

                }
                if (radioButtonШ.Checked == true)
                {
                    this.context = new Context(new ShellSort());
                    context.ExecuteAlgorithm();
                    this.AddItemsListBox();
                    IOFile.SaveData();

                }
                IOFile.content = "";
            }
            else
            {

                MessageBox.Show("Массив пуст, сортировка невозможна");
            }

        }
        public void AddItemsListBox(int first = -1, int second = -1)//пошаговый процесс сортировки
        {
            listBox1.Items.Add("");
            foreach (var item in Context.array)
            {
                if (item == first || item == second)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            labelCountComparison.Text = "";
            labelTimeSort.Text = "";
            labelNumberOfPermutations.Text = "";
            ComparativeAnalysis.NumberOfPermutations = 0;
            ComparativeAnalysis.Comparison = 0;
            Context.array = null;
            this.count = 0;

        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IOFile.LoadData();

        }

        private void сгенерироватьНаборToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Context.array == null)
            {
                SetGenerator setGenerator = new SetGenerator();
                SetGenerator.form1 = this;
                setGenerator.Show();
                buttonСорт.Enabled = true;
            }
            else
            {
                MessageBox.Show("Массив уже сгенерирован. Очистите старый набор и повторите попытку");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonШ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void выводСтатистикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                ComparativeAnalysis comparativeAnalysis = new ComparativeAnalysis();
                comparativeAnalysis.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}