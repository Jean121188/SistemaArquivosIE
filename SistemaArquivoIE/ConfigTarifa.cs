using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaArquivoIE
{
    public partial class ConfigTarifa : Form
    {
        public double tarifa { get; set; }

        public ConfigTarifa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarifa = double.Parse(txtTarifa.Text);
            this.Close();
        }
    }
}
