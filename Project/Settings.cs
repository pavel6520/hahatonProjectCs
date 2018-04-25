﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (TBip.Text.IndexOf('`') != -1 || TBdatabase.Text.IndexOf('`') != -1 || TBport.Text.IndexOf('`') != -1)
            {
                MessageBox.Show("Символ '`' запрещен", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TBip.Text.Length == 0)
            {
                LipErr.Show();
                return;
            }
            LipErr.Hide();
            if (TBdatabase.Text.Length == 0)
            {
                LdbErr.Show();
                return;
            }
            LdbErr.Hide();
            if (TBport.Text.Length == 0)
            {
                LportErr.Show();
                return;
            }
            LportErr.Hide();
            if (TBip.Text.Length != 0 && TBdatabase.Text.Length != 0 && TBport.Text.Length != 0)
            {
                Program.IF.WriteINI("ConnSett", "Adress", TBip.Text);
                Program.IF.WriteINI("ConnSett", "DBname", TBdatabase.Text);
                Program.IF.WriteINI("ConnSett", "Port", TBport.Text);
                this.Close();
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if(Program.IF.KeyExists("ConnSett", "Address"))
            {
                TBip.Text = Program.IF.ReadINI("ConnSett", "Address");
            }
            if (Program.IF.KeyExists("ConnSett", "DBname"))
            {
                TBdatabase.Text = Program.IF.ReadINI("ConnSett", "DBname");
            }
            if (Program.IF.KeyExists("ConnSett", "Port"))
            {
                TBport.Text = Program.IF.ReadINI("ConnSett", "Port");
            }
        }
    }
}
