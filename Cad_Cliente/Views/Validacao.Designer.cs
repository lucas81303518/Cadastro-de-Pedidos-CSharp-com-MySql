
namespace Cad_Cliente
{
    partial class Tela_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.check_Senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBox_Senha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(108, 146);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(380, 22);
            this.txtLogin.TabIndex = 1;
            // 
            // check_Senha
            // 
            this.check_Senha.AutoSize = true;
            this.check_Senha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Senha.Location = new System.Drawing.Point(104, 118);
            this.check_Senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.check_Senha.Name = "check_Senha";
            this.check_Senha.Size = new System.Drawing.Size(55, 21);
            this.check_Senha.TabIndex = 33;
            this.check_Senha.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(108, 209);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(380, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(108, 252);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 27);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBox_Senha
            // 
            this.checkBox_Senha.AutoSize = true;
            this.checkBox_Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox_Senha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Senha.Location = new System.Drawing.Point(376, 239);
            this.checkBox_Senha.Name = "checkBox_Senha";
            this.checkBox_Senha.Size = new System.Drawing.Size(112, 21);
            this.checkBox_Senha.TabIndex = 38;
            this.checkBox_Senha.Text = "Mostrar Senha";
            this.checkBox_Senha.UseVisualStyleBackColor = false;
            this.checkBox_Senha.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cad_Cliente.Properties.Resources.Logotipo_maluart2;
            this.ClientSize = new System.Drawing.Size(610, 349);
            this.Controls.Add(this.checkBox_Senha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.check_Senha);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label check_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBox_Senha;
    }
}