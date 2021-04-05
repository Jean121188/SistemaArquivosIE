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
    public partial class FormConfigEquipamento : Form
    {
        
        public int EquipSelect { get; set; }
        public string NomeEquipSel { get; set; }

        public FormConfigEquipamento()
        {
            InitializeComponent();
            comboEquip.SelectedIndex = 0;
        }

        private void comboEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipSelect = comboEquip.SelectedIndex;
            
            if (comboEquip.SelectedIndex == 1) // SMW-Lite
            {
                checkHoras.Checked = true;
                checkMinutos.Checked = true;
                checkSegundos.Checked = true;
                checkPotAtFaseA.Checked = true;
            }else if(comboEquip.SelectedIndex == 2) // SM-2W Lite (Bifásico)
            {
                checkHoras.Checked = true;
                checkMinutos.Checked = true;
                checkSegundos.Checked = true;
                checkPotAtFaseA.Checked = true;
                checkPotAtFaseB.Checked = true;
                checkPotAtTotal.Checked = true;
                checkTensaoFaseA.Checked = true;
                checkTensaoFaseB.Checked = true;
                checkCorrentFaseA.Checked = true;
                checkCorrentFaseB.Checked = true;
                checkConAtTotal.Checked = true;
            }
            else if (comboEquip.SelectedIndex == 3) // SM-2W Lite (Bifásico Bidirecional)
            {
                checkHoras.Checked = true;
                checkMinutos.Checked = true;
                checkSegundos.Checked = true;
                checkPotAtFaseA.Checked = true;
                checkPotAtFaseB.Checked = true;
                checkPotAtTotal.Checked = true;
                checkTensaoFaseA.Checked = true;
                checkTensaoFaseB.Checked = true;
                checkCorrentFaseA.Checked = true;
                checkCorrentFaseB.Checked = true;
                checkConAtTotal.Checked = true;
            }
            else if (comboEquip.SelectedIndex == 4) // SM-3W Lite (Trifásico)
            {
                checkHoras.Checked = true;
                checkMinutos.Checked = true;
                checkSegundos.Checked = true;
                checkPotAtFaseA.Checked = true;
                checkPotAtFaseB.Checked = true;
                checkPotAtFaseC.Checked = true;
                checkPotAtTotal.Checked = true;
                checkTensaoFaseA.Checked = true;
                checkTensaoFaseB.Checked = true;
                checkTensaoFaseC.Checked = true;
                checkCorrentFaseA.Checked = true;
                checkCorrentFaseB.Checked = true;
                checkCorrentFaseC.Checked = true;
                checkConAtTotal.Checked = true;
            }
            else if (comboEquip.SelectedIndex == 5) // SM-3W Lite (Trifásico Bidirecional)
            {
                checkHoras.Checked = true;
                checkMinutos.Checked = true;
                checkSegundos.Checked = true;
                checkPotAtFaseA.Checked = true;
                checkPotAtFaseB.Checked = true;
                checkPotAtFaseC.Checked = true;
                checkPotAtTotal.Checked = true;
                checkTensaoFaseA.Checked = true;
                checkTensaoFaseB.Checked = true;
                checkTensaoFaseC.Checked = true;
                checkCorrentFaseA.Checked = true;
                checkCorrentFaseB.Checked = true;
                checkCorrentFaseC.Checked = true;
                checkConAtTotal.Checked = true;
            }
            else if(comboEquip.SelectedIndex == 6) // SM-3W (Trifásico)
            {
                checkPotAtFaseA.Checked = true;
                checkPotAtFaseB.Checked = true;
                checkPotAtFaseC.Checked = true;
                checkPotAtTotal.Checked = true;
                checkPotReFaseA.Checked = true;
                checkPotReFaseB.Checked = true;
                checkPotReFaseC.Checked = true;
                checkPotReTotal.Checked = true;
                checkPotApFaseA.Checked = true;
                checkPotApFaseB.Checked = true;
                checkPotApFaseC.Checked = true;
                checkPotApTotal.Checked = true;
                checkTensaoFaseA.Checked = true;
                checkTensaoFaseB.Checked = true;
                checkTensaoFaseC.Checked = true;
                checkTensaoTotal.Checked = true;
                checkCorrentFaseA.Checked = true;
                checkCorrentFaseB.Checked = true;
                checkCorrentFaseC.Checked = true;
                checkCorrentTotal.Checked = true;
                checkfpFaseA.Checked = true;
                checkfpFaseB.Checked = true;
                checkfpFaseC.Checked = true;
                checkfpTotal.Checked = true;
                checkConAtFaseA.Checked = true;
                checkConAtFaseB.Checked = true;
                checkConAtFaseC.Checked = true;
                checkConAtTotal.Checked = true;
                checkConReFaseA.Checked = true;
                checkConReFaseB.Checked = true;
                checkConReFaseC.Checked = true;
                checkConReTotal.Checked = true;
                checkFreq.Checked = true;
                checkTemp.Checked = true;
                checkAngTFaseAB.Checked = true;
                checkAngTFaseBC.Checked = true;
                checkAngTFaseCA.Checked = true;
                checkDefFaseA.Checked = true;
                checkDefFaseB.Checked = true;
                checkDefFaseC.Checked = true;
                checkDefTotal.Checked = true;
                checkHoras.Checked = true;
                checkMinutos.Checked = true;
                checkSegundos.Checked = true;
            }
            else if (comboEquip.SelectedIndex == 7) // ------------------------------------
            {
                MessageBox.Show("Esta opção não é Valida...");
                return;
            }
            else if(comboEquip.SelectedIndex == 8) // Hidrometro
            {

            }
            else // Temperatura
            {

            }
            labelteste.Text = comboEquip.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboEquip.SelectedIndex == 0)
            {
                MessageBox.Show("A opção Selecione não é um equipamento para analise", 
                    "ERRO", MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            EquipSelect = comboEquip.SelectedIndex;
            NomeEquipSel = comboEquip.Text;
            Close();
        }
    }
}
