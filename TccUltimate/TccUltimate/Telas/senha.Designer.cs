namespace teste
{
    partial class Senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Senha));
            this.btnCadastrarSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmaNewSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.lbCon = new System.Windows.Forms.Label();
            this.lbNew = new System.Windows.Forms.Label();
            this.lbAtual = new System.Windows.Forms.Label();
            this.lbUsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarSenha
            // 
            this.btnCadastrarSenha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCadastrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSenha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSenha.Location = new System.Drawing.Point(65, 190);
            this.btnCadastrarSenha.Name = "btnCadastrarSenha";
            this.btnCadastrarSenha.Size = new System.Drawing.Size(162, 36);
            this.btnCadastrarSenha.TabIndex = 5;
            this.btnCadastrarSenha.Text = "Cadastrar";
            this.btnCadastrarSenha.UseVisualStyleBackColor = false;
            this.btnCadastrarSenha.Click += new System.EventHandler(this.BtnCadastrarSenha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nova senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirmar senha:";
            // 
            // txtNewSenha
            // 
            this.txtNewSenha.Location = new System.Drawing.Point(123, 79);
            this.txtNewSenha.Name = "txtNewSenha";
            this.txtNewSenha.Size = new System.Drawing.Size(133, 20);
            this.txtNewSenha.TabIndex = 3;
            this.txtNewSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmaNewSenha
            // 
            this.txtConfirmaNewSenha.Location = new System.Drawing.Point(123, 111);
            this.txtConfirmaNewSenha.Name = "txtConfirmaNewSenha";
            this.txtConfirmaNewSenha.Size = new System.Drawing.Size(133, 20);
            this.txtConfirmaNewSenha.TabIndex = 4;
            this.txtConfirmaNewSenha.UseSystemPasswordChar = true;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(123, 50);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(133, 20);
            this.txtSenhaAtual.TabIndex = 2;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha atual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email/Usúario:";
            // 
            // txtUsu
            // 
            this.txtUsu.Location = new System.Drawing.Point(123, 24);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(133, 20);
            this.txtUsu.TabIndex = 1;
            // 
            // lbCon
            // 
            this.lbCon.AutoSize = true;
            this.lbCon.ForeColor = System.Drawing.Color.Red;
            this.lbCon.Location = new System.Drawing.Point(262, 113);
            this.lbCon.Name = "lbCon";
            this.lbCon.Size = new System.Drawing.Size(17, 13);
            this.lbCon.TabIndex = 18;
            this.lbCon.Text = "(*)";
            this.lbCon.Visible = false;
            // 
            // lbNew
            // 
            this.lbNew.AutoSize = true;
            this.lbNew.ForeColor = System.Drawing.Color.Red;
            this.lbNew.Location = new System.Drawing.Point(262, 82);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(17, 13);
            this.lbNew.TabIndex = 17;
            this.lbNew.Text = "(*)";
            this.lbNew.Visible = false;
            // 
            // lbAtual
            // 
            this.lbAtual.AutoSize = true;
            this.lbAtual.ForeColor = System.Drawing.Color.Red;
            this.lbAtual.Location = new System.Drawing.Point(262, 57);
            this.lbAtual.Name = "lbAtual";
            this.lbAtual.Size = new System.Drawing.Size(17, 13);
            this.lbAtual.TabIndex = 16;
            this.lbAtual.Text = "(*)";
            this.lbAtual.Visible = false;
            // 
            // lbUsu
            // 
            this.lbUsu.AutoSize = true;
            this.lbUsu.ForeColor = System.Drawing.Color.Red;
            this.lbUsu.Location = new System.Drawing.Point(262, 26);
            this.lbUsu.Name = "lbUsu";
            this.lbUsu.Size = new System.Drawing.Size(17, 13);
            this.lbUsu.TabIndex = 15;
            this.lbUsu.Text = "(*)";
            this.lbUsu.Visible = false;
            // 
            // Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbCon);
            this.Controls.Add(this.lbNew);
            this.Controls.Add(this.lbAtual);
            this.Controls.Add(this.lbUsu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.txtConfirmaNewSenha);
            this.Controls.Add(this.txtNewSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Senha";
            this.Load += new System.EventHandler(this.Senha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewSenha;
        private System.Windows.Forms.TextBox txtConfirmaNewSenha;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label lbCon;
        private System.Windows.Forms.Label lbNew;
        private System.Windows.Forms.Label lbAtual;
        private System.Windows.Forms.Label lbUsu;
    }
}