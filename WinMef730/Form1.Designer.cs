namespace WinMef730
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSSA = new System.Windows.Forms.TextBox();
            this.txtASL = new System.Windows.Forms.TextBox();
            this.txtRegione = new System.Windows.Forms.TextBox();
            this.btnTestSend = new System.Windows.Forms.Button();
            this.btnInvio = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtCfProprietario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRichiediRicevuta = new System.Windows.Forms.Button();
            this.btnRicevutaTest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dtPickerDataFine = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtPickerDataInizio = new System.Windows.Forms.DateTimePicker();
            this.txtProtocollo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Zip file|*.zip|XML|*.xml";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Carica file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(6, 6);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(339, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(106, 38);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "UXN6VMDD";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(322, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "P2SPDVF4";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(556, 34);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 4;
            this.txtPin.Text = "1426073406";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome utente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Codice struttura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codice ASL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codice Regione";
            // 
            // txtSSA
            // 
            this.txtSSA.Location = new System.Drawing.Point(556, 9);
            this.txtSSA.Name = "txtSSA";
            this.txtSSA.Size = new System.Drawing.Size(100, 20);
            this.txtSSA.TabIndex = 10;
            this.txtSSA.Text = "888888";
            // 
            // txtASL
            // 
            this.txtASL.Location = new System.Drawing.Point(322, 9);
            this.txtASL.Name = "txtASL";
            this.txtASL.Size = new System.Drawing.Size(100, 20);
            this.txtASL.TabIndex = 9;
            this.txtASL.Text = "101";
            // 
            // txtRegione
            // 
            this.txtRegione.Location = new System.Drawing.Point(106, 9);
            this.txtRegione.Name = "txtRegione";
            this.txtRegione.Size = new System.Drawing.Size(100, 20);
            this.txtRegione.TabIndex = 8;
            this.txtRegione.Text = "020";
            // 
            // btnTestSend
            // 
            this.btnTestSend.Location = new System.Drawing.Point(6, 32);
            this.btnTestSend.Name = "btnTestSend";
            this.btnTestSend.Size = new System.Drawing.Size(75, 23);
            this.btnTestSend.TabIndex = 14;
            this.btnTestSend.Text = "Invio Test";
            this.btnTestSend.UseVisualStyleBackColor = true;
            this.btnTestSend.Click += new System.EventHandler(this.btnTestSend_Click);
            // 
            // btnInvio
            // 
            this.btnInvio.Location = new System.Drawing.Point(270, 32);
            this.btnInvio.Name = "btnInvio";
            this.btnInvio.Size = new System.Drawing.Size(75, 23);
            this.btnInvio.TabIndex = 15;
            this.btnInvio.Text = "Invio";
            this.btnInvio.UseVisualStyleBackColor = true;
            this.btnInvio.Click += new System.EventHandler(this.btnInvio_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(6, 61);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(420, 125);
            this.txtResponse.TabIndex = 16;
            // 
            // txtCfProprietario
            // 
            this.txtCfProprietario.Location = new System.Drawing.Point(106, 64);
            this.txtCfProprietario.Name = "txtCfProprietario";
            this.txtCfProprietario.Size = new System.Drawing.Size(132, 20);
            this.txtCfProprietario.TabIndex = 17;
            this.txtCfProprietario.Text = "CCSRMO77A09H501E";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "CF Proprietario";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 243);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTestSend);
            this.tabPage1.Controls.Add(this.btnInvio);
            this.tabPage1.Controls.Add(this.txtResponse);
            this.tabPage1.Controls.Add(this.txtFileName);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Invio Asincrono";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRichiediRicevuta);
            this.tabPage2.Controls.Add(this.btnRicevutaTest);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dtPickerDataFine);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dtPickerDataInizio);
            this.tabPage2.Controls.Add(this.txtProtocollo);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ricevute";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRichiediRicevuta
            // 
            this.btnRichiediRicevuta.Location = new System.Drawing.Point(610, 33);
            this.btnRichiediRicevuta.Name = "btnRichiediRicevuta";
            this.btnRichiediRicevuta.Size = new System.Drawing.Size(123, 23);
            this.btnRichiediRicevuta.TabIndex = 14;
            this.btnRichiediRicevuta.Text = "Richiedi ricevuta";
            this.btnRichiediRicevuta.UseVisualStyleBackColor = true;
            // 
            // btnRicevutaTest
            // 
            this.btnRicevutaTest.Location = new System.Drawing.Point(7, 30);
            this.btnRicevutaTest.Name = "btnRicevutaTest";
            this.btnRicevutaTest.Size = new System.Drawing.Size(123, 23);
            this.btnRicevutaTest.TabIndex = 13;
            this.btnRicevutaTest.Text = "Richiedi ricevuta test";
            this.btnRicevutaTest.UseVisualStyleBackColor = true;
            this.btnRicevutaTest.Click += new System.EventHandler(this.btnRicevutaTest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Codice,
            this.Descrizione});
            this.dataGridView1.Location = new System.Drawing.Point(9, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(724, 151);
            this.dataGridView1.TabIndex = 12;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Codice
            // 
            this.Codice.HeaderText = "Codice";
            this.Codice.Name = "Codice";
            this.Codice.ReadOnly = true;
            // 
            // Descrizione
            // 
            this.Descrizione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descrizione.HeaderText = "Descrizione";
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(477, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Data fine";
            // 
            // dtPickerDataFine
            // 
            this.dtPickerDataFine.Location = new System.Drawing.Point(533, 7);
            this.dtPickerDataFine.Name = "dtPickerDataFine";
            this.dtPickerDataFine.Size = new System.Drawing.Size(200, 20);
            this.dtPickerDataFine.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data inizio";
            // 
            // dtPickerDataInizio
            // 
            this.dtPickerDataInizio.Location = new System.Drawing.Point(271, 7);
            this.dtPickerDataInizio.Name = "dtPickerDataInizio";
            this.dtPickerDataInizio.Size = new System.Drawing.Size(200, 20);
            this.dtPickerDataInizio.TabIndex = 8;
            // 
            // txtProtocollo
            // 
            this.txtProtocollo.Location = new System.Drawing.Point(66, 7);
            this.txtProtocollo.Name = "txtProtocollo";
            this.txtProtocollo.Size = new System.Drawing.Size(137, 20);
            this.txtProtocollo.TabIndex = 7;
            this.txtProtocollo.Text = "15120115340302387";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Protocollo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 342);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCfProprietario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSSA);
            this.Controls.Add(this.txtASL);
            this.Controls.Add(this.txtRegione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.Text = "MEF - Flussi 730";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSSA;
        private System.Windows.Forms.TextBox txtASL;
        private System.Windows.Forms.TextBox txtRegione;
        private System.Windows.Forms.Button btnTestSend;
        private System.Windows.Forms.Button btnInvio;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtCfProprietario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRichiediRicevuta;
        private System.Windows.Forms.Button btnRicevutaTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtPickerDataFine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtPickerDataInizio;
        private System.Windows.Forms.TextBox txtProtocollo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrizione;
    }
}

