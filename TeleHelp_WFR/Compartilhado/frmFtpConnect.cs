using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace TeleHelp_WFR.Compartilhado
{
    public partial class frmFtpConnect : Form
    {
        Label lblTotalArquivo;
        FtpWebRequest request;
        int totalFile;
        readonly Timer timer = new Timer();

        public frmFtpConnect()
        {
            InitializeComponent();
            lblTotalArquivo = new Label();
            request = (FtpWebRequest)WebRequest.Create(new Uri("www.myftpfile.com/Tecnologia"));
            timer.Interval = 10000;
            timer.Tick += PercorreFtp;
            totalFile = 0;
        }
        ~frmFtpConnect()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void PercorreFtp(object sender, EventArgs e)
        {
            try
            {
                //DOWNLOAD DO ARQUIVO
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential("user", "pass");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                byte[] buffer = new byte[2048];
                FileStream newFile = new FileStream(@"c:\\Documents\\", FileMode.Create); 
                int readCount = responseStream.Read(buffer, 0, buffer.Length);
                while (readCount > 0)
                {
                    newFile.Write(buffer, 0, readCount);
                    readCount = responseStream.Read(buffer, 0, buffer.Length);
                    totalFile++;
                    //ALIMENTA A LABEL INFORMANDO O TOTAL DE ARQUIVOS BAIXADOS
                    lblTotalArquivo.Text = totalFile.ToString();
                }
                newFile.Close();
                responseStream.Close();
                response.Close();

                // EXCLUSÃO DO ARQUIVO
                request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                FtpWebResponse _response = (FtpWebResponse)request.GetResponse();
                Stream _responseStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(responseStream);
                sr.ReadToEnd();
                string StatusCode = response.StatusDescription;
                sr.Close();
                response.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void frmFtpConnect_Load(object sender, EventArgs e)
        {
            try
            {
                timer.Start();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
