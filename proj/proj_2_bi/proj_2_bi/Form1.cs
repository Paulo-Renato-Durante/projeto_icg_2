using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_2_bi
{
    public partial class Form1 : Form
    {
        int click;
        int[] pontos = new int[10];
        bool linha, circulo, quadrado, losango, triangulo, pentagono, selecionado;
        Pen canetinha;
        public Color cor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public Pen caneta(Color cor, int espessura)
        {
            return new Pen(cor, espessura);
        }
        public void retaBreseham(int x0, int y0, int x1, int y1, PaintEventArgs e)
        {
            e.Graphics.DrawLine(canetinha, x0, y0, x1, y1);
        }
        public void pintap(int x, int y, PaintEventArgs e)
        {
            e.Graphics.DrawLine(canetinha, x, y, x + 1, y);
        }
        public void desenhaQuadrilatero(PaintEventArgs e,int x, int y, int altura, int largura)
        {
            e.Graphics.DrawRectangle(canetinha, x, y, largura, altura);
        }
        public void desenharCirculo(int xc, int yc, int raio, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(canetinha, xc, yc, raio, raio);
        }
        public void desenharElipse(int xc, int yc, int raiox, int raioy, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(canetinha, xc, yc, raiox, raioy);
        }

        public void desenhaFormas(PaintEventArgs e, int[] pontos)
        {
            for (int i = 0; i < pontos.Length - 2; i += 2)
            {
                retaBreseham(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], e);
            }
            retaBreseham(pontos[0], pontos[1], pontos[pontos.Length - 2], pontos[pontos.Length - 1], e);
        }

        public void setFalse()
        {
            linha = false;
            circulo = false;
            quadrado = false;
            losango = false;
            triangulo = false;
            pentagono = false;
            selecionado = false;
        }
        public void zerarPontos()
        {
            for(int i = 0; i <= pontos.Length - 1; i++)
            {
                pontos[i] = 0;
            }
            click = 0;
        }
        


        private void btn_linha_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            linha = true;
            selecionado = true;
        }

        private void btn_circulo_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            circulo = true;
            selecionado = true;
        }

        private void btn_quadrado_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            quadrado = true;
            selecionado = true;
        }

        private void btn_losangulo_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            losango = true;
            selecionado = true;
        }

        private void btn_triangulo_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            triangulo = true;
            selecionado = true;
        }

        private void btn_pentagono_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            pentagono = true;
            selecionado = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click++;
            if (click>5)
            {
                click =1 ;
            }
            pontos[(click*2)-2] = e.X;
            pontos[(click*2)-1] = e.Y;
            if (linha == true && click == 2)
            {
                Invalidate();
            }
            else if(triangulo == true && click == 3)
            {
                Invalidate();
            }
            else if(quadrado == true && click == 2)
            {
                Invalidate();
            }
            else if(losango == true && click == 4)
            {
                Invalidate();
            }else if(pentagono == true && click == 5){
                Invalidate();
            }
            else if (circulo == true && click > 0)
            {
                Invalidate();
            }
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + " " + e.Y.ToString();
        }
        public void controladorLinha(PaintEventArgs e)
        {

            retaBreseham(pontos[0], pontos[1], pontos[2], pontos[3], e);
            
        }
        public void controladorTriangulo(PaintEventArgs e)
        {
            retaBreseham(pontos[0], pontos[1], pontos[2], pontos[3], e);
            retaBreseham(pontos[2], pontos[3], pontos[4], pontos[5], e);
            retaBreseham(pontos[4], pontos[5], pontos[0], pontos[1], e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void controladorQuadrilatero(PaintEventArgs e)
        {
            int largura = Math.Abs(pontos[0] - pontos[2]);
            int altura = Math.Abs(pontos[1] - pontos[3]);
            int x, y;
            if (pontos[0] < pontos[2])
            {
                x = pontos[0];
            }
            else
            {
                x = pontos[2];
            }
            if (pontos[1] < pontos[3])
            {
                y = pontos[1];
            }
            else
            {
                y = pontos[3];
            }
            desenhaQuadrilatero(e,x, y, altura, largura);
        }
        public void controladorLosango(PaintEventArgs e)
        {
            int[] pontosLosango = new int[pontos.Length - 2];
            for(int i = 0; i < pontos.Length - 2; i++)
            {
                pontosLosango[i] = pontos[i];
            }
            desenhaFormas(e, pontosLosango);
         }
        public void controladorPentagono(PaintEventArgs e)
        {
            desenhaFormas(e, pontos);
        }
        public void controladorCirculo(PaintEventArgs e)
        {
            desenharCirculo(pontos[0], pontos[1], int.Parse(Raio.Text), e);
        }

        public void controlarElipse(PaintEventArgs e)
        {
            desenharElipse(pontos[0], pontos[1], int.Parse(Largura.Text), int.Parse(Altura.Text), e);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // TO-DO: calculo no controleLosango e no controlePentagono para não crusar as linhas
            canetinha = caneta(cor(255, 0, 0), 1);
            if (linha)
            {
                controladorLinha(e);
                zerarPontos();
            }
            else if (circulo && click > 0)
            {
                if (string.IsNullOrEmpty(Raio.Text) && string.IsNullOrEmpty(Altura.Text) == false && string.IsNullOrEmpty(Largura.Text) == false)
                {
                    controlarElipse(e);
                }
                else if (string.IsNullOrEmpty(Altura.Text) && string.IsNullOrEmpty(Largura.Text) && string.IsNullOrEmpty(Raio.Text) == false)
                {
                    controladorCirculo(e);
                }

                zerarPontos();
            }
            else if (quadrado)
            {
                controladorQuadrilatero(e);
                zerarPontos();
            }
            else if (losango)
            {
                controladorLosango(e);
                zerarPontos();
            }
            else if (triangulo)
            {
                controladorTriangulo(e);
                zerarPontos();
            }
            else if (pentagono)
            {
                controladorPentagono(e);
                zerarPontos();
            }
        }
    }
}
