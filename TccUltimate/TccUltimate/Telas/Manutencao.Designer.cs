namespace teste
{
    partial class Manutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manutencao));
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dataManu = new System.Windows.Forms.MaskedTextBox();
            this.cbPreventiva = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gridManutencao = new System.Windows.Forms.DataGridView();
            this.codmanutencaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamanutencaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manutencaopreventivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusmanutencaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaveiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manutencaoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tccUltimate = new teste.tccUltimate();
            this.manutencaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tccFinal = new teste.tccFinal();
            this.manutencaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.manutencaoTableAdapter1 = new teste.tccFinalTableAdapters.ManutencaoTableAdapter();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.manutencaoTableAdapter = new teste.tccUltimateTableAdapters.ManutencaoTableAdapter();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoTableAdapter = new teste.tccUltimateTableAdapters.VeiculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridManutencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "OK",
            "C/Pendências"});
            this.cbStatus.Location = new System.Drawing.Point(525, 53);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(79, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // dataManu
            // 
            this.dataManu.Location = new System.Drawing.Point(525, 98);
            this.dataManu.Mask = "99/99/9999";
            this.dataManu.Name = "dataManu";
            this.dataManu.Size = new System.Drawing.Size(79, 20);
            this.dataManu.TabIndex = 4;
            this.dataManu.ValidatingType = typeof(System.DateTime);
            // 
            // cbPreventiva
            // 
            this.cbPreventiva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreventiva.FormattingEnabled = true;
            this.cbPreventiva.Items.AddRange(new object[] {
            "Realizada",
            "Pendente"});
            this.cbPreventiva.Location = new System.Drawing.Point(234, 97);
            this.cbPreventiva.Name = "cbPreventiva";
            this.cbPreventiva.Size = new System.Drawing.Size(79, 21);
            this.cbPreventiva.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Manutenção Preventiva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Status:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(638, 118);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 49);
            this.btnSalvar.TabIndex = 6;
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
            this.btnExcluir.Location = new System.Drawing.Point(638, 228);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 49);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // gridManutencao
            // 
            this.gridManutencao.AllowUserToAddRows = false;
            this.gridManutencao.AllowUserToDeleteRows = false;
            this.gridManutencao.AllowUserToResizeColumns = false;
            this.gridManutencao.AllowUserToResizeRows = false;
            this.gridManutencao.AutoGenerateColumns = false;
            this.gridManutencao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridManutencao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridManutencao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridManutencao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codmanutencaoDataGridViewTextBoxColumn,
            this.datamanutencaoDataGridViewTextBoxColumn,
            this.manutencaopreventivaDataGridViewTextBoxColumn,
            this.statusmanutencaoDataGridViewTextBoxColumn,
            this.placaveiculoDataGridViewTextBoxColumn});
            this.gridManutencao.DataSource = this.manutencaoBindingSource2;
            this.gridManutencao.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridManutencao.Location = new System.Drawing.Point(128, 183);
            this.gridManutencao.Name = "gridManutencao";
            this.gridManutencao.ReadOnly = true;
            this.gridManutencao.RowHeadersVisible = false;
            this.gridManutencao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridManutencao.Size = new System.Drawing.Size(476, 188);
            this.gridManutencao.TabIndex = 76;
            this.gridManutencao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridManutencao_CellContentClick);
            // 
            // codmanutencaoDataGridViewTextBoxColumn
            // 
            this.codmanutencaoDataGridViewTextBoxColumn.DataPropertyName = "cod_manutencao";
            this.codmanutencaoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codmanutencaoDataGridViewTextBoxColumn.Name = "codmanutencaoDataGridViewTextBoxColumn";
            this.codmanutencaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codmanutencaoDataGridViewTextBoxColumn.Width = 50;
            // 
            // datamanutencaoDataGridViewTextBoxColumn
            // 
            this.datamanutencaoDataGridViewTextBoxColumn.DataPropertyName = "data_manutencao";
            this.datamanutencaoDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datamanutencaoDataGridViewTextBoxColumn.Name = "datamanutencaoDataGridViewTextBoxColumn";
            this.datamanutencaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manutencaopreventivaDataGridViewTextBoxColumn
            // 
            this.manutencaopreventivaDataGridViewTextBoxColumn.DataPropertyName = "manutencao_preventiva";
            this.manutencaopreventivaDataGridViewTextBoxColumn.HeaderText = "Mant. Preventiva";
            this.manutencaopreventivaDataGridViewTextBoxColumn.Name = "manutencaopreventivaDataGridViewTextBoxColumn";
            this.manutencaopreventivaDataGridViewTextBoxColumn.ReadOnly = true;
            this.manutencaopreventivaDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusmanutencaoDataGridViewTextBoxColumn
            // 
            this.statusmanutencaoDataGridViewTextBoxColumn.DataPropertyName = "status_manutencao";
            this.statusmanutencaoDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusmanutencaoDataGridViewTextBoxColumn.Name = "statusmanutencaoDataGridViewTextBoxColumn";
            this.statusmanutencaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaveiculoDataGridViewTextBoxColumn
            // 
            this.placaveiculoDataGridViewTextBoxColumn.DataPropertyName = "placa_veiculo";
            this.placaveiculoDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaveiculoDataGridViewTextBoxColumn.Name = "placaveiculoDataGridViewTextBoxColumn";
            this.placaveiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manutencaoBindingSource2
            // 
            this.manutencaoBindingSource2.DataMember = "Manutencao";
            this.manutencaoBindingSource2.DataSource = this.tccUltimate;
            // 
            // tccUltimate
            // 
            this.tccUltimate.DataSetName = "tccUltimate";
            this.tccUltimate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manutencaoBindingSource1
            // 
            this.manutencaoBindingSource1.DataMember = "Manutencao";
            this.manutencaoBindingSource1.DataSource = this.tccFinal;
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
            this.btnAlterar.Location = new System.Drawing.Point(638, 173);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(106, 49);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Inf. Placa:";
            // 
            // manutencaoTableAdapter1
            // 
            this.manutencaoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(638, 64);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(104, 49);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(105, 183);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(23, 20);
            this.txtCod.TabIndex = 82;
            this.txtCod.Visible = false;
            // 
            // manutencaoTableAdapter
            // 
            this.manutencaoTableAdapter.ClearBeforeFill = true;
            // 
            // cbPlaca
            // 
            this.cbPlaca.DataSource = this.veiculoBindingSource;
            this.cbPlaca.DisplayMember = "placa_veiculo";
            this.cbPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(234, 57);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(79, 21);
            this.cbPlaca.TabIndex = 1;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this.tccUltimate;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // Manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 373);
            this.Controls.Add(this.cbPlaca);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gridManutencao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPreventiva);
            this.Controls.Add(this.dataManu);
            this.Controls.Add(this.cbStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutencao";
            this.Load += new System.EventHandler(this.Manutencao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridManutencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.MaskedTextBox dataManu;
        private System.Windows.Forms.ComboBox cbPreventiva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView gridManutencao;

        private System.Windows.Forms.BindingSource manutencaoBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn codmanutencaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datamanutencaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manutencaopreventivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusmanutencaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaveiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label6;
        private tccFinal tccFinal;
        private System.Windows.Forms.BindingSource manutencaoBindingSource1;
        private tccFinalTableAdapters.ManutencaoTableAdapter manutencaoTableAdapter1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtCod;
        private tccUltimate tccUltimate;
        private System.Windows.Forms.BindingSource manutencaoBindingSource2;
        private tccUltimateTableAdapters.ManutencaoTableAdapter manutencaoTableAdapter;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private tccUltimateTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
    }
}