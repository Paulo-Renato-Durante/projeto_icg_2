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
        bool linha, circulo, quadrado, losango, triangulo, pentagono;
        public Color cor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public Pen caneta(Color cor, int espessura)
        {
            return new Pen(cor, espessura);
        }
        public void retaBreseham(int x0, int y0, int x1, int y1, Pen caneta, PaintEventArgs e)
        {
            e.Graphics.DrawLine(caneta, x0, y0, x1, y1);
        }
        public void pintap(int x, int y,Pen caneta, PaintEventArgs e)
        {
            e.Graphics.DrawLine(caneta, x, y, x + 1, y);
        }
        public void desenhaQuadrilatero(PaintEventArgs e,int x, int y, int altura, int largura, Pen caneta)
        {
            e.Graphics.DrawRectangle(caneta, x, y, largura, altura);
        }
        public void desenharCirculo(int xc, int yc, int raio,Pen caneta, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(caneta, xc, yc, raio, raio);
        }
        public void desenharElipse(int xc, int yc, int raiox, int raioy, Pen caneta, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(caneta, xc, yc, raiox, raioy);
        }

        public void desenhaFormas(PaintEventArgs e, int[] pontos,Pen caneta)
        {
            for (int i = 0; i < pontos.Length - 2; i += 2)
            {
                retaBreseham(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], caneta, e);
            }
            retaBreseham(pontos[0], pontos[1], pontos[pontos.Length - 2], pontos[pontos.Length - 1], caneta, e);
        }
        public void setFalse()
        {
            linha = false;
            circulo = false;
            quadrado = false;
            losango = false;
            triangulo = false;
            pentagono = false;
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
        }

        private void btn_circulo_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            circulo = true;
        }

        private void btn_quadrado_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            quadrado = true;
        }

        private void btn_losangulo_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            losango = true;
        }

        private void btn_triangulo_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            triangulo = false;
        }

        private void btn_pentagono_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            pentagono = true;
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
            else if(quadrado == true && click == 4)
            {
                Invalidate();
            }
            else if(losango == true && click == 4)
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
            if (click % 2 == 0)
            {
                retaBreseham(pontos[0], pontos[1], pontos[2], pontos[3], caneta(cor(255, 0, 0), 2), e);
            }
        }
        public void controladorTriangulo(PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (linha)
            {
                controladorLinha(e);
                zerarPontos();
            }
            else if (circulo)
            {

            }else if (quadrado)
            {

            }else if (losango)
            {

            }else if (triangulo)
            {
                triangulo

            }else if (pentagono)
            {

            }
        
            
            
           

        }
    }
}
