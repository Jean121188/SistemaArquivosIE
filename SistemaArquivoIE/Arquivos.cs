using System;
using System.Collections.Generic;
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
    class Arquivos
    {
        public string caminhoArquivo { get; set; }
        public string nomeArquivo { get; set; }
        public string formatoArquivo { get; set; }
        public string FullNameArq { get; set; }
        public string NomeDoGrafico { get; set; }

        // Variaveis de Configuração
        public int EquipSelect { get; set; }
        public string NomeEquiSelected { get; set; }
        public double TarifaAtual { get; set; }

        // variaveis do medidor SM-3W, pois possui todas variaveis
        public int hora, minutos, segundos, pa, pb, pc, pt, qa, qb, qc, qt, sa, sb, sc, st,
            uarms, ubrms, ucrms, iarms, ibrms, icrms, itrms, pfa, pfb, pfc, pft, pga, pgb,
            pgc, freq, epa, epb, epc, ept, eqa, eqb, eqc, eqt, yuaub, yuauc, yubuc, tpsd, ep_g, ep_c;

        // Equipamentos de energia
        private string[] SM3W ={"Hora", "PA", "PB", "PC", "PT", "QA", "QB", "QC", "QT",
                "SA", "SB", "SC", "ST", "UARMS", "UBRMS", "UCRMS", "IARMS", "IBRMS", "UCRMS", "ITRMS",
                "PFA", "PFB", "PFC", "PFT", "PGA", "PGB", "PGC", "FREQ", "EPA", "EPB", "EPC", "EPT",
                "EQA", "EQB", "EQC", "EQT", "YUAUB", "YUAUC", "YUBUC", "TPSD"};
        private string[] SMW_Lite = {"Hora", "EPA"};
        private string[] SM2W_Lite = { "Hora", "PA", "PB", "PT", "UARMS", "UBRMS", "IARMS", "IBRMS", "EPT"};
        private string[] SM2W_Bidirecional = { "Hora", "PA", "PB", "PT", "UARMS", "UBRMS", "IARMS", "IBRMS", "EPT_G", "EPT_C" };
        private string[] SM3W_Lite = { "Hora", "PA", "PB", "PC", "PT", "UARMS", "UBRMS", "UCRMS", "IARMS", "IBRMS", "ICRMS", "EPT" };
        private string[] SM3W_Bidirecional = { "Hora", "PA", "PB", "PC", "PT", "UARMS", "UBRMS", "UCRMS", "IARMS", "IBRMS", "ICRMS", "EPT_G", "EPT_C" };
        
        // Outros Equipamentos
        private string[] SMWA = {"HORA", "EPT" };
        private string[] SMTW = { "ID", "T_CANAL1", "U_CANAL1", "T_CANAL2", "U_CANAL2" };

        public ListView listViewDados;  // Faz parte da exibição de dados
        public Chart grafico;   // vincula grafico de consumo
        public Chart grafico2;  // vincula o grafico de tensao
        public TreeView arvore; // vincula o treeView
        public Label label1, label2, label3;    // Label
        public TextBox textbox1, textbox2, textbox3;

        List<Arquivos> listArquivos = new List<Arquivos>();

        public void AtribuiVariaveis(string caminho)
        {
            string[] ArqText = File.ReadAllLines(caminho);

            if (EquipSelect == 6) // SM-3W Trifasico Industrial
            {
                for (int i = 0; i < ArqText.Length; i++)
                {
                    string[] aux = ArqText[i].Split(':');

                    Arquivos arq2 = new Arquivos();
                    arq2.hora = int.Parse(aux[0]);
                    arq2.minutos = int.Parse(aux[1]);
                    arq2.segundos = int.Parse(aux[2]);
                    arq2.pa = int.Parse(aux[3]);
                    arq2.pb = int.Parse(aux[4]);
                    arq2.pc = int.Parse(aux[5]);
                    arq2.pt = int.Parse(aux[6]);
                    arq2.qa = int.Parse(aux[7]);
                    arq2.qb = int.Parse(aux[8]);
                    arq2.qc = int.Parse(aux[9]);
                    arq2.qt = int.Parse(aux[10]);
                    arq2.sa = int.Parse(aux[11]);
                    arq2.sb = int.Parse(aux[12]);
                    arq2.sc = int.Parse(aux[13]);
                    arq2.st = int.Parse(aux[14]);
                    arq2.uarms = int.Parse(aux[15]);
                    arq2.ubrms = int.Parse(aux[16]);
                    arq2.ucrms = int.Parse(aux[17]);
                    arq2.iarms = int.Parse(aux[18]);
                    arq2.ibrms = int.Parse(aux[19]);
                    arq2.icrms = int.Parse(aux[20]);
                    arq2.itrms = int.Parse(aux[21]);
                    arq2.pfa = int.Parse(aux[22]);
                    arq2.pfb = int.Parse(aux[23]);
                    arq2.pfc = int.Parse(aux[24]);
                    arq2.pft = int.Parse(aux[25]);
                    arq2.pga = int.Parse(aux[26]);
                    arq2.pgb = int.Parse(aux[27]);
                    arq2.pgc = int.Parse(aux[28]);
                    arq2.freq = int.Parse(aux[29]);
                    arq2.epa = int.Parse(aux[30]);
                    arq2.epb = int.Parse(aux[31]);
                    arq2.epc = int.Parse(aux[32]);
                    arq2.ept = int.Parse(aux[33]);
                    arq2.eqa = int.Parse(aux[34]);
                    arq2.eqb = int.Parse(aux[35]);
                    arq2.eqc = int.Parse(aux[36]);
                    arq2.eqt = int.Parse(aux[37]);
                    arq2.yuaub = int.Parse(aux[38]);
                    arq2.yuauc = int.Parse(aux[39]);
                    arq2.yubuc = int.Parse(aux[40]);
                    arq2.tpsd = int.Parse(aux[41]);
                    listArquivos.Add(arq2);
                }
            }
            else if (EquipSelect == 1) // Monofasico
            {
                for (int i = 0; i < ArqText.Length; i++)
                {
                    string[] aux = ArqText[i].Split(':');

                    Arquivos arq2 = new Arquivos();
                    arq2.hora = int.Parse(aux[0]);
                    arq2.minutos = int.Parse(aux[1]);
                    arq2.segundos = int.Parse(aux[2]);
                    arq2.ept = int.Parse(aux[3]);
                    listArquivos.Add(arq2);
                }
            }
            else if (EquipSelect == 2) // SM-2W Lite (Bifásico)
            {
                for (int i = 0; i < ArqText.Length; i++)
                {
                    string[] aux = ArqText[i].Split(':');

                    Arquivos arq2 = new Arquivos();
                    arq2.hora = int.Parse(aux[0]);
                    arq2.minutos = int.Parse(aux[1]);
                    arq2.segundos = int.Parse(aux[2]);
                    arq2.pa = int.Parse(aux[3]);
                    arq2.pb = int.Parse(aux[4]);
                    arq2.pt = int.Parse(aux[5]);
                    arq2.uarms = int.Parse(aux[6]);
                    arq2.ubrms = int.Parse(aux[7]);
                    arq2.iarms = int.Parse(aux[8]);
                    arq2.ibrms = int.Parse(aux[9]);
                    arq2.ept = int.Parse(aux[10]);
                    listArquivos.Add(arq2);
                }
            }
            else if (EquipSelect == 3) // SM-2W Lite (Bifásico bidirecional)
            {
                for (int i = 0; i < ArqText.Length; i++)
                {
                    string[] aux = ArqText[i].Split(':');

                    Arquivos arq2 = new Arquivos();
                    arq2.hora = int.Parse(aux[0]);
                    arq2.minutos = int.Parse(aux[1]);
                    arq2.segundos = int.Parse(aux[2]);
                    arq2.pa = int.Parse(aux[3]);
                    arq2.pb = int.Parse(aux[4]);
                    arq2.pt = int.Parse(aux[5]);
                    arq2.uarms = int.Parse(aux[6]);
                    arq2.ubrms = int.Parse(aux[7]);
                    arq2.iarms = int.Parse(aux[8]);
                    arq2.ibrms = int.Parse(aux[9]);
                    arq2.ep_g = int.Parse(aux[10]);
                    arq2.ep_c = int.Parse(aux[11]);
                    listArquivos.Add(arq2);
                }
            }
            else if (EquipSelect == 4) // SM-3W Lite (Trifásico)
            {
                for (int i = 0; i < ArqText.Length; i++)
                {
                    string[] aux = ArqText[i].Split(':');

                    Arquivos arq2 = new Arquivos();
                    arq2.hora = int.Parse(aux[0]);
                    arq2.minutos = int.Parse(aux[1]);
                    arq2.segundos = int.Parse(aux[2]);
                    arq2.pa = int.Parse(aux[3]);
                    arq2.pb = int.Parse(aux[4]);
                    arq2.pc = int.Parse(aux[5]);
                    arq2.pt = int.Parse(aux[6]);
                    arq2.uarms = int.Parse(aux[7]);
                    arq2.ubrms = int.Parse(aux[8]);
                    arq2.ucrms = int.Parse(aux[9]);
                    arq2.iarms = int.Parse(aux[10]);
                    arq2.ibrms = int.Parse(aux[11]);
                    arq2.icrms = int.Parse(aux[12]);
                    arq2.ept = int.Parse(aux[13]);
                    listArquivos.Add(arq2);
                }
            }
            else if (EquipSelect == 5) //SM - 3W Lite(Trifásico Bidirecional)
            {
                for (int i = 0; i < ArqText.Length; i++)
                {
                    string[] aux = ArqText[i].Split(':');

                    Arquivos arq2 = new Arquivos();
                    arq2.hora = int.Parse(aux[0]);
                    arq2.minutos = int.Parse(aux[1]);
                    arq2.segundos = int.Parse(aux[2]);
                    arq2.pa = int.Parse(aux[3]);
                    arq2.pb = int.Parse(aux[4]);
                    arq2.pc = int.Parse(aux[5]);
                    arq2.pt = int.Parse(aux[6]);
                    arq2.uarms = int.Parse(aux[7]);
                    arq2.ubrms = int.Parse(aux[8]);
                    arq2.ucrms = int.Parse(aux[9]);
                    arq2.iarms = int.Parse(aux[10]);
                    arq2.ibrms = int.Parse(aux[11]);
                    arq2.icrms = int.Parse(aux[12]);
                    arq2.ep_g = int.Parse(aux[13]);
                    arq2.ep_c = int.Parse(aux[14]);
                    listArquivos.Add(arq2);
                }
            }
            
            // Preenche o ListView
            listViewDados.Invoke(new Action(() =>
            {
                PreencheTabelaDados(listArquivos);
            }));
            // Preenche os Graficos
            grafico.Invoke(new Action(()=> {
                CriaGraficos(grafico, "Consumo", "Consumo", "Horas", "Consumo", SeriesChartType.Column, listArquivos);
                CriaGraficos(grafico2, "Tensao", "Tensao", "Horas", "Tensao", SeriesChartType.Spline, listArquivos);
            }));
            // Preenche o TreeView
            arvore.Invoke(new Action(()=> {
                arvore.Nodes[0].Nodes.Add(nomeArquivo);
            }));
            // Preenche os valores medios de tensao
            label1.Invoke(new Action(() => {
                label1.Text = CalculaTensao("A", listArquivos).ToString("###.##");
            }));
            label2.Invoke(new Action(() => {
                label2.Text = CalculaTensao("B", listArquivos).ToString("###.##");
            }));
            label3.Invoke(new Action(() => {
                label3.Text = CalculaTensao("C", listArquivos).ToString("###.##");
            }));
            textbox1.Invoke(new Action(() => {
                textbox1.Text = CalculaConsumo("maximo", listArquivos).ToString("N2");
            }));
            textbox2.Invoke(new Action(() => {
                textbox2.Text = CalculaConsumo("minimo", listArquivos).ToString("N2");
            }));
            textbox3.Invoke(new Action(() => {
                textbox3.Text = CalculaConsumo("media", listArquivos).ToString("N2");
            }));

            // Cria Arquivo para fazer relatorios
            CriaArquivoRelatorio();
        }

        // Metodo que recebe o caminho do arquivo e trata os dados para cada equipamento
        private void PreencheTabelaDados(List<Arquivos> arquivos)
        {
            listViewDados.View = View.Details;
            listViewDados.LabelEdit = true;
            listViewDados.AllowColumnReorder = true;
            listViewDados.FullRowSelect = true;
            listViewDados.GridLines = true;

            if (EquipSelect == 6)
            {
                // colunas para o SM 3W
                for (int i = 0; i < SM3W.Length; i++)
                {
                    listViewDados.Columns.Add(new ColumnHeader());
                    listViewDados.Columns[i].Text = SM3W[i];
                }

                foreach (var item in arquivos)
                {
                    ListViewItem listItem = new ListViewItem(item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString());
                    listItem.SubItems.Add(item.pa.ToString());
                    listItem.SubItems.Add(item.pb.ToString());
                    listItem.SubItems.Add(item.pc.ToString());
                    listItem.SubItems.Add(item.pt.ToString());
                    listItem.SubItems.Add(item.qa.ToString());
                    listItem.SubItems.Add(item.qb.ToString());
                    listItem.SubItems.Add(item.qc.ToString());
                    listItem.SubItems.Add(item.qt.ToString());
                    listItem.SubItems.Add(item.sa.ToString());
                    listItem.SubItems.Add(item.sb.ToString());
                    listItem.SubItems.Add(item.sc.ToString());
                    listItem.SubItems.Add(item.st.ToString());
                    listItem.SubItems.Add(item.uarms.ToString());
                    listItem.SubItems.Add(item.ubrms.ToString());
                    listItem.SubItems.Add(item.ucrms.ToString());
                    listItem.SubItems.Add(item.iarms.ToString());
                    listItem.SubItems.Add(item.ibrms.ToString());
                    listItem.SubItems.Add(item.icrms.ToString());
                    listItem.SubItems.Add(item.itrms.ToString());
                    listItem.SubItems.Add(item.pfa.ToString());
                    listItem.SubItems.Add(item.pfb.ToString());
                    listItem.SubItems.Add(item.pfc.ToString());
                    listItem.SubItems.Add(item.pft.ToString());
                    listItem.SubItems.Add(item.pga.ToString());
                    listItem.SubItems.Add(item.pgb.ToString());
                    listItem.SubItems.Add(item.pgc.ToString());
                    listItem.SubItems.Add(item.freq.ToString());
                    listItem.SubItems.Add(item.epa.ToString());
                    listItem.SubItems.Add(item.epb.ToString());
                    listItem.SubItems.Add(item.epc.ToString());
                    listItem.SubItems.Add(item.ept.ToString());
                    listItem.SubItems.Add(item.eqa.ToString());
                    listItem.SubItems.Add(item.eqb.ToString());
                    listItem.SubItems.Add(item.eqc.ToString());
                    listItem.SubItems.Add(item.eqt.ToString());
                    listItem.SubItems.Add(item.yuaub.ToString());
                    listItem.SubItems.Add(item.yuauc.ToString());
                    listItem.SubItems.Add(item.yubuc.ToString());
                    listItem.SubItems.Add(item.tpsd.ToString());
                    listViewDados.Items.Add(listItem);
                }
            }
            else if(EquipSelect == 1) //SM-W Lite (Monofásico)
            {
                for (int i = 0; i < SMW_Lite.Length; i++)
                {
                    listViewDados.Columns.Add(new ColumnHeader());
                    listViewDados.Columns[i].Text = SMW_Lite[i];
                }
                foreach (var item in arquivos)
                {
                    ListViewItem listItem = new ListViewItem(item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString());
                    listItem.SubItems.Add(item.ept.ToString());
                    listViewDados.Items.Add(listItem);
                }
            }
            else if (EquipSelect == 2) //SM-2W Lite (Bifásico)
            {
                for (int i = 0; i < SM2W_Lite.Length; i++)
                {
                    listViewDados.Columns.Add(new ColumnHeader());
                    listViewDados.Columns[i].Text = SM2W_Lite[i];
                }
                foreach (var item in arquivos)
                {
                    ListViewItem listItem = new ListViewItem(item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString());
                    listItem.SubItems.Add(item.pa.ToString());
                    listItem.SubItems.Add(item.pb.ToString());
                    listItem.SubItems.Add(item.pt.ToString());
                    listItem.SubItems.Add(item.uarms.ToString());
                    listItem.SubItems.Add(item.ubrms.ToString());
                    listItem.SubItems.Add(item.iarms.ToString());
                    listItem.SubItems.Add(item.ibrms.ToString());
                    listItem.SubItems.Add(item.ept.ToString());
                    listViewDados.Items.Add(listItem);
                }
            }
            else if (EquipSelect == 3) //SM-2W Lite (Bifásico Bidirecional)
            {
                for (int i = 0; i < SM2W_Bidirecional.Length; i++)
                {
                    listViewDados.Columns.Add(new ColumnHeader());
                    listViewDados.Columns[i].Text = SM2W_Bidirecional[i];
                }
                foreach (var item in arquivos)
                {
                    ListViewItem listItem = new ListViewItem(item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString());
                    listItem.SubItems.Add(item.pa.ToString());
                    listItem.SubItems.Add(item.pb.ToString());
                    listItem.SubItems.Add(item.pt.ToString());
                    listItem.SubItems.Add(item.uarms.ToString());
                    listItem.SubItems.Add(item.ubrms.ToString());
                    listItem.SubItems.Add(item.iarms.ToString());
                    listItem.SubItems.Add(item.ibrms.ToString());
                    listItem.SubItems.Add(item.ep_g.ToString());
                    listItem.SubItems.Add(item.ep_c.ToString());
                    listViewDados.Items.Add(listItem);
                }
            }
            else if (EquipSelect == 4) //SM3W_Lite
            {
                for (int i = 0; i < SM3W_Lite.Length; i++)
                {
                    listViewDados.Columns.Add(new ColumnHeader());
                    listViewDados.Columns[i].Text = SM3W_Lite[i];
                }
                foreach (var item in arquivos)
                {
                    ListViewItem listItem = new ListViewItem(item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString());
                    listItem.SubItems.Add(item.pa.ToString());
                    listItem.SubItems.Add(item.pb.ToString());
                    listItem.SubItems.Add(item.pc.ToString());
                    listItem.SubItems.Add(item.pt.ToString());
                    listItem.SubItems.Add(item.uarms.ToString());
                    listItem.SubItems.Add(item.ubrms.ToString());
                    listItem.SubItems.Add(item.ucrms.ToString());
                    listItem.SubItems.Add(item.iarms.ToString());
                    listItem.SubItems.Add(item.ibrms.ToString());
                    listItem.SubItems.Add(item.icrms.ToString());
                    listItem.SubItems.Add(item.ept.ToString());
                    listViewDados.Items.Add(listItem);
                }
            }
            else if (EquipSelect == 5) //SM-3W Lite (Trifásico Bidirecional)
            {
                for (int i = 0; i < SM3W_Bidirecional.Length; i++)
                {
                    listViewDados.Columns.Add(new ColumnHeader());
                    listViewDados.Columns[i].Text = SM3W_Bidirecional[i];
                }
                foreach (var item in arquivos)
                {
                    ListViewItem listItem = new ListViewItem(item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString());
                    listItem.SubItems.Add(item.pa.ToString());
                    listItem.SubItems.Add(item.pb.ToString());
                    listItem.SubItems.Add(item.pc.ToString());
                    listItem.SubItems.Add(item.pt.ToString());
                    listItem.SubItems.Add(item.uarms.ToString());
                    listItem.SubItems.Add(item.ubrms.ToString());
                    listItem.SubItems.Add(item.ucrms.ToString());
                    listItem.SubItems.Add(item.iarms.ToString());
                    listItem.SubItems.Add(item.ibrms.ToString());
                    listItem.SubItems.Add(item.icrms.ToString());
                    listItem.SubItems.Add(item.ep_g.ToString());
                    listItem.SubItems.Add(item.ep_c.ToString());
                    listViewDados.Items.Add(listItem);
                }
            }
        }

        // Metodo que cria os graficos
        private void CriaGraficos(Chart grafico, string nomeGrafico, string Legenda, string nomeX, string nomeY, SeriesChartType charType, List<Arquivos> lista)
        {
            NomeDoGrafico = nomeGrafico; // importante não mexer

            // Titulo
            Title titulo = new Title();
            titulo.Font = new Font("Arial", 14, FontStyle.Bold);
            titulo.ForeColor = Color.Black;
            titulo.Text = @nomeGrafico;
            grafico.Titles.Add(titulo);
            // Legenda
            Legend legenda = new Legend();
            grafico.Legends.Add(legenda);
            grafico.Legends[0].Title = Legenda;

            //Titulo dos Eixos
            grafico.ChartAreas["ChartArea1"].AxisX.Title = @nomeX;
            grafico.ChartAreas["ChartArea1"].AxisY.Title = @nomeY;
            
            // Escala
            grafico.ChartAreas[0].AxisY.IsStartedFromZero = false;
            grafico.ChartAreas[0].AxisX.IsStartedFromZero = false;

            // pegando o consumo via LINQ
            var tempo = from horas in listArquivos select horas;

            if (charType == SeriesChartType.Column)
            {
                grafico.Series.Add(nomeGrafico);
                grafico.Series[nomeGrafico].LegendText = "Ativo";

                grafico.Series[nomeGrafico].ChartType = charType;
                grafico.Series[nomeGrafico].BorderWidth = 4;

                foreach (var item in tempo)
                {
                    string horas_t = item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString();
                    grafico.Series[nomeGrafico].Points.AddXY(horas_t, (item.ept / 100));
                }
            }
            else if (charType == SeriesChartType.Spline)
            {
                if(EquipSelect == 4 || EquipSelect == 5 || EquipSelect == 6)
                {

                    grafico.Series.Add(nomeGrafico + "FaseA");
                    grafico.Series[nomeGrafico + "FaseA"].LegendText = "Tensão Fase A";

                    grafico.Series[nomeGrafico + "FaseA"].ChartType = SeriesChartType.Spline;

                    foreach (var item in tempo)
                    {
                        string horaTotal = item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString();
                        grafico.Series[nomeGrafico + "FaseA"].Points.AddXY(horaTotal, (item.uarms / 100));
                    }
                    // Serie Tensão fase b
                    grafico.Series.Add(nomeGrafico + "FaseB");
                    grafico.Series[nomeGrafico + "FaseB"].LegendText = "Tensão Fase B";
                    grafico.Series[nomeGrafico + "FaseB"].ChartType = charType;

                    foreach (Arquivos item in listArquivos)
                    {
                        string horaTotal = item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString();
                        grafico.Series[nomeGrafico + "FaseB"].Points.AddXY(horaTotal, (item.ubrms / 100));
                    }

                    grafico.Series.Add(nomeGrafico + "FaseC");
                    grafico.Series[nomeGrafico + "FaseC"].LegendText = "Tensão Fase C";

                    grafico.Series[nomeGrafico + "FaseC"].ChartType = charType;

                    foreach (Arquivos item in listArquivos)
                    {
                        string horaTotal = item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString();
                        grafico.Series[nomeGrafico + "FaseC"].Points.AddXY(horaTotal, (item.ucrms / 100));
                    }
                }else if(EquipSelect == 2 || EquipSelect == 3)
                {
                    grafico.Series.Add(nomeGrafico + "FaseA");
                    grafico.Series[nomeGrafico + "FaseA"].LegendText = "Tensão Fase A";

                    grafico.Series[nomeGrafico + "FaseA"].ChartType = SeriesChartType.Spline;

                    foreach (var item in tempo)
                    {
                        string horaTotal = item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString();
                        grafico.Series[nomeGrafico + "FaseA"].Points.AddXY(horaTotal, (item.uarms / 100));
                    }
                    // Serie Tensão fase b
                    grafico.Series.Add(nomeGrafico + "FaseB");
                    grafico.Series[nomeGrafico + "FaseB"].LegendText = "Tensão Fase B";
                    grafico.Series[nomeGrafico + "FaseB"].ChartType = charType;

                    foreach (Arquivos item in listArquivos)
                    {
                        string horaTotal = item.hora.ToString() + ":" + item.minutos.ToString() + ":" + item.segundos.ToString();
                        grafico.Series[nomeGrafico + "FaseB"].Points.AddXY(horaTotal, (item.ubrms / 100));
                    }
                }
            }
            // No final de Tudo, salve o grafico na pasta TEMP
            string path = Environment.CurrentDirectory + @"\temp\" + nomeGrafico + ".png";
            grafico.SaveImage(path, ChartImageFormat.Png);
        }

        private double CalculaConsumo(string tipo, List<Arquivos> Lista)
        {
            var dados = from cons in Lista select cons;

            List<int> dadosCon = new List<int>();
            var consumo = from consF in dadosCon select consF;

            foreach (var item in dados)
            {
                dadosCon.Add(item.ept);
            }

            if (tipo == "media")
            {
                double Media = consumo.Average();
                return (Media / 100);
            }
            else if (tipo == "maximo")
            {
                double Maximo = consumo.Max();
                return (Maximo / 100);
            }
            else if (tipo == "minimo")
            {
                double Minimo = consumo.Min();
                return (Minimo / 100);
            }
            return 0;
        }

        public double CalculaTensao(string Fase, List<Arquivos> Lista)
        {
            double count = 0.00;
            int quant = 0;

            if (Fase == "A" || Fase == "a")
            {
                foreach (Arquivos item in Lista)
                {
                    count += (item.uarms / 100.00);
                    quant++;
                }
                return (count / quant);
            }
            else if (Fase == "B" || Fase == "b")
            {
                foreach (Arquivos item in Lista)
                {
                    count += (item.ubrms / 100.00);
                    quant++;
                }
                return (count / quant);
            }
            else
            {
                foreach (Arquivos item in Lista)
                {
                    count += (item.ucrms / 100.00);
                    quant++;
                }
                return (count / quant);
            }
            
        }

        private void CriaArquivoRelatorio()
        {
            /*
             Este metodo cria um arquivo de configuração para ser utilizado no relatorio
             */
            string path = Environment.CurrentDirectory + @"\temp\DateReport.txt";

            double ConsumoMaximo = CalculaConsumo("maximo", listArquivos);
            double ConsumoMinimo = CalculaConsumo("minimo", listArquivos);
            double ConsumoMedio = CalculaConsumo("media", listArquivos); 
            double ConsumoReal = ConsumoMaximo - ConsumoMinimo;
            double ConsumoReais = ConsumoReal * TarifaAtual;

            double TensaoA = CalculaTensao("a", listArquivos);
            double TensaoB = CalculaTensao("b", listArquivos);
            double TensaoC = CalculaTensao("c", listArquivos);
            double MediaTensao = ((TensaoA + TensaoB + TensaoC) / 3);

            string mensagem = NomeEquiSelected + ":"+ ConsumoReal + ":" + ConsumoReais + ":" + ConsumoMedio + ":" + MediaTensao + ":";

            StreamWriter write = new StreamWriter(path);
            write.WriteLine(mensagem);
            write.Flush();      // limpa o buffer de memoria
            write.Dispose();    // libera recursos de escrita
            write.Close();      // IMPORTANTE so depois que fecha que grava
            //MessageBox.Show("Gravação realizada com Sucesso!!!");
        }
    }
}
