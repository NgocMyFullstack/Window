using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void Login(object sender, EventArgs e)
        {
            String txtUser = txtUseName.Text.ToString();
            String txtPass = txtPassWord.Text.ToString();
            if (txtUser == "Ngocmy" && txtPass == "123")
            {
                Menu objMenu = new Menu();
                objMenu.Show();
            }
            else
            {

            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
