namespace PSalário
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxDependentes = new System.Windows.Forms.ComboBox();
            this.ckbxCasamento = new System.Windows.Forms.CheckBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.txtDescIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFam = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.lblSalFam = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 0;
            // 
            // cbxDependentes
            // 
            this.cbxDependentes.FormattingEnabled = true;
            this.cbxDependentes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxDependentes.Location = new System.Drawing.Point(54, 185);
            this.cbxDependentes.Name = "cbxDependentes";
            this.cbxDependentes.Size = new System.Drawing.Size(121, 21);
            this.cbxDependentes.TabIndex = 2;
            // 
            // ckbxCasamento
            // 
            this.ckbxCasamento.AutoSize = true;
            this.ckbxCasamento.Location = new System.Drawing.Point(54, 397);
            this.ckbxCasamento.Name = "ckbxCasamento";
            this.ckbxCasamento.Size = new System.Drawing.Size(74, 17);
            this.ckbxCasamento.TabIndex = 3;
            this.ckbxCasamento.Text = "Casado(a)";
            this.ckbxCasamento.UseVisualStyleBackColor = true;
            this.ckbxCasamento.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Location = new System.Drawing.Point(54, 262);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(200, 100);
            this.gbxSexo.TabIndex = 4;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(22, 56);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rbtnFem.TabIndex = 1;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(22, 33);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasc.TabIndex = 0;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(99, 450);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 47);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Verificar Desconto";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(54, 118);
            this.mskbxSalBruto.Mask = "000000.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(121, 20);
            this.mskbxSalBruto.TabIndex = 7;
            // 
            // txtINSS
            // 
            this.txtINSS.Enabled = false;
            this.txtINSS.Location = new System.Drawing.Point(580, 99);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(151, 20);
            this.txtINSS.TabIndex = 8;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Enabled = false;
            this.txtDescINSS.Location = new System.Drawing.Point(580, 165);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(151, 20);
            this.txtDescINSS.TabIndex = 9;
            // 
            // txtIRPF
            // 
            this.txtIRPF.Enabled = false;
            this.txtIRPF.Location = new System.Drawing.Point(580, 231);
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.Size = new System.Drawing.Size(151, 20);
            this.txtIRPF.TabIndex = 10;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Enabled = false;
            this.txtDescIRPF.Location = new System.Drawing.Point(580, 297);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.Size = new System.Drawing.Size(151, 20);
            this.txtDescIRPF.TabIndex = 11;
            // 
            // txtSalFam
            // 
            this.txtSalFam.Enabled = false;
            this.txtSalFam.Location = new System.Drawing.Point(580, 363);
            this.txtSalFam.Name = "txtSalFam";
            this.txtSalFam.Size = new System.Drawing.Size(151, 20);
            this.txtSalFam.TabIndex = 12;
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Enabled = false;
            this.txtSalLiq.Location = new System.Drawing.Point(580, 429);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(151, 20);
            this.txtSalLiq.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(51, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(132, 13);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome do(a) Funcionário(a)";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(51, 102);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(67, 13);
            this.lblSalario.TabIndex = 15;
            this.lblSalario.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(51, 169);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblFilhos.TabIndex = 16;
            this.lblFilhos.Text = "Número de Filhos";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(459, 102);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(75, 13);
            this.lblINSS.TabIndex = 17;
            this.lblINSS.Text = "Alíquota INSS";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(456, 168);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescINSS.TabIndex = 18;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(456, 234);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(74, 13);
            this.lblIRPF.TabIndex = 19;
            this.lblIRPF.Text = "Alíquota IRPF";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(456, 300);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescIRPF.TabIndex = 20;
            this.lblDescIRPF.Text = "Desconto IRPF";
            this.lblDescIRPF.Click += new System.EventHandler(this.LblDescIRPF_Click);
            // 
            // lblSalFam
            // 
            this.lblSalFam.AutoSize = true;
            this.lblSalFam.Location = new System.Drawing.Point(456, 366);
            this.lblSalFam.Name = "lblSalFam";
            this.lblSalFam.Size = new System.Drawing.Size(76, 13);
            this.lblSalFam.TabIndex = 21;
            this.lblSalFam.Text = "Salário Família";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(456, 432);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(78, 13);
            this.lblSalLiq.TabIndex = 22;
            this.lblSalLiq.Text = "Salário Líquido";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.BackColor = System.Drawing.Color.Azure;
            this.lblDados.Location = new System.Drawing.Point(431, 51);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(38, 13);
            this.lblDados.TabIndex = 23;
            this.lblDados.Text = "Dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(802, 526);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFam);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtSalFam);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtIRPF);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.ckbxCasamento);
            this.Controls.Add(this.cbxDependentes);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbxDependentes;
        private System.Windows.Forms.CheckBox ckbxCasamento;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtIRPF;
        private System.Windows.Forms.TextBox txtDescIRPF;
        private System.Windows.Forms.TextBox txtSalFam;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.Label lblSalFam;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDados;
    }
}

