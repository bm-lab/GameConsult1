﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClient1
{
    public partial class GameSessionForm : Form
    {
        public GameSessionForm()
        {
            InitializeComponent();
        }

        public GameSessionForm(MenuForm f)
        {
            InitializeComponent();
            //f.BackColor = Color.Yellow;
        }

    }
}
