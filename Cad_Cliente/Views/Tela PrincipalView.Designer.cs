
namespace Cad_Cliente.screens
{
    partial class Tela_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.novoEditarExcluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finançasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPrincipal,
            this.cadastrarFuncionario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoEditarExcluirToolStripMenuItem});
            this.MenuPrincipal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(56, 20);
            this.MenuPrincipal.Text = "Menu";
            // 
            // novoEditarExcluirToolStripMenuItem
            // 
            this.novoEditarExcluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.pedidoToolStripMenuItem1,
            this.finançasToolStripMenuItem});
            this.novoEditarExcluirToolStripMenuItem.Name = "novoEditarExcluirToolStripMenuItem";
            this.novoEditarExcluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoEditarExcluirToolStripMenuItem.Text = "Tabelas";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem1
            // 
            this.pedidoToolStripMenuItem1.Name = "pedidoToolStripMenuItem1";
            this.pedidoToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.pedidoToolStripMenuItem1.Text = "Pedido";
            this.pedidoToolStripMenuItem1.Click += new System.EventHandler(this.pedidoToolStripMenuItem1_Click);
            // 
            // finançasToolStripMenuItem
            // 
            this.finançasToolStripMenuItem.Name = "finançasToolStripMenuItem";
            this.finançasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.finançasToolStripMenuItem.Text = "Finanças";
            this.finançasToolStripMenuItem.Click += new System.EventHandler(this.finançasToolStripMenuItem_Click);
            // 
            // cadastrarFuncionario
            // 
            this.cadastrarFuncionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarFuncionario.Name = "cadastrarFuncionario";
            this.cadastrarFuncionario.Size = new System.Drawing.Size(166, 20);
            this.cadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.cadastrarFuncionario.Visible = false;
            this.cadastrarFuncionario.Click += new System.EventHandler(this.cadastrarFuncionario_Click);
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(708, 317);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem novoEditarExcluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finançasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionario;
    }
}