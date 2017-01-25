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
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Zip file|*.zip|XML|*.xml";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Carica file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(16, 15);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(339, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(16, 42);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "UXN6VMDD";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "P2SPDVF4";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(16, 94);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 4;
            this.txtPin.Text = "1426073406";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome utente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Codice struttura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codice ASL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codice Regione";
            // 
            // txtSSA
            // 
            this.txtSSA.Location = new System.Drawing.Point(204, 94);
            this.txtSSA.Name = "txtSSA";
            this.txtSSA.Size = new System.Drawing.Size(100, 20);
            this.txtSSA.TabIndex = 10;
            this.txtSSA.Text = "888888";
            // 
            // txtASL
            // 
            this.txtASL.Location = new System.Drawing.Point(204, 68);
            this.txtASL.Name = "txtASL";
            this.txtASL.Size = new System.Drawing.Size(100, 20);
            this.txtASL.TabIndex = 9;
            this.txtASL.Text = "101";
            // 
            // txtRegione
            // 
            this.txtRegione.Location = new System.Drawing.Point(204, 42);
            this.txtRegione.Name = "txtRegione";
            this.txtRegione.Size = new System.Drawing.Size(100, 20);
            this.txtRegione.TabIndex = 8;
            this.txtRegione.Text = "020";
            // 
            // btnTestSend
            // 
            this.btnTestSend.Location = new System.Drawing.Point(16, 146);
            this.btnTestSend.Name = "btnTestSend";
            this.btnTestSend.Size = new System.Drawing.Size(75, 23);
            this.btnTestSend.TabIndex = 14;
            this.btnTestSend.Text = "Invio Test";
            this.btnTestSend.UseVisualStyleBackColor = true;
            this.btnTestSend.Click += new System.EventHandler(this.btnTestSend_Click);
            // 
            // btnInvio
            // 
            this.btnInvio.Location = new System.Drawing.Point(97, 146);
            this.btnInvio.Name = "btnInvio";
            this.btnInvio.Size = new System.Drawing.Size(75, 23);
            this.btnInvio.TabIndex = 15;
            this.btnInvio.Text = "Invio";
            this.btnInvio.UseVisualStyleBackColor = true;
            this.btnInvio.Click += new System.EventHandler(this.btnInvio_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(16, 175);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(420, 125);
            this.txtResponse.TabIndex = 16;
            // 
            // txtCfProprietario
            // 
            this.txtCfProprietario.Location = new System.Drawing.Point(16, 120);
            this.txtCfProprietario.Name = "txtCfProprietario";
            this.txtCfProprietario.Size = new System.Drawing.Size(132, 20);
            this.txtCfProprietario.TabIndex = 17;
            this.txtCfProprietario.Text = "CCSRMO77A09H501E";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "CF Proprietario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 312);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCfProprietario);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnInvio);
            this.Controls.Add(this.btnTestSend);
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
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Caricamento XML";
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
    }
}

