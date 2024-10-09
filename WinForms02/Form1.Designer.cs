namespace WinForms02
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            hScrollBarRed = new HScrollBar();
            hScrollBarGreen = new HScrollBar();
            hScrollBarBlue = new HScrollBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonColor = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            labelStartWork = new Label();
            labelEndWork = new Label();
            numericUpDown1 = new NumericUpDown();
            labelPriceWork = new Label();
            labelTotalPrice = new Label();
            toolTip1 = new ToolTip(components);
            textBox1 = new TextBox();
            label4 = new Label();
            labelEmailStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 23);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(399, 23);
            progressBar1.TabIndex = 0;
            // 
            // hScrollBarRed
            // 
            hScrollBarRed.Location = new Point(105, 173);
            hScrollBarRed.Maximum = 255;
            hScrollBarRed.Name = "hScrollBarRed";
            hScrollBarRed.Size = new Size(338, 29);
            hScrollBarRed.TabIndex = 2;
            hScrollBarRed.ValueChanged += hScrollBarRed_ValueChanged;
            // 
            // hScrollBarGreen
            // 
            hScrollBarGreen.Location = new Point(105, 218);
            hScrollBarGreen.Maximum = 255;
            hScrollBarGreen.Name = "hScrollBarGreen";
            hScrollBarGreen.Size = new Size(338, 29);
            hScrollBarGreen.TabIndex = 3;
            hScrollBarGreen.ValueChanged += hScrollBarGreen_ValueChanged_1;
            // 
            // hScrollBarBlue
            // 
            hScrollBarBlue.Location = new Point(105, 257);
            hScrollBarBlue.Maximum = 255;
            hScrollBarBlue.Name = "hScrollBarBlue";
            hScrollBarBlue.Size = new Size(338, 29);
            hScrollBarBlue.TabIndex = 4;
            hScrollBarBlue.ValueChanged += hScrollBarBlue_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(75, 173);
            label1.Name = "label1";
            label1.Size = new Size(27, 30);
            label1.TabIndex = 5;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(75, 217);
            label2.Name = "label2";
            label2.Size = new Size(28, 30);
            label2.TabIndex = 6;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(75, 256);
            label3.Name = "label3";
            label3.Size = new Size(26, 30);
            label3.TabIndex = 7;
            label3.Text = "B";
            // 
            // buttonColor
            // 
            buttonColor.BackColor = Color.Silver;
            buttonColor.Location = new Point(477, 173);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(123, 113);
            buttonColor.TabIndex = 8;
            buttonColor.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(668, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(668, 135);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(168, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // labelStartWork
            // 
            labelStartWork.AutoSize = true;
            labelStartWork.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStartWork.Location = new Point(669, 48);
            labelStartWork.Name = "labelStartWork";
            labelStartWork.Size = new Size(262, 21);
            labelStartWork.TabIndex = 11;
            labelStartWork.Text = "Введите дату начало работ";
            // 
            // labelEndWork
            // 
            labelEndWork.AutoSize = true;
            labelEndWork.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEndWork.Location = new Point(668, 111);
            labelEndWork.Name = "labelEndWork";
            labelEndWork.Size = new Size(290, 21);
            labelEndWork.TabIndex = 12;
            labelEndWork.Text = "Введите дату окончания работ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(669, 196);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(167, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // labelPriceWork
            // 
            labelPriceWork.AutoSize = true;
            labelPriceWork.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPriceWork.Location = new Point(669, 173);
            labelPriceWork.Name = "labelPriceWork";
            labelPriceWork.Size = new Size(214, 21);
            labelPriceWork.TabIndex = 14;
            labelPriceWork.Text = "Введите цену 1-ог дня";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalPrice.Location = new Point(668, 256);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(0, 25);
            labelTotalPrice.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 336);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(448, 23);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(75, 329);
            label4.Name = "label4";
            label4.Size = new Size(86, 30);
            label4.TabIndex = 17;
            label4.Text = "ПОЧТА";
            // 
            // labelEmailStatus
            // 
            labelEmailStatus.AutoSize = true;
            labelEmailStatus.Location = new Point(242, 309);
            labelEmailStatus.Name = "labelEmailStatus";
            labelEmailStatus.Size = new Size(0, 15);
            labelEmailStatus.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 633);
            Controls.Add(labelEmailStatus);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelPriceWork);
            Controls.Add(numericUpDown1);
            Controls.Add(labelEndWork);
            Controls.Add(labelStartWork);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonColor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hScrollBarBlue);
            Controls.Add(hScrollBarGreen);
            Controls.Add(hScrollBarRed);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private HScrollBar hScrollBarRed;
        private HScrollBar hScrollBarGreen;
        private HScrollBar hScrollBarBlue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonColor;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label labelStartWork;
        private Label labelEndWork;
        private NumericUpDown numericUpDown1;
        private Label labelPriceWork;
        private Label labelTotalPrice;
        private ToolTip toolTip1;
        private TextBox textBox1;
        private Label label4;
        private Label labelEmailStatus;
    }
}
