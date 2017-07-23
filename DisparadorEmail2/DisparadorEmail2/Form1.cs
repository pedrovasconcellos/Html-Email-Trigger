using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices; // ativamento da leitura do excell MARSHAL
using Excel = Microsoft.Office.Interop.Excel;

namespace DisparadorEmail2
{
    public partial class Form1 : Form
    {
        // ALTERAR - INICIO
        private string fromEmail = "envio@empresa.com.br";
        private string smtpEmail = "smtp.com.br";
        private string assuntoEmail = "Assunto";
        private string folder => @"C:\EnvioDeEmailExcel\";
        
        private string excelNomeArquivo => "EnvioDeEmailExcel.xlsx";

        private string path => Path.Combine(
                        @"c:\users\pedro.vasconcellos\documents\visual studio 2015\Projects\",
                                 @"DisparadorEmail2\DisparadorEmail2\Campanha.html");
        // ALTERAR - FIM

        private int pularLinhaExcel;
        private int excelAba;
        private string caminhoImportacao
        {
            get
            {
                return Path.Combine(folder, excelNomeArquivo);
            }
        }

        public Form1()
        {
            InitializeComponent();

            lblFolder.Text = folder;
            lblExcelNomeArquivo.Text = excelNomeArquivo;
            cbxExcelAba.SelectedIndex = 0;
            cbxPularLinha.SelectedIndex = 1;

            if (!Directory.Exists(folder))
            {

                Directory.CreateDirectory(folder);
                MessageBox.Show(
                    String.Concat(
                        "O Diretório " , folder , " foi criado com sucesso!",
                        " Por favor utilize este diretório para armazenar a planilha que será importada.")
                    );
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            excelAba = Convert.ToInt32(cbxExcelAba.SelectedItem);
            pularLinhaExcel = Convert.ToInt32(cbxPularLinha.SelectedItem);

            List<Empresa> empresas = BuscarEmailNoExcel();
            try
            {
                foreach (var empresa in empresas)
                {
                    EnviarEmail(empresa);
                }
                MessageBox.Show(@"Todos os E-mails foram enviados!");
            }
            catch (Exception)
            {
                throw new Exception("ERRO");
            }

        }

        public List<Empresa> BuscarEmailNoExcel()
        {
            var empresas = new List<Empresa>();
            
            if (File.Exists(caminhoImportacao))
            {
                try
                {
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(caminhoImportacao);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[excelAba];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;

                    for (int i = 1 + pularLinhaExcel; i <= rowCount + pularLinhaExcel; i++)
                    {
                        var empresa = new Empresa();
                        empresa.Email = xlWorksheet.Cells[i, 1].Value;
                        empresas.Add(empresa);
                    }

                    //FECHANDO OS PROCESSOS
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //OBS:nunca use dois pontos, todos os objetos COM devem ser referenciados e liberados individualmente
                    //Liberar objetos com para matar completamente excel processo de execução em segundo plano
                    Marshal.ReleaseComObject(xlRange);
                    Marshal.ReleaseComObject(xlWorksheet);
                    xlWorkbook.Close();
                    Marshal.ReleaseComObject(xlWorkbook);
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                    //FECHANDO OS PROCESSOS
                }
                catch (Exception)
                {
                    throw;
                }


            }
            return empresas;
        }

        public void EnviarEmail(Empresa empresa)
        {

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (empresa.Email != null)
            {

                if (rg.IsMatch(empresa.Email))
                {

                    string html = File.ReadAllText(path);

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                    //html = html.Replace("@Nome_Agente", empresa.Nome_Agente);
                    html = html.Replace("@Email_Agente", empresa.Email);


                    MailMessage msg = new System.Net.Mail.MailMessage();
                    SmtpClient smtp = new System.Net.Mail.SmtpClient(smtpEmail);
                    msg.From = new System.Net.Mail.MailAddress(fromEmail);
                    msg.To.Add(new System.Net.Mail.MailAddress(empresa.Email));
                    msg.IsBodyHtml = true;
                    msg.Subject = assuntoEmail;
                    msg.Body = html;
                    try
                    {
                        smtp.Send(msg);
                    }
                    catch (Exception e)
                    {

                    }
                    finally
                    {
                        msg.Dispose();
                    }

                }
            }
        }
        private void btnAbrirPlanilha_Click(object sender, EventArgs e)
        {
            if (excelNomeArquivo != "")
            {
                try
                {
                    System.Diagnostics.Process.Start(caminhoImportacao);
                }
                catch
                {
                    MessageBox.Show(@"Planilha não encontrada");
                }
            }
            else
            {
                MessageBox.Show(@"Escreva o nome da planilha que você deseja abrir");
            }
        }
        private void btnAbrirDiretorio_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(folder);
            }
            catch
            {
                MessageBox.Show(@"Diretório não encontrador");
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
