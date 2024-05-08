using PimProject.Application.Domain.Response;
using PimProject.Application.Infra.Data.Repository;
using PimProject.Application.Services;

namespace PIM_III
{
    public partial class Form1 : Form
    {
      
        private readonly ColaboradoresService _cobService;
        private readonly LoginService _loginService;

        public Form1()
        {
            InitializeComponent();
            _cobService = new ColaboradoresService();
            _loginService = new LoginService();
          
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public async void ExecutarLogin()
        {
            string login = textBox5.Text;
            string senha = textBox1.Text;

            var dadosForm = new LoginResponse
            {
                Login = login,
                Senha = senha
            };

            await _loginService.ExecutarLogin(dadosForm);
        }

        private async void pictureBox4_Click(object sender, EventArgs e)
        {

            string login = textBox5.Text;
            string senha = textBox1.Text;

            var dadosForm = new LoginResponse
            {
                Login = login,
                Senha = senha
            };

            await _loginService.ExecutarLogin(dadosForm);
        }
    }
}