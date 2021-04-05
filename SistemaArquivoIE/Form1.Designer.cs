
namespace SistemaArquivoIE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeMedidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoDaAnaliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirAnterioresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolImportar = new System.Windows.Forms.ToolStripButton();
            this.toolSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolExportar = new System.Windows.Forms.ToolStripButton();
            this.toolRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.process = new System.Windows.Forms.ToolStripProgressBar();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsumo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConsMedio = new System.Windows.Forms.TextBox();
            this.txtConsMinimo = new System.Windows.Forms.TextBox();
            this.txtConsMaximo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartConsumo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabTensao = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMediaC = new System.Windows.Forms.Label();
            this.lblMediaB = new System.Windows.Forms.Label();
            this.lblMediaA = new System.Windows.Forms.Label();
            this.GraficoTensao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.listViewDate = new System.Windows.Forms.ListView();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabConsumo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).BeginInit();
            this.tabTensao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoTensao)).BeginInit();
            this.tabDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.configurarToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.toolStripTextBox1,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripSeparator1,
            this.importarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.abrirToolStripMenuItem.Text = "Abrir ";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeMedidorToolStripMenuItem,
            this.configuraçãoGeralToolStripMenuItem,
            this.configuraçãoDaAnaliseToolStripMenuItem});
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // tipoDeMedidorToolStripMenuItem
            // 
            this.tipoDeMedidorToolStripMenuItem.Name = "tipoDeMedidorToolStripMenuItem";
            this.tipoDeMedidorToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.tipoDeMedidorToolStripMenuItem.Text = "Equipamento";
            this.tipoDeMedidorToolStripMenuItem.Click += new System.EventHandler(this.tipoDeMedidorToolStripMenuItem_Click);
            // 
            // configuraçãoGeralToolStripMenuItem
            // 
            this.configuraçãoGeralToolStripMenuItem.Name = "configuraçãoGeralToolStripMenuItem";
            this.configuraçãoGeralToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.configuraçãoGeralToolStripMenuItem.Text = "Configuração Geral";
            this.configuraçãoGeralToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoGeralToolStripMenuItem_Click);
            // 
            // configuraçãoDaAnaliseToolStripMenuItem
            // 
            this.configuraçãoDaAnaliseToolStripMenuItem.Name = "configuraçãoDaAnaliseToolStripMenuItem";
            this.configuraçãoDaAnaliseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.configuraçãoDaAnaliseToolStripMenuItem.Text = "Configuração da Analise";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.abrirAnterioresToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // gerarToolStripMenuItem
            // 
            this.gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            this.gerarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.gerarToolStripMenuItem.Text = "Gerar";
            this.gerarToolStripMenuItem.Click += new System.EventHandler(this.gerarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // abrirAnterioresToolStripMenuItem
            // 
            this.abrirAnterioresToolStripMenuItem.Name = "abrirAnterioresToolStripMenuItem";
            this.abrirAnterioresToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.abrirAnterioresToolStripMenuItem.Text = "Abrir Anteriores";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 23);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(42, 23);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolImportar,
            this.toolSalvar,
            this.toolExportar,
            this.toolRun,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolImportar
            // 
            this.toolImportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolImportar.Image = global::SistemaArquivoIE.Properties.Resources.import;
            this.toolImportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolImportar.Name = "toolImportar";
            this.toolImportar.Size = new System.Drawing.Size(23, 22);
            this.toolImportar.Text = "toolStripButton1";
            this.toolImportar.ToolTipText = "Importar";
            this.toolImportar.Click += new System.EventHandler(this.toolImportar_Click);
            // 
            // toolSalvar
            // 
            this.toolSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSalvar.Image = global::SistemaArquivoIE.Properties.Resources.save;
            this.toolSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSalvar.Name = "toolSalvar";
            this.toolSalvar.Size = new System.Drawing.Size(23, 22);
            this.toolSalvar.Text = "toolStripButton2";
            this.toolSalvar.ToolTipText = "Salvar";
            // 
            // toolExportar
            // 
            this.toolExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolExportar.Image = global::SistemaArquivoIE.Properties.Resources.pasta;
            this.toolExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExportar.Name = "toolExportar";
            this.toolExportar.Size = new System.Drawing.Size(23, 22);
            this.toolExportar.Text = "toolStripButton3";
            this.toolExportar.ToolTipText = "Exportar";
            // 
            // toolRun
            // 
            this.toolRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRun.Image = global::SistemaArquivoIE.Properties.Resources.run;
            this.toolRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRun.Name = "toolRun";
            this.toolRun.Size = new System.Drawing.Size(23, 22);
            this.toolRun.Text = "toolStripButton4";
            this.toolRun.ToolTipText = "Executar";
            this.toolRun.Click += new System.EventHandler(this.toolRun_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.process});
            this.status.Location = new System.Drawing.Point(0, 565);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(922, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Satuts: ";
            // 
            // process
            // 
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(100, 16);
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(12, 55);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(175, 507);
            this.treeView.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConsumo);
            this.tabControl1.Controls.Add(this.tabTensao);
            this.tabControl1.Controls.Add(this.tabDados);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(193, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 507);
            this.tabControl1.TabIndex = 4;
            // 
            // tabConsumo
            // 
            this.tabConsumo.Controls.Add(this.groupBox1);
            this.tabConsumo.Controls.Add(this.chartConsumo);
            this.tabConsumo.Location = new System.Drawing.Point(4, 25);
            this.tabConsumo.Name = "tabConsumo";
            this.tabConsumo.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsumo.Size = new System.Drawing.Size(721, 478);
            this.tabConsumo.TabIndex = 0;
            this.tabConsumo.Text = "Consumo";
            this.tabConsumo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConsMedio);
            this.groupBox1.Controls.Add(this.txtConsMinimo);
            this.groupBox1.Controls.Add(this.txtConsMaximo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analises";
            // 
            // txtConsMedio
            // 
            this.txtConsMedio.Enabled = false;
            this.txtConsMedio.Location = new System.Drawing.Point(586, 28);
            this.txtConsMedio.Name = "txtConsMedio";
            this.txtConsMedio.Size = new System.Drawing.Size(100, 22);
            this.txtConsMedio.TabIndex = 5;
            // 
            // txtConsMinimo
            // 
            this.txtConsMinimo.Enabled = false;
            this.txtConsMinimo.Location = new System.Drawing.Point(350, 31);
            this.txtConsMinimo.Name = "txtConsMinimo";
            this.txtConsMinimo.Size = new System.Drawing.Size(100, 22);
            this.txtConsMinimo.TabIndex = 4;
            // 
            // txtConsMaximo
            // 
            this.txtConsMaximo.Enabled = false;
            this.txtConsMaximo.Location = new System.Drawing.Point(121, 31);
            this.txtConsMaximo.Name = "txtConsMaximo";
            this.txtConsMaximo.Size = new System.Drawing.Size(100, 22);
            this.txtConsMaximo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Consumo Médio: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Consumo Mínimo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Consumo Máximo: ";
            // 
            // chartConsumo
            // 
            this.chartConsumo.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartConsumo.ChartAreas.Add(chartArea1);
            this.chartConsumo.Location = new System.Drawing.Point(6, 6);
            this.chartConsumo.Name = "chartConsumo";
            this.chartConsumo.Size = new System.Drawing.Size(707, 403);
            this.chartConsumo.TabIndex = 0;
            this.chartConsumo.Text = "chart2";
            // 
            // tabTensao
            // 
            this.tabTensao.BackColor = System.Drawing.Color.Transparent;
            this.tabTensao.Controls.Add(this.label3);
            this.tabTensao.Controls.Add(this.label2);
            this.tabTensao.Controls.Add(this.label1);
            this.tabTensao.Controls.Add(this.lblMediaC);
            this.tabTensao.Controls.Add(this.lblMediaB);
            this.tabTensao.Controls.Add(this.lblMediaA);
            this.tabTensao.Controls.Add(this.GraficoTensao);
            this.tabTensao.Location = new System.Drawing.Point(4, 25);
            this.tabTensao.Name = "tabTensao";
            this.tabTensao.Padding = new System.Windows.Forms.Padding(3);
            this.tabTensao.Size = new System.Drawing.Size(721, 478);
            this.tabTensao.TabIndex = 1;
            this.tabTensao.Text = "Tensão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Media Fase C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Media Fase B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Media Fase A:";
            // 
            // lblMediaC
            // 
            this.lblMediaC.AutoSize = true;
            this.lblMediaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaC.Location = new System.Drawing.Point(400, 444);
            this.lblMediaC.Name = "lblMediaC";
            this.lblMediaC.Size = new System.Drawing.Size(52, 16);
            this.lblMediaC.TabIndex = 3;
            this.lblMediaC.Text = "###.##";
            // 
            // lblMediaB
            // 
            this.lblMediaB.AutoSize = true;
            this.lblMediaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaB.Location = new System.Drawing.Point(251, 444);
            this.lblMediaB.Name = "lblMediaB";
            this.lblMediaB.Size = new System.Drawing.Size(52, 16);
            this.lblMediaB.TabIndex = 2;
            this.lblMediaB.Text = "###.##";
            // 
            // lblMediaA
            // 
            this.lblMediaA.AutoSize = true;
            this.lblMediaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaA.Location = new System.Drawing.Point(102, 444);
            this.lblMediaA.Name = "lblMediaA";
            this.lblMediaA.Size = new System.Drawing.Size(52, 16);
            this.lblMediaA.TabIndex = 1;
            this.lblMediaA.Text = "###.##";
            // 
            // GraficoTensao
            // 
            chartArea2.Name = "ChartArea1";
            this.GraficoTensao.ChartAreas.Add(chartArea2);
            this.GraficoTensao.Location = new System.Drawing.Point(6, 6);
            this.GraficoTensao.Name = "GraficoTensao";
            this.GraficoTensao.Size = new System.Drawing.Size(707, 421);
            this.GraficoTensao.TabIndex = 0;
            this.GraficoTensao.Text = "chart1";
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.listViewDate);
            this.tabDados.Location = new System.Drawing.Point(4, 25);
            this.tabDados.Name = "tabDados";
            this.tabDados.Size = new System.Drawing.Size(721, 478);
            this.tabDados.TabIndex = 2;
            this.tabDados.Text = "Dados";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // listViewDate
            // 
            this.listViewDate.FullRowSelect = true;
            this.listViewDate.GridLines = true;
            this.listViewDate.Location = new System.Drawing.Point(3, 0);
            this.listViewDate.Name = "listViewDate";
            this.listViewDate.Size = new System.Drawing.Size(718, 472);
            this.listViewDate.TabIndex = 0;
            this.listViewDate.UseCompatibleStateImageBehavior = false;
            this.listViewDate.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 587);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.status);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Visualização de Arquivos de Consumo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabConsumo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).EndInit();
            this.tabTensao.ResumeLayout(false);
            this.tabTensao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoTensao)).EndInit();
            this.tabDados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMedidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoDaAnaliseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirAnterioresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolImportar;
        private System.Windows.Forms.ToolStripButton toolSalvar;
        private System.Windows.Forms.ToolStripButton toolExportar;
        private System.Windows.Forms.ToolStripButton toolRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar process;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsumo;
        private System.Windows.Forms.TabPage tabTensao;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.ListView listViewDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoTensao;
        private System.Windows.Forms.Label lblMediaA;
        private System.Windows.Forms.Label lblMediaB;
        private System.Windows.Forms.Label lblMediaC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConsumo;
        private System.Windows.Forms.TextBox txtConsMaximo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsMedio;
        private System.Windows.Forms.TextBox txtConsMinimo;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

