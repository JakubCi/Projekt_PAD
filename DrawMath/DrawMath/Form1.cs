using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openChildForm(new Form3());
            btnInfo.BackColor = Color.FromArgb(58, 72, 99);
        }
        private Form activeForm;
        
        private void openChildForm(Form childForm)
        {

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFill.Controls.Add(childForm);
            panelFill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz wyjść z aplikacji? ☹", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            btnDraw.BackColor = Color.FromArgb(58, 72, 99);
            btnInfo.BackColor = Color.FromArgb(49, 60, 83);
            panelSide.Location = new Point(0, 300);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            btnDraw.BackColor = Color.FromArgb(49, 60, 83);
            btnInfo.BackColor = Color.FromArgb(58, 72, 99);
            panelSide.Location = new Point(0, 200);
        }
    }
}
