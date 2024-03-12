namespace WinCom
{
    partial class frmFormulario2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulario2));
            this.lblBuscador = new System.Windows.Forms.Label();
            this.bcdBuscador = new AxSHDocVw.AxWebBrowser();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bcdBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(367, 19);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(108, 16);
            this.lblBuscador.TabIndex = 8;
            this.lblBuscador.Text = "BUSCADOR WEB";
            // 
            // bcdBuscador
            // 
            this.bcdBuscador.Enabled = true;
            this.bcdBuscador.Location = new System.Drawing.Point(53, 49);
            this.bcdBuscador.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bcdBuscador.OcxState")));
            this.bcdBuscador.Size = new System.Drawing.Size(750, 395);
            this.bcdBuscador.TabIndex = 9;
            // 
            // btnBuscador
            // 
            this.btnBuscador.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBuscador.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscador.Location = new System.Drawing.Point(649, 463);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(154, 26);
            this.btnBuscador.TabIndex = 11;
            this.btnBuscador.Text = "Iniciar busqueda";
            this.btnBuscador.UseVisualStyleBackColor = false;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVolver.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(53, 466);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "<<";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmFormulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 501);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.bcdBuscador);
            this.Controls.Add(this.lblBuscador);
            this.Name = "frmFormulario2";
            this.Text = "BUSCADOR WEB";
            ((System.ComponentModel.ISupportInitialize)(this.bcdBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscador;
        private AxSHDocVw.AxWebBrowser bcdBuscador;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.Button btnVolver;
    }
}