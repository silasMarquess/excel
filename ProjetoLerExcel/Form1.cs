using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLerExcel.Entidade;
using ProjetoLerExcel.Controler;
using System.IO;

namespace ProjetoLerExcel
{
    public partial class Form1 : Form
    {
        private string _urlEntrada = string.Empty;
        private string _urlSaida = string.Empty;
        private string _urlSiadaPrimario = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomePlanilha.Text == string.Empty) throw new DomainException("Nome da planilha é obrigatorio");
                if (txtCaminhoEntrada.Text == string.Empty) throw new DomainException("Erro: Nemhuma planilha selecionada selecionado");
                if (txtSaidaCaminho.Text == string.Empty) throw new DomainException("erro: Nemhum caminho de saida selecionado");
                if (txtNomeDaPlanilhaAnalise.Text == string.Empty) throw new DomainException("Erro: informe o nome correto  da planilha de análise,Obdecendo maicuscula e minusculas");


                List<ProdutoPeca> lista = ReadArquivo.getListaProdutoEPP(_urlEntrada, txtNomeDaPlanilhaAnalise.Text.Trim());

                int i = 0;
                ReadArquivo.GerarPlanilha(_urlEntrada, lista);
                MessageBox.Show("Operação Realizada com sucesso");

                _urlEntrada = string.Empty;
                _urlSaida = string.Empty;
                _urlSiadaPrimario = string.Empty;
                txtCaminhoEntrada.Text = string.Empty;
                txtSaidaCaminho.Text = string.Empty;
                txtNomePlanilha.Text = string.Empty;
                txtNomeDaPlanilhaAnalise.Text = string.Empty;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DomainException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show("Erro: O nome da planilha de análise está incorreto");

            }catch(System.InvalidOperationException ex)
            {
                MessageBox.Show("Erro: A planilha que vc selecionou deve ser feixada no excel primeiro para o progama possa modificá-la");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = @"C:\Users\silas\OneDrive\Documentos";
                fileDialog.Filter = "xlsx Files (*.xlsx)|*.xlsx";


                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    _urlEntrada = fileDialog.FileName;
                    txtCaminhoEntrada.Text = _urlEntrada;
                }
            }
        }

        private void btn_SelecionarPastaSaida_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCaminhoEntrada.Text == string.Empty) throw new DomainException("Erro: nemhuma Planilha Selecionada");
                FolderBrowserDialog s = new FolderBrowserDialog();
                if (s.ShowDialog() == DialogResult.OK)
                {
                    _urlSiadaPrimario = s.SelectedPath;
                    _urlSaida = _urlSiadaPrimario;
                    txtSaidaCaminho.Text = _urlSaida;
                }
            }
            catch (DomainException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNomePlanilha_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_urlSaida == string.Empty)
                {
                    txtNomePlanilha.Text = string.Empty;
                    throw new DomainException("Caminho saida não pode ser vazio");
                }
                string nome = txtNomePlanilha.Text;
                _urlSaida = _urlSiadaPrimario + @"\" + nome.Trim() + ".xlsx";
                txtSaidaCaminho.Text = _urlSaida;
            }
            catch (DomainException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
