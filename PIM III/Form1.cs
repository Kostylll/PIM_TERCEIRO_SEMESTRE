using PimProject.Application.Domain.Response;
using PimProject.Application.Infra.Data.Repository;
using PimProject.Application.Services;

namespace PIM_III
{
    public partial class Form1 : Form
    {
        private readonly ColaboradoresService _colService;
        private readonly ColaboradoresServiceSql _sqlColService;

        public Form1()
        {
            InitializeComponent();
            _colService = new ColaboradoresService();
            _sqlColService = new ColaboradoresServiceSql();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string sobrenome = textBox2.Text;
            string email = textBox3.Text;
            string dataNascimento = textBox4.Text;
            string cpf = textBox5.Text;


            var dadosForm = new ColaboradoresResponse
            {
                Nome = nome,
                Sobrenome = sobrenome,
                Email = email,
                Data_Nascimento = dataNascimento,
                CPF = cpf
            };

            _sqlColService.AdicionarColaborador(dadosForm);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}