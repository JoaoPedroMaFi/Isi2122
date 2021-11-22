﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFSoapClientSide
{
    public partial class Infecteds : Form
    {
        public Infecteds()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WCFClient.ClientClient client = new();
            List<WCFClient.Infectado> list = new();
            list = client.GetAllInfectedAsync().Result;
            foreach (WCFClient.Infectado inf in list)
            {
                RTBox.Text += inf.Firstname +"\t" + inf.Laststname;
            }
        }
    }
}
