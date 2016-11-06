using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping
{
    public partial class EasyShopkeeping : Form
    {
        public EasyShopkeeping()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberLogin lgnfrm = new MemberLogin();
            lgnfrm.Show();
            this.Hide();

        }

        private void EasyShopkeeping_Load(object sender, EventArgs e)
        {

        }
    }
    }