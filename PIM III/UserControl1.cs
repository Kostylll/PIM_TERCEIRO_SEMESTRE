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
    public partial class UserControl1 : UserControl
    {
        private readonly ColaboradoresServiceSql _colaboradoresServiceSql;
        public UserControl1()
        {
            InitializeComponent();
            _colaboradoresServiceSql = new ColaboradoresServiceSql();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();

            this.Controls.Add(userControl1);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        public void SetValues(string nome, string email, string cpf)
        {
            textBox2.Text = nome;
            textBox3.Text = email;
            textBox4.Text = cpf;


        }

        public void pictureBox10_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox4.Text))
            {

                string cpf = textBox4.Text;

                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar este colaborador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _colaboradoresServiceSql.RemoverColaborador(cpf);

                    Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
                    form2?.PreencherDataGridView();

                    this.Parent.Controls.Remove(this);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um CPF válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public async Task EsconderBotao()
        {
            pictureBox10.Hide();
        }

        public void pictureBox11_Click(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            this.Controls.Add(userControl1);

            string nome = textBox2.Text;
            string email = textBox3.Text;
            string cpf = FormatarCPF(textBox4.Text);

            var dadosForm = new ColaboradoresResponse
            {
                Nome_Completo = nome,
                Email = email,
                CPF = cpf,
                Data_Nascimento = "",
            };

            _colaboradoresServiceSql.AdicionarColaborador(dadosForm);



            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();

            form2.PreencherDataGridView();

            this.Parent.Controls.Remove(this);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public string FormatarCPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());
         
            if (cpf.Length != 11)
            {
                
                return cpf;
            }

            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
        }
    }
}

