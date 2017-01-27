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
        private string endpoint_configuration_name = "InvioTelematicoSS730pMtomPort";
        private string test_invio_telematico_remote_address = "https://invioSS730pTest.sanita.finanze.it/InvioTelematicoSS730pMtomWeb/InvioTelematicoSS730pMtomPort";
        private string invio_telematico_remote_address = "https://invioSS730p.sanita.finanze.it/InvioTelematicoSS730pMtomWeb/InvioTelematicoSS730pMtomPort";

        private string endpoint_ricevuta_pdf_name = "RicevutaPdf730Port";
        private string test_ricevute_pdf = "https://invioSS730pTest.sanita.finanze.it/Ricevute730ServiceWeb/ricevutePdf";
        private string ricevute_pdf = "https://invioSS730p.sanita.finanze.it/Ricevute730ServiceWeb/ricevutePdf";

        private InvioFlussi730.InvioTelematicoSS730pMtomClient clientInvio;
        private ServiceReference1.RicevutaPdf730Client clientRicevuta;

        public Form1()
        {
            InitializeComponent();
            /*
            txtUsername.Text = ConfigurationManager.AppSettings["username"];
            txtPassword.Text = ConfigurationManager.AppSettings["password"];
            txtPin.Text = ConfigurationManager.AppSettings["pin"];
            txtCfProprietario.Text = ConfigurationManager.AppSettings["cf_proprietario"];
            txtRegione.Text = ConfigurationManager.AppSettings["codice_regione"];
            txtASL.Text = ConfigurationManager.AppSettings["codice_asl"];
            txtSSA.Text = ConfigurationManager.AppSettings["codice_ssa"];*/
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
            this.clientInvio = new InvioFlussi730.InvioTelematicoSS730pMtomClient(this.endpoint_configuration_name, this.test_invio_telematico_remote_address);
            this.sendRequest();
        }

        private void btnInvio_Click(object sender, EventArgs e)
        {
            this.clientInvio = new InvioFlussi730.InvioTelematicoSS730pMtomClient(this.endpoint_configuration_name, this.invio_telematico_remote_address);
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

            this.clientInvio.Endpoint.EndpointBehaviors.Add(new BasicAuthenticationBehavior(txtUsername.Text, txtPassword.Text));

            InvioFlussi730.ricevutaInvio ricevuta = null;
            try
            {
                ricevuta = this.clientInvio.inviaFileMtom(
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

        /**
         * Gestione delle ricevute
         */
        private void btnRicevutaTest_Click(object sender, EventArgs e)
        {
            this.clientRicevuta = new ServiceReference1.RicevutaPdf730Client(this.endpoint_ricevuta_pdf_name, this.test_ricevute_pdf);
            this.sendRicevutaRequest();
        }
        
        private void btnRichiediRicevuta_Click(object sender, EventArgs e)
        {
            this.clientRicevuta = new ServiceReference1.RicevutaPdf730Client(this.endpoint_ricevuta_pdf_name, this.ricevute_pdf);
            this.sendRicevutaRequest();
        }

        private void sendRicevutaRequest()
        {
            ServiceReference1.RicevutaPdfRequest req = new ServiceReference1.RicevutaPdfRequest();
            ServiceReference1.RicevutaPdfResponse resp = new ServiceReference1.RicevutaPdfResponse();

            req.DatiInputRichiesta = new ServiceReference1.datiInput();
            req.DatiInputRichiesta.pinCode = this.encode(txtPin.Text);
            req.DatiInputRichiesta.protocollo = txtProtocollo.Text;

            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (
                Object obj, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
            {
                return (true);
            };

            this.clientRicevuta.Endpoint.EndpointBehaviors.Add(new BasicAuthenticationBehavior(txtUsername.Text, txtPassword.Text));

            ServiceReference1.datiInput datiIn = new ServiceReference1.datiInput();
            datiIn.pinCode = this.encode(txtPin.Text);
            datiIn.protocollo = txtProtocollo.Text;

            ServiceReference1.datiOutput datiOut = this.clientRicevuta.RicevutaPdf(datiIn);

            if(datiOut.esitiPositivi != null && datiOut.esitoChiamata == "1")
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string file = "Ricevuta_" + txtProtocollo.Text + ".pdf";
                string filename = path + '\\' + file;
                if(File.Exists(filename))
                {
                    DialogResult dr = MessageBox.Show(
                        "Il file " + filename + " esiste. Vuoi sovrascriverlo ?", 
                        "Attenzione", 
                        MessageBoxButtons.YesNo);
                    if(dr == DialogResult.No)
                    {
                        return;
                    }
                }
                File.WriteAllBytes(filename, datiOut.esitiPositivi.dettagliEsito.pdf);
                this.dataGridView1.Rows.Add("Successo", "000", "File salvato in "+filename);
            } else {
                foreach (ServiceReference1.dettaglioEsitoNegativo negativo in datiOut.esitiNegativi)
                {
                    this.dataGridView1.Rows.Add("Errore", negativo.codice, negativo.descrizione);
                }
            }
            return;
        }
    }
}
