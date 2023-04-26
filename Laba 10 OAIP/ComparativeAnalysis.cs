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

namespace Laba_10_OAIP
{
    public partial class ComparativeAnalysis : Form
    {
        private Random random = new Random();
        public static int Comparison = 0;
        public static int NumberOfPermutations = 0;
        public static string elapsedTime = "";
        public static int timeSort = 0;
        public static List<SortingResultsInformation> sortingResults = new
       List<SortingResultsInformation>();
        private Context context = new Context();

        public ComparativeAnalysis()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Volume", "Объем выборки");
            dataGridView1.Columns.Add("BubbleSort", "Метод обмена");
            dataGridView1.Columns.Add("ShellSort", "Метод Шелла");
            25
 dataGridView1.Rows.Add("10");
            dataGridView1.Rows.Add("100");
            dataGridView1.Rows.Add("1000");
            dataGridView1.Rows.Add("10000");
            dataGridView1.Rows.Add("100000");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
            }
            label1.Text = "";
            label2.Text = "";
        }

        private void FillArray(int[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = random.Next(0, 100000);
            }
        }

        private void Sort(int n, int number)
        {
            this.context = new Context(new BubbleSort());
            Context.array = new int[n];
            FillArray(Context.array);
            context.ExecuteAlgorithm(false);
            dataGridView1.Rows[number].Cells[1].Value += "С: " +
           Convert.ToString(Comparison) + " ";
            dataGridView1.Rows[number].Cells[1].Value += "П: " +
           Convert.ToString(NumberOfPermutations) + " ";
            dataGridView1.Rows[number].Cells[1].Value += "t: " +
           Convert.ToString(elapsedTime);
            sortingResults.Add(new SortingResultsInformation(Comparison,
           NumberOfPermutations, elapsedTime, new BubbleSort(), timeSort, n));
            Comparison = 0;
            NumberOfPermutations = 0;
            timeSort = 0;
            elapsedTime = "";
            Context.array = null;
            this.context = new Context(new ShellSort());
            Context.array = new int[n];
            FillArray(Context.array);
 context.ExecuteAlgorithm(false);
            dataGridView1.Rows[number].Cells[2].Value += "С: " +
           Convert.ToString(Comparison) + " ";
            dataGridView1.Rows[number].Cells[2].Value += "П: " +
           Convert.ToString(NumberOfPermutations) + " ";
            dataGridView1.Rows[number].Cells[2].Value += "t: " +
           Convert.ToString(elapsedTime);
            sortingResults.Add(new SortingResultsInformation(Comparison,
           NumberOfPermutations, elapsedTime, new ShellSort(), timeSort, n));
            Comparison = 0;
            NumberOfPermutations = 0;
            timeSort = 0;
            elapsedTime = "";
            Context.array = null;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
