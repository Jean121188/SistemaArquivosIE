using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace SistemaArquivoIE
{
    public partial class Relatorio : Form
    {
        Arquivos arq = new Arquivos();
        Report report = new Report();

        int X;
        int Y;
        int largura;
        int altura;
        int num_linhas;

        int pagina;
        int num_paginas;

        public Relatorio()
        {
            InitializeComponent();
            pagina = 0;
            num_paginas = 0;
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            string local = Environment.CurrentDirectory + @"\temp\DateReport.txt";
            report.PuxaDados(local);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            X = 50;
            Y = 50;

            printPreviewControl1.Document = printDocument1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                printPreviewControl1.StartPage = --pagina;
            }
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (pagina < num_paginas)
            {
                printPreviewControl1.StartPage = ++pagina;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            X = 50;
            Y = 50;
            num_linhas = 0;

            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                // sempre que cria o visualizador é preciso inicializar o tamanho
                largura = printDocument1.DefaultPageSettings.Bounds.Width;
                altura = printDocument1.DefaultPageSettings.Bounds.Height;

                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Arquivos arquivos = new Arquivos();
           
            // Formatacao de Escrita
            StringFormat Centralizado = new StringFormat();
            Centralizado.Alignment = StringAlignment.Center;
            Centralizado.LineAlignment = StringAlignment.Center;
            
            StringFormat Perto = new StringFormat();
            Perto.Alignment = StringAlignment.Near;
            Perto.LineAlignment = StringAlignment.Near;

            StringFormat Longe = new StringFormat();
            Longe.Alignment = StringAlignment.Far;
            Longe.LineAlignment = StringAlignment.Far;

            // Titulo
            GeraCelula(e, "Analise de Energia do " + report.NomeEquipamento, 16, 0, 0, -100, 60, Centralizado);
            // Grafico de Consumo titulo:
            GeraCelula(e, "Gráfico de consumo:", 12, 0, 65, -100, 20, Perto);
            // Grafico de Consumo
            GeraCelulaImagem(e, 20, 90, -100, 300, @"\temp\Consumo.png");
            // Analise de Consumo
            // Coluna Esquerda
            GeraCelula(e, "Consumo Real: " + report.ConsumoReal.ToString("N2") + " kw/h", 12, 0, 460, -500, 20, Perto);
            GeraCelula(e, "Consumo em Reais: R$ " + report.ConsumoEmReais.ToString("N2"), 12, 0, 485, -500, 20, Perto); // a distancia entre linhas é de 25
            GeraCelula(e, "Média de Consumo: " + report.ConsumoMedio.ToString("N2"), 12, 0, 510, -500, 20, Perto);
            // Coluna Direita
            GeraCelula(e, "Horario de Maior Consumo " , 12, 350, 460, -500, 20, Perto);
            GeraCelula(e, "Consumo Medio por Hora: " , 12, 350, 485, -500, 20, Perto);
            GeraCelula(e, "Fator de potencia Médio: " , 12, 350, 510, -500, 20, Perto);

            //// Grafico de Tensão
            GeraCelula(e, "Gráfico de Tensão:", 12, 0, 535, -500, 20, Perto);
            GeraCelulaImagem(e, 20, 566, -100, 300, @"\temp\Tensao.png");
            // Analise de Tensao
            // Coluna Esquerda
            GeraCelula(e, "Tensão Máxima ", 12, 0, 935, -500, 20, Perto);
            GeraCelula(e, "Tensão Média: ", 12, 0, 960, -500, 20, Perto);
            GeraCelula(e, "Horario de Pico: ", 12, 0, 985, -500, 20, Perto);
            // Coluna Direito
            GeraCelula(e, "Tensão Máxima ", 12, 350, 935, -500, 20, Perto);
            GeraCelula(e, "Tensão Média: ", 12, 350, 960, -500, 20, Perto);
            GeraCelula(e, "Horario de Pico: ", 12, 350, 985, -500, 20, Perto);



            //List<string> linhas = new List<string>()
            //{
            //    "1. Nulla facilisi. Vestibulum ante ipsum primis",
            //    "2. Nulla facilisi. Vestibulum ante ipsum primis",
            //};

            //while (num_linhas < linhas.Count)
            //{
            //    // Imprimir o Titulo
            //    if (num_linhas == 0)
            //    {
            //        e.Graphics.DrawString(Titulo, fonteTitulo, pincelTitulo, areaTextoTitulo, formatTitulo);
            //        Y += 150;
            //    }

            //    e.Graphics.DrawString(linhas[num_linhas], fonte, pincel, new Point(X, Y));
            //    Y += 30;
            //    num_linhas++;

            //    if (Y >= altura - 50)
            //    {
            //        // Mudar de pagina
            //        Y = 50;
            //        e.HasMorePages = true;
            //        num_paginas++;
            //        break;
            //    }
            //}


        }

        private void GeraCelula(PrintPageEventArgs e, string Nome, int TamDaFonte, int DeslDireita, int DeslEsquerda, int TamHoriz, int TamVert, StringFormat formato)
        {
            string Titulo = Nome;
            Font fonteTitulo = new Font("Arial", TamDaFonte, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincelTitulo = new SolidBrush(Color.Black);
            Rectangle area = new Rectangle((X + DeslDireita), (Y + DeslEsquerda), (largura + TamHoriz), (TamVert));
            // X => aumentar o X desloca para a direita
            // Y => aumentar o Y desloca para baixo
            // (Largura -) => diminuir a (largura -) diminui o tamanho horizontal do retangulo
            // ultimo valor => aumentando aumenta o tamanho vertical do retangulo

            // Delimitador
            //e.Graphics.DrawRectangle(new Pen(Color.Red, 2), area);
            StringFormat formatTitulo = new StringFormat();
            e.Graphics.DrawString(Titulo, fonteTitulo, pincelTitulo, area, formato);
        }

        private void GeraCelulaImagem(PrintPageEventArgs e, int DeslDireita, int DeslEsquerda, int TamHoriz, int TamVert, string CamImagem)
        {
            // Grafico de Consumo
            Rectangle area = new Rectangle((X + DeslDireita), (Y + DeslEsquerda), (largura - 100 + TamHoriz), (60 + TamVert));
            // Delimitador
           // e.Graphics.DrawRectangle(new Pen(Color.Black, 2), area);
            Image ImagemChart = Image.FromFile(Environment.CurrentDirectory + CamImagem);
            e.Graphics.DrawImage(ImagemChart, area);
        }
    }
}
