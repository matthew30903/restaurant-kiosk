﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS741_FinalProject_LamontMacoyMelkie
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
        }
    }
}
