﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseScreen
{
    public partial class CantBuy : UserControl
    {
        public CantBuy()
        {
            InitializeComponent();
        }

        public void ChangeLabel(string str)
        {
            label1.Text = str;
        }
    }
}
