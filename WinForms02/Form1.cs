namespace WinForms02
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Start();
            UpdateColor();
            dateTimePicker1.ValueChanged += CalculateResult;
            dateTimePicker2.ValueChanged += CalculateResult;
            numericUpDown1.ValueChanged += CalculateResult;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = Math.Min(progressBar1.Value + timer.Interval / 100, progressBar1.Maximum);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer.Stop();
            }
        }

        private void hScrollBarRed_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }
        private void hScrollBarGreen_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateColor();
        }
        private void hScrollBarBlue_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }
        private void UpdateColor()
        {
            int redValue = hScrollBarRed.Value;
            int greenValue = hScrollBarGreen.Value;
            int blueValue = hScrollBarBlue.Value;
            buttonColor.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }

        private void CalculateResult(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePicker1.Value;
            DateTime endTime = dateTimePicker2.Value;
            decimal pricePerDay = numericUpDown1.Value;

            TimeSpan duration = endTime - startTime;
            int days = (int)Math.Ceiling(duration.TotalDays);

            decimal totalAmount = days * pricePerDay;

            labelTotalPrice.Text = $"Вы заработали: {totalAmount:C}";
        }
    }
}
