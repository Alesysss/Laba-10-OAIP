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
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripSplitButton();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            сгенерироватьНаборToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            radioButtonМВыб = new RadioButton();
            radioButton1 = new RadioButton();
            buttonСорт = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(64, 24);
            toolStripButton2.Text = "Анализ";
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
            // 
            // сгенерироватьНаборToolStripMenuItem
            // 
            сгенерироватьНаборToolStripMenuItem.Name = "сгенерироватьНаборToolStripMenuItem";
            сгенерироватьНаборToolStripMenuItem.Size = new Size(246, 26);
            сгенерироватьНаборToolStripMenuItem.Text = "Сгенерировать набор";
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 104);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(236, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Сортировка методом вставок";
            radioButton1.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonСорт);
            Controls.Add(radioButton1);
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
        private ToolStripButton toolStripButton2;
        private ToolStripSplitButton toolStripButton1;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem сгенерироватьНаборToolStripMenuItem;
        private Label label1;
        private RadioButton radioButtonМВыб;
        private RadioButton radioButton1;
        private Button buttonСорт;
    }
}