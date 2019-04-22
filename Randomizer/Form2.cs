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

namespace Randomizer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBoxHotkey.Text = ((Keys)Program.hotkey).ToString();
            this.textBoxEnable.Text = ((Keys)Program.disableApp).ToString();
            this.textBoxQuit.Text = ((Keys)Program.quit).ToString();

            this.textBoxFrom.Text = Program.min.ToString();
            this.textBoxTo.Text = Program.max.ToString();

            if (Program.backColor.ToString() == "White") this.radioButtonWhite.Checked = true;
            else this.radioButtonBlack.Checked = true;

            this.checkBoxTopMost.Checked = Program.alwaysOnTop;
            this.checkBoxSaveLog.Checked = Program.saveLog;

            this.trackBarOpacity.Value = Program.opacity;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {

                Program.hotkey = (int)(Keys)Convert.ToChar(this.textBoxHotkey.Text.ToUpper().Trim());
                Program.disableApp = (int)(Keys)Convert.ToChar(this.textBoxEnable.Text.ToUpper().Trim());
                Program.quit = (int)(Keys)Convert.ToChar(this.textBoxQuit.Text.ToUpper().Trim());
                Program.min = Convert.ToInt32(textBoxFrom.Text);
                Program.max = Convert.ToInt32(textBoxTo.Text);

                Program.saveLog = this.checkBoxSaveLog.Checked;
                
                if (radioButtonWhite.Checked) { Program.backColor = radioButtonWhite.Text; }
                else { Program.backColor = radioButtonBlack.Text; }
                Program.form.BackColor = Color.FromName(Program.backColor);

                Program.alwaysOnTop = this.checkBoxTopMost.Checked;
                Program.form.TopMost = Program.alwaysOnTop;

                Program.opacity = this.trackBarOpacity.Value;
                Program.form.Opacity = (double)Program.opacity / 10;

                string[] lines = new string[9];
                lines[0] = Program.hotkey.ToString();
                lines[1] = Program.disableApp.ToString();
                lines[2] = Program.quit.ToString();
                lines[3] = Program.min.ToString();
                lines[4] = Program.max.ToString();
                lines[5] = Program.backColor;
                lines[6] = Program.alwaysOnTop.ToString();
                lines[7] = Program.opacity.ToString();
                lines[8] = Program.saveLog.ToString();

                File.Delete(Program.rootFolder + Program.configFile);
                File.WriteAllLines(Program.rootFolder + Program.configFile, lines);

                MessageBox.Show("Configuration saved successfully.");

                this.Close();
            }
            catch(Exception oEx)
            {
                MessageBox.Show("Error saving configuration. Please take a look on the values and try again."+Environment.NewLine+"Exception message: "+oEx.Message);
            }
        }

        private void textBoxHotkey_TextChanged(object sender, EventArgs e)
        {
            this.textBoxHotkey.Text = this.textBoxHotkey.Text.ToUpper();
            this.textBoxHotkey.SelectionStart = 0;
            this.textBoxHotkey.SelectionLength = this.textBoxHotkey.Text.Length;
        }

        private void textBoxHotkey_Enter(object sender, EventArgs e)
        {
            this.textBoxHotkey.SelectionStart = 0;
            this.textBoxHotkey.SelectionLength = this.textBoxHotkey.Text.Length;
        }

        private void textBoxEnable_TextChanged(object sender, EventArgs e)
        {
            this.textBoxEnable.Text = this.textBoxEnable.Text.ToUpper();
            this.textBoxEnable.SelectionStart = 0;
            this.textBoxEnable.SelectionLength = this.textBoxEnable.Text.Length;
        }

        private void textBoxEnable_Enter(object sender, EventArgs e)
        {
            this.textBoxEnable.SelectionStart = 0;
            this.textBoxEnable.SelectionLength = this.textBoxEnable.Text.Length;
        }

        private void textBoxQuit_TextChanged(object sender, EventArgs e)
        {
            this.textBoxQuit.Text = this.textBoxQuit.Text.ToUpper();
            this.textBoxQuit.SelectionStart = 0;
            this.textBoxQuit.SelectionLength = this.textBoxQuit.Text.Length;
        }

        private void textBoxQuit_Enter(object sender, EventArgs e)
        {
            this.textBoxQuit.SelectionStart = 0;
            this.textBoxQuit.SelectionLength = this.textBoxQuit.Text.Length;
        }

        private void textBoxFrom_Enter(object sender, EventArgs e)
        {
            this.textBoxFrom.SelectionStart = 0;
            this.textBoxFrom.SelectionLength = this.textBoxFrom.Text.Length;
        }

        private void textBoxTo_Enter(object sender, EventArgs e)
        {
            this.textBoxTo.SelectionStart = 0;
            this.textBoxTo.SelectionLength = this.textBoxTo.Text.Length;
        }
    }
}
