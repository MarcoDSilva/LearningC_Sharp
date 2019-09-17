namespace proj_prod_msilva
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
            this.grid_association = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_listGrid = new System.Windows.Forms.Button();
            this.btn_listPeople = new System.Windows.Forms.Button();
            this.btn_activities = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_insertName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_insert_Year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_insertGender = new System.Windows.Forms.TextBox();
            this.btn_newPerson = new System.Windows.Forms.Button();
            this.combo_Users = new System.Windows.Forms.ComboBox();
            this.combo_activity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_YesNo = new System.Windows.Forms.TextBox();
            this.btn_addPersonAtActivity = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_updateInfo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_MBox = new System.Windows.Forms.Button();
            this.grid_answers = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ageToSearch = new System.Windows.Forms.TextBox();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.rd_male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_updatePerson = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_insertCodeActivity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_insertActivityName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_insertNewActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_association)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_answers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_association
            // 
            this.grid_association.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_association.Location = new System.Drawing.Point(16, 15);
            this.grid_association.Margin = new System.Windows.Forms.Padding(4);
            this.grid_association.Name = "grid_association";
            this.grid_association.Size = new System.Drawing.Size(485, 239);
            this.grid_association.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(16, 262);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(66, 28);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Limpa";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_listGrid
            // 
            this.btn_listGrid.Location = new System.Drawing.Point(392, 262);
            this.btn_listGrid.Margin = new System.Windows.Forms.Padding(4);
            this.btn_listGrid.Name = "btn_listGrid";
            this.btn_listGrid.Size = new System.Drawing.Size(109, 28);
            this.btn_listGrid.TabIndex = 2;
            this.btn_listGrid.Text = "Listar Registos";
            this.btn_listGrid.UseVisualStyleBackColor = true;
            this.btn_listGrid.Click += new System.EventHandler(this.btn_listGrid_Click);
            // 
            // btn_listPeople
            // 
            this.btn_listPeople.Location = new System.Drawing.Point(275, 262);
            this.btn_listPeople.Margin = new System.Windows.Forms.Padding(4);
            this.btn_listPeople.Name = "btn_listPeople";
            this.btn_listPeople.Size = new System.Drawing.Size(105, 28);
            this.btn_listPeople.TabIndex = 3;
            this.btn_listPeople.Text = "Listar Pessoas";
            this.btn_listPeople.UseVisualStyleBackColor = true;
            this.btn_listPeople.Click += new System.EventHandler(this.btn_listPeople_Click);
            // 
            // btn_activities
            // 
            this.btn_activities.Location = new System.Drawing.Point(140, 262);
            this.btn_activities.Margin = new System.Windows.Forms.Padding(4);
            this.btn_activities.Name = "btn_activities";
            this.btn_activities.Size = new System.Drawing.Size(120, 28);
            this.btn_activities.TabIndex = 4;
            this.btn_activities.Text = "Lista Actividades";
            this.btn_activities.UseVisualStyleBackColor = true;
            this.btn_activities.Click += new System.EventHandler(this.btn_activities_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-13, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1219, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "____________";
            // 
            // txt_insertName
            // 
            this.txt_insertName.Location = new System.Drawing.Point(164, 50);
            this.txt_insertName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertName.Name = "txt_insertName";
            this.txt_insertName.Size = new System.Drawing.Size(132, 22);
            this.txt_insertName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome:";
            // 
            // txt_insert_Year
            // 
            this.txt_insert_Year.Location = new System.Drawing.Point(164, 82);
            this.txt_insert_Year.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insert_Year.Name = "txt_insert_Year";
            this.txt_insert_Year.Size = new System.Drawing.Size(132, 22);
            this.txt_insert_Year.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ano Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sexo (M ou F):";
            // 
            // txt_insertGender
            // 
            this.txt_insertGender.Location = new System.Drawing.Point(164, 115);
            this.txt_insertGender.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertGender.Name = "txt_insertGender";
            this.txt_insertGender.Size = new System.Drawing.Size(132, 22);
            this.txt_insertGender.TabIndex = 12;
            // 
            // btn_newPerson
            // 
            this.btn_newPerson.Location = new System.Drawing.Point(103, 155);
            this.btn_newPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btn_newPerson.Name = "btn_newPerson";
            this.btn_newPerson.Size = new System.Drawing.Size(100, 28);
            this.btn_newPerson.TabIndex = 13;
            this.btn_newPerson.Text = "Registar!";
            this.btn_newPerson.UseVisualStyleBackColor = true;
            this.btn_newPerson.Click += new System.EventHandler(this.btn_newPerson_Click);
            // 
            // combo_Users
            // 
            this.combo_Users.FormattingEnabled = true;
            this.combo_Users.Location = new System.Drawing.Point(123, 42);
            this.combo_Users.Name = "combo_Users";
            this.combo_Users.Size = new System.Drawing.Size(177, 24);
            this.combo_Users.TabIndex = 15;
            // 
            // combo_activity
            // 
            this.combo_activity.FormattingEnabled = true;
            this.combo_activity.Location = new System.Drawing.Point(123, 78);
            this.combo_activity.Name = "combo_activity";
            this.combo_activity.Size = new System.Drawing.Size(177, 24);
            this.combo_activity.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Actividade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Quota em dia (Sim / Não):";
            // 
            // txt_YesNo
            // 
            this.txt_YesNo.Location = new System.Drawing.Point(217, 109);
            this.txt_YesNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_YesNo.Name = "txt_YesNo";
            this.txt_YesNo.Size = new System.Drawing.Size(83, 22);
            this.txt_YesNo.TabIndex = 20;
            // 
            // btn_addPersonAtActivity
            // 
            this.btn_addPersonAtActivity.Location = new System.Drawing.Point(123, 158);
            this.btn_addPersonAtActivity.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addPersonAtActivity.Name = "btn_addPersonAtActivity";
            this.btn_addPersonAtActivity.Size = new System.Drawing.Size(100, 28);
            this.btn_addPersonAtActivity.TabIndex = 21;
            this.btn_addPersonAtActivity.Text = "Registar!";
            this.btn_addPersonAtActivity.UseVisualStyleBackColor = true;
            this.btn_addPersonAtActivity.Click += new System.EventHandler(this.btn_addPersonAtActivity_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_updatePerson);
            this.groupBox1.Controls.Add(this.btn_updateInfo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_MBox);
            this.groupBox1.Controls.Add(this.grid_answers);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_ageToSearch);
            this.groupBox1.Controls.Add(this.rd_female);
            this.groupBox1.Controls.Add(this.rd_male);
            this.groupBox1.Location = new System.Drawing.Point(518, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 316);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "III - Operações";
            // 
            // btn_updateInfo
            // 
            this.btn_updateInfo.Location = new System.Drawing.Point(10, 231);
            this.btn_updateInfo.Name = "btn_updateInfo";
            this.btn_updateInfo.Size = new System.Drawing.Size(173, 23);
            this.btn_updateInfo.TabIndex = 27;
            this.btn_updateInfo.Text = "7 - Actualiza Actividade";
            this.btn_updateInfo.UseVisualStyleBackColor = true;
            this.btn_updateInfo.Click += new System.EventHandler(this.btn_updateInfo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "------------------";
            // 
            // btn_MBox
            // 
            this.btn_MBox.Location = new System.Drawing.Point(21, 180);
            this.btn_MBox.Name = "btn_MBox";
            this.btn_MBox.Size = new System.Drawing.Size(129, 23);
            this.btn_MBox.TabIndex = 24;
            this.btn_MBox.Text = "6 - Totais";
            this.btn_MBox.UseVisualStyleBackColor = true;
            this.btn_MBox.Click += new System.EventHandler(this.btn_Mbox_Click);
            // 
            // grid_answers
            // 
            this.grid_answers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_answers.Location = new System.Drawing.Point(191, 21);
            this.grid_answers.Name = "grid_answers";
            this.grid_answers.Size = new System.Drawing.Size(484, 279);
            this.grid_answers.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Acima de:";
            // 
            // txt_ageToSearch
            // 
            this.txt_ageToSearch.Location = new System.Drawing.Point(82, 117);
            this.txt_ageToSearch.Name = "txt_ageToSearch";
            this.txt_ageToSearch.Size = new System.Drawing.Size(100, 22);
            this.txt_ageToSearch.TabIndex = 3;
            this.txt_ageToSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Location = new System.Drawing.Point(47, 81);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(81, 20);
            this.rd_female.TabIndex = 2;
            this.rd_female.TabStop = true;
            this.rd_female.Text = "Feminino";
            this.rd_female.UseVisualStyleBackColor = true;
            this.rd_female.CheckedChanged += new System.EventHandler(this.rd_female_CheckedChanged);
            // 
            // rd_male
            // 
            this.rd_male.AutoSize = true;
            this.rd_male.Location = new System.Drawing.Point(47, 49);
            this.rd_male.Name = "rd_male";
            this.rd_male.Size = new System.Drawing.Size(87, 20);
            this.rd_male.TabIndex = 1;
            this.rd_male.TabStop = true;
            this.rd_male.Text = "Masculino";
            this.rd_male.UseVisualStyleBackColor = true;
            this.rd_male.CheckedChanged += new System.EventHandler(this.rd_male_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_insertName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_insert_Year);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_insertGender);
            this.groupBox2.Controls.Add(this.btn_newPerson);
            this.groupBox2.Location = new System.Drawing.Point(26, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 224);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inserir Pessoas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_Users);
            this.groupBox3.Controls.Add(this.combo_activity);
            this.groupBox3.Controls.Add(this.btn_addPersonAtActivity);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_YesNo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(401, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 224);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inserir em actividades:";
            // 
            // btn_updatePerson
            // 
            this.btn_updatePerson.Location = new System.Drawing.Point(9, 260);
            this.btn_updatePerson.Name = "btn_updatePerson";
            this.btn_updatePerson.Size = new System.Drawing.Size(173, 23);
            this.btn_updatePerson.TabIndex = 28;
            this.btn_updatePerson.Text = "7 - Actualiza Pessoas";
            this.btn_updatePerson.UseVisualStyleBackColor = true;
            this.btn_updatePerson.Click += new System.EventHandler(this.btn_updatePerson_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_insertCodeActivity);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txt_insertActivityName);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btn_insertNewActivity);
            this.groupBox4.Location = new System.Drawing.Point(783, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 224);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inserir Nova Atividade";
            // 
            // txt_insertCodeActivity
            // 
            this.txt_insertCodeActivity.Location = new System.Drawing.Point(165, 57);
            this.txt_insertCodeActivity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertCodeActivity.Name = "txt_insertCodeActivity";
            this.txt_insertCodeActivity.Size = new System.Drawing.Size(132, 22);
            this.txt_insertCodeActivity.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Código (D/E/F,etc):";
            // 
            // txt_insertActivityName
            // 
            this.txt_insertActivityName.Location = new System.Drawing.Point(165, 89);
            this.txt_insertActivityName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertActivityName.Name = "txt_insertActivityName";
            this.txt_insertActivityName.Size = new System.Drawing.Size(132, 22);
            this.txt_insertActivityName.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(39, 93);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Nome Actividade:";
            // 
            // btn_insertNewActivity
            // 
            this.btn_insertNewActivity.Location = new System.Drawing.Point(136, 144);
            this.btn_insertNewActivity.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insertNewActivity.Name = "btn_insertNewActivity";
            this.btn_insertNewActivity.Size = new System.Drawing.Size(100, 28);
            this.btn_insertNewActivity.TabIndex = 13;
            this.btn_insertNewActivity.Text = "Registar!";
            this.btn_insertNewActivity.UseVisualStyleBackColor = true;
            this.btn_insertNewActivity.Click += new System.EventHandler(this.btn_insertNewActivity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 618);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_activities);
            this.Controls.Add(this.btn_listPeople);
            this.Controls.Add(this.btn_listGrid);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.grid_association);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid_association)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_answers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_association;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_listGrid;
        private System.Windows.Forms.Button btn_listPeople;
        private System.Windows.Forms.Button btn_activities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_insertName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_insert_Year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_insertGender;
        private System.Windows.Forms.Button btn_newPerson;
        private System.Windows.Forms.ComboBox combo_Users;
        private System.Windows.Forms.ComboBox combo_activity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_YesNo;
        private System.Windows.Forms.Button btn_addPersonAtActivity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ageToSearch;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.RadioButton rd_male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grid_answers;
        private System.Windows.Forms.Button btn_MBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_updateInfo;
        private System.Windows.Forms.Button btn_updatePerson;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_insertCodeActivity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_insertActivityName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_insertNewActivity;
    }
}

