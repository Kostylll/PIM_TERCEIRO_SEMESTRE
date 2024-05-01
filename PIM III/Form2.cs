﻿using PimProject.Application.Domain.Response;
using PimProject.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_III
{
    public partial class Form2 : Form
    {
        private ColaboradoresServiceSql _colaboradoresServiceSql;

        public Form2()
        {
            InitializeComponent();
            _colaboradoresServiceSql = new ColaboradoresServiceSql();
            PreencherDataGridView();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async Task PreencherDataGridView()
        {
            List<ColaboradoresResponse> colaboradores = await _colaboradoresServiceSql.ExibirColaboradores();


            dataGridView1.Rows.Clear();


            foreach (var colaborador in colaboradores)
            {

                dataGridView1.Rows.Add(
                    colaborador.Nome,
                    colaborador.Sobrenome,
                    colaborador.Data_Nascimento,
                    colaborador.CPF,
                    colaborador.Email
                );
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            UserControl1 userControl1 = new UserControl1();

            this.Controls.Add(userControl1);

            int x = (this.Width - userControl1.Width) / 2;
            int y = (this.Height - userControl1.Height) / 2;



            userControl1.Location = new Point(x, y);

            userControl1.BringToFront();
            userControl1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            UserControl2 userControl2 = new UserControl2();

            userControl2.Location = new Point(970, 63);

            this.Controls.Add(userControl2);


            userControl2.BringToFront();
            userControl2.Show();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void pictureBox6_Click(object sender, EventArgs e)
        {
            //FUNÇÃO LUPINHA
            string searchTerm = textBox1.Text;
            List<ColaboradoresResponse> resultados = await _colaboradoresServiceSql.PesquisarColaboradores(searchTerm);
            dataGridView1.DataSource = resultados;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
