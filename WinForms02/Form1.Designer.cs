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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            checkBoxLang = new CheckBox();
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
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.Name = "progressBar1";
            toolTip1.SetToolTip(progressBar1, resources.GetString("progressBar1.ToolTip"));
            // 
            // hScrollBarRed
            // 
            resources.ApplyResources(hScrollBarRed, "hScrollBarRed");
            hScrollBarRed.Maximum = 255;
            hScrollBarRed.Name = "hScrollBarRed";
            toolTip1.SetToolTip(hScrollBarRed, resources.GetString("hScrollBarRed.ToolTip"));
            hScrollBarRed.ValueChanged += hScrollBarRed_ValueChanged;
            // 
            // hScrollBarGreen
            // 
            resources.ApplyResources(hScrollBarGreen, "hScrollBarGreen");
            hScrollBarGreen.Maximum = 255;
            hScrollBarGreen.Name = "hScrollBarGreen";
            toolTip1.SetToolTip(hScrollBarGreen, resources.GetString("hScrollBarGreen.ToolTip"));
            hScrollBarGreen.ValueChanged += hScrollBarGreen_ValueChanged_1;
            // 
            // hScrollBarBlue
            // 
            resources.ApplyResources(hScrollBarBlue, "hScrollBarBlue");
            hScrollBarBlue.Maximum = 255;
            hScrollBarBlue.Name = "hScrollBarBlue";
            toolTip1.SetToolTip(hScrollBarBlue, resources.GetString("hScrollBarBlue.ToolTip"));
            hScrollBarBlue.ValueChanged += hScrollBarBlue_ValueChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            toolTip1.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            toolTip1.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // buttonColor
            // 
            resources.ApplyResources(buttonColor, "buttonColor");
            buttonColor.BackColor = Color.Silver;
            buttonColor.Name = "buttonColor";
            toolTip1.SetToolTip(buttonColor, resources.GetString("buttonColor.ToolTip"));
            buttonColor.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(dateTimePicker1, "dateTimePicker1");
            dateTimePicker1.Name = "dateTimePicker1";
            toolTip1.SetToolTip(dateTimePicker1, resources.GetString("dateTimePicker1.ToolTip"));
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(dateTimePicker2, "dateTimePicker2");
            dateTimePicker2.Name = "dateTimePicker2";
            toolTip1.SetToolTip(dateTimePicker2, resources.GetString("dateTimePicker2.ToolTip"));
            // 
            // labelStartWork
            // 
            resources.ApplyResources(labelStartWork, "labelStartWork");
            labelStartWork.Name = "labelStartWork";
            toolTip1.SetToolTip(labelStartWork, resources.GetString("labelStartWork.ToolTip"));
            // 
            // labelEndWork
            // 
            resources.ApplyResources(labelEndWork, "labelEndWork");
            labelEndWork.Name = "labelEndWork";
            toolTip1.SetToolTip(labelEndWork, resources.GetString("labelEndWork.ToolTip"));
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(numericUpDown1, "numericUpDown1");
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            toolTip1.SetToolTip(numericUpDown1, resources.GetString("numericUpDown1.ToolTip"));
            // 
            // labelPriceWork
            // 
            resources.ApplyResources(labelPriceWork, "labelPriceWork");
            labelPriceWork.Name = "labelPriceWork";
            toolTip1.SetToolTip(labelPriceWork, resources.GetString("labelPriceWork.ToolTip"));
            // 
            // labelTotalPrice
            // 
            resources.ApplyResources(labelTotalPrice, "labelTotalPrice");
            labelTotalPrice.Name = "labelTotalPrice";
            toolTip1.SetToolTip(labelTotalPrice, resources.GetString("labelTotalPrice.ToolTip"));
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            toolTip1.SetToolTip(textBox1, resources.GetString("textBox1.ToolTip"));
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // labelEmailStatus
            // 
            resources.ApplyResources(labelEmailStatus, "labelEmailStatus");
            labelEmailStatus.Name = "labelEmailStatus";
            toolTip1.SetToolTip(labelEmailStatus, resources.GetString("labelEmailStatus.ToolTip"));
            // 
            // checkBoxLang
            // 
            resources.ApplyResources(checkBoxLang, "checkBoxLang");
            checkBoxLang.Name = "checkBoxLang";
            toolTip1.SetToolTip(checkBoxLang, resources.GetString("checkBoxLang.ToolTip"));
            checkBoxLang.UseVisualStyleBackColor = true;
            checkBoxLang.CheckedChanged += checkBoxLang_CheckedChanged;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBoxLang);
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
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
        private CheckBox checkBoxLang;
    }
}
