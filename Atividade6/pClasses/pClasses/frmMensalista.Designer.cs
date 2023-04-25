namespace pClasses
{
    partial class frmMensalista
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInstanciacao2 = new System.Windows.Forms.Button();
            this.btnInstanciacao = new System.Windows.Forms.Button();
            this.gbxHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNão = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.gbxHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Salário Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Matrícula";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnInstanciacao2
            // 
            this.btnInstanciacao2.Location = new System.Drawing.Point(375, 343);
            this.btnInstanciacao2.Name = "btnInstanciacao2";
            this.btnInstanciacao2.Size = new System.Drawing.Size(127, 54);
            this.btnInstanciacao2.TabIndex = 17;
            this.btnInstanciacao2.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstanciacao2.UseVisualStyleBackColor = true;
            this.btnInstanciacao2.Click += new System.EventHandler(this.BtnInstanciacao2_Click);
            // 
            // btnInstanciacao
            // 
            this.btnInstanciacao.Location = new System.Drawing.Point(188, 343);
            this.btnInstanciacao.Name = "btnInstanciacao";
            this.btnInstanciacao.Size = new System.Drawing.Size(127, 54);
            this.btnInstanciacao.TabIndex = 16;
            this.btnInstanciacao.Text = "Instanciar Mensalista";
            this.btnInstanciacao.UseVisualStyleBackColor = true;
            this.btnInstanciacao.Click += new System.EventHandler(this.BtnInstanciacao_Click);
            // 
            // gbxHomeOffice
            // 
            this.gbxHomeOffice.Controls.Add(this.rbtnNão);
            this.gbxHomeOffice.Controls.Add(this.rbtnSim);
            this.gbxHomeOffice.Location = new System.Drawing.Point(501, 73);
            this.gbxHomeOffice.Name = "gbxHomeOffice";
            this.gbxHomeOffice.Size = new System.Drawing.Size(200, 100);
            this.gbxHomeOffice.TabIndex = 15;
            this.gbxHomeOffice.TabStop = false;
            this.gbxHomeOffice.Text = "Trabalha em Home Office";
            // 
            // rbtnNão
            // 
            this.rbtnNão.AutoSize = true;
            this.rbtnNão.Location = new System.Drawing.Point(23, 63);
            this.rbtnNão.Name = "rbtnNão";
            this.rbtnNão.Size = new System.Drawing.Size(45, 17);
            this.rbtnNão.TabIndex = 1;
            this.rbtnNão.TabStop = true;
            this.rbtnNão.Text = "Não";
            this.rbtnNão.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(23, 38);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(42, 17);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(229, 252);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 14;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(229, 196);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(229, 134);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(229, 73);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 11;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstanciacao2);
            this.Controls.Add(this.btnInstanciacao);
            this.Controls.Add(this.gbxHomeOffice);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gbxHomeOffice.ResumeLayout(false);
            this.gbxHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInstanciacao2;
        private System.Windows.Forms.Button btnInstanciacao;
        private System.Windows.Forms.GroupBox gbxHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNão;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
    }
}