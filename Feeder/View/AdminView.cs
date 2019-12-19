﻿using Presenter.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AdminView : Form, IAdminView
    {
        public delegate void registernewuser(string name);
        public event registernewuser registerNewUser;
        private readonly ApplicationContext _context;
        public AdminView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void Show()
        {
            //_context.MainForm = this;
            if(!Application.OpenForms.Cast<Form>().Any(f => f.Name == base.Name))
            {
                base.Show();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void mainPage_Click(object sender, EventArgs e)
        {

        }

        private void userNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            registerNewUser?.Invoke(userNameInput.Text);
        }
    }
}
