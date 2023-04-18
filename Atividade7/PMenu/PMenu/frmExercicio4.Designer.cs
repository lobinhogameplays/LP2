namespace PMenu
{
    partial class frmExercicio4
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
            this.rchtxtInput = new System.Windows.Forms.RichTextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtInput
            // 
            this.rchtxtInput.Location = new System.Drawing.Point(23, 26);
            this.rchtxtInput.Name = "rchtxtInput";
            this.rchtxtInput.Size = new System.Drawing.Size(153, 289);
            this.rchtxtInput.TabIndex = 0;
            this.rchtxtInput.Text = "";
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(234, 132);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 23);
            this.btnNum.TabIndex = 1;
            this.btnNum.Text = "Números";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(234, 190);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(75, 23);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Em Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(234, 248);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(75, 23);
            this.btnLetras.TabIndex = 3;
            this.btnLetras.Text = "Letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 337);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.rchtxtInput);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtInput;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetras;
    }
}