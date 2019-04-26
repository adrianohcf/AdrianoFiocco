namespace Banco_Tuiuiu
{
    partial class frmSaque
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
            this.btnConfirmaSaque = new System.Windows.Forms.Button();
            this.txtValorSaque = new System.Windows.Forms.TextBox();
            this.lblValorSaque = new System.Windows.Forms.Label();
            this.btnCancelarSaque = new System.Windows.Forms.Button();
            this.txtSaldoSaque = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.gbInformacoesSaque = new System.Windows.Forms.GroupBox();
            this.gbInformacoesSaque.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmaSaque
            // 
            this.btnConfirmaSaque.Location = new System.Drawing.Point(181, 115);
            this.btnConfirmaSaque.Name = "btnConfirmaSaque";
            this.btnConfirmaSaque.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmaSaque.TabIndex = 0;
            this.btnConfirmaSaque.Text = "Confirmar";
            this.btnConfirmaSaque.UseVisualStyleBackColor = true;
            // 
            // txtValorSaque
            // 
            this.txtValorSaque.Location = new System.Drawing.Point(49, 62);
            this.txtValorSaque.Multiline = true;
            this.txtValorSaque.Name = "txtValorSaque";
            this.txtValorSaque.Size = new System.Drawing.Size(180, 22);
            this.txtValorSaque.TabIndex = 1;
            // 
            // lblValorSaque
            // 
            this.lblValorSaque.AutoSize = true;
            this.lblValorSaque.Location = new System.Drawing.Point(6, 65);
            this.lblValorSaque.Name = "lblValorSaque";
            this.lblValorSaque.Size = new System.Drawing.Size(34, 13);
            this.lblValorSaque.TabIndex = 2;
            this.lblValorSaque.Text = "Valor:";
            // 
            // btnCancelarSaque
            // 
            this.btnCancelarSaque.Location = new System.Drawing.Point(100, 115);
            this.btnCancelarSaque.Name = "btnCancelarSaque";
            this.btnCancelarSaque.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarSaque.TabIndex = 3;
            this.btnCancelarSaque.Text = "Cancelar";
            this.btnCancelarSaque.UseVisualStyleBackColor = true;
            this.btnCancelarSaque.Click += new System.EventHandler(this.btnCancelarSaque_Click);
            // 
            // txtSaldoSaque
            // 
            this.txtSaldoSaque.Enabled = false;
            this.txtSaldoSaque.Location = new System.Drawing.Point(49, 28);
            this.txtSaldoSaque.Multiline = true;
            this.txtSaldoSaque.Name = "txtSaldoSaque";
            this.txtSaldoSaque.Size = new System.Drawing.Size(180, 23);
            this.txtSaldoSaque.TabIndex = 4;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(6, 28);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo:";
            // 
            // gbInformacoesSaque
            // 
            this.gbInformacoesSaque.Controls.Add(this.lblSaldo);
            this.gbInformacoesSaque.Controls.Add(this.txtSaldoSaque);
            this.gbInformacoesSaque.Controls.Add(this.txtValorSaque);
            this.gbInformacoesSaque.Controls.Add(this.lblValorSaque);
            this.gbInformacoesSaque.Location = new System.Drawing.Point(12, 12);
            this.gbInformacoesSaque.Name = "gbInformacoesSaque";
            this.gbInformacoesSaque.Size = new System.Drawing.Size(244, 97);
            this.gbInformacoesSaque.TabIndex = 6;
            this.gbInformacoesSaque.TabStop = false;
            this.gbInformacoesSaque.Text = "Informações do Saque";
            // 
            // frmSaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 144);
            this.Controls.Add(this.gbInformacoesSaque);
            this.Controls.Add(this.btnCancelarSaque);
            this.Controls.Add(this.btnConfirmaSaque);
            this.Name = "frmSaque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saque";
            this.Load += new System.EventHandler(this.frmSaque_Load);
            this.gbInformacoesSaque.ResumeLayout(false);
            this.gbInformacoesSaque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmaSaque;
        private System.Windows.Forms.TextBox txtValorSaque;
        private System.Windows.Forms.Label lblValorSaque;
        private System.Windows.Forms.Button btnCancelarSaque;
        private System.Windows.Forms.TextBox txtSaldoSaque;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.GroupBox gbInformacoesSaque;
    }
}