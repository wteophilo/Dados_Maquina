namespace DadosMaquina
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btInformar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMac = new System.Windows.Forms.Label();
            this.lblProcessador = new System.Windows.Forms.Label();
            this.lblTipoSistema = new System.Windows.Forms.Label();
            this.vNomeComputador = new System.Windows.Forms.Label();
            this.vTipoSistema = new System.Windows.Forms.Label();
            this.vProcessador = new System.Windows.Forms.Label();
            this.vMac = new System.Windows.Forms.Label();
            this.lblPlacaMae = new System.Windows.Forms.Label();
            this.vPlacaMae = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInformar
            // 
            this.btInformar.Location = new System.Drawing.Point(71, 164);
            this.btInformar.Name = "btInformar";
            this.btInformar.Size = new System.Drawing.Size(75, 23);
            this.btInformar.TabIndex = 0;
            this.btInformar.Text = "Informar";
            this.btInformar.UseVisualStyleBackColor = true;
            this.btInformar.Click += new System.EventHandler(this.btInformar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(97, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome computador:";
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Location = new System.Drawing.Point(12, 117);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(28, 13);
            this.lblMac.TabIndex = 2;
            this.lblMac.Text = "Mac";
            this.lblMac.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProcessador
            // 
            this.lblProcessador.AutoSize = true;
            this.lblProcessador.Location = new System.Drawing.Point(12, 71);
            this.lblProcessador.Name = "lblProcessador";
            this.lblProcessador.Size = new System.Drawing.Size(69, 13);
            this.lblProcessador.TabIndex = 3;
            this.lblProcessador.Text = "Processador:";
            // 
            // lblTipoSistema
            // 
            this.lblTipoSistema.AutoSize = true;
            this.lblTipoSistema.Location = new System.Drawing.Point(12, 44);
            this.lblTipoSistema.Name = "lblTipoSistema";
            this.lblTipoSistema.Size = new System.Drawing.Size(71, 13);
            this.lblTipoSistema.TabIndex = 4;
            this.lblTipoSistema.Text = "Tipo Sistema:";
            // 
            // vNomeComputador
            // 
            this.vNomeComputador.AutoSize = true;
            this.vNomeComputador.Location = new System.Drawing.Point(152, 19);
            this.vNomeComputador.Name = "vNomeComputador";
            this.vNomeComputador.Size = new System.Drawing.Size(35, 13);
            this.vNomeComputador.TabIndex = 5;
            this.vNomeComputador.Text = "label1";
            // 
            // vTipoSistema
            // 
            this.vTipoSistema.AutoSize = true;
            this.vTipoSistema.Location = new System.Drawing.Point(152, 44);
            this.vTipoSistema.Name = "vTipoSistema";
            this.vTipoSistema.Size = new System.Drawing.Size(35, 13);
            this.vTipoSistema.TabIndex = 6;
            this.vTipoSistema.Text = "label1";
            // 
            // vProcessador
            // 
            this.vProcessador.AutoSize = true;
            this.vProcessador.Location = new System.Drawing.Point(152, 71);
            this.vProcessador.Name = "vProcessador";
            this.vProcessador.Size = new System.Drawing.Size(35, 13);
            this.vProcessador.TabIndex = 7;
            this.vProcessador.Text = "label1";
            // 
            // vMac
            // 
            this.vMac.AutoSize = true;
            this.vMac.Location = new System.Drawing.Point(152, 117);
            this.vMac.Name = "vMac";
            this.vMac.Size = new System.Drawing.Size(35, 13);
            this.vMac.TabIndex = 8;
            this.vMac.Text = "label1";
            // 
            // lblPlacaMae
            // 
            this.lblPlacaMae.AutoSize = true;
            this.lblPlacaMae.Location = new System.Drawing.Point(12, 93);
            this.lblPlacaMae.Name = "lblPlacaMae";
            this.lblPlacaMae.Size = new System.Drawing.Size(61, 13);
            this.lblPlacaMae.TabIndex = 9;
            this.lblPlacaMae.Text = "Placa Mãe:";
            // 
            // vPlacaMae
            // 
            this.vPlacaMae.AutoSize = true;
            this.vPlacaMae.Location = new System.Drawing.Point(152, 93);
            this.vPlacaMae.Name = "vPlacaMae";
            this.vPlacaMae.Size = new System.Drawing.Size(35, 13);
            this.vPlacaMae.TabIndex = 10;
            this.vPlacaMae.Text = "label1";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(263, 164);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Sair";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 196);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.vPlacaMae);
            this.Controls.Add(this.lblPlacaMae);
            this.Controls.Add(this.vMac);
            this.Controls.Add(this.vProcessador);
            this.Controls.Add(this.vTipoSistema);
            this.Controls.Add(this.vNomeComputador);
            this.Controls.Add(this.lblTipoSistema);
            this.Controls.Add(this.lblProcessador);
            this.Controls.Add(this.lblMac);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btInformar);
            this.Name = "frmMain";
            this.Text = "Informações PC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInformar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Label lblProcessador;
        private System.Windows.Forms.Label lblTipoSistema;
        private System.Windows.Forms.Label vNomeComputador;
        private System.Windows.Forms.Label vTipoSistema;
        private System.Windows.Forms.Label vProcessador;
        private System.Windows.Forms.Label vMac;
        private System.Windows.Forms.Label lblPlacaMae;
        private System.Windows.Forms.Label vPlacaMae;
        private System.Windows.Forms.Button btClose;
    }
}

