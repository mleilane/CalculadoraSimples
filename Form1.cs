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
        decimal porcentagemValor; // Armazena o valor da porcentagem
        bool resultado = false;

        public Form1()
        {
            InitializeComponent();

        }


        //evento de clique nos botões numericos  (0 a 9) 

        private void BtnZero_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0"; // o campo resultado vai receber ele mesmo mais o nº 0 
            TxtOperacao.Text += "0"; // o campo do resultado recebe ele mesmo mais o nª 0
        }
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

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += ",";
            TxtOperacao.Text += ",";
        }


        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            // calculo é o 1º valor que digitamos convertido em decimal
            calculo = Convert.ToDecimal(TxtResultado.Text);

            TxtOperacao.Text += "+"; // so clicar no + vamos visualizar ele no campo txtoperacao
            TxtResultado.Text = ""; //o txtResultado sera limpo para receber o novo valor

            //definindo a operacao que vamos usar - informa que apenas adicao sera utilizada
            adicao = true;
            multiplicacao = false;
            subtracao = false;
            divisao = false;
            porcentagem = false;
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            // calculo é o 1º valor que digitamos convertido em decimal
            calculo = Convert.ToDecimal(TxtResultado.Text);

            TxtOperacao.Text += "-";
            TxtResultado.Text = "";

            //definindo a operacao que vamos usar
            subtracao = true;
            adicao = false;
            multiplicacao = false;
            divisao = false;
            porcentagem = false;
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(TxtResultado.Text);

            TxtOperacao.Text += "x";
            TxtResultado.Text = "";

            //definindo a operacao que vamos usar
            multiplicacao = true;
            subtracao = false;
            adicao = false;
            divisao = false;
            porcentagem = false;

        }
        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(TxtResultado.Text);

            TxtOperacao.Text += "/";
            TxtResultado.Text = "";

            //definindo a operacao que vamos usar
            divisao = true;
            multiplicacao = false;
            subtracao = false;
            adicao = false;
            porcentagem = false;
        }

       
        // mostrar resultado ao clicar no botao de igualdade
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            resultado = true; // ao clicar no botao de = vai aparecer o resultado do calculo
            TxtOperacao.Text += "="; // o campo de operacao vai mostrar o resultado dele mesmo mais o simbolo de =

            if (adicao == true) //CALCULO PARA ADIÇÃO
            {

                // converte o valor de txtResultado em decimal e soma com o valor que foi digitado 1º e salvamos na variavel calculo
                TxtResultado.Text = Convert.ToString(Convert.ToDecimal(TxtResultado.Text) + calculo); // no fim o valo e convertido em string
                TxtOperacao.Text += TxtResultado.Text; // o campo operacao vai mostrar o valor que esta nele mais o resultado calculado

            }
            else if (subtracao == true) // CALCULO PARA SUBTRAÇÃO
            {
                TxtResultado.Text = Convert.ToString(calculo - Convert.ToDecimal(TxtResultado.Text)); // 1º valor digitado - o 2º
                TxtOperacao.Text += TxtResultado.Text;

            }
            else if (multiplicacao == true) // CALCULO PARA MULTIPLICAÇÃO
            {
                TxtResultado.Text = Convert.ToString(calculo * Convert.ToDecimal(TxtResultado.Text)); // 1º valor digitado x o 2º
                TxtOperacao.Text += TxtResultado.Text;

            }
            else if (divisao == true) // CALCULO PARA DIVISÃO -  TRATAMENTO DE ERRO CASO SEJA / POR ZERO
            {
                if (Convert.ToDecimal(TxtResultado.Text) != 0)
                {
                    TxtResultado.Text = Convert.ToString(calculo / Convert.ToDecimal(TxtResultado.Text)); // 1º valor digitado dividido pelo 2º
                    TxtOperacao.Text += TxtResultado.Text;
                }
                else
                {
                    TxtOperacao.Text = "Erro: Divisão por zero"; //msg de erro 
                    TxtResultado.Text = "";
                }
            }
          

            // Redefine todas as operações para evitar conflitos
            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
            porcentagem = false;
        }

        //controlando os valores que o usuario pode digitar pelo teclado
        private void TxtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir numero, tecla backspace, operadores + - * / e um unico ponto decimal

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.'
                && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/')
            {
                e.Handled = true; // Bloqueia a tecla se não for número, backspace ou ponto
            }

            //permitir apenas um ponto decimal

            if (e.KeyChar == '.' && (sender as TextBox)?.Text.Contains('.') == true) //valida se a tecla pressionado é um ponto ou se já existe um ponto no campo 
            {
                e.Handled = true; //bloqueia caso já exista um ponto no campo
            }
        }

        private void BtnApagarTudo_Click(object sender, EventArgs e)
        {
            //atribuindo ao botao C a funcionalidade de limpar todas as inf dos campos resultado e operacao
            TxtResultado.Text = "";
            TxtOperacao.Text = "";
        }

        private void BtnExcluirUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                // Armazena o texto atual do campo de resultado em uma variável.
                string Apagar = TxtResultado.Text;

                // Remove o último caractere da string armazenada em 'Apagar'.
                // Apagar.Length - 1 calcula a posição do último caractere,
                // e o método Remove remove esse caractere da string.
                Apagar = Apagar.Remove(Apagar.Length - 1); // verifica todos os caracteres e apaga apenas um

                // Atualiza o campo de resultado com a nova string sem o último caractere.
                TxtResultado.Text = Apagar;

                // Atualiza o campo de operação com o mesmo valor atualizado.
                TxtOperacao.Text = Apagar;
            }
            catch (Exception)
            {

            }

        }
    }
}
