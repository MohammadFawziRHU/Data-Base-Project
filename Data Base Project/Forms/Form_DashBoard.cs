using Data_Base_Project.usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base_Project.Forms
{
    public partial class Form_DashBoard : Form
    {
        int Panelwidth;
        bool isCollapsed;

        public Form_DashBoard()
        {
            InitializeComponent();
            timerTime.Start();
            Panelwidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private  void AddControlsToPanel(Control C)
        {
            C.Dock= DockStyle.Fill;
            PanelControls.Controls.Clear();
            PanelControls.Controls.Add(C);
        }
        private void button1_Click(object sender, EventArgs e)
        {
       moveSidePanel(btnHome);
            AddControlsToPanel(btnHome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= Panelwidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
                else
                {
                    panelLeft.Width = panelLeft.Width - 10;
                    if (panelLeft.Width<=59)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                        this.Refresh();
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSaleBooks);
        }

        private void btnPurchaseItems_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPurchaseItems);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExpenses);
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnViewSales);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("hh:mm:ss");
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void Form_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void PanelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
