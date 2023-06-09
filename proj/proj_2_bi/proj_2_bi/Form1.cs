﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_2_bi
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        
        int click;
        int[] pontos = new int[6];
        string[] dadosSalvos;
        bool linha, circulo, quadrado, losango, triangulo, pentagono, selecionado, desenhado, carregar ;

        int tipoForma;
        int espessura = 0;
        int estiloLinha;
        int r,g,b;
        int raio,raioX,raioY = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (carregar)
            {
                for (int i = 0; i <= dadosSalvos.Length - 1; i += 10)
                {
                    Pen canetaCarregado = caneta(cor(int.Parse(dadosSalvos[i + 3]), int.Parse(dadosSalvos[i + 4]), int.Parse(dadosSalvos[i + 5])), int.Parse(dadosSalvos[i + 2]));
                    float[] estiloCarregado = tipoEstilo(int.Parse(dadosSalvos[i + 1]));
                    canetaCarregado = setEstiloLinha(estiloCarregado, canetaCarregado);
                    pegarPontosSalvos(dadosSalvos[i + 6]);
                    if (int.Parse(dadosSalvos[i]) == 1)
                    {
                        controladorLinha(e, canetaCarregado);
                    }
                    else if (int.Parse(dadosSalvos[i]) == 2)
                    {
                        raio = int.Parse(dadosSalvos[i + 7]);
                        raioX = int.Parse(dadosSalvos[i + 8]);
                        raioY = int.Parse(dadosSalvos[i + 9]);
                        controladorCirculo(e, canetaCarregado);
                    }
                    else if (int.Parse(dadosSalvos[i]) == 3)
                    {
                        controladorQuadrilatero(e, canetaCarregado);
                    }
                    else if (int.Parse(dadosSalvos[i]) == 4)
                    {
                        controladorLosango(e, canetaCarregado);
                    }
                    else if (int.Parse(dadosSalvos[i]) == 5)
                    {
                        controladorTriangulo(e, canetaCarregado);
                    }
                    else
                    {
                        controladorPentagono(e, canetaCarregado);
                    }
                }
            }

            Pen canetinha = caneta(cor(r, g, b), espessura);
            float[] estilo = tipoEstilo(estiloLinha);
            canetinha = setEstiloLinha(estilo, canetinha);

            if (linha)
            {
                tipoForma = 1;
                controladorLinha(e, canetinha);
            }
            else if (circulo && click == 1)
            {
                tipoForma = 2;
                controladorCirculo(e, canetinha);
            }
            else if (quadrado)
            {
                tipoForma = 3;
                controladorQuadrilatero(e, canetinha);
            }
            else if (losango)
            {
                tipoForma = 4;
                controladorLosango(e, canetinha);
            }
            else if (triangulo)
            {
                tipoForma = 5;
                controladorTriangulo(e, canetinha);
            }
            else if (pentagono)
            {
                tipoForma = 6;
                controladorPentagono(e, canetinha);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (desenhado)
            {
                zerarPontos();
                desenhado = false;
            }
            if (selecionado)
            {
                click++;

                pontos[(click * 2) - 2] = e.X;
                pontos[(click * 2) - 1] = e.Y;
                if (linha == true && click == 2)
                {
                    desenhado = true;
                    Invalidate();
                }
                else if (triangulo == true && click == 3)
                {
                    desenhado = true;
                    Invalidate();
                }
                else if (quadrado == true && click == 2)
                {
                    desenhado = true;
                    Invalidate();
                }
                else if (losango == true && click == 1)
                {
                    desenhado = true;
                    Invalidate();
                }
                else if (pentagono == true && click == 1)
                {
                    desenhado = true;
                    Invalidate();
                }
                else if (circulo == true && click == 1)
                {
                    desenhado = true;
                    Invalidate();
                }
            }
        }

        //Primitivas
        public Color cor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public Pen caneta(Color cor, int espessura)
        {
            return new Pen(cor, espessura);
        }
        public void retaBreseham(int x0, int y0, int x1, int y1, PaintEventArgs e,Pen caneta)
        {
            e.Graphics.DrawLine(caneta, x0, y0, x1, y1);
        }
        public void pintap(int x, int y, PaintEventArgs e, Pen caneta)
        {
            e.Graphics.DrawLine(caneta, x, y, x + 1, y);
        }
        public void desenharTriangulo(int x1,int y1, int x2, int y2, int x3, int y3,PaintEventArgs e, Pen caneta)
        {
            retaBreseham(x1, y1, x2, y2, e, caneta);
            retaBreseham(x2, y2, x3, y3, e, caneta);
            retaBreseham(x3, y3, x1, y1, e, caneta);
        }
        public void desenharQuadrilatero(PaintEventArgs e,int x, int y, int altura, int largura, Pen caneta)
        {
            e.Graphics.DrawRectangle(caneta, x, y, largura, altura);
        }
        public void desenharCirculo(int xc, int yc, int raio, PaintEventArgs e, Pen caneta)
        {
            e.Graphics.DrawEllipse(caneta, xc, yc, raio, raio);
        }
        public void desenharElipse(int xc, int yc, int raiox, int raioy, PaintEventArgs e, Pen caneta)
        {
            e.Graphics.DrawEllipse(caneta, xc, yc, raiox, raioy);
        }
        public void desenhaFormas(PaintEventArgs e, int[] pontos, Pen caneta)
        {
            for (int i = 0; i < pontos.Length - 2; i += 2)
            {
                retaBreseham(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], e, caneta);
            }
            retaBreseham(pontos[0], pontos[1], pontos[pontos.Length - 2], pontos[pontos.Length - 1], e, caneta);
        }
        public Pen setEstiloLinha(float[] linha, Pen caneta)
        {
            caneta.DashPattern = linha;
            return caneta;
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
            desenhado = false;
            carregar = false;
        }
        public void zerarPontos()
        {
            for(int i = 0; i <= pontos.Length - 1; i++)
            {
                pontos[i] = 0;
            }
            click = 0;
        }
        public string concatenaPontos(string point)
        {
            for (int i = 0; i <= pontos.Length - 2; i++)
            {
                if (pontos[i] != 0)
                {
                    point += pontos[i] + ", ";
                }
            }
            point += pontos[pontos.Length - 1];
            return point;
        }
        public void pegarPontosSalvos(string pontosSalvos)
        {
            string[] points = pontosSalvos.Split(new string[] { ", " }, StringSplitOptions.None);
            for (int i = 0; i <= points.Length - 1; i++)
            {
                pontos[i] = int.Parse(points[i]);
            }
        }
        public float[] tipoEstilo(int estiloLinha)
        {
            if (estiloLinha == 0)
            {
                return new float[] { 1.0f };
            }
            else if (estiloLinha == 1)
            {
                return new float[4] { 15, 10, 3, 10 };
            }
            else if (estiloLinha == 2)
            {
                return new float[4] { 30, 5, 2, 5 };
            }
            else if (estiloLinha == 3)
            {
                return new float[2] { 10, 5 };
            }
            else
            {
                return new float[2] { 20, 5 };
            }
        }


        //Botoes das formas
        private void btn_linha_Click(object sender, EventArgs e)
        {
            zerarPontos();
            setFalse();
            linha = true;
            selecionado = true;
        }
        private void btn_circulo_Click(object sender, EventArgs e)
        {
            string resp = Interaction.InputBox("deseja desenhar um circulo ou uma elipse[c/e]", "", "", 400, 400);
            if(resp == "e")
            {
                raioX = int.Parse(Interaction.InputBox("informe o raio x", "", "", 400, 400));
                raioY = int.Parse(Interaction.InputBox("informe o raio y", "", "", 400, 400));
            }
            else
            {
                raio = int.Parse(Interaction.InputBox("informe o raio", "", "", 400, 400));
            }
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



        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + " " + e.Y.ToString();
        } 




        //serviços do arquivo
        private void button1_Click_1(object sender, EventArgs e)
        {
            string point = concatenaPontos("");
            string caminho = "";
            ofd.InitialDirectory = @"C:\Arquivos\";
            int resp = int.Parse(Interaction.InputBox("deseja criar um novo arquivo[1] ou utilizar um ja existente[2]", "", "", 400, 400));
            if(resp == 2)
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    caminho = ofd.FileName;
                }
            }
            else
            {
                string arquivo = Interaction.InputBox("informe o nome do arquivo q deseja criar", "", "", 400, 400);
                caminho = @"C:\Arquivos\" + arquivo + ".dat";
            }
            
            File.AppendAllText(caminho, tipoForma + Environment.NewLine);
            File.AppendAllText(caminho, estiloLinha + Environment.NewLine);
            File.AppendAllText(caminho, espessura + Environment.NewLine);
            File.AppendAllText(caminho, r + Environment.NewLine);
            File.AppendAllText(caminho, g + Environment.NewLine);
            File.AppendAllText(caminho, b + Environment.NewLine);
            File.AppendAllText(caminho, point + Environment.NewLine);
            File.AppendAllText(caminho, raio + Environment.NewLine);
            File.AppendAllText(caminho, raioX + Environment.NewLine);
            File.AppendAllText(caminho, raioY + Environment.NewLine);

            MessageBox.Show("Arquivo salvo com sucesso!");
        }
        private void btn_carregar_Click(object sender, EventArgs e)
        {
            string caminho = "";
            ofd.InitialDirectory = @"C:\Arquivos\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                caminho = ofd.FileName;
            }
            if (File.Exists(caminho))
            {
                dadosSalvos = File.ReadAllLines(caminho);
                carregar = true;
                Invalidate();
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado!");
            }
        }

        //Controladores
        public void controladorLinha(PaintEventArgs e, Pen canetinha)
        {
            retaBreseham(pontos[0], pontos[1], pontos[2], pontos[3], e, canetinha);
        }
        public void controladorTriangulo(PaintEventArgs e, Pen canetinha)
        {
            desenharTriangulo(pontos[0], pontos[1], pontos[2], pontos[3], pontos[4], pontos[5], e, canetinha);
        }
        public void controladorQuadrilatero(PaintEventArgs e, Pen canetinha)
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
            desenharQuadrilatero(e,x, y, altura, largura, canetinha);
        }
        public void controladorLosango(PaintEventArgs e, Pen canetinha)
        {
            int x = pontos[0];
            int y = pontos[1];
            int[] pontosLosango = new int[8] {x,y-150,x+75,y,x,y+150,x-75,y};

            desenhaFormas(e, pontosLosango, canetinha);
        }
        public void controladorPentagono(PaintEventArgs e, Pen canetinha)
        {
            int x = pontos[0];
            int y = pontos[1];
            int[] pontosPentagono = new int[10] { x, y - 100, x + 75, y, x+75, y + 100, x - 75, y+100, x-75,y };

            desenhaFormas(e, pontosPentagono, canetinha);
        }
        public void controladorCirculo(PaintEventArgs e, Pen canetinha)
        {
            if (raioX > 0)
            {
                desenharElipse(pontos[0] - raioX / 2, pontos[1] - raioY / 2, raioX, raioY, e, canetinha);
            }
            else
            {
                desenharCirculo(pontos[0] - raio / 2, pontos[1] - raio / 2, raio, e, canetinha);
            } 
        }


        //Cores
        private void button1_Click(object sender, EventArgs e)
        {
            r = 0;
            g = 0;
            b = 0;
        }
        private void Branco_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 255;
            b = 255;
        }
        private void Cinza_Click(object sender, EventArgs e)
        {
            r = 125;
            g = 125;
            b = 125;
        }
        private void CInzaClaro_Click(object sender, EventArgs e)
        {
            r = 224;
            g = 224;
            b = 224;
        }
        private void Maroon_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 255;
            b = 0;
        }
        private void RosaVermelho_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 128;
            b = 128;
        }
        private void Vermelho_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 0;
            b = 0;
        }
        private void Rosinha_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 192;
            b = 192;
        }
        private void Laranja_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 128;
            b = 0;
        }
        private void VerdeMato_Click(object sender, EventArgs e)
        {
            r = 192;
            g = 192;
            b = 0;
        }
        private void Amarelo_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 255;
            b = 0;
        }
        private void AmareloClaro_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 255;
            b = 192;
        }
        private void Verde_Click(object sender, EventArgs e)
        {
            r = 0;
            g = 192;
            b = 0;
        }
        private void VerdeClaro_Click(object sender, EventArgs e)
        {
            r = 128;
            g = 255;
            b = 128;
        }
        private void AzulBebe_Click(object sender, EventArgs e)
        {
            r = 192;
            g = 192;
            b = 255;
        }
        private void Ciano_Click(object sender, EventArgs e)
        {
            r = 192;
            g = 255;
            b = 255;
        }
        private void Azul_Click(object sender, EventArgs e)
        {
            r = 0;
            g = 0;
            b = 255;
        }
        private void AzulClaro_Click(object sender, EventArgs e)
        {
            r = 128;
            g = 128;
            b = 255;
        }
        private void Roxo_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 0;
            b = 255;

        }
        private void RoxoClaro_Click(object sender, EventArgs e)
        {
            r = 255;
            g = 192;
            b = 255;
        }

        //ComboBoxs
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != null)
            {
                espessura = comboBox1.SelectedIndex;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != null)
            {
                estiloLinha = comboBox2.SelectedIndex;

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

    }
}
