﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        static Operaciones op = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxOperacion.Text == "Suma")
            {
                lblres.Text = (op.Suma(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
            else if(cbxOperacion.Text == "Resta")
            {
                lblres.Text = (op.Resta(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
            else if (cbxOperacion.Text == "Mutiplicación")
            {
                lblres.Text = (op.Mult(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
            else if (cbxOperacion.Text == "División")
            {
                lblres.Text = (op.Div(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
        }
        
        private void lblres_MouseMove(object sender, EventArgs e)
        {
            MessageBox.Show("presione en resultado");
        }
        
        private void lblv1_Mouse(object sender, EventArgs e)
        {
            MessageBox.Show("coloque aquí su primer valor");
        }
        
        private void lblv2_Mouse(object sender, EventArgs e)
        {
            MessageBox.Show("coloque aquí su segundo valor");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
