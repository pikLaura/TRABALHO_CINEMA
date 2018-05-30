namespace TRABALHO_CINEMA
{
    partial class FuncionarioForm
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbNacionalidade = new System.Windows.Forms.Label();
            this.lbNumeroCelular = new System.Windows.Forms.Label();
            this.lbNumeroFixo = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbRG = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.lbEndereso = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbDataDENacimento = new System.Windows.Forms.Label();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.mtbNumeroCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumeroFixo = new System.Windows.Forms.MaskedTextBox();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtEndereso = new System.Windows.Forms.TextBox();
            this.btcancelar = new System.Windows.Forms.Button();
            this.DTFuncinarioCadastroDTNacimento = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFuncionarioNacionalidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 62);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(82, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome Completo";
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Location = new System.Drawing.Point(12, 127);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(34, 13);
            this.lbCurso.TabIndex = 1;
            this.lbCurso.Text = "Curso";
            // 
            // lbNacionalidade
            // 
            this.lbNacionalidade.AutoSize = true;
            this.lbNacionalidade.Location = new System.Drawing.Point(12, 197);
            this.lbNacionalidade.Name = "lbNacionalidade";
            this.lbNacionalidade.Size = new System.Drawing.Size(75, 13);
            this.lbNacionalidade.TabIndex = 2;
            this.lbNacionalidade.Text = "Nacionalidade";
            // 
            // lbNumeroCelular
            // 
            this.lbNumeroCelular.AutoSize = true;
            this.lbNumeroCelular.Location = new System.Drawing.Point(12, 265);
            this.lbNumeroCelular.Name = "lbNumeroCelular";
            this.lbNumeroCelular.Size = new System.Drawing.Size(79, 13);
            this.lbNumeroCelular.TabIndex = 3;
            this.lbNumeroCelular.Text = "Numero Celular";
            // 
            // lbNumeroFixo
            // 
            this.lbNumeroFixo.AutoSize = true;
            this.lbNumeroFixo.Location = new System.Drawing.Point(12, 326);
            this.lbNumeroFixo.Name = "lbNumeroFixo";
            this.lbNumeroFixo.Size = new System.Drawing.Size(63, 13);
            this.lbNumeroFixo.TabIndex = 4;
            this.lbNumeroFixo.Text = "Numero fixo";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(189, 62);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "E-mail";
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Location = new System.Drawing.Point(189, 127);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(27, 13);
            this.lbcpf.TabIndex = 6;
            this.lbcpf.Text = "CPF";
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(189, 196);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(23, 13);
            this.lbRG.TabIndex = 7;
            this.lbRG.Text = "RG";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(189, 326);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(31, 13);
            this.lbSexo.TabIndex = 9;
            this.lbSexo.Text = "Sexo";
            this.lbSexo.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Location = new System.Drawing.Point(352, 62);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lbEstadoCivil.TabIndex = 10;
            this.lbEstadoCivil.Text = "Estado Civil";
            // 
            // lbEndereso
            // 
            this.lbEndereso.AutoSize = true;
            this.lbEndereso.Location = new System.Drawing.Point(352, 127);
            this.lbEndereso.Name = "lbEndereso";
            this.lbEndereso.Size = new System.Drawing.Size(52, 13);
            this.lbEndereso.TabIndex = 11;
            this.lbEndereso.Text = "Endereso";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(352, 196);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(35, 13);
            this.lbCargo.TabIndex = 12;
            this.lbCargo.Text = "Cargo";
            // 
            // lbDataDENacimento
            // 
            this.lbDataDENacimento.AutoSize = true;
            this.lbDataDENacimento.Location = new System.Drawing.Point(191, 264);
            this.lbDataDENacimento.Name = "lbDataDENacimento";
            this.lbDataDENacimento.Size = new System.Drawing.Size(101, 13);
            this.lbDataDENacimento.TabIndex = 13;
            this.lbDataDENacimento.Text = "Data De Nacimento";
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(192, 143);
            this.mtbcpf.Mask = "000.000.000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(100, 20);
            this.mtbcpf.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 15;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(15, 143);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 16;
            // 
            // mtbNumeroCelular
            // 
            this.mtbNumeroCelular.Location = new System.Drawing.Point(15, 282);
            this.mtbNumeroCelular.Mask = "(999) 000-0000";
            this.mtbNumeroCelular.Name = "mtbNumeroCelular";
            this.mtbNumeroCelular.Size = new System.Drawing.Size(100, 20);
            this.mtbNumeroCelular.TabIndex = 18;
            // 
            // mtbNumeroFixo
            // 
            this.mtbNumeroFixo.Location = new System.Drawing.Point(12, 342);
            this.mtbNumeroFixo.Mask = "(999) 000-0000";
            this.mtbNumeroFixo.Name = "mtbNumeroFixo";
            this.mtbNumeroFixo.Size = new System.Drawing.Size(100, 20);
            this.mtbNumeroFixo.TabIndex = 19;
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(192, 213);
            this.mtbRG.Mask = "0.000.00";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(100, 20);
            this.mtbRG.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(192, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(355, 79);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(100, 20);
            this.txtEstadoCivil.TabIndex = 25;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(355, 212);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(100, 20);
            this.txtcargo.TabIndex = 27;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(16, 393);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 28;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Femino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(192, 341);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 29;
            // 
            // txtEndereso
            // 
            this.txtEndereso.Location = new System.Drawing.Point(355, 143);
            this.txtEndereso.Name = "txtEndereso";
            this.txtEndereso.Size = new System.Drawing.Size(100, 20);
            this.txtEndereso.TabIndex = 31;
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(192, 393);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(75, 23);
            this.btcancelar.TabIndex = 33;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            // 
            // DTFuncinarioCadastroDTNacimento
            // 
            this.DTFuncinarioCadastroDTNacimento.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DTFuncinarioCadastroDTNacimento.AllowDrop = true;
            this.DTFuncinarioCadastroDTNacimento.CustomFormat = "";
            this.DTFuncinarioCadastroDTNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFuncinarioCadastroDTNacimento.Location = new System.Drawing.Point(192, 280);
            this.DTFuncinarioCadastroDTNacimento.Name = "DTFuncinarioCadastroDTNacimento";
            this.DTFuncinarioCadastroDTNacimento.Size = new System.Drawing.Size(100, 20);
            this.DTFuncinarioCadastroDTNacimento.TabIndex = 34;
            this.DTFuncinarioCadastroDTNacimento.Value = new System.DateTime(2018, 5, 29, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(499, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(649, 376);
            this.dataGridView1.TabIndex = 35;
            // 
            // txtFuncionarioNacionalidade
            // 
            this.txtFuncionarioNacionalidade.Location = new System.Drawing.Point(15, 212);
            this.txtFuncionarioNacionalidade.Name = "txtFuncionarioNacionalidade";
            this.txtFuncionarioNacionalidade.Size = new System.Drawing.Size(100, 20);
            this.txtFuncionarioNacionalidade.TabIndex = 36;
            // 
            // FuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 450);
            this.Controls.Add(this.txtFuncionarioNacionalidade);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DTFuncinarioCadastroDTNacimento);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.txtEndereso);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtEstadoCivil);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mtbRG);
            this.Controls.Add(this.mtbNumeroFixo);
            this.Controls.Add(this.mtbNumeroCelular);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mtbcpf);
            this.Controls.Add(this.lbDataDENacimento);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.lbEndereso);
            this.Controls.Add(this.lbEstadoCivil);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbRG);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNumeroFixo);
            this.Controls.Add(this.lbNumeroCelular);
            this.Controls.Add(this.lbNacionalidade);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.lbNome);
            this.Name = "FuncionarioForm";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbNacionalidade;
        private System.Windows.Forms.Label lbNumeroCelular;
        private System.Windows.Forms.Label lbNumeroFixo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.Label lbEndereso;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbDataDENacimento;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.MaskedTextBox mtbNumeroCelular;
        private System.Windows.Forms.MaskedTextBox mtbNumeroFixo;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtEndereso;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.DateTimePicker DTFuncinarioCadastroDTNacimento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFuncionarioNacionalidade;
    }
}