namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtResultado = new TextBox();
            btnApagarTudo = new Button();
            btnExcluirUltimo = new Button();
            btnPorcentagem = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnNove = new Button();
            btnOito = new Button();
            btnSete = new Button();
            btnSubtracao = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnAdicao = new Button();
            btnTres = new Button();
            btnDois = new Button();
            btnUm = new Button();
            btnIgual = new Button();
            btnPonto = new Button();
            btnZero = new Button();
            txtOperacao = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.InactiveCaptionText;
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Font = new Font("Segoe UI", 45F);
            txtResultado.ForeColor = Color.FromArgb(255, 128, 0);
            txtResultado.Location = new Point(12, 75);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(371, 100);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnApagarTudo
            // 
            btnApagarTudo.BackColor = SystemColors.WindowFrame;
            btnApagarTudo.FlatStyle = FlatStyle.Popup;
            btnApagarTudo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnApagarTudo.ForeColor = Color.FromArgb(255, 128, 0);
            btnApagarTudo.Location = new Point(18, 239);
            btnApagarTudo.Name = "btnApagarTudo";
            btnApagarTudo.Size = new Size(75, 60);
            btnApagarTudo.TabIndex = 1;
            btnApagarTudo.Text = "C";
            btnApagarTudo.UseVisualStyleBackColor = false;
            // 
            // btnExcluirUltimo
            // 
            btnExcluirUltimo.BackColor = SystemColors.WindowFrame;
            btnExcluirUltimo.FlatStyle = FlatStyle.Popup;
            btnExcluirUltimo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnExcluirUltimo.ForeColor = Color.FromArgb(255, 128, 0);
            btnExcluirUltimo.Location = new Point(108, 239);
            btnExcluirUltimo.Name = "btnExcluirUltimo";
            btnExcluirUltimo.Size = new Size(75, 60);
            btnExcluirUltimo.TabIndex = 2;
            btnExcluirUltimo.Text = "CE";
            btnExcluirUltimo.UseVisualStyleBackColor = false;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = SystemColors.WindowFrame;
            btnPorcentagem.FlatStyle = FlatStyle.Popup;
            btnPorcentagem.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnPorcentagem.ForeColor = Color.FromArgb(255, 128, 0);
            btnPorcentagem.Location = new Point(197, 239);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(75, 60);
            btnPorcentagem.TabIndex = 3;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = SystemColors.WindowFrame;
            btnDivisao.FlatStyle = FlatStyle.Popup;
            btnDivisao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnDivisao.ForeColor = Color.FromArgb(255, 128, 0);
            btnDivisao.Location = new Point(303, 239);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(75, 60);
            btnDivisao.TabIndex = 4;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = SystemColors.WindowFrame;
            btnMultiplicacao.FlatStyle = FlatStyle.Popup;
            btnMultiplicacao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnMultiplicacao.ForeColor = Color.FromArgb(255, 128, 0);
            btnMultiplicacao.Location = new Point(303, 318);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(75, 60);
            btnMultiplicacao.TabIndex = 8;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // btnNove
            // 
            btnNove.BackColor = SystemColors.WindowFrame;
            btnNove.FlatStyle = FlatStyle.Popup;
            btnNove.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnNove.ForeColor = SystemColors.ButtonFace;
            btnNove.Location = new Point(197, 318);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(75, 60);
            btnNove.TabIndex = 7;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += BtnNove_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = SystemColors.WindowFrame;
            btnOito.FlatStyle = FlatStyle.Popup;
            btnOito.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnOito.ForeColor = SystemColors.ButtonFace;
            btnOito.Location = new Point(108, 318);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(75, 60);
            btnOito.TabIndex = 6;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += BtnOito_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = SystemColors.WindowFrame;
            btnSete.FlatStyle = FlatStyle.Popup;
            btnSete.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnSete.ForeColor = SystemColors.ButtonFace;
            btnSete.Location = new Point(18, 318);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(75, 60);
            btnSete.TabIndex = 5;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += BtnSete_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = SystemColors.WindowFrame;
            btnSubtracao.FlatStyle = FlatStyle.Popup;
            btnSubtracao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnSubtracao.ForeColor = Color.FromArgb(255, 128, 0);
            btnSubtracao.Location = new Point(303, 393);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(75, 60);
            btnSubtracao.TabIndex = 12;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = SystemColors.WindowFrame;
            btnSeis.FlatStyle = FlatStyle.Popup;
            btnSeis.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnSeis.ForeColor = SystemColors.ButtonFace;
            btnSeis.Location = new Point(197, 393);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(75, 60);
            btnSeis.TabIndex = 11;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += BtnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = SystemColors.WindowFrame;
            btnCinco.FlatStyle = FlatStyle.Popup;
            btnCinco.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnCinco.ForeColor = SystemColors.ButtonFace;
            btnCinco.Location = new Point(108, 393);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(75, 60);
            btnCinco.TabIndex = 10;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += BtnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = SystemColors.WindowFrame;
            btnQuatro.FlatStyle = FlatStyle.Popup;
            btnQuatro.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnQuatro.ForeColor = SystemColors.ButtonFace;
            btnQuatro.Location = new Point(18, 393);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(75, 60);
            btnQuatro.TabIndex = 9;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += BtnQuatro_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = SystemColors.WindowFrame;
            btnAdicao.FlatStyle = FlatStyle.Popup;
            btnAdicao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnAdicao.ForeColor = Color.FromArgb(255, 128, 0);
            btnAdicao.Location = new Point(303, 471);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(75, 60);
            btnAdicao.TabIndex = 16;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += BtnAdicao_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.WindowFrame;
            btnTres.FlatStyle = FlatStyle.Popup;
            btnTres.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnTres.ForeColor = SystemColors.ButtonFace;
            btnTres.Location = new Point(197, 471);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(75, 60);
            btnTres.TabIndex = 15;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += BtnTres_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = SystemColors.WindowFrame;
            btnDois.FlatStyle = FlatStyle.Popup;
            btnDois.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnDois.ForeColor = SystemColors.ButtonFace;
            btnDois.Location = new Point(108, 471);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(75, 60);
            btnDois.TabIndex = 14;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += BtnDois_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = SystemColors.WindowFrame;
            btnUm.FlatStyle = FlatStyle.Popup;
            btnUm.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnUm.ForeColor = SystemColors.ButtonFace;
            btnUm.Location = new Point(18, 471);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(75, 60);
            btnUm.TabIndex = 13;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += BtnUm_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(255, 128, 0);
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnIgual.ForeColor = SystemColors.ButtonFace;
            btnIgual.Location = new Point(303, 548);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 60);
            btnIgual.TabIndex = 20;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += BtnIgual_Click;
            // 
            // btnPonto
            // 
            btnPonto.BackColor = SystemColors.WindowFrame;
            btnPonto.FlatStyle = FlatStyle.Popup;
            btnPonto.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnPonto.ForeColor = SystemColors.ButtonFace;
            btnPonto.Location = new Point(197, 548);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(75, 60);
            btnPonto.TabIndex = 19;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.WindowFrame;
            btnZero.FlatStyle = FlatStyle.Popup;
            btnZero.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnZero.ForeColor = SystemColors.ButtonFace;
            btnZero.Location = new Point(18, 548);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(165, 60);
            btnZero.TabIndex = 17;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            // 
            // txtOperacao
            // 
            txtOperacao.BackColor = SystemColors.InactiveCaptionText;
            txtOperacao.BorderStyle = BorderStyle.None;
            txtOperacao.Font = new Font("Segoe UI", 15F);
            txtOperacao.ForeColor = Color.FromArgb(255, 128, 0);
            txtOperacao.Location = new Point(11, 35);
            txtOperacao.Name = "txtOperacao";
            txtOperacao.Size = new Size(371, 34);
            txtOperacao.TabIndex = 21;
            txtOperacao.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(395, 652);
            Controls.Add(txtOperacao);
            Controls.Add(btnIgual);
            Controls.Add(btnPonto);
            Controls.Add(btnZero);
            Controls.Add(btnAdicao);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnDivisao);
            Controls.Add(btnPorcentagem);
            Controls.Add(btnExcluirUltimo);
            Controls.Add(btnApagarTudo);
            Controls.Add(txtResultado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnApagarTudo;
        private Button btnExcluirUltimo;
        private Button btnPorcentagem;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnSubtracao;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnAdicao;
        private Button btnTres;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgual;
        private Button btnPonto;
        private Button btnZero;
        private TextBox txtOperacao;
    }
}
