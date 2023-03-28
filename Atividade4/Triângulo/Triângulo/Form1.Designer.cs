
namespace Triângulo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.txtValorC = new System.Windows.Forms.TextBox();
            this.BtnVerif = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(88, 74);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 20);
            this.txtValorA.TabIndex = 0;
            this.txtValorA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(88, 140);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 20);
            this.txtValorB.TabIndex = 1;
            this.txtValorB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtValorC
            // 
            this.txtValorC.Location = new System.Drawing.Point(88, 206);
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(100, 20);
            this.txtValorC.TabIndex = 2;
            this.txtValorC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BtnVerif
            // 
            this.BtnVerif.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnVerif.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnVerif.Location = new System.Drawing.Point(73, 270);
            this.BtnVerif.Name = "BtnVerif";
            this.BtnVerif.Size = new System.Drawing.Size(131, 44);
            this.BtnVerif.TabIndex = 3;
            this.BtnVerif.Text = "Verificar";
            this.BtnVerif.UseVisualStyleBackColor = false;
            this.BtnVerif.Click += new System.EventHandler(this.BtnVerif_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(68, 78);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(14, 13);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "A";
            this.labelA.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(68, 144);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 13);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B";
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(68, 210);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(14, 13);
            this.labelC.TabIndex = 6;
            this.labelC.Text = "C";
            this.labelC.Click += new System.EventHandler(this.labelC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insira três valores:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(283, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.BtnVerif);
            this.Controls.Add(this.txtValorC);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.TextBox txtValorC;
        private System.Windows.Forms.Button BtnVerif;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label label1;
    }
}

