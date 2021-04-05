using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaArquivoIE
{
    class Report
    {
        public string NomeEquipamento { get; set; }
        public double ConsumoReal { get; set; }
        public double ConsumoEmReais { get; set; }
        public double ConsumoMedio { get; set; }
        public double TensaoMedia { get; set; }

        public void PuxaDados(string caminho)
        {
            //List<Report> lista = new List<Report>();
            
            string[] ArqText = File.ReadAllLines(caminho);
            
            for (int i = 0; i < ArqText.Length; i++)
            {
                string[] aux = ArqText[i].Split(':');
                //Report rep = new Report();

                NomeEquipamento = aux[0];
                ConsumoReal = double.Parse(aux[1]);
                ConsumoEmReais = double.Parse(aux[2]);
                ConsumoMedio = double.Parse(aux[3]);
                TensaoMedia = double.Parse(aux[4]);

                //lista.Add(rep);
            }
        }
    }
}
