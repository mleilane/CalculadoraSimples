namespace CalculadoraSimples

//txtResultado = o resultado do calculo | txtOperacao = toda a operacao que foi realizada


{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool divisao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool porcentagem = false;
        bool resultado = false;

        public Form1()
        {
            InitializeComponent();
        }


        //evento de clique no botao 1
        private void BtnUm_Click(object sender, EventArgs e)
        {
            // vai mostra no campo resultado e operacao o numero que foi digitado 
            txtResultado.Text += "1"; // o campo resultado vai receber ele mesmo mais o nº 1 
            txtOperacao.Text += "1"; // o campo do resultado recebe ele mesmo mais o nª 1
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2"; // o campo resultado vai receber ele mesmo mais o nº 2
            txtOperacao.Text += "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtOperacao.Text += "3";
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtOperacao.Text += "4";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtOperacao.Text += "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtOperacao.Text += "6";
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtOperacao.Text += "7";
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtOperacao.Text += "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtOperacao.Text += "9";
        }

        // criando o ca
        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            // calculo recebe o valor de txtResultado convertendo em decimal
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "+"; // so clicar no + vamos visualizar ele no campo txtoperacao
            txtResultado.Text = ""; //o txxResultado sera limpo para receber o novo valor

            //definindo a operacao que vams usar - informa que apenas adicao sera utilizada
            adicao = true;
            multiplicacao = false;
            subtracao = false;
            divisao = false;
            porcentagem = false;

            

        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            resultado = true; // ao clicar no botao de = vai aparecer o resultado do calculo
            txtOperacao.Text += "="; // o campo de operacao vai mostrar o resultado dele mesmo mais o simbolo de =
        
        if(adicao == true)
            {

                // converte o valor de txtResultado em decimal e soma com o valor que foi digitado 1º e salvamos na variavel calculo
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) + calculo); // no fim o valo e convertido em string
                txtOperacao.Text += txtResultado.Text; // o campo operacao vai mostrar o valor que esta nele mais o resultado calculado
            }
        
        
        
        }
    }
}
