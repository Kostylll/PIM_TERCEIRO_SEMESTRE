using PimProject.Application.Domain.Response;
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
        private ColaboradoresService _cobService;
        private UserControl2 userControl2;
        public Form2()
        {
            InitializeComponent();
            _cobService = new ColaboradoresService();
            PreencherDataGridView();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public async Task PreencherDataGridView()
        {
            List<ColaboradoresResponse> colaboradores = await _cobService.ExibirColaboradores();


            BindingList<ColaboradoresResponse> bindingList = new BindingList<ColaboradoresResponse>(colaboradores);


            dataGridView1.DataSource = bindingList;


        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (this.Controls.OfType<UserControl1>().Any())
            {
                return;
            }

            UserControl1 userControl1 = new UserControl1();



            this.Controls.Add(userControl1);

            int x = (this.Width - userControl1.Width) / 2;
            int y = (this.Height - userControl1.Height) / 2;
            userControl1.Location = new Point(x, y);

            userControl1.BringToFront();
            userControl1.Show();
            userControl1.EsconderBotao();



        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (userControl2 == null || userControl2.IsDisposed)
            {
                userControl2 = new UserControl2();
                userControl2.Location = new Point(970, 63);
                this.Controls.Add(userControl2);
            }

            if (userControl2.Visible)
            {
                userControl2.Hide();
            }
            else
            {
                userControl2.BringToFront();
                userControl2.Show();
            }
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void pictureBox6_Click(object sender, EventArgs e)
        {
            //FUNÇÃO LUPINHA
            string searchTerm = textBox1.Text;
            List<ColaboradoresResponse> resultados = await _cobService.PesquisarColaboradores(searchTerm);
            dataGridView1.DataSource = resultados;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (this.Controls.OfType<UserControl1>().Any())
            {
                return;
            }


            if (dataGridView1.SelectedRows.Count > 0)
            {
                UserControl1 userControl1 = new UserControl1();
                this.Controls.Add(userControl1);

                int x = (this.Width - userControl1.Width) / 2;
                int y = (this.Height - userControl1.Height) / 2;

                userControl1.Location = new Point(x, y);
                userControl1.Show();
                userControl1.BringToFront();
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];

                string nome = linhaSelecionada.Cells["Nome_Completo"].Value.ToString();
                string email = linhaSelecionada.Cells["Email"].Value.ToString();
                string cpf = linhaSelecionada.Cells["CPF"].Value.ToString();
                string status = linhaSelecionada.Cells["Status"].Value.ToString();
                string telefone = linhaSelecionada.Cells["Telefone"].Value.ToString();

                userControl1.SetValues(nome, email, cpf, status, telefone);
                userControl1.LockarCpf();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                string cpf = dataGridView1.Rows[rowIndex].Cells["CPF"].Value.ToString();

                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar este colaborador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _cobService.RemoverColaborador(cpf);

                    Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
                    form2?.PreencherDataGridView();


                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um colaborador para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
