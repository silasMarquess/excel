﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using ProjetoLerExcel.Entidade;
using System.IO;
using OfficeOpenXml;
using System.Data.OleDb;

namespace ProjetoLerExcel.Controler
{
    class ReadArquivo
    {
        public static List<ProdutoPeca> ReadXla(string url, string nomePlanilha)
        {
            List<ProdutoPeca> lista = new List<ProdutoPeca>();
            string sql = "select * from ["+nomePlanilha+"$]";

            string UrlCon = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + url + ";Extended Properties=Excel 8.0";
            OleDbConnection con = new OleDbConnection(UrlCon);
            con.Open();

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ProdutoPeca p = new ProdutoPeca();
                p.Ordem = rd[1].ToString();
                p.Descricao = rd[2].ToString();
                p.Tag = rd[3].ToString();
                p.Status = rd[15].ToString();
                p.CheckList = rd[29].ToString();
                lista.Add(p);
                p.ProcessaCheckLis();
            }
            con.Close();
            return lista;
        }


        public static void GerarXLSx(List<ProdutoPeca> listaFonte, string urlSaida)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage pacote = new ExcelPackage();

            var workSheet = pacote.Workbook.Worksheets.Add("Planilha Derivada");
            workSheet.Row(1).Style.Font.Bold = true;

            workSheet.Cells[1, 1].Value = "ORDEM";
            workSheet.Cells[1, 2].Value = "DESCRICAO";
            workSheet.Cells[1, 3].Value = "TAG";
            workSheet.Cells[1, 4].Value = "STATUS";
            workSheet.Cells[1, 5].Value = "CHECKLIST";


            //AJUSTANDO AS COLUNAS
            workSheet.Column(1).AutoFit();
            workSheet.Column(2).AutoFit();
            workSheet.Column(3).AutoFit();
            workSheet.Column(4).AutoFit();
            workSheet.Column(5).AutoFit();


            int indece = 2;

            foreach (ProdutoPeca p in listaFonte)
            {
                foreach (string s in p.listaCheck)
                {
                    workSheet.Cells[indece, 1].Value = p.Ordem;
                    workSheet.Cells[indece, 2].Value = p.Descricao;
                    workSheet.Cells[indece, 3].Value = p.Tag;
                    workSheet.Cells[indece, 4].Value = p.Status;
                    workSheet.Cells[indece, 5].Value = s;
                    indece++;

                }

                if (p.listaCheck.Count != 0)
                {
                    workSheet.Cells[indece, 1].Value = "";
                    workSheet.Cells[indece, 2].Value = "";
                    workSheet.Cells[indece, 3].Value = "";
                    workSheet.Cells[indece, 4].Value = "";
                    workSheet.Cells[indece, 5].Value = "";
                    indece++;

                }
            }


            if (File.Exists(urlSaida)) File.Delete(urlSaida);

            FileStream fileS = File.Create(urlSaida);
            fileS.Close();

            File.WriteAllBytes(urlSaida, pacote.GetAsByteArray());

            pacote.Dispose();
            System.Windows.Forms.MessageBox.Show("Operação de Leitura Realizada e Nova Planilha Criada");
        }
    }
}
