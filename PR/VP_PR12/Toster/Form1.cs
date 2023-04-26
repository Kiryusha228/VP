using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Toster
{
    public partial class Toster : Form
    {
        private int _time;
        private int _currentTime;
        SoundPlayer soundUp;
        SoundPlayer soundDown;

        public Toster()
        {
            InitializeComponent();
            timer.Interval = 1000;
            SetImage(@"C:\Users\Kirill\source\repos\VP_PR12\Toster\Bread\toster.png");
            soundUp = new SoundPlayer(@"C:\Users\Kirill\source\repos\VP_PR12\Toster\Bread\Sounds\up.wav");
            soundDown = new SoundPlayer(@"C:\Users\Kirill\source\repos\VP_PR12\Toster\Bread\Sounds\down.wav");
            buttonStart.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (trackBarTime.Value != 0 && comboBoxBreadType.SelectedIndex != -1)
            {
                Start();
            }

        }

        private void vScrollBarOnOff_ValueChanged(object sender, EventArgs e)
        {
            if (vScrollBarOnOff.Value == 16 && trackBarTime.Value != 0 && comboBoxBreadType.SelectedIndex != -1)
            {
                Start();
            }
        }

        private void Start()
        {
            soundDown.Play();
            SwapImage("Rare", "In");
            groupBoxScroll.Enabled = false;
            groupBoxSettings.Enabled = false;
            _time = trackBarTime.Value;
            vScrollBarOnOff.Value = 25;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _currentTime++;
            trackBarTime.Value--;
            trackBarTime.Update();
            if (_currentTime == 5)
            {
                SwapImage("Medium", "In");
            }

            if (_currentTime == 11)
            {
                SwapImage("Well", "In");
            }

            if (_currentTime == _time)
            {
                vScrollBarOnOff.Value = 0;
                groupBoxScroll.Enabled = true;
                groupBoxSettings.Enabled = true;
                labelTime.Text = "Время";
                soundUp.Play();
                string coocked;
                if (_currentTime >= 11)
                {
                    coocked = "Well";
                }
                else if (_currentTime >= 5 && _currentTime < 11)
                {
                    coocked = "Medium";
                }
                else
                {
                    coocked = "Rare";
                }
                SwapImage(coocked, "");
                timer.Stop();
                MessageBox.Show($"Ваш {comboBoxBreadType.Text} {coocked} прожарки готов в количестве {GetCount()}", "Готово");
                _currentTime = 0;
            }
        }

        private string GetCount()
        {
            if (radioButtonOneBread.Checked)
            {
                return radioButtonOneBread.Text;
            }

            return radioButtonTwoBreads.Text;
        }

        private void comboBoxBreadType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwapImage("Rare", "");
        }
        

        private void trackBarTime_Scroll(object sender, EventArgs e)
        {
            labelTime.Text = $"Время: {trackBarTime.Value} сек";
        }

        private void radioButtonOneBread_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxBreadType.SelectedIndex != -1)
            {
                SwapImage("Rare", "");
            }
        }

        private void SwapImage(string coocked, string position)
        {
            string bread;
            string count = "";
            switch (comboBoxBreadType.SelectedIndex)
            {
                case 0:
                    bread = "Baton";
                    break;
                case 1:
                    bread = "Black";
                    break;
                case 2:
                    bread = "Baget";
                    break;
                case 3:
                    bread = "Bulka";
                    break;
                default:
                    bread = "";
                    break;
            }
            if (radioButtonTwoBreads.Checked)
            {
                count = "2";
            }
            SetImage(@"C:\Users\Kirill\source\repos\VP_PR12\Toster\Bread\" + bread + @"\toster" + position + bread + coocked + count + ".jpg");
        }

        private void SetImage(string fileName)
        {
            using (var tmp = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                pictureBoxToster.Image = new Bitmap(tmp);
            }
        }
    }
}