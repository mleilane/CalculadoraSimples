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
            TxtResultado = new TextBox();
            BtnApagarTudo = new Button();
            BtnExcluirUltimo = new Button();
            BtnDivisao = new Button();
            BtnMultiplicacao = new Button();
            BtnNove = new Button();
            BtnOito = new Button();
            BtnSete = new Button();
            BtnSubtracao = new Button();
            BtnSeis = new Button();
            BtnCinco = new Button();
            BtnQuatro = new Button();
            BtnAdicao = new Button();
            BtnTres = new Button();
            BtnDois = new Button();
            BtnUm = new Button();
            BtnIgual = new Button();
            BtnPonto = new Button();
            BtnZero = new Button();
            TxtOperacao = new TextBox();
            SuspendLayout();
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = SystemColors.InactiveCaptionText;
            TxtResultado.BorderStyle = BorderStyle.None;
            TxtResultado.Font = new Font("Segoe UI", 45F);
            TxtResultado.ForeColor = Color.FromArgb(255, 128, 0);
            TxtResultado.Location = new Point(12, 75);
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(371, 100);
            TxtResultado.TabIndex = 0;
            TxtResultado.TextAlign = HorizontalAlignment.Right;
            TxtResultado.KeyPress += TxtResultado_KeyPress;
            // 
            // BtnApagarTudo
            // 
            BtnApagarTudo.BackColor = SystemColors.WindowFrame;
            BtnApagarTudo.FlatStyle = FlatStyle.Popup;
            BtnApagarTudo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnApagarTudo.ForeColor = Color.FromArgb(255, 128, 0);
            BtnApagarTudo.Location = new Point(18, 239);
            BtnApagarTudo.Name = "BtnApagarTudo";
            BtnApagarTudo.Size = new Size(75, 60);
            BtnApagarTudo.TabIndex = 1;
            BtnApagarTudo.Text = "C";
            BtnApagarTudo.UseVisualStyleBackColor = false;
            BtnApagarTudo.Click += BtnApagarTudo_Click;
            // 
            // BtnExcluirUltimo
            // 
            BtnExcluirUltimo.BackColor = SystemColors.WindowFrame;
            BtnExcluirUltimo.FlatStyle = FlatStyle.Popup;
            BtnExcluirUltimo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnExcluirUltimo.ForeColor = Color.FromArgb(255, 128, 0);
            BtnExcluirUltimo.Location = new Point(108, 239);
            BtnExcluirUltimo.Name = "BtnExcluirUltimo";
            BtnExcluirUltimo.Size = new Size(75, 60);
            BtnExcluirUltimo.TabIndex = 2;
            BtnExcluirUltimo.Text = "CE";
            BtnExcluirUltimo.UseVisualStyleBackColor = false;
            BtnExcluirUltimo.Click += BtnExcluirUltimo_Click;
            // 
            // BtnDivisao
            // 
            BtnDivisao.BackColor = SystemColors.WindowFrame;
            BtnDivisao.FlatStyle = FlatStyle.Popup;
            BtnDivisao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnDivisao.ForeColor = Color.FromArgb(255, 128, 0);
            BtnDivisao.Location = new Point(197, 239);
            BtnDivisao.Name = "BtnDivisao";
            BtnDivisao.Size = new Size(75, 60);
            BtnDivisao.TabIndex = 4;
            BtnDivisao.Text = "/";
            BtnDivisao.UseVisualStyleBackColor = false;
            BtnDivisao.Click += BtnDivisao_Click;
            // 
            // BtnMultiplicacao
            // 
            BtnMultiplicacao.BackColor = SystemColors.WindowFrame;
            BtnMultiplicacao.FlatStyle = FlatStyle.Popup;
            BtnMultiplicacao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnMultiplicacao.ForeColor = Color.FromArgb(255, 128, 0);
            BtnMultiplicacao.Location = new Point(303, 239);
            BtnMultiplicacao.Name = "BtnMultiplicacao";
            BtnMultiplicacao.Size = new Size(75, 60);
            BtnMultiplicacao.TabIndex = 8;
            BtnMultiplicacao.Text = "x";
            BtnMultiplicacao.UseVisualStyleBackColor = false;
            BtnMultiplicacao.Click += BtnMultiplicacao_Click;
            // 
            // BtnNove
            // 
            BtnNove.BackColor = SystemColors.WindowFrame;
            BtnNove.FlatStyle = FlatStyle.Popup;
            BtnNove.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnNove.ForeColor = SystemColors.ButtonFace;
            BtnNove.Location = new Point(197, 318);
            BtnNove.Name = "BtnNove";
            BtnNove.Size = new Size(75, 60);
            BtnNove.TabIndex = 7;
            BtnNove.Text = "9";
            BtnNove.UseVisualStyleBackColor = false;
            BtnNove.Click += BtnNove_Click;
            // 
            // BtnOito
            // 
            BtnOito.BackColor = SystemColors.WindowFrame;
            BtnOito.FlatStyle = FlatStyle.Popup;
            BtnOito.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnOito.ForeColor = SystemColors.ButtonFace;
            BtnOito.Location = new Point(108, 318);
            BtnOito.Name = "BtnOito";
            BtnOito.Size = new Size(75, 60);
            BtnOito.TabIndex = 6;
            BtnOito.Text = "8";
            BtnOito.UseVisualStyleBackColor = false;
            BtnOito.Click += BtnOito_Click;
            // 
            // BtnSete
            // 
            BtnSete.BackColor = SystemColors.WindowFrame;
            BtnSete.FlatStyle = FlatStyle.Popup;
            BtnSete.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnSete.ForeColor = SystemColors.ButtonFace;
            BtnSete.Location = new Point(18, 318);
            BtnSete.Name = "BtnSete";
            BtnSete.Size = new Size(75, 60);
            BtnSete.TabIndex = 5;
            BtnSete.Text = "7";
            BtnSete.UseVisualStyleBackColor = false;
            BtnSete.Click += BtnSete_Click;
            // 
            // BtnSubtracao
            // 
            BtnSubtracao.BackColor = SystemColors.WindowFrame;
            BtnSubtracao.FlatStyle = FlatStyle.Popup;
            BtnSubtracao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnSubtracao.ForeColor = Color.FromArgb(255, 128, 0);
            BtnSubtracao.Location = new Point(303, 314);
            BtnSubtracao.Name = "BtnSubtracao";
            BtnSubtracao.Size = new Size(75, 60);
            BtnSubtracao.TabIndex = 12;
            BtnSubtracao.Text = "-";
            BtnSubtracao.UseVisualStyleBackColor = false;
            BtnSubtracao.Click += BtnSubtracao_Click;
            // 
            // BtnSeis
            // 
            BtnSeis.BackColor = SystemColors.WindowFrame;
            BtnSeis.FlatStyle = FlatStyle.Popup;
            BtnSeis.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnSeis.ForeColor = SystemColors.ButtonFace;
            BtnSeis.Location = new Point(197, 393);
            BtnSeis.Name = "BtnSeis";
            BtnSeis.Size = new Size(75, 60);
            BtnSeis.TabIndex = 11;
            BtnSeis.Text = "6";
            BtnSeis.UseVisualStyleBackColor = false;
            BtnSeis.Click += BtnSeis_Click;
            // 
            // BtnCinco
            // 
            BtnCinco.BackColor = SystemColors.WindowFrame;
            BtnCinco.FlatStyle = FlatStyle.Popup;
            BtnCinco.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnCinco.ForeColor = SystemColors.ButtonFace;
            BtnCinco.Location = new Point(108, 393);
            BtnCinco.Name = "BtnCinco";
            BtnCinco.Size = new Size(75, 60);
            BtnCinco.TabIndex = 10;
            BtnCinco.Text = "5";
            BtnCinco.UseVisualStyleBackColor = false;
            BtnCinco.Click += BtnCinco_Click;
            // 
            // BtnQuatro
            // 
            BtnQuatro.BackColor = SystemColors.WindowFrame;
            BtnQuatro.FlatStyle = FlatStyle.Popup;
            BtnQuatro.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnQuatro.ForeColor = SystemColors.ButtonFace;
            BtnQuatro.Location = new Point(18, 393);
            BtnQuatro.Name = "BtnQuatro";
            BtnQuatro.Size = new Size(75, 60);
            BtnQuatro.TabIndex = 9;
            BtnQuatro.Text = "4";
            BtnQuatro.UseVisualStyleBackColor = false;
            BtnQuatro.Click += BtnQuatro_Click;
            // 
            // BtnAdicao
            // 
            BtnAdicao.BackColor = SystemColors.WindowFrame;
            BtnAdicao.FlatStyle = FlatStyle.Popup;
            BtnAdicao.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnAdicao.ForeColor = Color.FromArgb(255, 128, 0);
            BtnAdicao.Location = new Point(303, 392);
            BtnAdicao.Name = "BtnAdicao";
            BtnAdicao.Size = new Size(75, 60);
            BtnAdicao.TabIndex = 16;
            BtnAdicao.Text = "+";
            BtnAdicao.UseVisualStyleBackColor = false;
            BtnAdicao.Click += BtnAdicao_Click;
            // 
            // BtnTres
            // 
            BtnTres.BackColor = SystemColors.WindowFrame;
            BtnTres.FlatStyle = FlatStyle.Popup;
            BtnTres.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnTres.ForeColor = SystemColors.ButtonFace;
            BtnTres.Location = new Point(197, 471);
            BtnTres.Name = "BtnTres";
            BtnTres.Size = new Size(75, 60);
            BtnTres.TabIndex = 15;
            BtnTres.Text = "3";
            BtnTres.UseVisualStyleBackColor = false;
            BtnTres.Click += BtnTres_Click;
            // 
            // BtnDois
            // 
            BtnDois.BackColor = SystemColors.WindowFrame;
            BtnDois.FlatStyle = FlatStyle.Popup;
            BtnDois.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnDois.ForeColor = SystemColors.ButtonFace;
            BtnDois.Location = new Point(108, 471);
            BtnDois.Name = "BtnDois";
            BtnDois.Size = new Size(75, 60);
            BtnDois.TabIndex = 14;
            BtnDois.Text = "2";
            BtnDois.UseVisualStyleBackColor = false;
            BtnDois.Click += BtnDois_Click;
            // 
            // BtnUm
            // 
            BtnUm.BackColor = SystemColors.WindowFrame;
            BtnUm.FlatStyle = FlatStyle.Popup;
            BtnUm.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnUm.ForeColor = SystemColors.ButtonFace;
            BtnUm.Location = new Point(18, 471);
            BtnUm.Name = "BtnUm";
            BtnUm.Size = new Size(75, 60);
            BtnUm.TabIndex = 13;
            BtnUm.Text = "1";
            BtnUm.UseVisualStyleBackColor = false;
            BtnUm.Click += BtnUm_Click;
            // 
            // BtnIgual
            // 
            BtnIgual.BackColor = Color.FromArgb(255, 128, 0);
            BtnIgual.FlatStyle = FlatStyle.Popup;
            BtnIgual.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnIgual.ForeColor = SystemColors.ButtonFace;
            BtnIgual.Location = new Point(303, 471);
            BtnIgual.Name = "BtnIgual";
            BtnIgual.Size = new Size(75, 137);
            BtnIgual.TabIndex = 20;
            BtnIgual.Text = "=";
            BtnIgual.UseVisualStyleBackColor = false;
            BtnIgual.Click += BtnIgual_Click;
            // 
            // BtnPonto
            // 
            BtnPonto.BackColor = SystemColors.WindowFrame;
            BtnPonto.FlatStyle = FlatStyle.Popup;
            BtnPonto.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnPonto.ForeColor = SystemColors.ButtonFace;
            BtnPonto.Location = new Point(197, 548);
            BtnPonto.Name = "BtnPonto";
            BtnPonto.Size = new Size(75, 60);
            BtnPonto.TabIndex = 19;
            BtnPonto.Text = ",";
            BtnPonto.UseVisualStyleBackColor = false;
            BtnPonto.Click += BtnPonto_Click;
            // 
            // BtnZero
            // 
            BtnZero.BackColor = SystemColors.WindowFrame;
            BtnZero.FlatStyle = FlatStyle.Popup;
            BtnZero.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BtnZero.ForeColor = SystemColors.ButtonFace;
            BtnZero.Location = new Point(18, 548);
            BtnZero.Name = "BtnZero";
            BtnZero.Size = new Size(165, 60);
            BtnZero.TabIndex = 17;
            BtnZero.Text = "0";
            BtnZero.UseVisualStyleBackColor = false;
            BtnZero.Click += BtnZero_Click;
            // 
            // TxtOperacao
            // 
            TxtOperacao.BackColor = SystemColors.InactiveCaptionText;
            TxtOperacao.BorderStyle = BorderStyle.None;
            TxtOperacao.Font = new Font("Segoe UI", 15F);
            TxtOperacao.ForeColor = Color.FromArgb(255, 128, 0);
            TxtOperacao.Location = new Point(11, 35);
            TxtOperacao.Name = "TxtOperacao";
            TxtOperacao.Size = new Size(371, 34);
            TxtOperacao.TabIndex = 21;
            TxtOperacao.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(395, 652);
            Controls.Add(TxtOperacao);
            Controls.Add(BtnIgual);
            Controls.Add(BtnPonto);
            Controls.Add(BtnZero);
            Controls.Add(BtnAdicao);
            Controls.Add(BtnTres);
            Controls.Add(BtnDois);
            Controls.Add(BtnUm);
            Controls.Add(BtnSubtracao);
            Controls.Add(BtnSeis);
            Controls.Add(BtnCinco);
            Controls.Add(BtnQuatro);
            Controls.Add(BtnMultiplicacao);
            Controls.Add(BtnNove);
            Controls.Add(BtnOito);
            Controls.Add(BtnSete);
            Controls.Add(BtnDivisao);
            Controls.Add(BtnExcluirUltimo);
            Controls.Add(BtnApagarTudo);
            Controls.Add(TxtResultado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtResultado;
        private Button BtnApagarTudo;
        private Button BtnExcluirUltimo;
        private Button BtnDivisao;
        private Button BtnMultiplicacao;
        private Button BtnNove;
        private Button BtnOito;
        private Button BtnSete;
        private Button BtnSubtracao;
        private Button BtnSeis;
        private Button BtnCinco;
        private Button BtnQuatro;
        private Button BtnAdicao;
        private Button BtnTres;
        private Button BtnDois;
        private Button BtnUm;
        private Button BtnIgual;
        private Button BtnPonto;
        private Button BtnZero;
        private TextBox TxtOperacao;
    }
}
