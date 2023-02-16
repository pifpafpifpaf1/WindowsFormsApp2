using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                listBox1.Items.Clear();

                // Получаем компоненты начала и конца даты
                DateTime start_date = dateTimePicker1.Value.Date;
                DateTime end_date = dateTimePicker2.Value.Date;
                int start_year = start_date.Year;
                int end_year = end_date.Year;
            // Зацикливание за выбранные годы
            for (int year = start_year; year <= end_year; year++)
            {
                // Цикл в течение месяцев в году
                for (int month = 1; month <= 12; month++)
                {
                    // Смотрим, будет ли в этом месяце 13-я пятница
                    DateTime test_date = new DateTime(year, month, 13);

                    // Если мы не достигли даты начала
                    if (test_date < start_date) continue;

                    // Если мы закончили дату окончания
                    if (test_date > end_date) break;

                    // Пятница
                    if (test_date.DayOfWeek == DayOfWeek.Friday)
                        listBox1.Items.Add(test_date.ToShortDateString());
                }
            }

        }
    }
}
