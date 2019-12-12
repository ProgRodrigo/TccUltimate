namespace teste
{
    partial class Contratante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contratante));
            this.txtNomeCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCeluCon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContratacao = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarCon = new System.Windows.Forms.Button();
            this.btnExcluirCli = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailCon = new System.Windows.Forms.TextBox();
            this.contratanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridContratante = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratanteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tccUltimate = new teste.tccUltimate();
            this.contratanteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contratanteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.contratanteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.contratanteTableAdapter = new teste.tccUltimateTableAdapters.ContratanteTableAdapter();
            this.txtCod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCon
            // 
            this.txtNomeCon.Location = new System.Drawing.Point(187, 56);
            this.txtNomeCon.Name = "txtNomeCon";
            this.txtNomeCon.Size = new System.Drawing.Size(355, 20);
            this.txtNomeCon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nome Completo:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(187, 113);
            this.txtCnpj.Mask = "99.999.999/9999-99";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(108, 20);
            this.txtCnpj.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "CNPJ:";
            // 
            // txtCeluCon
            // 
            this.txtCeluCon.Location = new System.Drawing.Point(187, 139);
            this.txtCeluCon.Mask = "(99) 00000-0000";
            this.txtCeluCon.Name = "txtCeluCon";
            this.txtCeluCon.Size = new System.Drawing.Size(100, 20);
            this.txtCeluCon.TabIndex = 4;
         
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Contratação:";
            // 
            // txtContratacao
            // 
            this.txtContratacao.Location = new System.Drawing.Point(187, 165);
            this.txtContratacao.Mask = "00/00/0000";
            this.txtContratacao.Name = "txtContratacao";
            this.txtContratacao.Size = new System.Drawing.Size(82, 20);
            this.txtContratacao.TabIndex = 5;
            this.txtContratacao.ValidatingType = typeof(System.DateTime);
            // 
            // btnSalvarCon
            // 
            this.btnSalvarCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCon.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCon.Image")));
            this.btnSalvarCon.Location = new System.Drawing.Point(692, 111);
            this.btnSalvarCon.Name = "btnSalvarCon";
            this.btnSalvarCon.Size = new System.Drawing.Size(104, 49);
            this.btnSalvarCon.TabIndex = 7;
            this.btnSalvarCon.Text = "Salvar";
            this.btnSalvarCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarCon.UseVisualStyleBackColor = true;
            this.btnSalvarCon.Click += new System.EventHandler(this.BtnSalvarCon_Click_1);
            // 
            // btnExcluirCli
            // 
            this.btnExcluirCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCli.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCli.Image")));
            this.btnExcluirCli.Location = new System.Drawing.Point(692, 202);
            this.btnExcluirCli.Name = "btnExcluirCli";
            this.btnExcluirCli.Size = new System.Drawing.Size(104, 49);
            this.btnExcluirCli.TabIndex = 9;
            this.btnExcluirCli.Text = "Excluir";
            this.btnExcluirCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirCli.UseVisualStyleBackColor = true;
            this.btnExcluirCli.Click += new System.EventHandler(this.BtnExcluirCli_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Email:";
            // 
            // txtEmailCon
            // 
            this.txtEmailCon.Location = new System.Drawing.Point(187, 86);
            this.txtEmailCon.Name = "txtEmailCon";
            this.txtEmailCon.Size = new System.Drawing.Size(355, 20);
            this.txtEmailCon.TabIndex = 2;
            // 
            // gridContratante
            // 
            this.gridContratante.AllowUserToAddRows = false;
            this.gridContratante.AllowUserToDeleteRows = false;
            this.gridContratante.AllowUserToResizeColumns = false;
            this.gridContratante.AllowUserToResizeRows = false;
            this.gridContratante.AutoGenerateColumns = false;
            this.gridContratante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridContratante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridContratante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContratante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gridContratante.DataSource = this.contratanteBindingSource4;
            this.gridContratante.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridContratante.Location = new System.Drawing.Point(44, 215);
            this.gridContratante.Name = "gridContratante";
            this.gridContratante.ReadOnly = true;
            this.gridContratante.RowHeadersVisible = false;
            this.gridContratante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContratante.Size = new System.Drawing.Size(617, 186);
            this.gridContratante.TabIndex = 75;
            this.gridContratante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridContratante_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_contratante";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_contratante";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome completo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cnpj_contratante";
            this.dataGridViewTextBoxColumn3.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email_contratante";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefone_contratante";
            this.dataGridViewTextBoxColumn5.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "data_contratacao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Contratação";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // contratanteBindingSource4
            // 
            this.contratanteBindingSource4.DataMember = "Contratante";
            this.contratanteBindingSource4.DataSource = this.tccUltimate;
            // 
            // tccUltimate
            // 
            this.tccUltimate.DataSetName = "tccUltimate";
            this.tccUltimate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(692, 155);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(104, 49);
            this.btnAlterar.TabIndex = 8;
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
            this.btnNovo.Location = new System.Drawing.Point(692, 56);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(104, 49);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // contratanteBindingSource3
            // 
            this.contratanteBindingSource3.DataMember = "Contratante";
            this.contratanteBindingSource3.DataSource = this.tccUltimate;
            // 
            // contratanteTableAdapter
            // 
            this.contratanteTableAdapter.ClearBeforeFill = true;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(22, 215);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(25, 20);
            this.txtCod.TabIndex = 76;
            this.txtCod.Visible = false;
            // 
            // Contratante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gridContratante);
            this.Controls.Add(this.txtEmailCon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvarCon);
            this.Controls.Add(this.btnExcluirCli);
            this.Controls.Add(this.txtContratacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCeluCon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeCon);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contratante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contratante";
            this.Load += new System.EventHandler(this.Contratante_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUltimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCeluCon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtContratacao;
        private System.Windows.Forms.Button btnSalvarCon;
        private System.Windows.Forms.Button btnExcluirCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailCon;
        
   
        private System.Windows.Forms.BindingSource contratanteBindingSource;

        private System.Windows.Forms.DataGridView gridContratante;
        private System.Windows.Forms.BindingSource contratanteBindingSource1;
        private System.Windows.Forms.BindingSource contratanteBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcontratanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecontratanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjcontratanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcontratanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonecontratanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacontratacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private tccUltimate tccUltimate;
        private System.Windows.Forms.BindingSource contratanteBindingSource3;
        private tccUltimateTableAdapters.ContratanteTableAdapter contratanteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource contratanteBindingSource4;
        private System.Windows.Forms.TextBox txtCod;
    }
}