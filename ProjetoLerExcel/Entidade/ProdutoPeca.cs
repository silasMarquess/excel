using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLerExcel.Entidade
{
    class ProdutoPeca
    {
        public string Ordem { get; set; }
        public string Descricao { get; set; }
        public string Tag { get; set; }
        public string Status { get; set; }

        public string CheckList { get; set; }
        public string Observação { get; set; }

        public List<string> listaCheck = new List<string>();

        public void ProcessaCheckLis()
        {
            listaCheck.Clear();
            string[] textoCortado = CheckList.Split('\n');

            foreach(string linha in textoCortado)
            {
                listaCheck.Add(linha);
            }
        }
    }
}
