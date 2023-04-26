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
            toolStrip1.BackColor = Color.FromArgb(250, 228, 238);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1550, 36);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, сгенерироватьНаборToolStripMenuItem });
            toolStripButton1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButton1.ForeColor = Color.FromArgb(73, 0, 34);
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(119, 33);
            toolStripButton1.Text = "Данные";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.BackColor = Color.FromArgb(250, 228, 238);
            открытьФайлToolStripMenuItem.ForeColor = Color.FromArgb(73, 0, 34);
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(340, 34);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // сгенерироватьНаборToolStripMenuItem
            // 
            сгенерироватьНаборToolStripMenuItem.BackColor = Color.FromArgb(250, 228, 238);
            сгенерироватьНаборToolStripMenuItem.ForeColor = Color.FromArgb(73, 0, 34);
            сгенерироватьНаборToolStripMenuItem.Name = "сгенерироватьНаборToolStripMenuItem";
            сгенерироватьНаборToolStripMenuItem.Size = new Size(340, 34);
            сгенерироватьНаборToolStripMenuItem.Text = "Сгенерировать набор";
            сгенерироватьНаборToolStripMenuItem.Click += сгенерироватьНаборToolStripMenuItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.DropDownItems.AddRange(new ToolStripItem[] { выводСтатистикиToolStripMenuItem });
            toolStripButton2.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButton2.ForeColor = Color.FromArgb(73, 0, 34);
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(111, 33);
            toolStripButton2.Text = "Анализ";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // выводСтатистикиToolStripMenuItem
            // 
            выводСтатистикиToolStripMenuItem.BackColor = Color.FromArgb(250, 228, 238);
            выводСтатистикиToolStripMenuItem.ForeColor = Color.FromArgb(73, 0, 34);
            выводСтатистикиToolStripMenuItem.Name = "выводСтатистикиToolStripMenuItem";
            выводСтатистикиToolStripMenuItem.Size = new Size(300, 34);
            выводСтатистикиToolStripMenuItem.Text = "Вывод статистики";
            выводСтатистикиToolStripMenuItem.Click += выводСтатистикиToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 228, 238);
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 0, 34);
            label1.Location = new Point(7, 46);
            label1.Name = "label1";
            label1.Size = new Size(468, 36);
            label1.TabIndex = 1;
            label1.Text = "Выберите метод сортировки";
            label1.Click += label1_Click;
            // 
            // radioButtonМВыб
            // 
            radioButtonМВыб.AutoSize = true;
            radioButtonМВыб.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonМВыб.ForeColor = Color.FromArgb(73, 0, 34);
            radioButtonМВыб.Location = new Point(7, 100);
            radioButtonМВыб.Name = "radioButtonМВыб";
            radioButtonМВыб.Size = new Size(354, 33);
            radioButtonМВыб.TabIndex = 2;
            radioButtonМВыб.TabStop = true;
            radioButtonМВыб.Text = "Сортировка методом выбора";
            radioButtonМВыб.UseVisualStyleBackColor = true;
            radioButtonМВыб.CheckedChanged += radioButtonМВыб_CheckedChanged;
            // 
            // radioButtonШ
            // 
            radioButtonШ.AutoSize = true;
            radioButtonШ.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonШ.ForeColor = Color.FromArgb(73, 0, 34);
            radioButtonШ.Location = new Point(7, 154);
            radioButtonШ.Name = "radioButtonШ";
            radioButtonШ.Size = new Size(347, 33);
            radioButtonШ.TabIndex = 3;
            radioButtonШ.TabStop = true;
            radioButtonШ.Text = "Сортировка методом Шелла";
            radioButtonШ.UseVisualStyleBackColor = true;
            radioButtonШ.CheckedChanged += radioButtonШ_CheckedChanged;
            // 
            // buttonСорт
            // 
            buttonСорт.BackColor = Color.FromArgb(250, 228, 238);
            buttonСорт.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonСорт.ForeColor = Color.FromArgb(73, 0, 34);
            buttonСорт.Location = new Point(7, 213);
            buttonСорт.Name = "buttonСорт";
            buttonСорт.Size = new Size(468, 79);
            buttonСорт.TabIndex = 4;
            buttonСорт.Text = "Сортируем!";
            buttonСорт.UseVisualStyleBackColor = false;
            buttonСорт.Click += buttonСорт_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 0, 34);
            label2.Location = new Point(7, 325);
            label2.Name = "label2";
            label2.Size = new Size(353, 36);
            label2.TabIndex = 5;
            label2.Text = "Узрите некие данные";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(250, 228, 238);
            label3.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(73, 0, 34);
            label3.Location = new Point(7, 385);
            label3.Name = "label3";
            label3.Size = new Size(276, 29);
            label3.TabIndex = 6;
            label3.Text = "Количество сравнений:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(73, 0, 34);
            label4.Location = new Point(7, 439);
            label4.Name = "label4";
            label4.Size = new Size(310, 29);
            label4.TabIndex = 7;
            label4.Text = "Количество перестановок:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(73, 0, 34);
            label5.Location = new Point(7, 489);
            label5.Name = "label5";
            label5.Size = new Size(224, 29);
            label5.TabIndex = 8;
            label5.Text = "Время сортировки:";
            // 
            // labelCountComparison
            // 
            labelCountComparison.AutoSize = true;
            labelCountComparison.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCountComparison.ForeColor = Color.FromArgb(73, 0, 34);
            labelCountComparison.Location = new Point(296, 388);
            labelCountComparison.Name = "labelCountComparison";
            labelCountComparison.Size = new Size(23, 24);
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
            labelNumberOfPermutations.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumberOfPermutations.ForeColor = Color.FromArgb(73, 0, 34);
            labelNumberOfPermutations.Location = new Point(333, 442);
            labelNumberOfPermutations.Name = "labelNumberOfPermutations";
            labelNumberOfPermutations.Size = new Size(23, 24);
            labelNumberOfPermutations.TabIndex = 12;
            labelNumberOfPermutations.Text = "0";
            // 
            // labelTimeSort
            // 
            labelTimeSort.AutoSize = true;
            labelTimeSort.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimeSort.ForeColor = Color.FromArgb(73, 0, 34);
            labelTimeSort.Location = new Point(251, 492);
            labelTimeSort.Name = "labelTimeSort";
            labelTimeSort.Size = new Size(23, 24);
            labelTimeSort.TabIndex = 13;
            labelTimeSort.Text = "0";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(250, 228, 238);
            listBox1.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(550, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(945, 532);
            listBox1.TabIndex = 14;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(250, 228, 238);
            buttonClear.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.ForeColor = Color.FromArgb(73, 0, 34);
            buttonClear.Location = new Point(7, 531);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(468, 79);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Зачистка!";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 228, 238);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1550, 622);
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