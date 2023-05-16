
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
            this.Raio = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.Largura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_linha
            // 
            this.btn_linha.Location = new System.Drawing.Point(52, 12);
            this.btn_linha.Name = "btn_linha";
            this.btn_linha.Size = new System.Drawing.Size(30, 23);
            this.btn_linha.TabIndex = 0;
            this.btn_linha.Text = "/";
            this.btn_linha.UseVisualStyleBackColor = true;
            this.btn_linha.Click += new System.EventHandler(this.btn_linha_Click);
            // 
            // btn_circulo
            // 
            this.btn_circulo.Location = new System.Drawing.Point(88, 13);
            this.btn_circulo.Name = "btn_circulo";
            this.btn_circulo.Size = new System.Drawing.Size(30, 23);
            this.btn_circulo.TabIndex = 1;
            this.btn_circulo.Text = "O";
            this.btn_circulo.UseVisualStyleBackColor = true;
            this.btn_circulo.Click += new System.EventHandler(this.btn_circulo_Click);
            // 
            // btn_losangulo
            // 
            this.btn_losangulo.Location = new System.Drawing.Point(160, 13);
            this.btn_losangulo.Name = "btn_losangulo";
            this.btn_losangulo.Size = new System.Drawing.Size(30, 23);
            this.btn_losangulo.TabIndex = 3;
            this.btn_losangulo.Text = "◇";
            this.btn_losangulo.UseVisualStyleBackColor = true;
            this.btn_losangulo.Click += new System.EventHandler(this.btn_losangulo_Click);
            // 
            // btn_triangulo
            // 
            this.btn_triangulo.Location = new System.Drawing.Point(196, 13);
            this.btn_triangulo.Name = "btn_triangulo";
            this.btn_triangulo.Size = new System.Drawing.Size(30, 23);
            this.btn_triangulo.TabIndex = 4;
            this.btn_triangulo.Text = "△";
            this.btn_triangulo.UseVisualStyleBackColor = true;
            this.btn_triangulo.Click += new System.EventHandler(this.btn_triangulo_Click);
            // 
            // btn_pentagono
            // 
            this.btn_pentagono.Location = new System.Drawing.Point(232, 13);
            this.btn_pentagono.Name = "btn_pentagono";
            this.btn_pentagono.Size = new System.Drawing.Size(30, 23);
            this.btn_pentagono.TabIndex = 5;
            this.btn_pentagono.Text = "⭔";
            this.btn_pentagono.UseVisualStyleBackColor = true;
            this.btn_pentagono.Click += new System.EventHandler(this.btn_pentagono_Click);
            // 
            // btn_quadrado
            // 
            this.btn_quadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_quadrado.Location = new System.Drawing.Point(124, 13);
            this.btn_quadrado.Name = "btn_quadrado";
            this.btn_quadrado.Size = new System.Drawing.Size(30, 23);
            this.btn_quadrado.TabIndex = 2;
            this.btn_quadrado.Text = "⬜";
            this.btn_quadrado.UseVisualStyleBackColor = true;
            this.btn_quadrado.Click += new System.EventHandler(this.btn_quadrado_Click);
            // 
            // Raio
            // 
            this.Raio.Location = new System.Drawing.Point(52, 60);
            this.Raio.Name = "Raio";
            this.Raio.Size = new System.Drawing.Size(66, 20);
            this.Raio.TabIndex = 6;
            this.Raio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(126, 60);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(64, 20);
            this.Altura.TabIndex = 7;
            // 
            // Largura
            // 
            this.Largura.Location = new System.Drawing.Point(196, 60);
            this.Largura.Name = "Largura";
            this.Largura.Size = new System.Drawing.Size(66, 20);
            this.Largura.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Largura);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Raio);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_linha;
        private System.Windows.Forms.Button btn_circulo;
        private System.Windows.Forms.Button btn_losangulo;
        private System.Windows.Forms.Button btn_triangulo;
        private System.Windows.Forms.Button btn_pentagono;
        private System.Windows.Forms.Button btn_quadrado;
        private System.Windows.Forms.TextBox Raio;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.TextBox Largura;
    }
}

