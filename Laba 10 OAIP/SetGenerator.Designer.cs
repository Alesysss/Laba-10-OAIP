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
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(430, 29);
            label1.TabIndex = 0;
            label1.Text = "Выберите количество элементов";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 51);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(440, 56);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBoxCountElements
            // 
            textBoxCountElements.Location = new Point(20, 125);
            textBoxCountElements.Name = "textBoxCountElements";
            textBoxCountElements.Size = new Size(125, 27);
            textBoxCountElements.TabIndex = 2;
            textBoxCountElements.TextChanged += textBoxCountElements_TextChanged;
            // 
            // buttonCreateArray
            // 
            buttonCreateArray.Location = new Point(234, 133);
            buttonCreateArray.Name = "buttonCreateArray";
            buttonCreateArray.Size = new Size(94, 29);
            buttonCreateArray.TabIndex = 3;
            buttonCreateArray.Text = "Вуаля!";
            buttonCreateArray.UseVisualStyleBackColor = true;
            buttonCreateArray.Click += buttonCreateArray_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 188);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // SetGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 241);
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