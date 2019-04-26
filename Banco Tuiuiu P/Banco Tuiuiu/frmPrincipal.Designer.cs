namespace Banco_Tuiuiu
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.pnlPrincipalTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrincipalTitulo = new System.Windows.Forms.Label();
            this.pnlPrincipalMsg = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.gbPrincipal.SuspendLayout();
            this.pnlPrincipalTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPrincipalMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.txtSaldo);
            this.gbPrincipal.Controls.Add(this.txtConta);
            this.gbPrincipal.Controls.Add(this.txtNome);
            this.gbPrincipal.Controls.Add(this.lblSaldo);
            this.gbPrincipal.Controls.Add(this.lblConta);
            this.gbPrincipal.Controls.Add(this.lblNome);
            this.gbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrincipal.Location = new System.Drawing.Point(12, 99);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(412, 210);
            this.gbPrincipal.TabIndex = 0;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Informações do Cliente";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(112, 154);
            this.txtSaldo.Multiline = true;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(283, 27);
            this.txtSaldo.TabIndex = 5;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(112, 93);
            this.txtConta.Multiline = true;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(283, 27);
            this.txtConta.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 32);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 27);
            this.txtNome.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(10, 154);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(82, 29);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(10, 89);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(82, 29);
            this.lblConta.TabIndex = 1;
            this.lblConta.Text = "Conta:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(10, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 29);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(12, 363);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(131, 53);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "REINICIAR";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(304, 363);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(120, 53);
            this.btnDeposito.TabIndex = 2;
            this.btnDeposito.Text = "DEPÓSITO";
            this.btnDeposito.UseVisualStyleBackColor = true;
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(164, 363);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(118, 53);
            this.btnSaque.TabIndex = 3;
            this.btnSaque.Text = "SAQUE";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // pnlPrincipalTitulo
            // 
            this.pnlPrincipalTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlPrincipalTitulo.Controls.Add(this.pictureBox1);
            this.pnlPrincipalTitulo.Controls.Add(this.lblPrincipalTitulo);
            this.pnlPrincipalTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipalTitulo.Name = "pnlPrincipalTitulo";
            this.pnlPrincipalTitulo.Size = new System.Drawing.Size(436, 93);
            this.pnlPrincipalTitulo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrincipalTitulo
            // 
            this.lblPrincipalTitulo.AutoSize = true;
            this.lblPrincipalTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipalTitulo.ForeColor = System.Drawing.Color.White;
            this.lblPrincipalTitulo.Location = new System.Drawing.Point(114, 26);
            this.lblPrincipalTitulo.Name = "lblPrincipalTitulo";
            this.lblPrincipalTitulo.Size = new System.Drawing.Size(304, 55);
            this.lblPrincipalTitulo.TabIndex = 6;
            this.lblPrincipalTitulo.Text = "Banco Tuiuiu";
            // 
            // pnlPrincipalMsg
            // 
            this.pnlPrincipalMsg.BackColor = System.Drawing.Color.Blue;
            this.pnlPrincipalMsg.Controls.Add(this.lblMsg);
            this.pnlPrincipalMsg.Location = new System.Drawing.Point(0, 315);
            this.pnlPrincipalMsg.Name = "pnlPrincipalMsg";
            this.pnlPrincipalMsg.Size = new System.Drawing.Size(436, 42);
            this.pnlPrincipalMsg.TabIndex = 5;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(136, 11);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(42, 20);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.Text = "msg";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 428);
            this.Controls.Add(this.pnlPrincipalMsg);
            this.Controls.Add(this.pnlPrincipalTitulo);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.gbPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.pnlPrincipalTitulo.ResumeLayout(false);
            this.pnlPrincipalTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPrincipalMsg.ResumeLayout(false);
            this.pnlPrincipalMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Panel pnlPrincipalTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrincipalTitulo;
        private System.Windows.Forms.Panel pnlPrincipalMsg;
        private System.Windows.Forms.Label lblMsg;
    }
}