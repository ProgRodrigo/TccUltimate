namespace teste
{
    partial class Financas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financas));
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaGasto = new System.Windows.Forms.Button();
            this.txtPesqViagem = new System.Windows.Forms.TextBox();
            this.btnFinaizar = new System.Windows.Forms.Button();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodGastos = new System.Windows.Forms.TextBox();
            this.tccFinal = new teste.tccFinal();
            this.gastosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gastosTableAdapter1 = new teste.tccFinalTableAdapters.GastosTableAdapter();
            this.gridFinancas = new System.Windows.Forms.DataGridView();
            this.codgastosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasolinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedagioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valormultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manutencaocorretivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codviagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tccUltimate = new teste.tccUltimate();
            this.gastosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gastosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtManutencao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gastosTableAdapter = new teste.tccUltimateTableAdapters.GastosTableAdapter();
            this.cbViagem = new System.Windows.Forms.ComboBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new teste.tccUltimateTableAdapters.FuncionarioTableAdapter();
            this.viagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viagemTableAdapter = new teste.tccUltimateTableAdapters.ViagemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viagemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(201, 132);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(68, 20);
            this.txtData.TabIndex = 4;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Multa:";
            // 
            // txtMulta
            // 
            this.txtMulta.Enabled = false;
            this.txtMulta.Location = new System.Drawing.Point(487, 132);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(83, 20);
            this.txtMulta.TabIndex = 10;
            this.txtMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMulta_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscaGasto);
            this.groupBox1.Controls.Add(this.txtPesqViagem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(260, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 79);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Viagem:";
            // 
            // btnBuscaGasto
            // 
            this.btnBuscaGasto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaGasto.Image")));
            this.btnBuscaGasto.Location = new System.Drawing.Point(186, 20);
            this.btnBuscaGasto.Name = "btnBuscaGasto";
            this.btnBuscaGasto.Size = new System.Drawing.Size(55, 46);
            this.btnBuscaGasto.TabIndex = 61;
            this.btnBuscaGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscaGasto.UseVisualStyleBackColor = true;
            this.btnBuscaGasto.Click += new System.EventHandler(this.BtnBuscaGasto_Click);
            // 
            // txtPesqViagem
            // 
            this.txtPesqViagem.Location = new System.Drawing.Point(87, 34);
            this.txtPesqViagem.Name = "txtPesqViagem";
            this.txtPesqViagem.Size = new System.Drawing.Size(93, 20);
            this.txtPesqViagem.TabIndex = 61;
            // 
            // btnFinaizar
            // 
            this.btnFinaizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinaizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinaizar.Image")));
            this.btnFinaizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinaizar.Location = new System.Drawing.Point(671, 149);
            this.btnFinaizar.Name = "btnFinaizar";
            this.btnFinaizar.Size = new System.Drawing.Size(87, 71);
            this.btnFinaizar.TabIndex = 11;
            this.btnFinaizar.Text = "Finalizar";
            this.btnFinaizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinaizar.UseVisualStyleBackColor = true;
            this.btnFinaizar.Click += new System.EventHandler(this.BtnFinaizar_Click_1);
            // 
            // txtPedagio
            // 
            this.txtPedagio.Location = new System.Drawing.Point(487, 79);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(83, 20);
            this.txtPedagio.TabIndex = 6;
            this.txtPedagio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPedagio_KeyPress);
            // 
            // txtGasolina
            // 
            this.txtGasolina.Location = new System.Drawing.Point(201, 101);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(83, 20);
            this.txtGasolina.TabIndex = 3;
            this.txtGasolina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGasolina_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(110, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "Gasolina:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 84;
            this.label9.Text = "Pedagio:";
            // 
            // txtCodGastos
            // 
            this.txtCodGastos.Enabled = false;
            this.txtCodGastos.Location = new System.Drawing.Point(67, 258);
            this.txtCodGastos.Name = "txtCodGastos";
            this.txtCodGastos.Size = new System.Drawing.Size(19, 20);
            this.txtCodGastos.TabIndex = 82;
            this.txtCodGastos.Visible = false;
            // 
            // tccFinal
            // 
            this.tccFinal.DataSetName = "tccFinal";
            this.tccFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastosBindingSource1
            // 
            this.gastosBindingSource1.DataMember = "Gastos";
            this.gastosBindingSource1.DataSource = this.tccFinal;
            // 
            // gastosTableAdapter1
            // 
            this.gastosTableAdapter1.ClearBeforeFill = true;
            // 
            // gridFinancas
            // 
            this.gridFinancas.AllowUserToAddRows = false;
            this.gridFinancas.AllowUserToDeleteRows = false;
            this.gridFinancas.AllowUserToResizeColumns = false;
            this.gridFinancas.AllowUserToResizeRows = false;
            this.gridFinancas.AutoGenerateColumns = false;
            this.gridFinancas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridFinancas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridFinancas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFinancas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codgastosDataGridViewTextBoxColumn,
            this.gasolinaDataGridViewTextBoxColumn,
            this.pedagioDataGridViewTextBoxColumn,
            this.datamultaDataGridViewTextBoxColumn,
            this.valormultaDataGridViewTextBoxColumn,
            this.manutencaocorretivaDataGridViewTextBoxColumn,
            this.codfuncionarioDataGridViewTextBoxColumn,
            this.codviagemDataGridViewTextBoxColumn});
            this.gridFinancas.DataSource = this.gastosBindingSource4;
            this.gridFinancas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridFinancas.Location = new System.Drawing.Point(67, 275);
            this.gridFinancas.Name = "gridFinancas";
            this.gridFinancas.ReadOnly = true;
            this.gridFinancas.RowHeadersVisible = false;
            this.gridFinancas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFinancas.Size = new System.Drawing.Size(691, 175);
            this.gridFinancas.TabIndex = 97;
            this.gridFinancas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFinancas_CellContentClick);
            // 
            // codgastosDataGridViewTextBoxColumn
            // 
            this.codgastosDataGridViewTextBoxColumn.DataPropertyName = "cod_gastos";
            this.codgastosDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codgastosDataGridViewTextBoxColumn.Name = "codgastosDataGridViewTextBoxColumn";
            this.codgastosDataGridViewTextBoxColumn.ReadOnly = true;
            this.codgastosDataGridViewTextBoxColumn.Width = 42;
            // 
            // gasolinaDataGridViewTextBoxColumn
            // 
            this.gasolinaDataGridViewTextBoxColumn.DataPropertyName = "gasolina";
            this.gasolinaDataGridViewTextBoxColumn.HeaderText = "Gasolina";
            this.gasolinaDataGridViewTextBoxColumn.Name = "gasolinaDataGridViewTextBoxColumn";
            this.gasolinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedagioDataGridViewTextBoxColumn
            // 
            this.pedagioDataGridViewTextBoxColumn.DataPropertyName = "pedagio";
            this.pedagioDataGridViewTextBoxColumn.HeaderText = "Pedagio";
            this.pedagioDataGridViewTextBoxColumn.Name = "pedagioDataGridViewTextBoxColumn";
            this.pedagioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datamultaDataGridViewTextBoxColumn
            // 
            this.datamultaDataGridViewTextBoxColumn.DataPropertyName = "data_multa";
            this.datamultaDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datamultaDataGridViewTextBoxColumn.Name = "datamultaDataGridViewTextBoxColumn";
            this.datamultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valormultaDataGridViewTextBoxColumn
            // 
            this.valormultaDataGridViewTextBoxColumn.DataPropertyName = "valor_multa";
            this.valormultaDataGridViewTextBoxColumn.HeaderText = "Multa";
            this.valormultaDataGridViewTextBoxColumn.Name = "valormultaDataGridViewTextBoxColumn";
            this.valormultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manutencaocorretivaDataGridViewTextBoxColumn
            // 
            this.manutencaocorretivaDataGridViewTextBoxColumn.DataPropertyName = "manutencao_corretiva";
            this.manutencaocorretivaDataGridViewTextBoxColumn.HeaderText = "Manutenção";
            this.manutencaocorretivaDataGridViewTextBoxColumn.Name = "manutencaocorretivaDataGridViewTextBoxColumn";
            this.manutencaocorretivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codfuncionarioDataGridViewTextBoxColumn
            // 
            this.codfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "cod_funcionario";
            this.codfuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
            this.codfuncionarioDataGridViewTextBoxColumn.Name = "codfuncionarioDataGridViewTextBoxColumn";
            this.codfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.codfuncionarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // codviagemDataGridViewTextBoxColumn
            // 
            this.codviagemDataGridViewTextBoxColumn.DataPropertyName = "cod_viagem";
            this.codviagemDataGridViewTextBoxColumn.HeaderText = "Viagem";
            this.codviagemDataGridViewTextBoxColumn.Name = "codviagemDataGridViewTextBoxColumn";
            this.codviagemDataGridViewTextBoxColumn.ReadOnly = true;
            this.codviagemDataGridViewTextBoxColumn.Width = 70;
            // 
            // gastosBindingSource4
            // 
            this.gastosBindingSource4.DataMember = "Gastos";
            this.gastosBindingSource4.DataSource = this.tccUltimate;
            // 
            // tccUltimate
            // 
            this.tccUltimate.DataSetName = "tccUltimate";
            this.tccUltimate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastosBindingSource3
            // 
            this.gastosBindingSource3.DataMember = "Gastos";
            this.gastosBindingSource3.DataSource = this.tccUltimate;
            // 
            // gastosBindingSource2
            // 
            this.gastosBindingSource2.DataMember = "Gastos";
            this.gastosBindingSource2.DataSource = this.tccFinal;
            // 
            // txtManutencao
            // 
            this.txtManutencao.Location = new System.Drawing.Point(487, 50);
            this.txtManutencao.Name = "txtManutencao";
            this.txtManutencao.Size = new System.Drawing.Size(83, 20);
            this.txtManutencao.TabIndex = 5;
            this.txtManutencao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtManutencao_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "Cód. Funcionario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "Manutenção:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 103;
            this.label6.Text = "Cód. Viagem:";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(491, 104);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 7;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.Click += new System.EventHandler(this.RbSim_Click);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(539, 104);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 8;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.Click += new System.EventHandler(this.RbNao_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Possui multa:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(671, 218);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 23);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(671, 246);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Limpar Dados";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // gastosTableAdapter
            // 
            this.gastosTableAdapter.ClearBeforeFill = true;
            // 
            // cbViagem
            // 
            this.cbViagem.DataSource = this.viagemBindingSource;
            this.cbViagem.DisplayMember = "cod_viagem";
            this.cbViagem.FormattingEnabled = true;
            this.cbViagem.Location = new System.Drawing.Point(201, 75);
            this.cbViagem.Name = "cbViagem";
            this.cbViagem.Size = new System.Drawing.Size(83, 21);
            this.cbViagem.TabIndex = 107;
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DataSource = this.funcionarioBindingSource;
            this.cbFuncionario.DisplayMember = "cod_funcionario";
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(201, 50);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(83, 21);
            this.cbFuncionario.TabIndex = 108;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.tccUltimate;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // viagemBindingSource
            // 
            this.viagemBindingSource.DataMember = "Viagem";
            this.viagemBindingSource.DataSource = this.tccUltimate;
            // 
            // viagemTableAdapter
            // 
            this.viagemTableAdapter.ClearBeforeFill = true;
            // 
            // Financas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.cbViagem);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtManutencao);
            this.Controls.Add(this.gridFinancas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFinaizar);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.txtGasolina);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodGastos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Financas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Tech";
            this.Load += new System.EventHandler(this.Financas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viagemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private System.Windows.Forms.BindingSource gastosBindingSource;
      
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtMulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscaGasto;
        private System.Windows.Forms.TextBox txtPesqViagem;
        private System.Windows.Forms.Button btnFinaizar;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.TextBox txtGasolina;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodGastos;
        private tccFinal tccFinal;
        private System.Windows.Forms.BindingSource gastosBindingSource1;
        private tccFinalTableAdapters.GastosTableAdapter gastosTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridFinancas;
        private System.Windows.Forms.BindingSource gastosBindingSource2;
        private System.Windows.Forms.MaskedTextBox txtManutencao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codgastosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasolinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedagioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datamultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valormultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manutencaocorretivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codviagemDataGridViewTextBoxColumn;
        private tccUltimate tccUltimate;
        private System.Windows.Forms.BindingSource gastosBindingSource3;
        private tccUltimateTableAdapters.GastosTableAdapter gastosTableAdapter;
        private System.Windows.Forms.BindingSource gastosBindingSource4;
        private System.Windows.Forms.ComboBox cbViagem;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private tccUltimateTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource viagemBindingSource;
        private tccUltimateTableAdapters.ViagemTableAdapter viagemTableAdapter;
    }
}