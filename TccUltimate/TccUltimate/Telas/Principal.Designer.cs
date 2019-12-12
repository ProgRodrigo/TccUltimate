namespace teste
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnManutencao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContratante = new System.Windows.Forms.Button();
            this.btnFinan = new System.Windows.Forms.Button();
            this.btnViagem = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnVeiculo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(386, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(106, 16);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Bem Vindo(a)!";
            // 
            // btnManutencao
            // 
            this.btnManutencao.BackColor = System.Drawing.Color.Transparent;
            this.btnManutencao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManutencao.BackgroundImage")));
            this.btnManutencao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManutencao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManutencao.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnManutencao.Location = new System.Drawing.Point(523, 238);
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Size = new System.Drawing.Size(117, 83);
            this.btnManutencao.TabIndex = 12;
            this.btnManutencao.Text = "Manutenção";
            this.btnManutencao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManutencao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManutencao.UseVisualStyleBackColor = false;
            this.btnManutencao.Click += new System.EventHandler(this.BtnManutencao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnContratante
            // 
            this.btnContratante.BackColor = System.Drawing.Color.Transparent;
            this.btnContratante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContratante.BackgroundImage")));
            this.btnContratante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContratante.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContratante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnContratante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnContratante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContratante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContratante.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnContratante.Location = new System.Drawing.Point(125, 238);
            this.btnContratante.Name = "btnContratante";
            this.btnContratante.Size = new System.Drawing.Size(117, 83);
            this.btnContratante.TabIndex = 9;
            this.btnContratante.Text = "Contratante";
            this.btnContratante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContratante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContratante.UseVisualStyleBackColor = false;
            this.btnContratante.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnFinan
            // 
            this.btnFinan.BackColor = System.Drawing.Color.Transparent;
            this.btnFinan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinan.BackgroundImage")));
            this.btnFinan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinan.Location = new System.Drawing.Point(523, 140);
            this.btnFinan.Name = "btnFinan";
            this.btnFinan.Size = new System.Drawing.Size(117, 83);
            this.btnFinan.TabIndex = 8;
            this.btnFinan.Text = "Finanças";
            this.btnFinan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFinan.UseVisualStyleBackColor = false;
            this.btnFinan.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnViagem
            // 
            this.btnViagem.BackColor = System.Drawing.Color.Transparent;
            this.btnViagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViagem.BackgroundImage")));
            this.btnViagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViagem.Location = new System.Drawing.Point(337, 238);
            this.btnViagem.Name = "btnViagem";
            this.btnViagem.Size = new System.Drawing.Size(117, 83);
            this.btnViagem.TabIndex = 6;
            this.btnViagem.Text = "Viagem";
            this.btnViagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViagem.UseVisualStyleBackColor = false;
            this.btnViagem.Click += new System.EventHandler(this.Button7_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.BackgroundImage")));
            this.btnFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(125, 140);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(117, 83);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "Funcionario";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.btnVeiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVeiculo.BackgroundImage")));
            this.btnVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVeiculo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeiculo.Location = new System.Drawing.Point(337, 140);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(117, 83);
            this.btnVeiculo.TabIndex = 2;
            this.btnVeiculo.Text = "Veículo";
            this.btnVeiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeiculo.UseVisualStyleBackColor = false;
            this.btnVeiculo.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(761, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 51);
            this.button1.TabIndex = 13;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManutencao);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnContratante);
            this.Controls.Add(this.btnFinan);
            this.Controls.Add(this.btnViagem);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnVeiculo);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Tech";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVeiculo;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnViagem;
        private System.Windows.Forms.Button btnFinan;
        private System.Windows.Forms.Button btnContratante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnManutencao;
        private System.Windows.Forms.Button button1;
    }
}

