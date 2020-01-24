using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.SpeechToText.v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace food_truck.Telas
{
    public partial class FrmWhatsApp : Form
    {
        public FrmWhatsApp()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Telas.DesignPanelMenu menu = new DesignPanelMenu();

            menu.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string tele = txtNumero.Text;
                string mensagem = txtMensagem.Text;


                this.Wpp(tele, mensagem);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }

        }

        private void SMS (string numero, string mensagem)
        {
            try
            {
                numero = numero.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;


                TwilioClient.Init("AC49edf4d16d907503563bd9e549917aca", "6edced3c88d64b42589189d954a03549");


                var message = MessageResource.Create(
                   new PhoneNumber(numero),
                   from: new PhoneNumber("+18176592132"),
                    body: mensagem);


                MessageBox.Show("Mensagem Enviada com Sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }


        }

        private void Wpp(string numero, string mensagem)
        {
            try
            {
                numero = numero.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

               TwilioClient.Init("AC49edf4d16d907503563bd9e549917aca", "6edced3c88d64b42589189d954a03549");


                   var message = MessageResource.Create(
                   new PhoneNumber("whatsapp:" + numero),
                   from: new PhoneNumber("whatsapp:+14155238886"),
                   body: mensagem);

                MessageBox.Show("Mensagem Enviada com Sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string tele = txtNumero.Text;
                string mensagem = txtMensagem.Text;

                this.SMS(tele, mensagem);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                mciSendString("open new Type waveaudio alias meuaudio", null, 0, IntPtr.Zero);
                mciSendString("record meuaudio", null, 0, IntPtr.Zero);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }
        }

        private void button4_Click(object sender, EventArgs e)
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


                txtMensagem.Text = voz;
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
