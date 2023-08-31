namespace Vendas
{
    partial class Form1
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
            this.lblCodPedido = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisarPedido = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProdutosPedido = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGravarProduto = new System.Windows.Forms.Button();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncluiPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncluiNomeProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIncluiProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnCarregaProdutos = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.btnSelecionarProduto = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodPedido
            // 
            this.lblCodPedido.AutoSize = true;
            this.lblCodPedido.Location = new System.Drawing.Point(54, 37);
            this.lblCodPedido.Name = "lblCodPedido";
            this.lblCodPedido.Size = new System.Drawing.Size(43, 13);
            this.lblCodPedido.TabIndex = 0;
            this.lblCodPedido.Text = "Pedido:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(103, 34);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(100, 20);
            this.txtPedido.TabIndex = 1;
            this.txtPedido.Leave += new System.EventHandler(this.txtPedido_Leave);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(103, 81);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(273, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(54, 84);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(195, 129);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisarPedido
            // 
            this.btnPesquisarPedido.Location = new System.Drawing.Point(285, 129);
            this.btnPesquisarPedido.Name = "btnPesquisarPedido";
            this.btnPesquisarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPedido.TabIndex = 5;
            this.btnPesquisarPedido.Text = "Pesquisar";
            this.btnPesquisarPedido.UseVisualStyleBackColor = true;
            this.btnPesquisarPedido.Click += new System.EventHandler(this.btnPesquisarPedido_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.Location = new System.Drawing.Point(586, 31);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(75, 23);
            this.btnCadProduto.TabIndex = 6;
            this.btnCadProduto.Text = "Produtos >>";
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(586, 60);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCadCliente.TabIndex = 7;
            this.btnCadCliente.Text = "Clientes >>";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTotalProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvProdutosPedido);
            this.groupBox1.Controls.Add(this.btnGravarProduto);
            this.groupBox1.Controls.Add(this.txtQuantidadeProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIncluiPreco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIncluiNomeProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIncluiProduto);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Controls.Add(this.btnSelecionarProduto);
            this.groupBox1.Location = new System.Drawing.Point(28, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 272);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incluir Produtos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Location = new System.Drawing.Point(570, 41);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Size = new System.Drawing.Size(63, 20);
            this.txtTotalProduto.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total";
            // 
            // dgvProdutosPedido
            // 
            this.dgvProdutosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Nome,
            this.Preco,
            this.Quantidade});
            this.dgvProdutosPedido.Location = new System.Drawing.Point(15, 96);
            this.dgvProdutosPedido.Name = "dgvProdutosPedido";
            this.dgvProdutosPedido.Size = new System.Drawing.Size(618, 162);
            this.dgvProdutosPedido.TabIndex = 18;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // btnGravarProduto
            // 
            this.btnGravarProduto.Location = new System.Drawing.Point(215, 67);
            this.btnGravarProduto.Name = "btnGravarProduto";
            this.btnGravarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnGravarProduto.TabIndex = 17;
            this.btnGravarProduto.Text = "Gravar";
            this.btnGravarProduto.UseVisualStyleBackColor = true;
            this.btnGravarProduto.Click += new System.EventHandler(this.btnGravarProduto_Click);
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(501, 41);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(63, 20);
            this.txtQuantidadeProduto.TabIndex = 16;
            this.txtQuantidadeProduto.Leave += new System.EventHandler(this.txtQuantidadeProduto_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Qtde.";
            // 
            // txtIncluiPreco
            // 
            this.txtIncluiPreco.Location = new System.Drawing.Point(432, 41);
            this.txtIncluiPreco.Name = "txtIncluiPreco";
            this.txtIncluiPreco.Size = new System.Drawing.Size(63, 20);
            this.txtIncluiPreco.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Preço";
            // 
            // txtIncluiNomeProd
            // 
            this.txtIncluiNomeProd.Location = new System.Drawing.Point(123, 41);
            this.txtIncluiNomeProd.Name = "txtIncluiNomeProd";
            this.txtIncluiNomeProd.Size = new System.Drawing.Size(303, 20);
            this.txtIncluiNomeProd.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // txtIncluiProduto
            // 
            this.txtIncluiProduto.Location = new System.Drawing.Point(15, 41);
            this.txtIncluiProduto.Name = "txtIncluiProduto";
            this.txtIncluiProduto.Size = new System.Drawing.Size(63, 20);
            this.txtIncluiProduto.TabIndex = 10;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(25, 25);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 9;
            this.lblProduto.Text = "Produto";
            // 
            // btnCarregaProdutos
            // 
            this.btnCarregaProdutos.Location = new System.Drawing.Point(381, 129);
            this.btnCarregaProdutos.Name = "btnCarregaProdutos";
            this.btnCarregaProdutos.Size = new System.Drawing.Size(150, 23);
            this.btnCarregaProdutos.TabIndex = 10;
            this.btnCarregaProdutos.Text = "Carregar Produtos";
            this.btnCarregaProdutos.UseVisualStyleBackColor = true;
            this.btnCarregaProdutos.Click += new System.EventHandler(this.btnCarregaProdutos_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(103, 129);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Vendas.Properties.Resources.file_976396;
            this.button3.Location = new System.Drawing.Point(209, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 29);
            this.button3.TabIndex = 14;
            this.toolTip1.SetToolTip(this.button3, "Novo");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.Image = global::Vendas.Properties.Resources.folder_342740;
            this.btnBuscarPedido.Location = new System.Drawing.Point(243, 28);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(33, 29);
            this.btnBuscarPedido.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnBuscarPedido, "Pesquisar pedido");
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.MouseHover += new System.EventHandler(this.btnBuscarPedido_MouseHover);
            // 
            // btnSelecionarProduto
            // 
            this.btnSelecionarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelecionarProduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSelecionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarProduto.Image = global::Vendas.Properties.Resources.folder_342740;
            this.btnSelecionarProduto.Location = new System.Drawing.Point(84, 36);
            this.btnSelecionarProduto.Name = "btnSelecionarProduto";
            this.btnSelecionarProduto.Size = new System.Drawing.Size(33, 29);
            this.btnSelecionarProduto.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnSelecionarProduto, "Pesquisar produto");
            this.btnSelecionarProduto.UseVisualStyleBackColor = false;
            this.btnSelecionarProduto.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 456);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCarregaProdutos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadCliente);
            this.Controls.Add(this.btnCadProduto);
            this.Controls.Add(this.btnPesquisarPedido);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblCodPedido);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodPedido;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisarPedido;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnSelecionarProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProdutosPedido;
        private System.Windows.Forms.Button btnGravarProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIncluiPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIncluiNomeProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIncluiProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnCarregaProdutos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTotalProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

