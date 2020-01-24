using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.SpeechToText.v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_truck.Telas
{
    public partial class DesignPanelMenu : Form
    {
        public DesignPanelMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Telas.FrmFornedor fornecedor = new Telas.FrmFornedor();
            fornecedor.Show();
            this.Hide();
        }

        private void btnDespGastos_Click(object sender, EventArgs e)
        {
            Telas.FrmFinanceiro fine = new FrmFinanceiro();

            fine.Show();
            
      
            this.Hide();

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            telas.Estoque estoque = new telas.Estoque();
            estoque.Show();
            this.Hide();

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Telas.FrmFinanceiro finan = new FrmFinanceiro();
            finan.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJornadaDeTrab_Click(object sender, EventArgs e)
        {

        }

        private void DesignPanelMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel2.Visible = true;

                mciSendString("open new Type waveaudio alias meuaudio", null, 0, IntPtr.Zero);
                mciSendString("record meuaudio", null, 0, IntPtr.Zero);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                mciSendString("save meuaudio arquivo.wav", null, 0, IntPtr.Zero);
                mciSendString("close meuaudio", null, 0, IntPtr.Zero);


                IamAuthenticator authenticator = new IamAuthenticator(
                   apikey: "0glqYYg5lpaDz2LNStEFtvowIdC0ditJf-3QnGsO5rfr");

                SpeechToTextService service = new SpeechToTextService(authenticator);
                service.SetServiceUrl("https://stream.watsonplatform.net/speech-to-text/api");

                var result = service.Recognize(
                    audio: File.ReadAllBytes("arquivo.wav"),
                    contentType: "audio/wav",
                    model: "pt-BR_NarrowbandModel");



                string voz = result.Result.Results.First().Alternatives.First().Transcript;


                if (voz.Contains("mensagem"))
                {
                    Telas.FrmWhatsApp wpp = new FrmWhatsApp();

                    wpp.Show();

                    this.Hide();

                }

                if (voz.Contains("fornecedor"))
                {
                    Telas.FrmFornedor wpp = new FrmFornedor();

                    wpp.Show();

                    this.Hide();

                }

                if (voz.Contains("estoque"))
                {
                    telas.Estoque wpp = new telas.Estoque();

                    wpp.Show();

                    this.Hide();

                }

                if (voz.Contains("financeiro"))
                {
                    Telas.FrmFinanceiro wpp = new FrmFinanceiro();

                    wpp.Show();

                    this.Hide();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }


        }

        [System.Runtime.InteropServices.DllImport("winmm.dll")]

        private static extern long mciSendString(string comando, StringBuilder sb, int length, IntPtr cb);
    }

}
