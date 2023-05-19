
namespace proj_2_bi
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_linha = new System.Windows.Forms.Button();
            this.btn_circulo = new System.Windows.Forms.Button();
            this.btn_losangulo = new System.Windows.Forms.Button();
            this.btn_triangulo = new System.Windows.Forms.Button();
            this.btn_pentagono = new System.Windows.Forms.Button();
            this.btn_quadrado = new System.Windows.Forms.Button();
            this.Preto = new System.Windows.Forms.Button();
            this.Branco = new System.Windows.Forms.Button();
            this.CInzaClaro = new System.Windows.Forms.Button();
            this.Cinza = new System.Windows.Forms.Button();
            this.Rosinha = new System.Windows.Forms.Button();
            this.Vermelho = new System.Windows.Forms.Button();
            this.RosaVermelho = new System.Windows.Forms.Button();
            this.Maroon = new System.Windows.Forms.Button();
            this.AmareloClaro = new System.Windows.Forms.Button();
            this.Amarelo = new System.Windows.Forms.Button();
            this.VerdeMato = new System.Windows.Forms.Button();
            this.Laranja = new System.Windows.Forms.Button();
            this.Ciano = new System.Windows.Forms.Button();
            this.AzulBebe = new System.Windows.Forms.Button();
            this.VerdeClaro = new System.Windows.Forms.Button();
            this.Verde = new System.Windows.Forms.Button();
            this.RoxoClaro = new System.Windows.Forms.Button();
            this.Roxo = new System.Windows.Forms.Button();
            this.AzulClaro = new System.Windows.Forms.Button();
            this.Azul = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_linha
            // 
            this.btn_linha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_linha.Location = new System.Drawing.Point(350, 12);
            this.btn_linha.Name = "btn_linha";
            this.btn_linha.Size = new System.Drawing.Size(58, 37);
            this.btn_linha.TabIndex = 0;
            this.btn_linha.Text = "/";
            this.btn_linha.UseVisualStyleBackColor = true;
            this.btn_linha.Click += new System.EventHandler(this.btn_linha_Click);
            // 
            // btn_circulo
            // 
            this.btn_circulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_circulo.Location = new System.Drawing.Point(414, 12);
            this.btn_circulo.Name = "btn_circulo";
            this.btn_circulo.Size = new System.Drawing.Size(58, 37);
            this.btn_circulo.TabIndex = 1;
            this.btn_circulo.Text = "O";
            this.btn_circulo.UseVisualStyleBackColor = true;
            this.btn_circulo.Click += new System.EventHandler(this.btn_circulo_Click);
            // 
            // btn_losangulo
            // 
            this.btn_losangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btn_losangulo.Location = new System.Drawing.Point(542, 12);
            this.btn_losangulo.Name = "btn_losangulo";
            this.btn_losangulo.Size = new System.Drawing.Size(58, 37);
            this.btn_losangulo.TabIndex = 3;
            this.btn_losangulo.Text = "◇";
            this.btn_losangulo.UseVisualStyleBackColor = true;
            this.btn_losangulo.Click += new System.EventHandler(this.btn_losangulo_Click);
            // 
            // btn_triangulo
            // 
            this.btn_triangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btn_triangulo.Location = new System.Drawing.Point(606, 11);
            this.btn_triangulo.Name = "btn_triangulo";
            this.btn_triangulo.Size = new System.Drawing.Size(58, 37);
            this.btn_triangulo.TabIndex = 4;
            this.btn_triangulo.Text = "△";
            this.btn_triangulo.UseVisualStyleBackColor = true;
            this.btn_triangulo.Click += new System.EventHandler(this.btn_triangulo_Click);
            // 
            // btn_pentagono
            // 
            this.btn_pentagono.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btn_pentagono.Location = new System.Drawing.Point(670, 11);
            this.btn_pentagono.Name = "btn_pentagono";
            this.btn_pentagono.Size = new System.Drawing.Size(58, 37);
            this.btn_pentagono.TabIndex = 5;
            this.btn_pentagono.Text = "⭔";
            this.btn_pentagono.UseVisualStyleBackColor = true;
            this.btn_pentagono.Click += new System.EventHandler(this.btn_pentagono_Click);
            // 
            // btn_quadrado
            // 
            this.btn_quadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btn_quadrado.Location = new System.Drawing.Point(478, 11);
            this.btn_quadrado.Name = "btn_quadrado";
            this.btn_quadrado.Size = new System.Drawing.Size(58, 37);
            this.btn_quadrado.TabIndex = 2;
            this.btn_quadrado.Text = "⬜";
            this.btn_quadrado.UseVisualStyleBackColor = true;
            this.btn_quadrado.Click += new System.EventHandler(this.btn_quadrado_Click);
            // 
            // Preto
            // 
            this.Preto.BackColor = System.Drawing.Color.Black;
            this.Preto.Location = new System.Drawing.Point(1135, 13);
            this.Preto.Name = "Preto";
            this.Preto.Size = new System.Drawing.Size(40, 40);
            this.Preto.TabIndex = 9;
            this.Preto.UseVisualStyleBackColor = false;
            this.Preto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Branco
            // 
            this.Branco.BackColor = System.Drawing.Color.White;
            this.Branco.Location = new System.Drawing.Point(1135, 57);
            this.Branco.Name = "Branco";
            this.Branco.Size = new System.Drawing.Size(40, 40);
            this.Branco.TabIndex = 10;
            this.Branco.UseVisualStyleBackColor = false;
            this.Branco.Click += new System.EventHandler(this.Branco_Click);
            // 
            // CInzaClaro
            // 
            this.CInzaClaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CInzaClaro.Location = new System.Drawing.Point(1181, 57);
            this.CInzaClaro.Name = "CInzaClaro";
            this.CInzaClaro.Size = new System.Drawing.Size(40, 40);
            this.CInzaClaro.TabIndex = 12;
            this.CInzaClaro.UseVisualStyleBackColor = false;
            this.CInzaClaro.Click += new System.EventHandler(this.CInzaClaro_Click);
            // 
            // Cinza
            // 
            this.Cinza.BackColor = System.Drawing.Color.Gray;
            this.Cinza.Location = new System.Drawing.Point(1181, 13);
            this.Cinza.Name = "Cinza";
            this.Cinza.Size = new System.Drawing.Size(40, 40);
            this.Cinza.TabIndex = 11;
            this.Cinza.UseVisualStyleBackColor = false;
            this.Cinza.Click += new System.EventHandler(this.Cinza_Click);
            // 
            // Rosinha
            // 
            this.Rosinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Rosinha.Location = new System.Drawing.Point(1273, 57);
            this.Rosinha.Name = "Rosinha";
            this.Rosinha.Size = new System.Drawing.Size(40, 40);
            this.Rosinha.TabIndex = 16;
            this.Rosinha.UseVisualStyleBackColor = false;
            this.Rosinha.Click += new System.EventHandler(this.Rosinha_Click);
            // 
            // Vermelho
            // 
            this.Vermelho.BackColor = System.Drawing.Color.Red;
            this.Vermelho.Location = new System.Drawing.Point(1273, 13);
            this.Vermelho.Name = "Vermelho";
            this.Vermelho.Size = new System.Drawing.Size(40, 40);
            this.Vermelho.TabIndex = 15;
            this.Vermelho.UseVisualStyleBackColor = false;
            this.Vermelho.Click += new System.EventHandler(this.Vermelho_Click);
            // 
            // RosaVermelho
            // 
            this.RosaVermelho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RosaVermelho.Location = new System.Drawing.Point(1227, 57);
            this.RosaVermelho.Name = "RosaVermelho";
            this.RosaVermelho.Size = new System.Drawing.Size(40, 40);
            this.RosaVermelho.TabIndex = 14;
            this.RosaVermelho.UseVisualStyleBackColor = false;
            this.RosaVermelho.Click += new System.EventHandler(this.RosaVermelho_Click);
            // 
            // Maroon
            // 
            this.Maroon.BackColor = System.Drawing.Color.Maroon;
            this.Maroon.Location = new System.Drawing.Point(1227, 13);
            this.Maroon.Name = "Maroon";
            this.Maroon.Size = new System.Drawing.Size(40, 40);
            this.Maroon.TabIndex = 13;
            this.Maroon.UseVisualStyleBackColor = false;
            this.Maroon.Click += new System.EventHandler(this.Maroon_Click);
            // 
            // AmareloClaro
            // 
            this.AmareloClaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AmareloClaro.Location = new System.Drawing.Point(1365, 57);
            this.AmareloClaro.Name = "AmareloClaro";
            this.AmareloClaro.Size = new System.Drawing.Size(40, 40);
            this.AmareloClaro.TabIndex = 20;
            this.AmareloClaro.UseVisualStyleBackColor = false;
            this.AmareloClaro.Click += new System.EventHandler(this.AmareloClaro_Click);
            // 
            // Amarelo
            // 
            this.Amarelo.BackColor = System.Drawing.Color.Yellow;
            this.Amarelo.Location = new System.Drawing.Point(1365, 13);
            this.Amarelo.Name = "Amarelo";
            this.Amarelo.Size = new System.Drawing.Size(40, 40);
            this.Amarelo.TabIndex = 19;
            this.Amarelo.UseVisualStyleBackColor = false;
            this.Amarelo.Click += new System.EventHandler(this.Amarelo_Click);
            // 
            // VerdeMato
            // 
            this.VerdeMato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.VerdeMato.Location = new System.Drawing.Point(1319, 57);
            this.VerdeMato.Name = "VerdeMato";
            this.VerdeMato.Size = new System.Drawing.Size(40, 40);
            this.VerdeMato.TabIndex = 18;
            this.VerdeMato.UseVisualStyleBackColor = false;
            this.VerdeMato.Click += new System.EventHandler(this.VerdeMato_Click);
            // 
            // Laranja
            // 
            this.Laranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Laranja.Location = new System.Drawing.Point(1319, 13);
            this.Laranja.Name = "Laranja";
            this.Laranja.Size = new System.Drawing.Size(40, 40);
            this.Laranja.TabIndex = 17;
            this.Laranja.UseVisualStyleBackColor = false;
            this.Laranja.Click += new System.EventHandler(this.Laranja_Click);
            // 
            // Ciano
            // 
            this.Ciano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ciano.Location = new System.Drawing.Point(1457, 57);
            this.Ciano.Name = "Ciano";
            this.Ciano.Size = new System.Drawing.Size(40, 40);
            this.Ciano.TabIndex = 24;
            this.Ciano.UseVisualStyleBackColor = false;
            this.Ciano.Click += new System.EventHandler(this.Ciano_Click);
            // 
            // AzulBebe
            // 
            this.AzulBebe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AzulBebe.Location = new System.Drawing.Point(1457, 13);
            this.AzulBebe.Name = "AzulBebe";
            this.AzulBebe.Size = new System.Drawing.Size(40, 40);
            this.AzulBebe.TabIndex = 23;
            this.AzulBebe.UseVisualStyleBackColor = false;
            this.AzulBebe.Click += new System.EventHandler(this.AzulBebe_Click);
            // 
            // VerdeClaro
            // 
            this.VerdeClaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.VerdeClaro.Location = new System.Drawing.Point(1411, 57);
            this.VerdeClaro.Name = "VerdeClaro";
            this.VerdeClaro.Size = new System.Drawing.Size(40, 40);
            this.VerdeClaro.TabIndex = 22;
            this.VerdeClaro.UseVisualStyleBackColor = false;
            this.VerdeClaro.Click += new System.EventHandler(this.VerdeClaro_Click);
            // 
            // Verde
            // 
            this.Verde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Verde.Location = new System.Drawing.Point(1411, 13);
            this.Verde.Name = "Verde";
            this.Verde.Size = new System.Drawing.Size(40, 40);
            this.Verde.TabIndex = 21;
            this.Verde.UseVisualStyleBackColor = false;
            this.Verde.Click += new System.EventHandler(this.Verde_Click);
            // 
            // RoxoClaro
            // 
            this.RoxoClaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RoxoClaro.Location = new System.Drawing.Point(1549, 57);
            this.RoxoClaro.Name = "RoxoClaro";
            this.RoxoClaro.Size = new System.Drawing.Size(40, 40);
            this.RoxoClaro.TabIndex = 28;
            this.RoxoClaro.UseVisualStyleBackColor = false;
            this.RoxoClaro.Click += new System.EventHandler(this.RoxoClaro_Click);
            // 
            // Roxo
            // 
            this.Roxo.BackColor = System.Drawing.Color.Purple;
            this.Roxo.Location = new System.Drawing.Point(1549, 13);
            this.Roxo.Name = "Roxo";
            this.Roxo.Size = new System.Drawing.Size(40, 40);
            this.Roxo.TabIndex = 27;
            this.Roxo.UseVisualStyleBackColor = false;
            this.Roxo.Click += new System.EventHandler(this.Roxo_Click);
            // 
            // AzulClaro
            // 
            this.AzulClaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AzulClaro.Location = new System.Drawing.Point(1503, 57);
            this.AzulClaro.Name = "AzulClaro";
            this.AzulClaro.Size = new System.Drawing.Size(40, 40);
            this.AzulClaro.TabIndex = 26;
            this.AzulClaro.UseVisualStyleBackColor = false;
            this.AzulClaro.Click += new System.EventHandler(this.AzulClaro_Click);
            // 
            // Azul
            // 
            this.Azul.BackColor = System.Drawing.Color.Blue;
            this.Azul.Location = new System.Drawing.Point(1503, 13);
            this.Azul.Name = "Azul";
            this.Azul.Size = new System.Drawing.Size(40, 40);
            this.Azul.TabIndex = 25;
            this.Azul.UseVisualStyleBackColor = false;
            this.Azul.Click += new System.EventHandler(this.Azul_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(972, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 32);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "Espessura";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(13, 12);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 30;
            this.btn_salvar.Text = "salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_carregar
            // 
            this.btn_carregar.Location = new System.Drawing.Point(12, 41);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(75, 23);
            this.btn_carregar.TabIndex = 31;
            this.btn_carregar.Text = "carregar";
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "____________",
            "_._._._._._._._",
            "__.__.__.__.__",
            "_ _ _ _ _ _ _ _ ",
            "_   _   _   _   _"});
            this.comboBox2.Location = new System.Drawing.Point(972, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(118, 32);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.Text = "estilo";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1061);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RoxoClaro);
            this.Controls.Add(this.Roxo);
            this.Controls.Add(this.AzulClaro);
            this.Controls.Add(this.Azul);
            this.Controls.Add(this.Ciano);
            this.Controls.Add(this.AzulBebe);
            this.Controls.Add(this.VerdeClaro);
            this.Controls.Add(this.Verde);
            this.Controls.Add(this.AmareloClaro);
            this.Controls.Add(this.Amarelo);
            this.Controls.Add(this.VerdeMato);
            this.Controls.Add(this.Laranja);
            this.Controls.Add(this.Rosinha);
            this.Controls.Add(this.Vermelho);
            this.Controls.Add(this.RosaVermelho);
            this.Controls.Add(this.Maroon);
            this.Controls.Add(this.CInzaClaro);
            this.Controls.Add(this.Cinza);
            this.Controls.Add(this.Branco);
            this.Controls.Add(this.Preto);
            this.Controls.Add(this.btn_pentagono);
            this.Controls.Add(this.btn_triangulo);
            this.Controls.Add(this.btn_losangulo);
            this.Controls.Add(this.btn_quadrado);
            this.Controls.Add(this.btn_circulo);
            this.Controls.Add(this.btn_linha);
            this.Name = "Form1";
            this.Text = "paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_linha;
        private System.Windows.Forms.Button btn_circulo;
        private System.Windows.Forms.Button btn_losangulo;
        private System.Windows.Forms.Button btn_triangulo;
        private System.Windows.Forms.Button btn_pentagono;
        private System.Windows.Forms.Button btn_quadrado;
        private System.Windows.Forms.Button Preto;
        private System.Windows.Forms.Button Branco;
        private System.Windows.Forms.Button CInzaClaro;
        private System.Windows.Forms.Button Cinza;
        private System.Windows.Forms.Button Rosinha;
        private System.Windows.Forms.Button Vermelho;
        private System.Windows.Forms.Button RosaVermelho;
        private System.Windows.Forms.Button Maroon;
        private System.Windows.Forms.Button AmareloClaro;
        private System.Windows.Forms.Button Amarelo;
        private System.Windows.Forms.Button VerdeMato;
        private System.Windows.Forms.Button Laranja;
        private System.Windows.Forms.Button Ciano;
        private System.Windows.Forms.Button AzulBebe;
        private System.Windows.Forms.Button VerdeClaro;
        private System.Windows.Forms.Button Verde;
        private System.Windows.Forms.Button RoxoClaro;
        private System.Windows.Forms.Button Roxo;
        private System.Windows.Forms.Button AzulClaro;
        private System.Windows.Forms.Button Azul;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

