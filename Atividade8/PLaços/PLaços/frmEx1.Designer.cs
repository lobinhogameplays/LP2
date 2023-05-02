namespace PLaços
{
    partial class frmEx1
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
            this.btnPares = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnBrancos = new System.Windows.Forms.Button();
            this.rtbxTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(618, 382);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(146, 40);
            this.btnPares.TabIndex = 7;
            this.btnPares.Text = "Números de Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.BtnPares_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(328, 382);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(146, 40);
            this.btnR.TabIndex = 6;
            this.btnR.Text = "Número de Letras R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // btnBrancos
            // 
            this.btnBrancos.Location = new System.Drawing.Point(38, 382);
            this.btnBrancos.Name = "btnBrancos";
            this.btnBrancos.Size = new System.Drawing.Size(146, 40);
            this.btnBrancos.TabIndex = 5;
            this.btnBrancos.Text = "Espaços em Branco";
            this.btnBrancos.UseVisualStyleBackColor = true;
            this.btnBrancos.Click += new System.EventHandler(this.BtnBrancos_Click);
            // 
            // rtbxTexto
            // 
            this.rtbxTexto.Location = new System.Drawing.Point(12, 29);
            this.rtbxTexto.Name = "rtbxTexto";
            this.rtbxTexto.Size = new System.Drawing.Size(776, 322);
            this.rtbxTexto.TabIndex = 4;
            this.rtbxTexto.Text = "";
            // 
            // frmEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBrancos);
            this.Controls.Add(this.rtbxTexto);
            this.Name = "frmEx1";
            this.Text = "frmEx1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnBrancos;
        private System.Windows.Forms.RichTextBox rtbxTexto;
    }
}