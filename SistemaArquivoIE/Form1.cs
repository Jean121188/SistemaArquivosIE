using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace SistemaArquivoIE
{
    public partial class Form1 : Form
    {
        // Variaveis
        string FormatoAnterior = "";
        
        Arquivos arq = new Arquivos();          // chamada da classe

        public Form1()
        {
            InitializeComponent();
            treeView.Nodes.Add("Arquivo");
            treeView.Nodes.Add("Relatório");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            process.Visible = false; // inicializa a barra de progresso como false
            toolRun.Enabled = false;

            arq.listViewDados = listViewDate;
            arq.grafico = chartConsumo;
            arq.grafico2 = GraficoTensao;
            arq.arvore = treeView;
            arq.label1 = lblMediaA;
            arq.label2 = lblMediaB;
            arq.label3 = lblMediaC;
            arq.textbox1 = txtConsMaximo;
            arq.textbox2 = txtConsMinimo;
            arq.textbox3 = txtConsMedio;
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (arq.EquipSelect == 0)
            {
                MessageBox.Show("Antes de Importar é Nescessário Selecionar o Equipamento",
                        "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            toolRun.Enabled = true;                     // Habilita Execução
            open.Filter = "Arquivo de Texto | *.txt";   // Preenche O TreeView

            if (open.ShowDialog() != DialogResult.Cancel)
            {

                listViewDate.Items.Clear();

                // Pegar o nome do Arquivo
                DirectoryInfo nameArq = new DirectoryInfo(open.FileName);   // pega o nome do Arquivo
                arq.nomeArquivo = nameArq.Name;                             // envia paraa classe o nome do arquivo
                arq.formatoArquivo = nameArq.Extension;                     // envia paraa classe o formato do arquivo
                arq.FullNameArq = nameArq.FullName;

                // Verifica se é um arquivo utilizado nos medidores no padao ddmmaaaa
                #region Tratamento do Arquivo
                string NomeSemExtensao = "";
                try
                {
                    NomeSemExtensao = arq.nomeArquivo.Substring(0, 8);
                }
                catch (Exception)
                {
                    MessageBox.Show("Este Arquivo não é o esperado para Analise");
                    return;
                }

                bool isNumeric = int.TryParse(NomeSemExtensao, out int n);
                if (!isNumeric)
                {
                    MessageBox.Show("Este Arquivo não possui o formato esperado para Realizar a Analise");
                    return;
                }

                if (FormatoAnterior == arq.formatoArquivo)
                {
                    MessageBox.Show("Só é possivel fazer a Analise de um arquivo por vez",
                        "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                FormatoAnterior = arq.formatoArquivo;                // Não Apagar!!!

                DialogResult res = MessageBox.Show("Arquivo Importado com Sucesso! \n Deseja Executar?", "SUCESS", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (res == DialogResult.Yes)
                {
                    toolRun_Click(sender, e);
                }
            }
        }

        private void toolImportar_Click(object sender, EventArgs e)
        {
            importarToolStripMenuItem_Click(sender, e);
        }

        private void tipoDeMedidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status.Items.Clear();

            FormConfigEquipamento formConfig = new FormConfigEquipamento();
            formConfig.ShowDialog();

            arq.EquipSelect = formConfig.EquipSelect;
            arq.NomeEquiSelected = formConfig.NomeEquipSel;

            // Aparece embaixo o equipamento selecionado
            status.Items.Add("Equipamento Selecionado: " + arq.NomeEquiSelected);
        }

        private void toolRun_Click(object sender, EventArgs e)
        {
            toolRun.Enabled = false;
            arq.AtribuiVariaveis(arq.FullNameArq);              

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gerarToolStripMenuItem_Click(object sender, EventArgs x)
        {
            // Relatorios
            Relatorio relatorio = new Relatorio();
            relatorio.ShowDialog();
        }

        private void configuraçãoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigTarifa tarifa = new ConfigTarifa();
            tarifa.ShowDialog();

            arq.TarifaAtual = tarifa.tarifa;
        }
    }
}
