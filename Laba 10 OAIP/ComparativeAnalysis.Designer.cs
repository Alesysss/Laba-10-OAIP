namespace Laba_10_OAIP
{
    partial class ComparativeAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparativeAnalysis));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            buttonSort = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(250, 228, 238);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(528, 215);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 228, 238);
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 0, 34);
            label1.Location = new Point(4, 297);
            label1.Name = "label1";
            label1.Size = new Size(75, 29);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(250, 228, 238);
            label2.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 0, 34);
            label2.Location = new Point(4, 377);
            label2.Name = "label2";
            label2.Size = new Size(75, 29);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // buttonSort
            // 
            buttonSort.BackColor = Color.FromArgb(250, 228, 238);
            buttonSort.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSort.ForeColor = Color.FromArgb(73, 0, 34);
            buttonSort.Location = new Point(612, 92);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(157, 106);
            buttonSort.TabIndex = 3;
            buttonSort.Text = "Тык!";
            buttonSort.UseVisualStyleBackColor = false;
            buttonSort.Click += buttonSort_Click;
            // 
            // ComparativeAnalysis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(811, 450);
            Controls.Add(buttonSort);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ComparativeAnalysis";
            Text = "ComparativeAnalysis";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button buttonSort;
    }
}