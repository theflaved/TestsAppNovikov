﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsApp
{
    public partial class CreateOrEditForm : Form
    {
        public CreateOrEditForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm(true);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
