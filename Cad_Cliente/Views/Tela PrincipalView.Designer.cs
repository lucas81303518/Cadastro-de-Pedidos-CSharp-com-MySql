
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPrincipal});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
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
            this.novoEditarExcluirToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 41);
            this.label1.TabIndex = 31;
            this.label1.Text = "ao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 41);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bem Vindo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 41);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sistema";
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cad_Cliente.Properties.Resources.capa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(610, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem novoEditarExcluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finançasToolStripMenuItem;
    }
}