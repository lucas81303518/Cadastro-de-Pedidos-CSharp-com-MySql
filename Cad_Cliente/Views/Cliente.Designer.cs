
namespace Cad_Cliente
{
    partial class Cliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.txtBusca_Cliente = new System.Windows.Forms.TextBox();
            this.tp_Novo = new System.Windows.Forms.ToolTip(this.components);
            this.tp_Editar = new System.Windows.Forms.ToolTip(this.components);
            this.tp_Excluir = new System.Windows.Forms.ToolTip(this.components);
            this.tp_Consultar = new System.Windows.Forms.ToolTip(this.components);
            this.tp_Exibir = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvCliente
            // 
            this.DgvCliente.AllowUserToAddRows = false;
            this.DgvCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvCliente.BackgroundColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCliente.GridColor = System.Drawing.Color.LightGray;
            this.DgvCliente.Location = new System.Drawing.Point(13, 78);
            this.DgvCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvCliente.MultiSelect = false;
            this.DgvCliente.Name = "DgvCliente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCliente.Size = new System.Drawing.Size(679, 226);
            this.DgvCliente.TabIndex = 12;
            this.DgvCliente.TabStop = false;
            this.DgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCliente_CellClick);
            // 
            // txtBusca_Cliente
            // 
            this.txtBusca_Cliente.Location = new System.Drawing.Point(469, 47);
            this.txtBusca_Cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusca_Cliente.Name = "txtBusca_Cliente";
            this.txtBusca_Cliente.Size = new System.Drawing.Size(223, 23);
            this.txtBusca_Cliente.TabIndex = 27;
            this.txtBusca_Cliente.TextChanged += new System.EventHandler(this.txtBusca_Cliente_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCliente,
            this.editarCliente,
            this.excluirCliente,
            this.atualizarCliente});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 25);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoCliente
            // 
            this.novoCliente.Image = global::Cad_Cliente.Properties.Resources.user1;
            this.novoCliente.Name = "novoCliente";
            this.novoCliente.Size = new System.Drawing.Size(69, 21);
            this.novoCliente.Text = "Novo";
            this.novoCliente.Click += new System.EventHandler(this.novoCliente_Click);
            // 
            // editarCliente
            // 
            this.editarCliente.Image = global::Cad_Cliente.Properties.Resources.icons8_editar_nó_481;
            this.editarCliente.Name = "editarCliente";
            this.editarCliente.Size = new System.Drawing.Size(70, 21);
            this.editarCliente.Text = "Editar";
            this.editarCliente.Click += new System.EventHandler(this.editarCliente_Click);
            // 
            // excluirCliente
            // 
            this.excluirCliente.Image = global::Cad_Cliente.Properties.Resources.ExcluirBarra;
            this.excluirCliente.Name = "excluirCliente";
            this.excluirCliente.Size = new System.Drawing.Size(73, 21);
            this.excluirCliente.Text = "Excluir";
            this.excluirCliente.Click += new System.EventHandler(this.excluirCliente_Click);
            // 
            // atualizarCliente
            // 
            this.atualizarCliente.Image = global::Cad_Cliente.Properties.Resources.icons8_sincronizar_100;
            this.atualizarCliente.Name = "atualizarCliente";
            this.atualizarCliente.Size = new System.Drawing.Size(88, 21);
            this.atualizarCliente.Text = "Atualizar";
            this.atualizarCliente.Click += new System.EventHandler(this.atualizarCliente_Click);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Buscar cliente:";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca_Cliente);
            this.Controls.Add(this.DgvCliente);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvCliente;
        private System.Windows.Forms.TextBox txtBusca_Cliente;
        private System.Windows.Forms.ToolTip tp_Novo;
        private System.Windows.Forms.ToolTip tp_Editar;
        private System.Windows.Forms.ToolTip tp_Excluir;
        private System.Windows.Forms.ToolTip tp_Consultar;
        private System.Windows.Forms.ToolTip tp_Exibir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCliente;
        private System.Windows.Forms.ToolStripMenuItem editarCliente;
        private System.Windows.Forms.ToolStripMenuItem excluirCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem atualizarCliente;
    }
}

