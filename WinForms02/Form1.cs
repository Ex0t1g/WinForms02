using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Text.RegularExpressions;

namespace WinForms02
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private CultureInfo currentCulture;
        private ResourceManager manager;
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

            SetCulture(Thread.CurrentThread.CurrentUICulture.Name == "en-US");
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
            if (!IsValidDate(dateTimePicker1.Value.ToString("yyyy-MM-dd")))
            {
                toolTip1.Show("Дата начала работ не может быть в прошлом.", dateTimePicker1);
                return;
            }

            if (!IsValidDate(dateTimePicker2.Value.ToString("yyyy-MM-dd")))
            {
                toolTip1.Show("Дата окончания работ не может быть в прошлом.", dateTimePicker2);
                return;
            }


            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                toolTip1.Show("Дата начала работ не может быть позже даты окончания работ.", dateTimePicker1);
                return;
            }

            string pricePerDayText = numericUpDown1.Value.ToString();
            if (!IsValidPrice(pricePerDayText))
            {
                toolTip1.Show("Цена дня работ должна быть положительным числом.", numericUpDown1);
                return;
            }


            decimal pricePerDay = decimal.Parse(pricePerDayText);
            DateTime startTime = dateTimePicker1.Value;
            DateTime endTime = dateTimePicker2.Value;

            TimeSpan duration = endTime - startTime;
            int days = (int)Math.Ceiling(duration.TotalDays);

            decimal totalAmount = days * pricePerDay;

            labelTotalPrice.Text = $"Вы заработали: {totalAmount:C}";
        }

        private bool IsValidDate(string date)
        {
            Regex regex = new Regex(@"^\d{4}-\d{2}-\d{2}$");
            return regex.IsMatch(date) && DateTime.Parse(date) >= DateTime.Now;
        }

        private bool IsValidPrice(string price)
        {
            Regex regex = new Regex(@"^[1-9]\d*(\.\d+)?$");
            return regex.IsMatch(price);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(textBox1.Text))
            {
                textBox1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                textBox1.ForeColor = System.Drawing.Color.Red;
                toolTip1.Show("Адрес электронной почты должен соответствовать формату user@domain.com", textBox1);
            }
        }

        private bool IsValidEmail(string email)
        {

            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        
        private void checkBoxLang_CheckedChanged(object sender, EventArgs e)
        {
            SetCulture(checkBoxLang.Checked);

        }

        private void SetCulture(bool isEnglish)
        {
            if (isEnglish)
            {
                currentCulture = new CultureInfo("en-US");
            } else
            {
                currentCulture = new CultureInfo("ru-RU");
            }


            Thread.CurrentThread.CurrentUICulture = currentCulture;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            manager = new ResourceManager(typeof(Form1));
            checkBoxLang.Text = manager.GetString("checkBoxLang.Text");
            label4.Text = manager.GetString("label4.Text");
            labelEndWork.Text = manager.GetString("labelEndWork.Text");
            labelPriceWork.Text = manager.GetString("labelPriceWork.Text");
            labelStartWork.Text = manager.GetString("labelStartWork.Text");
            

        }
    }
}
