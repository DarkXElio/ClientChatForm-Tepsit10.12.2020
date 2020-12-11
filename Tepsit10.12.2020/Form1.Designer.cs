namespace Tepsit10._12._2020
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
            this.Serverip = new System.Windows.Forms.Label();
            this.Serverport = new System.Windows.Forms.Label();
            this.txt_severip = new System.Windows.Forms.TextBox();
            this.txt_serverport = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.Messagio = new System.Windows.Forms.Label();
            this.txt_mesaggio = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.lstbox_messagio_server = new System.Windows.Forms.ListBox();
            this._hr_ = new System.Windows.Forms.Label();
            this.@__hr = new System.Windows.Forms.Label();
            this.errore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Serverip
            // 
            this.Serverip.AutoSize = true;
            this.Serverip.Location = new System.Drawing.Point(90, 15);
            this.Serverip.Name = "Serverip";
            this.Serverip.Size = new System.Drawing.Size(54, 13);
            this.Serverip.TabIndex = 0;
            this.Serverip.Text = "Server IP:";
            // 
            // Serverport
            // 
            this.Serverport.AutoSize = true;
            this.Serverport.Location = new System.Drawing.Point(90, 45);
            this.Serverport.Name = "Serverport";
            this.Serverport.Size = new System.Drawing.Size(63, 13);
            this.Serverport.TabIndex = 1;
            this.Serverport.Text = "Server Port:";
            // 
            // txt_severip
            // 
            this.txt_severip.Location = new System.Drawing.Point(172, 7);
            this.txt_severip.Name = "txt_severip";
            this.txt_severip.Size = new System.Drawing.Size(100, 20);
            this.txt_severip.TabIndex = 2;
            this.txt_severip.Text = "127.0.0.1";
            // 
            // txt_serverport
            // 
            this.txt_serverport.Location = new System.Drawing.Point(172, 45);
            this.txt_serverport.Name = "txt_serverport";
            this.txt_serverport.Size = new System.Drawing.Size(100, 20);
            this.txt_serverport.TabIndex = 3;
            this.txt_serverport.Text = "23000";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(322, 24);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Messagio
            // 
            this.Messagio.AutoSize = true;
            this.Messagio.Location = new System.Drawing.Point(90, 121);
            this.Messagio.Name = "Messagio";
            this.Messagio.Size = new System.Drawing.Size(52, 13);
            this.Messagio.TabIndex = 5;
            this.Messagio.Text = "Messagio";
            // 
            // txt_mesaggio
            // 
            this.txt_mesaggio.Location = new System.Drawing.Point(172, 121);
            this.txt_mesaggio.Name = "txt_mesaggio";
            this.txt_mesaggio.Size = new System.Drawing.Size(100, 20);
            this.txt_mesaggio.TabIndex = 6;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(322, 117);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "Invia";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // lstbox_messagio_server
            // 
            this.lstbox_messagio_server.FormattingEnabled = true;
            this.lstbox_messagio_server.Location = new System.Drawing.Point(93, 146);
            this.lstbox_messagio_server.Name = "lstbox_messagio_server";
            this.lstbox_messagio_server.Size = new System.Drawing.Size(304, 199);
            this.lstbox_messagio_server.TabIndex = 8;
            // 
            // _hr_
            // 
            this._hr_.AutoSize = true;
            this._hr_.Location = new System.Drawing.Point(112, 68);
            this._hr_.Name = "_hr_";
            this._hr_.Size = new System.Drawing.Size(238, 13);
            this._hr_.TabIndex = 9;
            this._hr_.Text = "-----------------------------------------------------------------------------";
            // 
            // __hr
            // 
            this.@__hr.AutoSize = true;
            this.@__hr.Location = new System.Drawing.Point(110, 101);
            this.@__hr.Name = "__hr";
            this.@__hr.Size = new System.Drawing.Size(238, 13);
            this.@__hr.TabIndex = 10;
            this.@__hr.Text = "-----------------------------------------------------------------------------";
            // 
            // errore
            // 
            this.errore.AutoSize = true;
            this.errore.Location = new System.Drawing.Point(172, 85);
            this.errore.Name = "errore";
            this.errore.Size = new System.Drawing.Size(0, 13);
            this.errore.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Marelio Bejko";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errore);
            this.Controls.Add(this.@__hr);
            this.Controls.Add(this._hr_);
            this.Controls.Add(this.lstbox_messagio_server);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_mesaggio);
            this.Controls.Add(this.Messagio);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_serverport);
            this.Controls.Add(this.txt_severip);
            this.Controls.Add(this.Serverport);
            this.Controls.Add(this.Serverip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Serverip;
        private System.Windows.Forms.Label Serverport;
        private System.Windows.Forms.TextBox txt_severip;
        private System.Windows.Forms.TextBox txt_serverport;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label Messagio;
        private System.Windows.Forms.TextBox txt_mesaggio;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.ListBox lstbox_messagio_server;
        private System.Windows.Forms.Label _hr_;
        private System.Windows.Forms.Label __hr;
        private System.Windows.Forms.Label errore;
        private System.Windows.Forms.Label label1;
    }
}

