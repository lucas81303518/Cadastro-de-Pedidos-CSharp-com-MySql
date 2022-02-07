
namespace Cad_Cliente.Views
{
    partial class CadastroPedidoView
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCliente_Pedido = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.dtEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtPedido = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFormaPag = new System.Windows.Forms.ComboBox();
            this.txtValTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnSalvarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aguardando Pagamento",
            "Montar Arte",
            "Impressão",
            "Produção",
            "Finalizado",
            "Entregue"});
            this.cbStatus.Location = new System.Drawing.Point(533, 32);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(172, 25);
            this.cbStatus.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(530, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 86;
            this.label11.Text = "Status:";
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.Location = new System.Drawing.Point(344, 175);
            this.txtCusto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(168, 22);
            this.txtCusto.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(340, 147);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "Custo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "Selecionar cliente:";
            // 
            // cbCliente_Pedido
            // 
            this.cbCliente_Pedido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCliente_Pedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbCliente_Pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente_Pedido.FormattingEnabled = true;
            this.cbCliente_Pedido.Location = new System.Drawing.Point(10, 32);
            this.cbCliente_Pedido.Margin = new System.Windows.Forms.Padding(4);
            this.cbCliente_Pedido.Name = "cbCliente_Pedido";
            this.cbCliente_Pedido.Size = new System.Drawing.Size(261, 25);
            this.cbCliente_Pedido.TabIndex = 67;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(10, 98);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(396, 22);
            this.txtProduto.TabIndex = 68;
            // 
            // dtEntrega
            // 
            this.dtEntrega.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtEntrega.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntrega.Location = new System.Drawing.Point(533, 235);
            this.dtEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.dtEntrega.Name = "dtEntrega";
            this.dtEntrega.Size = new System.Drawing.Size(140, 22);
            this.dtEntrega.TabIndex = 75;
            // 
            // dtPedido
            // 
            this.dtPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtPedido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPedido.Location = new System.Drawing.Point(533, 159);
            this.dtPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dtPedido.Name = "dtPedido";
            this.dtPedido.Size = new System.Drawing.Size(135, 22);
            this.dtPedido.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(529, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 83;
            this.label9.Text = "Data de Entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "Data do Pedido:";
            // 
            // txtValPago
            // 
            this.txtValPago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValPago.Location = new System.Drawing.Point(167, 175);
            this.txtValPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValPago.Name = "txtValPago";
            this.txtValPago.Size = new System.Drawing.Size(168, 22);
            this.txtValPago.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Valor Pago:";
            // 
            // cbFormaPag
            // 
            this.cbFormaPag.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbFormaPag.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaPag.FormattingEnabled = true;
            this.cbFormaPag.Items.AddRange(new object[] {
            "Pix",
            "Dinheiro",
            "Boleto",
            "Deposito",
            "Site"});
            this.cbFormaPag.Location = new System.Drawing.Point(533, 95);
            this.cbFormaPag.Margin = new System.Windows.Forms.Padding(4);
            this.cbFormaPag.Name = "cbFormaPag";
            this.cbFormaPag.Size = new System.Drawing.Size(147, 25);
            this.cbFormaPag.TabIndex = 73;
            // 
            // txtValTotal
            // 
            this.txtValTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValTotal.Location = new System.Drawing.Point(9, 175);
            this.txtValTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtValTotal.Name = "txtValTotal";
            this.txtValTotal.Size = new System.Drawing.Size(148, 22);
            this.txtValTotal.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Valor Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Produto:";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackColor = System.Drawing.Color.White;
            this.btnCancelarPedido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPedido.Image = global::Cad_Cliente.Properties.Resources.icons8_cancelar_assinatura_481;
            this.btnCancelarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPedido.Location = new System.Drawing.Point(170, 292);
            this.btnCancelarPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(115, 43);
            this.btnCancelarPedido.TabIndex = 88;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.BackColor = System.Drawing.Color.White;
            this.btnSalvarPedido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPedido.Image = global::Cad_Cliente.Properties.Resources.icons8_salvar_482;
            this.btnSalvarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarPedido.Location = new System.Drawing.Point(45, 292);
            this.btnSalvarPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(115, 43);
            this.btnSalvarPedido.TabIndex = 87;
            this.btnSalvarPedido.Text = "Salvar";
            this.btnSalvarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarPedido.UseVisualStyleBackColor = false;
            this.btnSalvarPedido.Click += new System.EventHandler(this.btnSalvarPedido_Click);
            // 
            // CadastroPedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Cad_Cliente.Properties.Resources.img_pedido;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(712, 408);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnSalvarPedido);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCliente_Pedido);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.dtEntrega);
            this.Controls.Add(this.dtPedido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFormaPag);
            this.Controls.Add(this.txtValTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "CadastroPedidoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroPedido";
            this.Load += new System.EventHandler(this.CadastroPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCliente_Pedido;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.DateTimePicker dtEntrega;
        private System.Windows.Forms.DateTimePicker dtPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFormaPag;
        private System.Windows.Forms.TextBox txtValTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnSalvarPedido;
    }
}