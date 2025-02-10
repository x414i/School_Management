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



namespace School_Management
{       public partial class main : Form
        {
            //Fields
            private Button currentButton;
            private Random random;
            private int tempIndex;
            private Form activeForm;

            //Constructor
            public main()
            {
                InitializeComponent();
            
            random = new Random();
            btnCloseChildForm.Visible = false;
            //this.Text = string.Empty;
            //this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            }
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();

            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

            //Methods
            private Color SelectThemeColor()
            {
                int index = random.Next(ThemeColor.ColorList.Count);
                while (tempIndex == index)
                {
                    index = random.Next(ThemeColor.ColorList.Count);
                }
                tempIndex = index;
                string color = ThemeColor.ColorList[index];
                return ColorTranslator.FromHtml(color);
            }

            private void ActivateButton(object btnSender)
            {
                if (btnSender != null)
                {
                    if (currentButton != (Button)btnSender)
                    {
                        DisableButton();
                        Color color = SelectThemeColor();
                        currentButton = (Button)btnSender;
                        currentButton.BackColor = color;
                        currentButton.ForeColor = Color.White;
                        currentButton.Font = new System.Drawing.Font("Cairo", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        panelTitleBar.BackColor = color;
                        panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                        ThemeColor.PrimaryColor = color;
                        ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                    }
                }
            }

            private void DisableButton()
            {
                foreach (Control previousBtn in panelMenu.Controls)
                {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                    //previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.BackColor = Color.FromArgb(42, 92, 117);
                    previousBtn.ForeColor = Color.Gainsboro;
                        previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }

            private void OpenChildForm(Form childForm, object btnSender)
            {
                if (activeForm != null)
                    activeForm.Close();
                ActivateButton(btnSender);
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPane.Controls.Add(childForm);
                this.panelDesktopPane.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTitle.Text = childForm.Text;

            }

            //private void btnProducts_Click(object sender, EventArgs e)
            //{ 
            //    OpenChildForm(new Forms.FormProduct(), sender);
            //}
        private void main_Load(object sender, EventArgs e)
        {
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "الصفحة الرئيسية";
            //panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.BackColor = Color.FromArgb(42, 92, 117);
            panelLogo.BackColor = Color.FromArgb(42, 92, 117);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnMaximize_Click(object sender, EventArgs e)
            {
                if (WindowState == FormWindowState.Normal)
                    this.WindowState = FormWindowState.Maximized;
                else
                    this.WindowState = FormWindowState.Normal;
            }

            private void bntMinimize_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm(), sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm(), sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentManagementForm(), sender);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentManagementForm(), sender);

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherManagementForm(), sender);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new AddUserForm(), sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SyncDB(), sender);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm(), sender);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimetableManagementForm(), sender);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ActivitiesManagementForm(), sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GradesEntryForm(), sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AttendanceTrackingForm(), sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ParentManagementForm(), sender);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SubjectManagementForm(), sender);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ClassManagementForm(), sender);

        }

        private void btnCloseChildForm_Click_2(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
                Reset();
        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnCloseChildForm_Click(object sender, EventArgs e)
        //{

        //}
    }
    }

