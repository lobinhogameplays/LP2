namespace PMenu
{
    partial class frmExercicio3
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnRem1 = new System.Windows.Forms.Button();
            this.btnRem2 = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(63, 45);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(63, 116);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // btnRem1
            // 
            this.btnRem1.Location = new System.Drawing.Point(76, 187);
            this.btnRem1.Name = "btnRem1";
            this.btnRem1.Size = new System.Drawing.Size(75, 23);
            this.btnRem1.TabIndex = 2;
            this.btnRem1.Text = "Remover";
            this.btnRem1.UseVisualStyleBackColor = true;
            this.btnRem1.Click += new System.EventHandler(this.BtnRem1_Click);
            // 
            // btnRem2
            // 
            this.btnRem2.Location = new System.Drawing.Point(76, 261);
            this.btnRem2.Name = "btnRem2";
            this.btnRem2.Size = new System.Drawing.Size(75, 23);
            this.btnRem2.TabIndex = 3;
            this.btnRem2.Text = "Remover(2)";
            this.btnRem2.UseVisualStyleBackColor = true;
            this.btnRem2.Click += new System.EventHandler(this.BtnRem2_Click);
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(76, 335);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(75, 23);
            this.btnInv.TabIndex = 4;
            this.btnInv.Text = "Inverter";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.BtnInv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Palavra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Palavra 2";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.btnRem2);
            this.Controls.Add(this.btnRem1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnRem1;
        private System.Windows.Forms.Button btnRem2;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}