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
    public partial class Form4 : Form
    {
        private VendasService _vendasServiceSql;
        private UserControl2 userControl2;

        public Form4()
        {
            InitializeComponent();
            _vendasServiceSql = new VendasService();
            PreencherDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public async Task PreencherDataGridView()
        {
            List<VendasResponse> vendas = await _vendasServiceSql.ExibirVendas();
            BindingList<VendasResponse> bindingList = new BindingList<VendasResponse>(vendas);
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

                string venda_id = linhaSelecionada.Cells["Venda_Id"].Value.ToString();
                string valor_venda = linhaSelecionada.Cells["Valor_Venda"].Value.ToString();
                string colaborador_cpf = linhaSelecionada.Cells["Colaborador_CPF"].Value.ToString();
                string quantidade_vendido = linhaSelecionada.Cells["Quantidade_Vendido"].Value.ToString();

                userControl1.SetValues(venda_id, valor_venda, colaborador_cpf, quantidade_vendido);

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

                string venda_id = dataGridView1.Rows[rowIndex].Cells["Venda_Id"].Value.ToString();

                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar esta venda?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _vendasServiceSql.RemoverVenda(venda_id);

                    Form4 form4 = Application.OpenForms.OfType<Form4>().FirstOrDefault();
                    form4?.PreencherDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma venda para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
