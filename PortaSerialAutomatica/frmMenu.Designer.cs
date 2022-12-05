namespace PortaSerialAutomatica
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnObterPorta = new System.Windows.Forms.Button();
            this.lblPortaCom = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObterPorta
            // 
            this.btnObterPorta.BackColor = System.Drawing.Color.SeaGreen;
            this.btnObterPorta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObterPorta.FlatAppearance.BorderSize = 0;
            this.btnObterPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObterPorta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnObterPorta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnObterPorta.Location = new System.Drawing.Point(12, 168);
            this.btnObterPorta.Name = "btnObterPorta";
            this.btnObterPorta.Size = new System.Drawing.Size(332, 36);
            this.btnObterPorta.TabIndex = 0;
            this.btnObterPorta.Text = "Obter porta automática";
            this.btnObterPorta.UseVisualStyleBackColor = false;
            this.btnObterPorta.Click += new System.EventHandler(this.btnObterPorta_Click);
            // 
            // lblPortaCom
            // 
            this.lblPortaCom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPortaCom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPortaCom.Location = new System.Drawing.Point(12, 84);
            this.lblPortaCom.Name = "lblPortaCom";
            this.lblPortaCom.Size = new System.Drawing.Size(328, 49);
            this.lblPortaCom.TabIndex = 1;
            this.lblPortaCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(332, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "A porta do PINPAD Gertec PPC930 é:";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 216);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPortaCom);
            this.Controls.Add(this.btnObterPorta);
            this.Name = "frmMenu";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnObterPorta;
        private Label lblPortaCom;
        private Label lblTitulo;
    }
}