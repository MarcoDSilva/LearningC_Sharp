namespace Shrek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_ano_nascimento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txtBox_nome = new System.Windows.Forms.TextBox();
            this.txtBox_ano_nascimento = new System.Windows.Forms.TextBox();
            this.txtBox_valor_base = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkBox_escalao = new System.Windows.Forms.CheckBox();
            this.chkBox_socio = new System.Windows.Forms.CheckBox();
            this.chkBox_agravamento = new System.Windows.Forms.CheckBox();
            this.lbl_distrito = new System.Windows.Forms.Label();
            this.rdBtn_sim = new System.Windows.Forms.RadioButton();
            this.rdBtn_nao = new System.Windows.Forms.RadioButton();
            this.lbl_concelho = new System.Windows.Forms.Label();
            this.cmbBox_concelhos = new System.Windows.Forms.ComboBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txtBox_resultado = new System.Windows.Forms.TextBox();
            this.lbl_warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(92, 98);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "NOME";
            // 
            // lbl_ano_nascimento
            // 
            this.lbl_ano_nascimento.AutoSize = true;
            this.lbl_ano_nascimento.Location = new System.Drawing.Point(92, 140);
            this.lbl_ano_nascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ano_nascimento.Name = "lbl_ano_nascimento";
            this.lbl_ano_nascimento.Size = new System.Drawing.Size(155, 17);
            this.lbl_ano_nascimento.TabIndex = 1;
            this.lbl_ano_nascimento.Text = "ANO DE NASCIMENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "VALOR BASE";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(208, 11);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(598, 39);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "CÁLCULO DO VALOR DA AVENÇA";
            // 
            // txtBox_nome
            // 
            this.txtBox_nome.Location = new System.Drawing.Point(276, 92);
            this.txtBox_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_nome.Name = "txtBox_nome";
            this.txtBox_nome.Size = new System.Drawing.Size(360, 22);
            this.txtBox_nome.TabIndex = 4;
            // 
            // txtBox_ano_nascimento
            // 
            this.txtBox_ano_nascimento.Location = new System.Drawing.Point(276, 134);
            this.txtBox_ano_nascimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_ano_nascimento.Name = "txtBox_ano_nascimento";
            this.txtBox_ano_nascimento.Size = new System.Drawing.Size(171, 22);
            this.txtBox_ano_nascimento.TabIndex = 5;
            this.txtBox_ano_nascimento.TextChanged += new System.EventHandler(this.TxtBox_ano_nascimento_TextChanged);
            // 
            // txtBox_valor_base
            // 
            this.txtBox_valor_base.Location = new System.Drawing.Point(276, 177);
            this.txtBox_valor_base.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_valor_base.Name = "txtBox_valor_base";
            this.txtBox_valor_base.Size = new System.Drawing.Size(171, 22);
            this.txtBox_valor_base.TabIndex = 6;
            this.txtBox_valor_base.TextChanged += new System.EventHandler(this.TxtBox_valor_base_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // chkBox_escalao
            // 
            this.chkBox_escalao.AutoSize = true;
            this.chkBox_escalao.Location = new System.Drawing.Point(276, 234);
            this.chkBox_escalao.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_escalao.Name = "chkBox_escalao";
            this.chkBox_escalao.Size = new System.Drawing.Size(213, 21);
            this.chkBox_escalao.TabIndex = 8;
            this.chkBox_escalao.Text = "Desconto de escalão? (10%)";
            this.chkBox_escalao.UseVisualStyleBackColor = true;
            this.chkBox_escalao.CheckedChanged += new System.EventHandler(this.ChkBox_escalao_CheckedChanged);
            // 
            // chkBox_socio
            // 
            this.chkBox_socio.AutoSize = true;
            this.chkBox_socio.Location = new System.Drawing.Point(276, 266);
            this.chkBox_socio.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_socio.Name = "chkBox_socio";
            this.chkBox_socio.Size = new System.Drawing.Size(189, 21);
            this.chkBox_socio.TabIndex = 9;
            this.chkBox_socio.Text = "Desconto de sócio? (5%)";
            this.chkBox_socio.UseVisualStyleBackColor = true;
            this.chkBox_socio.CheckedChanged += new System.EventHandler(this.ChkBox_socio_CheckedChanged);
            // 
            // chkBox_agravamento
            // 
            this.chkBox_agravamento.AutoSize = true;
            this.chkBox_agravamento.Location = new System.Drawing.Point(276, 299);
            this.chkBox_agravamento.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox_agravamento.Name = "chkBox_agravamento";
            this.chkBox_agravamento.Size = new System.Drawing.Size(227, 21);
            this.chkBox_agravamento.TabIndex = 10;
            this.chkBox_agravamento.Text = "Tem agravamento? (12 euros) ";
            this.chkBox_agravamento.UseVisualStyleBackColor = true;
            this.chkBox_agravamento.CheckedChanged += new System.EventHandler(this.ChkBox_agravamento_CheckedChanged);
            // 
            // lbl_distrito
            // 
            this.lbl_distrito.AutoSize = true;
            this.lbl_distrito.Location = new System.Drawing.Point(96, 366);
            this.lbl_distrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_distrito.Name = "lbl_distrito";
            this.lbl_distrito.Size = new System.Drawing.Size(126, 17);
            this.lbl_distrito.TabIndex = 11;
            this.lbl_distrito.Text = "Reside no distrito?";
            // 
            // rdBtn_sim
            // 
            this.rdBtn_sim.AutoSize = true;
            this.rdBtn_sim.Location = new System.Drawing.Point(271, 363);
            this.rdBtn_sim.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtn_sim.Name = "rdBtn_sim";
            this.rdBtn_sim.Size = new System.Drawing.Size(52, 21);
            this.rdBtn_sim.TabIndex = 12;
            this.rdBtn_sim.TabStop = true;
            this.rdBtn_sim.Text = "Sim";
            this.rdBtn_sim.UseVisualStyleBackColor = true;
            this.rdBtn_sim.CheckedChanged += new System.EventHandler(this.RdBtn_sim_CheckedChanged);
            // 
            // rdBtn_nao
            // 
            this.rdBtn_nao.AutoSize = true;
            this.rdBtn_nao.Location = new System.Drawing.Point(339, 364);
            this.rdBtn_nao.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtn_nao.Name = "rdBtn_nao";
            this.rdBtn_nao.Size = new System.Drawing.Size(55, 21);
            this.rdBtn_nao.TabIndex = 13;
            this.rdBtn_nao.TabStop = true;
            this.rdBtn_nao.Text = "Não";
            this.rdBtn_nao.UseVisualStyleBackColor = true;
            this.rdBtn_nao.CheckedChanged += new System.EventHandler(this.RdBtn_nao_CheckedChanged);
            // 
            // lbl_concelho
            // 
            this.lbl_concelho.AutoSize = true;
            this.lbl_concelho.Location = new System.Drawing.Point(532, 345);
            this.lbl_concelho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_concelho.Name = "lbl_concelho";
            this.lbl_concelho.Size = new System.Drawing.Size(85, 17);
            this.lbl_concelho.TabIndex = 14;
            this.lbl_concelho.Text = "CONCELHO";
            // 
            // cmbBox_concelhos
            // 
            this.cmbBox_concelhos.FormattingEnabled = true;
            this.cmbBox_concelhos.Items.AddRange(new object[] {
            "Braga",
            "Amares",
            "Guimarães"});
            this.cmbBox_concelhos.Location = new System.Drawing.Point(643, 340);
            this.cmbBox_concelhos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBox_concelhos.Name = "cmbBox_concelhos";
            this.cmbBox_concelhos.Size = new System.Drawing.Size(160, 24);
            this.cmbBox_concelhos.TabIndex = 15;
            this.cmbBox_concelhos.SelectedIndexChanged += new System.EventHandler(this.CmbBox_concelhos_SelectedIndexChanged);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(592, 442);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 28);
            this.btn_calcular.TabIndex = 16;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click);
            // 
            // txtBox_resultado
            // 
            this.txtBox_resultado.Location = new System.Drawing.Point(715, 444);
            this.txtBox_resultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_resultado.Name = "txtBox_resultado";
            this.txtBox_resultado.Size = new System.Drawing.Size(132, 22);
            this.txtBox_resultado.TabIndex = 17;
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warning.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_warning.Location = new System.Drawing.Point(109, 442);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(0, 24);
            this.lbl_warning.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 554);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.txtBox_resultado);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.cmbBox_concelhos);
            this.Controls.Add(this.lbl_concelho);
            this.Controls.Add(this.rdBtn_nao);
            this.Controls.Add(this.rdBtn_sim);
            this.Controls.Add(this.lbl_distrito);
            this.Controls.Add(this.chkBox_agravamento);
            this.Controls.Add(this.chkBox_socio);
            this.Controls.Add(this.chkBox_escalao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBox_valor_base);
            this.Controls.Add(this.txtBox_ano_nascimento);
            this.Controls.Add(this.txtBox_nome);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ano_nascimento);
            this.Controls.Add(this.lbl_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Shrek - by Marco Silva";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_ano_nascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txtBox_nome;
        private System.Windows.Forms.TextBox txtBox_ano_nascimento;
        private System.Windows.Forms.TextBox txtBox_valor_base;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkBox_escalao;
        private System.Windows.Forms.CheckBox chkBox_socio;
        private System.Windows.Forms.CheckBox chkBox_agravamento;
        private System.Windows.Forms.Label lbl_distrito;
        private System.Windows.Forms.RadioButton rdBtn_sim;
        private System.Windows.Forms.RadioButton rdBtn_nao;
        private System.Windows.Forms.Label lbl_concelho;
        private System.Windows.Forms.ComboBox cmbBox_concelhos;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txtBox_resultado;
        private System.Windows.Forms.Label lbl_warning;
    }
}

