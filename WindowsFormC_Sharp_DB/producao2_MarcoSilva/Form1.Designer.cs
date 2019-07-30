namespace producao2_MarcoSilva
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
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.cmbBox_categorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_contaRegistos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewConta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Location = new System.Drawing.Point(12, 81);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.Size = new System.Drawing.Size(776, 185);
            this.dataGridProdutos.TabIndex = 0;
            // 
            // cmbBox_categorias
            // 
            this.cmbBox_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_categorias.FormattingEnabled = true;
            this.cmbBox_categorias.Location = new System.Drawing.Point(172, 50);
            this.cmbBox_categorias.Name = "cmbBox_categorias";
            this.cmbBox_categorias.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_categorias.TabIndex = 1;
            this.cmbBox_categorias.SelectedIndexChanged += new System.EventHandler(this.CmbBox_categorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolher Categoria:";
            // 
            // btn_contaRegistos
            // 
            this.btn_contaRegistos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_contaRegistos.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contaRegistos.Location = new System.Drawing.Point(12, 317);
            this.btn_contaRegistos.Name = "btn_contaRegistos";
            this.btn_contaRegistos.Size = new System.Drawing.Size(180, 150);
            this.btn_contaRegistos.TabIndex = 3;
            this.btn_contaRegistos.Text = "Mostra Estatisticas";
            this.btn_contaRegistos.UseVisualStyleBackColor = true;
            this.btn_contaRegistos.Click += new System.EventHandler(this.Btn_contaRegistos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(6, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(68, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // gridViewConta
            // 
            this.gridViewConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewConta.Location = new System.Drawing.Point(198, 317);
            this.gridViewConta.Name = "gridViewConta";
            this.gridViewConta.Size = new System.Drawing.Size(590, 150);
            this.gridViewConta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estatisticas da base de dados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridViewConta);
            this.Controls.Add(this.btn_contaRegistos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBox_categorias);
            this.Controls.Add(this.dataGridProdutos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Produção 2 - Marco Silva, nº9";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.ComboBox cmbBox_categorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_contaRegistos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridViewConta;
        private System.Windows.Forms.Label label2;
    }
}

