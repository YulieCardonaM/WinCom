namespace WinCom
{
    partial class frmFormulario1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulario1));
            this.LectorPDF = new AxAcroPDFLib.AxAcroPDF();
            this.lblVideo = new System.Windows.Forms.Label();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.lblPDF = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LectorPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // LectorPDF
            // 
            this.LectorPDF.Enabled = true;
            this.LectorPDF.Location = new System.Drawing.Point(620, 66);
            this.LectorPDF.Name = "LectorPDF";
            this.LectorPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LectorPDF.OcxState")));
            this.LectorPDF.Size = new System.Drawing.Size(379, 346);
            this.LectorPDF.TabIndex = 2;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(196, 36);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(162, 16);
            this.lblVideo.TabIndex = 3;
            this.lblVideo.Text = "REPRODUCTOR DE VIDEO";
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReproducir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.Location = new System.Drawing.Point(232, 418);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(99, 31);
            this.btnReproducir.TabIndex = 4;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = false;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // lblPDF
            // 
            this.lblPDF.AutoSize = true;
            this.lblPDF.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDF.Location = new System.Drawing.Point(765, 36);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(101, 16);
            this.lblPDF.TabIndex = 6;
            this.lblPDF.Text = "LECTOR DE PDF";
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(50, 494);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(79, 28);
            this.btnPath.TabIndex = 8;
            this.btnPath.Text = "PATH";
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPDF.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(768, 423);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(87, 26);
            this.btnPDF.TabIndex = 9;
            this.btnPDF.Text = "Abrir PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Buscar Archivo PDF";
            // 
            // wmpVideo
            // 
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(50, 66);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(461, 346);
            this.wmpVideo.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSiguiente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(913, 494);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(86, 28);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmFormulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 546);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.lblPDF);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.LectorPDF);
            this.Controls.Add(this.wmpVideo);
            this.Name = "frmFormulario1";
            this.Text = "REUTILIZANDO BIBLIOTECAS";
            ((System.ComponentModel.ISupportInitialize)(this.LectorPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private AxAcroPDFLib.AxAcroPDF LectorPDF;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

