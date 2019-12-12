namespace teste
{
    partial class Veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veiculo));
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnBuscarVei = new System.Windows.Forms.Button();
            this.rbModelo = new System.Windows.Forms.RadioButton();
            this.txtPesquisaVei = new System.Windows.Forms.TextBox();
            this.rbPlaca = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModeloVei = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.cbSeguro = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarVei = new System.Windows.Forms.Button();
            this.btnExcluirVei = new System.Windows.Forms.Button();
            this.tbVeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridVeiculo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tccUltimate = new teste.tccUltimate();
            this.veiculoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tccFinal = new teste.tccFinal();
            this.veiculoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.veiculoTableAdapter1 = new teste.tccFinalTableAdapters.VeiculoTableAdapter();
            this.veiculoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoTableAdapter = new teste.tccUltimateTableAdapters.VeiculoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVeiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(518, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Seguro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.btnBuscarVei);
            this.groupBox1.Controls.Add(this.rbModelo);
            this.groupBox1.Controls.Add(this.txtPesquisaVei);
            this.groupBox1.Controls.Add(this.rbPlaca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(208, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 74);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(16, 51);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(60, 17);
            this.rbTodos.TabIndex = 16;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscarVei
            // 
            this.btnBuscarVei.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarVei.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarVei.Image")));
            this.btnBuscarVei.Location = new System.Drawing.Point(279, 17);
            this.btnBuscarVei.Name = "btnBuscarVei";
            this.btnBuscarVei.Size = new System.Drawing.Size(76, 41);
            this.btnBuscarVei.TabIndex = 13;
            this.btnBuscarVei.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarVei.UseVisualStyleBackColor = true;
            this.btnBuscarVei.Click += new System.EventHandler(this.BtnBuscarVei_Click);
            // 
            // rbModelo
            // 
            this.rbModelo.AutoSize = true;
            this.rbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModelo.Location = new System.Drawing.Point(172, 51);
            this.rbModelo.Name = "rbModelo";
            this.rbModelo.Size = new System.Drawing.Size(66, 17);
            this.rbModelo.TabIndex = 15;
            this.rbModelo.TabStop = true;
            this.rbModelo.Text = "Modelo";
            this.rbModelo.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaVei
            // 
            this.txtPesquisaVei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisaVei.Location = new System.Drawing.Point(16, 25);
            this.txtPesquisaVei.Name = "txtPesquisaVei";
            this.txtPesquisaVei.Size = new System.Drawing.Size(232, 26);
            this.txtPesquisaVei.TabIndex = 12;
            // 
            // rbPlaca
            // 
            this.rbPlaca.AutoSize = true;
            this.rbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlaca.Location = new System.Drawing.Point(97, 51);
            this.rbPlaca.Name = "rbPlaca";
            this.rbPlaca.Size = new System.Drawing.Size(57, 17);
            this.rbPlaca.TabIndex = 14;
            this.rbPlaca.TabStop = true;
            this.rbPlaca.Text = "Placa";
            this.rbPlaca.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Modelo:";
            // 
            // txtModeloVei
            // 
            this.txtModeloVei.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModeloVei.Location = new System.Drawing.Point(285, 99);
            this.txtModeloVei.Name = "txtModeloVei";
            this.txtModeloVei.Size = new System.Drawing.Size(82, 20);
            this.txtModeloVei.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Placa:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(454, 99);
            this.txtAno.Mask = "9999";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(75, 20);
            this.txtAno.TabIndex = 50;
            this.txtAno.ValidatingType = typeof(System.DateTime);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(391, 43);
            this.txtPlaca.Mask = ">?>?>?-####";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(82, 20);
            this.txtPlaca.TabIndex = 51;
            this.txtPlaca.ValidatingType = typeof(System.DateTime);
            // 
            // cbSeguro
            // 
            this.cbSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeguro.FormattingEnabled = true;
            this.cbSeguro.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbSeguro.Location = new System.Drawing.Point(596, 42);
            this.cbSeguro.Name = "cbSeguro";
            this.cbSeguro.Size = new System.Drawing.Size(75, 21);
            this.cbSeguro.TabIndex = 52;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Van",
            "Mini Van",
            "Bicicleta"});
            this.cbTipo.Location = new System.Drawing.Point(181, 39);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(86, 21);
            this.cbTipo.TabIndex = 53;
              // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Categoria:";
            // 
            // btnSalvarVei
            // 
            this.btnSalvarVei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarVei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarVei.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarVei.Image")));
            this.btnSalvarVei.Location = new System.Drawing.Point(695, 125);
            this.btnSalvarVei.Name = "btnSalvarVei";
            this.btnSalvarVei.Size = new System.Drawing.Size(101, 49);
            this.btnSalvarVei.TabIndex = 41;
            this.btnSalvarVei.Text = "Salvar";
            this.btnSalvarVei.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarVei.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarVei.UseVisualStyleBackColor = true;
            this.btnSalvarVei.Click += new System.EventHandler(this.BtnSalvarVei_Click);
            // 
            // btnExcluirVei
            // 
            this.btnExcluirVei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirVei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVei.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirVei.Image")));
            this.btnExcluirVei.Location = new System.Drawing.Point(695, 241);
            this.btnExcluirVei.Name = "btnExcluirVei";
            this.btnExcluirVei.Size = new System.Drawing.Size(101, 49);
            this.btnExcluirVei.TabIndex = 40;
            this.btnExcluirVei.Text = "Excluir";
            this.btnExcluirVei.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirVei.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirVei.UseVisualStyleBackColor = true;
            this.btnExcluirVei.Click += new System.EventHandler(this.BtnExcluirVei_Click);
            // 
            // gridVeiculo
            // 
            this.gridVeiculo.AllowUserToAddRows = false;
            this.gridVeiculo.AllowUserToDeleteRows = false;
            this.gridVeiculo.AllowUserToResizeColumns = false;
            this.gridVeiculo.AllowUserToResizeRows = false;
            this.gridVeiculo.AutoGenerateColumns = false;
            this.gridVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridVeiculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gridVeiculo.DataSource = this.veiculoBindingSource5;
            this.gridVeiculo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridVeiculo.Location = new System.Drawing.Point(152, 220);
            this.gridVeiculo.Name = "gridVeiculo";
            this.gridVeiculo.ReadOnly = true;
            this.gridVeiculo.RowHeadersVisible = false;
            this.gridVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVeiculo.Size = new System.Drawing.Size(507, 163);
            this.gridVeiculo.TabIndex = 57;
            this.gridVeiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVeiculo_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "placa_veiculo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipo_veiculo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "modelo_veiculo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ano_veiculo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "seguro_veiculo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Seguro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // veiculoBindingSource5
            // 
            this.veiculoBindingSource5.DataMember = "Veiculo";
            this.veiculoBindingSource5.DataSource = this.tccUltimate;
            // 
            // tccUltimate
            // 
            this.tccUltimate.DataSetName = "tccUltimate";
            this.tccUltimate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculoBindingSource3
            // 
            this.veiculoBindingSource3.DataMember = "Veiculo";
            this.veiculoBindingSource3.DataSource = this.tccFinal;
            // 
            // tccFinal
            // 
            this.tccFinal.DataSetName = "tccFinal";
            this.tccFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(695, 186);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 49);
            this.btnAlterar.TabIndex = 58;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(695, 70);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(101, 49);
            this.btnNovo.TabIndex = 59;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // veiculoTableAdapter1
            // 
            this.veiculoTableAdapter1.ClearBeforeFill = true;
            // 
            // veiculoBindingSource4
            // 
            this.veiculoBindingSource4.DataMember = "Veiculo";
            this.veiculoBindingSource4.DataSource = this.tccUltimate;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gridVeiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbSeguro);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvarVei);
            this.Controls.Add(this.btnExcluirVei);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModeloVei);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Veiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculo";
            this.Load += new System.EventHandler(this.Veiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVeiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarVei;
        private System.Windows.Forms.RadioButton rbModelo;
        private System.Windows.Forms.TextBox txtPesquisaVei;
        private System.Windows.Forms.RadioButton rbPlaca;
        private System.Windows.Forms.Button btnSalvarVei;
        private System.Windows.Forms.Button btnExcluirVei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModeloVei;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.BindingSource tbVeiculoBindingSource;
        
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.ComboBox cbSeguro;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridVeiculo;

        private System.Windows.Forms.BindingSource veiculoBindingSource;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn placaveiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoveiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloveiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoveiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguroveiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tccDataSetBindingSource;
 
        private System.Windows.Forms.BindingSource tccDataSetBindingSource1;
   
        private System.Windows.Forms.BindingSource veiculoBindingSource1;

        private System.Windows.Forms.BindingSource veiculoBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private tccFinal tccFinal;
        private System.Windows.Forms.BindingSource veiculoBindingSource3;
        private tccFinalTableAdapters.VeiculoTableAdapter veiculoTableAdapter1;
        private tccUltimate tccUltimate;
        private System.Windows.Forms.BindingSource veiculoBindingSource4;
        private tccUltimateTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.BindingSource veiculoBindingSource5;
    }
}