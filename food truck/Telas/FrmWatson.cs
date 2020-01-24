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
    public partial class FrmWatson : Form
    {
        public FrmWatson()
        {
            InitializeComponent();
        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            mciSendString("open new Type waveaudio alias meuaudio", null, 0, IntPtr.Zero);
            mciSendString("record meuaudio", null, 0, IntPtr.Zero);
        }

        private void Parar_Click(object sender, EventArgs e)
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

        [System.Runtime.InteropServices.DllImport("winmm.dll")]

        private static extern long mciSendString(string comando, StringBuilder sb, int length, IntPtr cb);


    }
}
