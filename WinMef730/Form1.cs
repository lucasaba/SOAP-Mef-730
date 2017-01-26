using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMef730
{
    public partial class Form1 : Form
    {
        private string endpoint_coinfiguration_name = "InvioTelematicoSS730pMtomPort";
        private string test_remote_address = "https://invioSS730pTest.sanita.finanze.it/InvioTelematicoSS730pMtomWeb/InvioTelematicoSS730pMtomPort";
        private string remote_address = "https://invioSS730p.sanita.finanze.it/InvioTelematicoSS730pMtomWeb/InvioTelematicoSS730pMtomPort";

        private InvioFlussi730.InvioTelematicoSS730pMtomClient client;

        public Form1()
        {
            InitializeComponent();
            txtUsername.Text = ConfigurationManager.AppSettings["username"];
            txtPassword.Text = ConfigurationManager.AppSettings["password"];
            txtPin.Text = ConfigurationManager.AppSettings["pin"];
            txtCfProprietario.Text = ConfigurationManager.AppSettings["cf_proprietario"];
            txtRegione.Text = ConfigurationManager.AppSettings["codice_regione"];
            txtASL.Text = ConfigurationManager.AppSettings["codice_asl"];
            txtSSA.Text = ConfigurationManager.AppSettings["codice_ssa"];
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
            FileInfo finfo = new FileInfo(txtFileName.Text);
            InvioFlussi730.inviaFileMtomRequest req = new InvioFlussi730.inviaFileMtomRequest();
            InvioFlussi730.inviaFileMtomResponse reesp = new InvioFlussi730.inviaFileMtomResponse();

            InvioFlussi730.proprietario proprietario = new InvioFlussi730.proprietario();

            proprietario.cfProprietario = txtCfProprietario.Text;
            proprietario.codiceAsl = txtASL.Text;
            proprietario.codiceRegione = txtRegione.Text;
            proprietario.codiceSSA = txtSSA.Text;

            req.datiProprietario = proprietario;
            req.nomeFileAllegato = finfo.Name;
            req.opzionale1 = "";
            req.opzionale2 = "";
            req.opzionale3 = "";
            req.documento = File.ReadAllBytes(txtFileName.Text);
            req.pincodeInvianteCifrato = this.encode(txtPin.Text);

            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(
                Object obj, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
                {
                    return (true);
                };

            this.client.Endpoint.EndpointBehaviors.Add(new BasicAuthenticationBehavior(txtUsername.Text, txtPassword.Text));

            InvioFlussi730.ricevutaInvio ricevuta = null;
            try
            {
                ricevuta = this.client.inviaFileMtom(
                    req.nomeFileAllegato, 
                    req.pincodeInvianteCifrato, 
                    req.datiProprietario, 
                    req.opzionale1, 
                    req.opzionale2, 
                    req.opzionale3, 
                    req.documento);
            } catch (System.ServiceModel.CommunicationException e)
            {
                this.txtResponse.Text = e.Message;
                return;
            }
            

            txtResponse.Text = "Esito: " + ricevuta.codiceEsito +
                "\r\nDescrizione esito: " + ricevuta.descrizioneEsito +
                "\r\nProtocollo assegnato: " + ricevuta.protocollo;
        }

        private string encode(string stringa_da_codificare)
        {
            X509Certificate2 cert = new X509Certificate2(WinMef730.Resource1.SanitelCF);
            RSACryptoServiceProvider rsaCSP = (RSACryptoServiceProvider) cert.PublicKey.Key;

            Byte[] byt = System.Text.Encoding.ASCII.GetBytes(stringa_da_codificare);
            Byte[] bytout = rsaCSP.Encrypt(byt, false);

            return Convert.ToBase64String(bytout);
        }
    }
}
