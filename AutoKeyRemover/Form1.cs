using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace AutoKeyRemover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(TextKey.Text, true))
            {
                if (key == null)
                {
                    MessageBox.Show("Key doesn't exist","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    BtnStartStop_Click(sender, e);
                }
                else
                {
                    try
                    {
                        key.DeleteValue(TextValue.Text);
                    }
                    catch
                    {
                        //Already deleted
                    }
                }
            }
        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (BtnStartStop.Text == "Start")
            {
                TextKey.Enabled = false;
                TextValue.Enabled = false;

                BtnStartStop.Text = "Stop";
                timer1.Interval = int.Parse(ComboTime.SelectedItem.ToString()) * 1000;
                timer1.Start();

            }
            else
            {
                TextKey.Enabled = true;
                TextValue.Enabled = true;

                BtnStartStop.Text = "Start";
                timer1.Stop();
            }
        }
    }
}
