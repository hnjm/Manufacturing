﻿using DevComponents.DotNetBar.Metro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manufacturing_Execution
{
    public partial class Query : MetroAppForm
    {
        public Query()
        {
            InitializeComponent();
        }

        private void checkBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTime.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void Query_Load(object sender, EventArgs e)
        {
            
        }
    }
}
