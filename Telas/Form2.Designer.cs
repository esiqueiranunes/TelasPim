﻿
namespace Telas {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.btnShowCadEndereco = new System.Windows.Forms.Button();
            this.panelEndereco = new System.Windows.Forms.Panel();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(532, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(514, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Categoria";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cliente",
            "Funcionário"});
            this.comboBox2.Location = new System.Drawing.Point(506, 202);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(46, 203);
            this.maskedTextBox4.Mask = "00/00/0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 5;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(162, 156);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(338, 20);
            this.maskedTextBox2.TabIndex = 3;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(46, 157);
            this.maskedTextBox3.Mask = "000,000,000-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 2;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(43, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(159, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "e-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(43, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Nome completo";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(46, 113);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(592, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.maskedTextBox8);
            this.panel2.Controls.Add(this.maskedTextBox7);
            this.panel2.Controls.Add(this.maskedTextBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.maskedTextBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.maskedTextBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.MinimumSize = new System.Drawing.Size(764, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 251);
            this.panel2.TabIndex = 77;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(514, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "Sexo";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não informar"});
            this.comboBox3.Location = new System.Drawing.Point(506, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(132, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(162, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 79;
            this.label12.Text = "Celular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(340, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 78;
            this.label11.Text = "Telefone";
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Location = new System.Drawing.Point(340, 203);
            this.maskedTextBox8.Mask = "(00) 00000-0000";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(160, 20);
            this.maskedTextBox8.TabIndex = 7;
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(162, 203);
            this.maskedTextBox7.Mask = "(00) 00000-0000";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(172, 20);
            this.maskedTextBox7.TabIndex = 6;
            // 
            // btnShowCadEndereco
            // 
            this.btnShowCadEndereco.FlatAppearance.BorderSize = 0;
            this.btnShowCadEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCadEndereco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowCadEndereco.Location = new System.Drawing.Point(28, 260);
            this.btnShowCadEndereco.Name = "btnShowCadEndereco";
            this.btnShowCadEndereco.Size = new System.Drawing.Size(701, 23);
            this.btnShowCadEndereco.TabIndex = 78;
            this.btnShowCadEndereco.Text = "Clique aqui para cadatrar Endereço";
            this.btnShowCadEndereco.UseVisualStyleBackColor = true;
            this.btnShowCadEndereco.Click += new System.EventHandler(this.btnShowCadEndereco_Click);
            // 
            // panelEndereco
            // 
            this.panelEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelEndereco.Controls.Add(this.maskedTextBox9);
            this.panelEndereco.Controls.Add(this.maskedTextBox5);
            this.panelEndereco.Controls.Add(this.label1);
            this.panelEndereco.Controls.Add(this.maskedTextBox6);
            this.panelEndereco.Controls.Add(this.comboBox1);
            this.panelEndereco.Controls.Add(this.label2);
            this.panelEndereco.Controls.Add(this.label8);
            this.panelEndereco.Controls.Add(this.label10);
            this.panelEndereco.Location = new System.Drawing.Point(46, 289);
            this.panelEndereco.Name = "panelEndereco";
            this.panelEndereco.Size = new System.Drawing.Size(607, 118);
            this.panelEndereco.TabIndex = 79;
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Location = new System.Drawing.Point(268, 72);
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(197, 20);
            this.maskedTextBox9.TabIndex = 11;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(3, 72);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(259, 20);
            this.maskedTextBox5.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(471, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Categoria";
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(3, 27);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(592, 20);
            this.maskedTextBox6.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cliente",
            "Funcionário"});
            this.comboBox1.Location = new System.Drawing.Point(474, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Logradouro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(0, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Cidade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(265, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Bairro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(420, 471);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 36);
            this.btnCadastrar.TabIndex = 80;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(532, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 81;
            this.button3.Text = "Botão";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(144, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(317, 31);
            this.label9.TabIndex = 82;
            this.label9.Text = "CADASTRAR PESSOA";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panelEndereco);
            this.Controls.Add(this.btnShowCadEndereco);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEndereco.ResumeLayout(false);
            this.panelEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShowCadEndereco;
        private System.Windows.Forms.Panel panelEndereco;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
    }
}