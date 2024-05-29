using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace daunTrip
{
    public partial class Form1 : Form
    {
        screen.china chinaScreen = new screen.china();
        screen.japan japanScreen = new screen.japan();
        screen.korea koreaScreen = new screen.korea();

        

        public Form1()
        {
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChn_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnChn.Text;
            panel1.Controls.Clear();
            panel1.Controls.Add(chinaScreen);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKor_Click(object sender, EventArgs e)
        {
            
            lblHome.Text = btnKor.Text;
            panel1.Controls.Clear();
            panel1.Controls.Add(koreaScreen);

        }

        private void btnJP_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Clear();
            lblHome.Text = btnJP.Text;
            panel1.Controls.Add(japanScreen);
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Room Add = new Add_Room();
            Add.ShowDialog();
        }
    }
}
