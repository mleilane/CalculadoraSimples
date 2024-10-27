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
            TxtResultado.Text += "1"; // o campo resultado vai receber ele mesmo mais o nº 1 
            TxtOperacao.Text += "1"; // o campo do resultado recebe ele mesmo mais o nª 1
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2"; // o campo resultado vai receber ele mesmo mais o nº 2
            TxtOperacao.Text += "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
            TxtOperacao.Text += "3";
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
            TxtOperacao.Text += "4";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
            TxtOperacao.Text += "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
            TxtOperacao.Text += "6";
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
            TxtOperacao.Text += "7";
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
            TxtOperacao.Text += "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
            TxtOperacao.Text += "9";
        }

        // criando o ca
        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            // calculo recebe o valor de txtResultado convertendo em decimal
            calculo = Convert.ToDecimal(TxtResultado.Text);

            TxtOperacao.Text += "+"; // so clicar no + vamos visualizar ele no campo txtoperacao
            TxtResultado.Text = ""; //o txxResultado sera limpo para receber o novo valor

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
            TxtOperacao.Text += "="; // o campo de operacao vai mostrar o resultado dele mesmo mais o simbolo de =

            if (adicao == true)
            {

                // converte o valor de txtResultado em decimal e soma com o valor que foi digitado 1º e salvamos na variavel calculo
                TxtResultado.Text = Convert.ToString(Convert.ToDecimal(TxtResultado.Text) + calculo); // no fim o valo e convertido em string
                TxtOperacao.Text += TxtResultado.Text; // o campo operacao vai mostrar o valor que esta nele mais o resultado calculado
            }



        }

        private void BtnApagarTudo_Click(object sender, EventArgs e)
        {
            //atribuindo ao botao C a funcionalidade de limpar todas as inf dos campos resultado e operacao
            TxtResultado.Text = "";
            TxtOperacao.Text = "";
        }
    }
}
