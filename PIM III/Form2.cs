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
    }
}
