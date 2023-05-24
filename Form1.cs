using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Будильник_и_таймер_сна
{
    public partial class Form1 : Form
    {
        private int Music = 0;
        private string NameFile = "";

        private string Hour = "";
        private string Minut = "";
        private string Second = "";

        private string HourNow = "";
        private string MinutNow = "";
        private string SecondNow = "";

        WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(Timer1_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hour = DateTime. Now.Hour.ToString();
            Minut = DateTime. Now.Minute.ToString();
            Second = DateTime. Now.Second.ToString();

            if (Hour.Length == 1)
            {
                Hour = "0" + Hour;
            }
            if (Minut.Length == 1)
            {
                Minut = "0" + Minut;
            }
            if (Second.Length == 1)
            {
                Second = "0" + Second;
            }

            textBoxHour.Text = Hour;
            textBoxMinut.Text = Minut;
            textBoxSecond.Text = Second;

        }

        private void buttonMusicSelection_Click(object sender, EventArgs e)
        {
            string extenstion = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                NameFile = openFileDialog1.FileName;
                extenstion = Path.GetExtension(NameFile);

                if (extenstion != ".mp3")
                {
                    MessageBox.Show("Выбери песню в формате mp3");
                    return;
                }
                string fileName = Path.GetFileName(NameFile); // берем толлько название файла
                buttonMusicSelection.Text = fileName.Length <= 14 ? fileName : fileName.Substring(0, 14) + "...";
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Стоп")
            {
                if (Music == 1)
                {
                    WMP.controls.stop();
                    buttonMusicSelection.Text = NameFile.Substring(0 , 14) + "...";
                    Music = 0;
                }
                textBoxHour.ReadOnly = false;
                textBoxMinut.ReadOnly = false;
                textBoxSecond.ReadOnly = false;
                timer1.Enabled = false;
                buttonStart.BackColor = Color.FromArgb(224, 233, 234);
                buttonStart.Text = "Запустить";
            }
            else
            {
                if (textBoxHour.Text == "")
                {
                    MessageBox.Show("Поле часы пусто");
                    return;
                }
                if (textBoxMinut.Text == "")
                {
                    MessageBox.Show("Поле минуты пусто");
                    return;
                }
                if (textBoxSecond.Text == "")
                {
                    MessageBox.Show("Поле секунды пусто");
                    return;
                }
                if (textBoxVolume.Text == "")
                {
                    MessageBox.Show("Громкость не установлена");
                    return;
                }

                if (!(Convert.ToInt32(textBoxHour.Text) >= 0 && Convert.ToInt32(textBoxHour.Text) <= 23))
                {
                    MessageBox.Show("Некорректно указаны часы");
                    return;
                }
                if (!(Convert.ToInt32(textBoxMinut.Text) >= 0 && Convert.ToInt32(textBoxMinut.Text) <= 59))
                {
                    MessageBox.Show("Некорректно указаны минуты");
                    return;
                }
                if (!(Convert.ToInt32(textBoxSecond.Text) >= 0 && Convert.ToInt32(textBoxSecond.Text) <= 59))
                {
                    MessageBox.Show("Некорректно указаны секунды");
                    return;
                }
                if (!(Convert.ToInt32(textBoxVolume.Text) >= 0 && Convert.ToInt32(textBoxVolume.Text) <= 100))
                {
                    MessageBox.Show("Некорректно указана громкость. Диапазон от 0 до 100 !");
                    return;
                }
                if (buttonMusicSelection.Text == "Выберите песню")
                {
                    MessageBox.Show("Песня не выбрана");
                    return;
                }
                else
                {
                    buttonStart.BackColor = Color.FromArgb(219, 11, 14);
                    buttonStart.Text = "Стоп";
                    Hour = textBoxHour.Text;
                    Minut = textBoxMinut.Text;
                    Second = textBoxSecond.Text;
                    textBoxHour.ReadOnly = true;
                    textBoxMinut.ReadOnly = true;
                    textBoxSecond.ReadOnly = true;
                }
                timer1.Enabled = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            HourNow = DateTime.Now.Hour.ToString();
            MinutNow = DateTime.Now.Minute.ToString();
            SecondNow = DateTime.Now.Second.ToString();

            if (HourNow.Length == 1)
            {
                HourNow = "0" + HourNow;
            }
            if (MinutNow.Length == 1)
            {
                MinutNow = "0" + MinutNow;
            }
            if (SecondNow.Length == 1)
            {
                SecondNow = "0" + SecondNow;
            }
            if (Hour == HourNow && Minut == MinutNow && Second == SecondNow)
            {
                WMP.URL = NameFile;
              //  WMP.settings.volume = 100;
                WMP.controls.play();
                Music = 1;
            }
        }

        private void textBoxHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >='0' && e.KeyChar <='9')
            {
                if (textBoxHour.Text.Length >= 0 && textBoxHour.Text.Length <=1)
                {
                    return;
                }
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBoxMinut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBoxMinut.Text.Length >= 0 && textBoxMinut.Text.Length <= 1)
                {
                    return;
                }
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBoxSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBoxSecond.Text.Length >= 0 && textBoxSecond.Text.Length <= 1)
                {
                    return;
                }
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBoxVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBoxVolume.Text.Length >= 0 && textBoxVolume.Text.Length <= 2)
                {
                    return;
                }
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBoxHour_Leave(object sender, EventArgs e)
        {
            if (textBoxHour.Text.Length == 1)
            {
                textBoxHour.Text = "0" + textBoxHour.Text;
            }
        }

        private void textBoxMinut_Leave(object sender, EventArgs e)
        {
            if (textBoxMinut.Text.Length == 1)
            {
                textBoxMinut.Text = "0" + textBoxMinut.Text;
            }
        }

        private void textBoxSecond_Leave(object sender, EventArgs e)
        {
            if (textBoxSecond.Text.Length == 1)
            {
                textBoxSecond.Text = "0" + textBoxSecond.Text;
            }
        }

        private void textBoxVolume_Leave(object sender, EventArgs e)
        {
            if (textBoxVolume.Text.Length == 1)
            {
                textBoxVolume.Text = "0" + textBoxVolume.Text;
            }
        }

        private void textBoxVolume_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxVolume.Text, out int volume);
            WMP.settings.volume = volume;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(218, 13, 29);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb (118, 139, 159);
        }

        Point lastPoint;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonWelding_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonWelding_MouseEnter(object sender, EventArgs e)
        {
            ButtonWelding.ForeColor = Color.FromArgb(218, 13, 29);
        }

        private void ButtonWelding_MouseLeave(object sender, EventArgs e)
        {
            ButtonWelding.ForeColor = Color.FromArgb(118, 139, 159);
        }
    }
}
