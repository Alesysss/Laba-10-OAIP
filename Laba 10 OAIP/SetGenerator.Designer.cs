namespace Laba_10_OAIP
{
    partial class SetGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetGenerator));
            label1 = new Label();
            trackBar1 = new TrackBar();
            textBoxCountElements = new TextBox();
            buttonCreateArray = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 228, 238);
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 0, 34);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(538, 36);
            label1.TabIndex = 0;
            label1.Text = "Выберите количество элементов";
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.FromArgb(250, 228, 238);
            trackBar1.Location = new Point(46, 82);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(440, 56);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBoxCountElements
            // 
            textBoxCountElements.BackColor = Color.FromArgb(250, 228, 238);
            textBoxCountElements.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCountElements.ForeColor = Color.FromArgb(73, 0, 34);
            textBoxCountElements.Location = new Point(208, 180);
            textBoxCountElements.Name = "textBoxCountElements";
            textBoxCountElements.Size = new Size(102, 36);
            textBoxCountElements.TabIndex = 2;
            textBoxCountElements.TextChanged += textBoxCountElements_TextChanged;
            // 
            // buttonCreateArray
            // 
            buttonCreateArray.BackColor = Color.FromArgb(250, 228, 238);
            buttonCreateArray.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreateArray.ForeColor = Color.FromArgb(73, 0, 34);
            buttonCreateArray.Location = new Point(178, 257);
            buttonCreateArray.Name = "buttonCreateArray";
            buttonCreateArray.Size = new Size(169, 44);
            buttonCreateArray.TabIndex = 3;
            buttonCreateArray.Text = "Вуаля!";
            buttonCreateArray.UseVisualStyleBackColor = false;
            buttonCreateArray.Click += buttonCreateArray_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(250, 228, 238);
            label2.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 0, 34);
            label2.Location = new Point(12, 342);
            label2.Name = "label2";
            label2.Size = new Size(75, 29);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // SetGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(554, 392);
            Controls.Add(label2);
            Controls.Add(buttonCreateArray);
            Controls.Add(textBoxCountElements);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Name = "SetGenerator";
            Text = "SetGenerator";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TrackBar trackBar1;
        private TextBox textBoxCountElements;
        private Button buttonCreateArray;
        private Label label2;
    }
}