namespace Es01AnrangoRamos
{
    partial class frmIscrizione
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
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascita = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnInserire = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnRicercaXanno = new System.Windows.Forms.Button();
            this.btnRicercaXcognome = new System.Windows.Forms.Button();
            this.btnInserire2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(13, 13);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 0;
            this.lblCognome.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(71, 13);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(188, 20);
            this.txtCognome.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Location = new System.Drawing.Point(13, 78);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(37, 13);
            this.lblDataNascita.TabIndex = 4;
            this.lblDataNascita.Text = "Nato il";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(71, 78);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(188, 20);
            this.txtData.TabIndex = 6;
            // 
            // btnInserire
            // 
            this.btnInserire.Location = new System.Drawing.Point(71, 115);
            this.btnInserire.Name = "btnInserire";
            this.btnInserire.Size = new System.Drawing.Size(188, 23);
            this.btnInserire.TabIndex = 7;
            this.btnInserire.Text = "INSERIRE con costruttore vuoto";
            this.btnInserire.UseVisualStyleBackColor = true;
            this.btnInserire.Click += new System.EventHandler(this.btnInserire_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(276, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(512, 263);
            this.dgv.TabIndex = 8;
            // 
            // btnRicercaXanno
            // 
            this.btnRicercaXanno.Location = new System.Drawing.Point(123, 174);
            this.btnRicercaXanno.Name = "btnRicercaXanno";
            this.btnRicercaXanno.Size = new System.Drawing.Size(136, 23);
            this.btnRicercaXanno.TabIndex = 9;
            this.btnRicercaXanno.Text = "RICERCA PER ANNO";
            this.btnRicercaXanno.UseVisualStyleBackColor = true;
            // 
            // btnRicercaXcognome
            // 
            this.btnRicercaXcognome.Location = new System.Drawing.Point(98, 203);
            this.btnRicercaXcognome.Name = "btnRicercaXcognome";
            this.btnRicercaXcognome.Size = new System.Drawing.Size(161, 23);
            this.btnRicercaXcognome.TabIndex = 10;
            this.btnRicercaXcognome.Text = "RICERCA PER COGNOME";
            this.btnRicercaXcognome.UseVisualStyleBackColor = true;
            // 
            // btnInserire2
            // 
            this.btnInserire2.Location = new System.Drawing.Point(47, 144);
            this.btnInserire2.Name = "btnInserire2";
            this.btnInserire2.Size = new System.Drawing.Size(212, 23);
            this.btnInserire2.TabIndex = 11;
            this.btnInserire2.Text = "INSERIRE con costruttore con  parametri";
            this.btnInserire2.UseVisualStyleBackColor = true;
            this.btnInserire2.Click += new System.EventHandler(this.btnInserire2_Click);
            // 
            // frmIscrizione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserire2);
            this.Controls.Add(this.btnRicercaXcognome);
            this.Controls.Add(this.btnRicercaXanno);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnInserire);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblDataNascita);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCognome);
            this.Name = "frmIscrizione";
            this.Text = "Gestione Iscrizioni al Torneo";
            this.Load += new System.EventHandler(this.frmIscrizione_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnInserire;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnRicercaXanno;
        private System.Windows.Forms.Button btnRicercaXcognome;
        private System.Windows.Forms.Button btnInserire2;
    }
}

