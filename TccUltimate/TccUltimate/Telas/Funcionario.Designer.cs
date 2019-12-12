namespace teste
{
    partial class Funcionario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nome_MotoLabel;
            System.Windows.Forms.Label data_MotoLabel;
            System.Windows.Forms.Label cPF_motoLabel;
            System.Windows.Forms.Label celu_motoLabel;
            System.Windows.Forms.Label cate_motoLabel;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtNomeFuncio = new System.Windows.Forms.TextBox();
            this.dataFun = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.cbHab = new System.Windows.Forms.ComboBox();
            this.gridFuncionario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.tccUltimate = new teste.tccUltimate();
            this.funcionarioBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tccFinal = new teste.tccFinal();
            this.funcionarioBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.tccDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.funcionarioBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter2 = new teste.tccFinalTableAdapters.FuncionarioTableAdapter();
            this.funcionarioTableAdapter3 = new teste.tccUltimateTableAdapters.FuncionarioTableAdapter();
            this.txtCodFun = new System.Windows.Forms.TextBox();
            nome_MotoLabel = new System.Windows.Forms.Label();
            data_MotoLabel = new System.Windows.Forms.Label();
            cPF_motoLabel = new System.Windows.Forms.Label();
            celu_motoLabel = new System.Windows.Forms.Label();
            cate_motoLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_MotoLabel
            // 
            nome_MotoLabel.AutoSize = true;
            nome_MotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_MotoLabel.Location = new System.Drawing.Point(16, 55);
            nome_MotoLabel.Name = "nome_MotoLabel";
            nome_MotoLabel.Size = new System.Drawing.Size(138, 20);
            nome_MotoLabel.TabIndex = 31;
            nome_MotoLabel.Text = "Nome completo:";
            // 
            // data_MotoLabel
            // 
            data_MotoLabel.AutoSize = true;
            data_MotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_MotoLabel.Location = new System.Drawing.Point(26, 85);
            data_MotoLabel.Name = "data_MotoLabel";
            data_MotoLabel.Size = new System.Drawing.Size(128, 20);
            data_MotoLabel.TabIndex = 33;
            data_MotoLabel.Text = "Data de Nasc.:";
            // 
            // cPF_motoLabel
            // 
            cPF_motoLabel.AutoSize = true;
            cPF_motoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPF_motoLabel.Location = new System.Drawing.Point(106, 147);
            cPF_motoLabel.Name = "cPF_motoLabel";
            cPF_motoLabel.Size = new System.Drawing.Size(48, 20);
            cPF_motoLabel.TabIndex = 35;
            cPF_motoLabel.Text = "CPF:";
            // 
            // celu_motoLabel
            // 
            celu_motoLabel.AutoSize = true;
            celu_motoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celu_motoLabel.Location = new System.Drawing.Point(84, 115);
            celu_motoLabel.Name = "celu_motoLabel";
            celu_motoLabel.Size = new System.Drawing.Size(70, 20);
            celu_motoLabel.TabIndex = 39;
            celu_motoLabel.Text = "Celular:";
            // 
            // cate_motoLabel
            // 
            cate_motoLabel.AutoSize = true;
            cate_motoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cate_motoLabel.Location = new System.Drawing.Point(50, 177);
            cate_motoLabel.Name = "cate_motoLabel";
            cate_motoLabel.Size = new System.Drawing.Size(104, 20);
            cate_motoLabel.TabIndex = 41;
            cate_motoLabel.Text = "Habilitação:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(92, 31);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(62, 20);
            label9.TabIndex = 50;
            label9.Text = "Cargo:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(692, 141);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 49);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(692, 249);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 49);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // txtNomeFuncio
            // 
            this.txtNomeFuncio.Location = new System.Drawing.Point(160, 57);
            this.txtNomeFuncio.Name = "txtNomeFuncio";
            this.txtNomeFuncio.Size = new System.Drawing.Size(200, 20);
            this.txtNomeFuncio.TabIndex = 32;
            // 
            // dataFun
            // 
            this.dataFun.Location = new System.Drawing.Point(160, 87);
            this.dataFun.Mask = "99/99/9999";
            this.dataFun.Name = "dataFun";
            this.dataFun.Size = new System.Drawing.Size(71, 20);
            this.dataFun.TabIndex = 44;
            this.dataFun.ValidatingType = typeof(System.DateTime);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(158, 145);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(86, 20);
            this.txtCpf.TabIndex = 45;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(158, 117);
            this.txtCelular.Mask = "(99) 99999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 47;
            // 
            // cbHab
            // 
            this.cbHab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHab.FormattingEnabled = true;
            this.cbHab.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "A/B",
            "A/C",
            "A/D",
            "A/E",
            "N/A"});
            this.cbHab.Location = new System.Drawing.Point(158, 174);
            this.cbHab.Name = "cbHab";
            this.cbHab.Size = new System.Drawing.Size(43, 21);
            this.cbHab.TabIndex = 49;
            this.cbHab.SelectedIndexChanged += new System.EventHandler(this.CbHab_SelectedIndexChanged);
            // 
            // gridFuncionario
            // 
            this.gridFuncionario.AllowUserToAddRows = false;
            this.gridFuncionario.AllowUserToDeleteRows = false;
            this.gridFuncionario.AllowUserToResizeColumns = false;
            this.gridFuncionario.AllowUserToResizeRows = false;
            this.gridFuncionario.AutoGenerateColumns = false;
            this.gridFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.gridFuncionario.DataSource = this.funcionarioBindingSource6;
            this.gridFuncionario.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridFuncionario.Location = new System.Drawing.Point(12, 220);
            this.gridFuncionario.Name = "gridFuncionario";
            this.gridFuncionario.ReadOnly = true;
            this.gridFuncionario.RowHeadersVisible = false;
            this.gridFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFuncionario.Size = new System.Drawing.Size(663, 177);
            this.gridFuncionario.TabIndex = 49;
            this.gridFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFuncionario_CellContentClick);
            this.gridFuncionario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFuncionario_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "cod_funcionario";
            this.dataGridViewTextBoxColumn16.HeaderText = "Código";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 42;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "cargo";
            this.dataGridViewTextBoxColumn17.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 110;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "nome_funcionario";
            this.dataGridViewTextBoxColumn18.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 130;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "dtnasc_funcionario";
            this.dataGridViewTextBoxColumn19.HeaderText = "Data nasc.";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 83;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "cnh_funcionario";
            this.dataGridViewTextBoxColumn20.HeaderText = "Habilitação";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 62;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "tel_funcionario";
            this.dataGridViewTextBoxColumn21.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "cpf_funcionario";
            this.dataGridViewTextBoxColumn22.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 115;
            // 
            // funcionarioBindingSource6
            // 
            this.funcionarioBindingSource6.DataMember = "Funcionario";
            this.funcionarioBindingSource6.DataSource = this.tccUltimate;
            // 
            // tccUltimate
            // 
            this.tccUltimate.DataSetName = "tccUltimate";
            this.tccUltimate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource5
            // 
            this.funcionarioBindingSource5.DataMember = "Funcionario";
            this.funcionarioBindingSource5.DataSource = this.tccFinal;
            // 
            // tccFinal
            // 
            this.tccFinal.DataSetName = "tccFinal";
            this.tccFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource2
            // 
            this.funcionarioBindingSource2.DataMember = "Funcionario";
            // 
            // funcionarioBindingSource1
            // 
            this.funcionarioBindingSource1.DataMember = "Funcionario";
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Motorista",
            "Administrador",
            "Gerente",
            "Coordenador"});
            this.cbCargo.Location = new System.Drawing.Point(160, 30);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(104, 21);
            this.cbCargo.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnBusca);
            this.groupBox2.Controls.Add(this.txtBusca);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(413, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 67);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 104;
            this.label10.Text = "Cód:";
            // 
            // btnBusca
            // 
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.Location = new System.Drawing.Point(182, 17);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(57, 38);
            this.btnBusca.TabIndex = 14;
            this.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.BtnBusca_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(50, 25);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(126, 22);
            this.txtBusca.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(692, 86);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(104, 49);
            this.btnNovo.TabIndex = 101;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(692, 194);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(104, 49);
            this.btnAlterar.TabIndex = 102;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // funcionarioBindingSource4
            // 
            this.funcionarioBindingSource4.DataMember = "Funcionario";
            this.funcionarioBindingSource4.DataSource = this.tccFinal;
            // 
            // funcionarioTableAdapter2
            // 
            this.funcionarioTableAdapter2.ClearBeforeFill = true;
            // 
            // funcionarioTableAdapter3
            // 
            this.funcionarioTableAdapter3.ClearBeforeFill = true;
            // 
            // txtCodFun
            // 
            this.txtCodFun.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCodFun.Enabled = false;
            this.txtCodFun.Location = new System.Drawing.Point(368, 1);
            this.txtCodFun.Name = "txtCodFun";
            this.txtCodFun.Size = new System.Drawing.Size(100, 20);
            this.txtCodFun.TabIndex = 103;
            this.txtCodFun.Visible = false;
            // 
            // Funcionario
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.txtCodFun);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(label9);
            this.Controls.Add(this.gridFuncionario);
            this.Controls.Add(this.cbHab);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.dataFun);
            this.Controls.Add(nome_MotoLabel);
            this.Controls.Add(this.txtNomeFuncio);
            this.Controls.Add(data_MotoLabel);
            this.Controls.Add(cPF_motoLabel);
            this.Controls.Add(celu_motoLabel);
            this.Controls.Add(cate_motoLabel);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarMoto;
        private System.Windows.Forms.CheckBox cbCpfMoto;
        private System.Windows.Forms.CheckBox cbIdMoto;
        private System.Windows.Forms.TextBox txtBuscaMoto;
        private System.Windows.Forms.Button btnSalvarMoto;
        private System.Windows.Forms.Button btnEditarMoto;
        private System.Windows.Forms.Button btnExcluirMoto;
        private System.Windows.Forms.TextBox txtIdMoto;
        private System.Windows.Forms.TextBox txtNomeMoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox cpfMoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.MaskedTextBox txtRgMoto;
        private System.Windows.Forms.MaskedTextBox dataMoto;
        private System.Windows.Forms.MaskedTextBox celuMoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbMotoristaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtNomeFuncio;
        private System.Windows.Forms.MaskedTextBox dataFun;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.ComboBox cbHab;
        private System.Windows.Forms.DataGridView gridFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.BindingSource tccDataSetBindingSource;
     
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn codfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtnascfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnhfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpffuncionarioDataGridViewTextBoxColumn;
  
        private System.Windows.Forms.BindingSource funcionarioBindingSource1;
      
        private System.Windows.Forms.BindingSource funcionarioBindingSource2;

        private System.Windows.Forms.BindingSource funcionarioBindingSource3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private tccFinal tccFinal;
        private System.Windows.Forms.BindingSource funcionarioBindingSource4;
        private tccFinalTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter2;
        private System.Windows.Forms.BindingSource funcionarioBindingSource5;
        private tccUltimate tccUltimate;
        private System.Windows.Forms.BindingSource funcionarioBindingSource6;
        private tccUltimateTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter3;
        private System.Windows.Forms.TextBox txtCodFun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
    }
}