using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMef730
{
    public partial class Form1 : Form
    {
        private string pin_cifrato = "txIO+4Z3DqZvxrol9o6KmkQjlWSD4SOLdeUigRadhoxVNv7rM3RytJlT1jCHdMEg337cD3D1bvYd/uFLeBT+uZzzZy67Rx5UlWD6bvqXlRQjAMxDH/oGcsxmLtBqLPe8i/ZHdiE1xgEPWj+OX6bOdZJOaQgCa9LY8WQaWOWSvbA=";
        private string cfProprietario = "CCSRMO77A09H501E";
        //private string pIva = "03213213210";

        private string endpoint_coinfiguration_name = "InvioTelematicoSS730pMtomPort";
        private string test_remote_address = "https://invioSS730pTest.sanita.finanze.it/InvioTelematicoSS730pMtomWeb/InvioTelematicoSS730pMtomPort";
        private string remote_address = "https://invioSS730p.sanita.finanze.it/InvioTelematicoSS730pMtomWeb/InvioTelematicoSS730pMtomPort";

        private InvioFlussi730.InvioTelematicoSS730pMtomClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
        }

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            this.client = new InvioFlussi730.InvioTelematicoSS730pMtomClient(this.endpoint_coinfiguration_name, this.test_remote_address);
            this.sendRequest();
        }

        private void btnInvio_Click(object sender, EventArgs e)
        {
            this.client = new InvioFlussi730.InvioTelematicoSS730pMtomClient(this.endpoint_coinfiguration_name, this.remote_address);
            this.sendRequest();
        }

        private void sendRequest()
        {
            InvioFlussi730.inviaFileMtomRequest req = new InvioFlussi730.inviaFileMtomRequest();
            InvioFlussi730.inviaFileMtomResponse reesp = new InvioFlussi730.inviaFileMtomResponse();

            InvioFlussi730.proprietario proprietario = new InvioFlussi730.proprietario();

            proprietario.cfProprietario = this.cfProprietario;
            proprietario.codiceAsl = txtASL.Text;
            proprietario.codiceRegione = txtRegione.Text;
            proprietario.codiceSSA = txtSSA.Text;

            req.datiProprietario = proprietario;
            req.nomeFileAllegato = "strutturaAccreditata.zip";
            req.opzionale1 = "";
            req.opzionale2 = "";
            req.opzionale3 = "";

            req.documento = System.IO.File.ReadAllBytes(txtFileName.Text);
            req.pincodeInvianteCifrato = this.pin_cifrato;

            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(
                Object obj, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
                {
                    return (true);
                };

            this.client.Endpoint.EndpointBehaviors.Add(new BasicAuthenticationBehavior(txtUsername.Text, txtPassword.Text));

            InvioFlussi730.ricevutaInvio ricevuta = this.client.inviaFileMtom(
                req.nomeFileAllegato, 
                req.pincodeInvianteCifrato, 
                req.datiProprietario, 
                req.opzionale1, 
                req.opzionale2, 
                req.opzionale3, 
                req.documento);

            txtResponse.Text = "Esito: " + ricevuta.codiceEsito + "\nDescrizione esito: " + ricevuta.descrizioneEsito;
        }
    }
}
