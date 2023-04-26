namespace Laba_10_OAIP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripSplitButton();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            сгенерироватьНаборToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton2 = new ToolStripSplitButton();
            выводСтатистикиToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            radioButtonМВыб = new RadioButton();
            radioButtonШ = new RadioButton();
            buttonСорт = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelCountComparison = new Label();
            label7 = new Label();
            labelNumberOfPermutations = new Label();
            labelTimeSort = new Label();
            listBox1 = new ListBox();
            buttonClear = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1506, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, сгенерироватьНаборToolStripMenuItem });
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(83, 24);
            toolStripButton1.Text = "Данные";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(246, 26);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // сгенерироватьНаборToolStripMenuItem
            // 
            сгенерироватьНаборToolStripMenuItem.Name = "сгенерироватьНаборToolStripMenuItem";
            сгенерироватьНаборToolStripMenuItem.Size = new Size(246, 26);
            сгенерироватьНаборToolStripMenuItem.Text = "Сгенерировать набор";
            сгенерироватьНаборToolStripMenuItem.Click += сгенерироватьНаборToolStripMenuItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.DropDownItems.AddRange(new ToolStripItem[] { выводСтатистикиToolStripMenuItem });
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(79, 24);
            toolStripButton2.Text = "Анализ";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // выводСтатистикиToolStripMenuItem
            // 
            выводСтатистикиToolStripMenuItem.Name = "выводСтатистикиToolStripMenuItem";
            выводСтатистикиToolStripMenuItem.Size = new Size(224, 26);
            выводСтатистикиToolStripMenuItem.Text = "Вывод статистики";
            выводСтатистикиToolStripMenuItem.Click += выводСтатистикиToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(373, 29);
            label1.TabIndex = 1;
            label1.Text = "Выберите метод сортировки";
            // 
            // radioButtonМВыб
            // 
            radioButtonМВыб.AutoSize = true;
            radioButtonМВыб.Location = new Point(16, 76);
            radioButtonМВыб.Name = "radioButtonМВыб";
            radioButtonМВыб.Size = new Size(237, 24);
            radioButtonМВыб.TabIndex = 2;
            radioButtonМВыб.TabStop = true;
            radioButtonМВыб.Text = "Сортировка методом выбора";
            radioButtonМВыб.UseVisualStyleBackColor = true;
            radioButtonМВыб.CheckedChanged += radioButtonМВыб_CheckedChanged;
            // 
            // radioButtonШ
            // 
            radioButtonШ.AutoSize = true;
            radioButtonШ.Location = new Point(15, 104);
            radioButtonШ.Name = "radioButtonШ";
            radioButtonШ.Size = new Size(229, 24);
            radioButtonШ.TabIndex = 3;
            radioButtonШ.TabStop = true;
            radioButtonШ.Text = "Сортировка методом Шелла";
            radioButtonШ.UseVisualStyleBackColor = true;
            radioButtonШ.CheckedChanged += radioButtonШ_CheckedChanged;
            // 
            // buttonСорт
            // 
            buttonСорт.Location = new Point(16, 140);
            buttonСорт.Name = "buttonСорт";
            buttonСорт.Size = new Size(142, 29);
            buttonСорт.TabIndex = 4;
            buttonСорт.Text = "Сортируем!";
            buttonСорт.UseVisualStyleBackColor = true;
            buttonСорт.Click += buttonСорт_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 183);
            label2.Name = "label2";
            label2.Size = new Size(284, 29);
            label2.TabIndex = 5;
            label2.Text = "Узрите некие данные";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 229);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 6;
            label3.Text = "Количество сравнений:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 272);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 7;
            label4.Text = "Количество перестановок:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 315);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 8;
            label5.Text = "Время сортировки:";
            // 
            // labelCountComparison
            // 
            labelCountComparison.AutoSize = true;
            labelCountComparison.Location = new Point(194, 229);
            labelCountComparison.Name = "labelCountComparison";
            labelCountComparison.Size = new Size(17, 20);
            labelCountComparison.TabIndex = 9;
            labelCountComparison.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 272);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 10;
            // 
            // labelNumberOfPermutations
            // 
            labelNumberOfPermutations.AutoSize = true;
            labelNumberOfPermutations.Location = new Point(217, 272);
            labelNumberOfPermutations.Name = "labelNumberOfPermutations";
            labelNumberOfPermutations.Size = new Size(17, 20);
            labelNumberOfPermutations.TabIndex = 12;
            labelNumberOfPermutations.Text = "0";
            // 
            // labelTimeSort
            // 
            labelTimeSort.AutoSize = true;
            labelTimeSort.Location = new Point(168, 315);
            labelTimeSort.Name = "labelTimeSort";
            labelTimeSort.Size = new Size(17, 20);
            labelTimeSort.TabIndex = 13;
            labelTimeSort.Text = "0";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(403, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1091, 764);
            listBox1.TabIndex = 14;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(16, 360);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(142, 29);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Зачистка!";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 793);
            Controls.Add(buttonClear);
            Controls.Add(listBox1);
            Controls.Add(labelTimeSort);
            Controls.Add(labelNumberOfPermutations);
            Controls.Add(label7);
            Controls.Add(labelCountComparison);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonСорт);
            Controls.Add(radioButtonШ);
            Controls.Add(radioButtonМВыб);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripButton1;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem сгенерироватьНаборToolStripMenuItem;
        private Label label1;
        private RadioButton radioButtonМВыб;
        private RadioButton radioButtonШ;
        private Button buttonСорт;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button buttonClear;
        private ToolStripSplitButton toolStripButton2;
        private ToolStripMenuItem выводСтатистикиToolStripMenuItem;
        public ListBox listBox1;
        public Label labelCountComparison;
        public Label labelNumberOfPermutations;
        public Label labelTimeSort;
    }
}