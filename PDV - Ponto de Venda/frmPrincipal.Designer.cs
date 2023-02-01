namespace PDV___Ponto_de_Venda
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFluxo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntradasSaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovements = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBills = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.Black;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProduto,
            this.menuMovimentacoes,
            this.menuRelatorio,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(844, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFuncionario,
            this.menuClientes,
            this.menuUsuarios,
            this.menuCargo,
            this.menuFornecedores});
            this.MenuCadastro.Font = new System.Drawing.Font("Rantera", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastro.ForeColor = System.Drawing.Color.White;
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(81, 20);
            this.MenuCadastro.Text = "Cadastro";
            // 
            // menuFuncionario
            // 
            this.menuFuncionario.Name = "menuFuncionario";
            this.menuFuncionario.Size = new System.Drawing.Size(157, 22);
            this.menuFuncionario.Text = "Funcionários";
            this.menuFuncionario.Click += new System.EventHandler(this.menuFuncionario_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(157, 22);
            this.menuClientes.Text = "Clientes";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(157, 22);
            this.menuUsuarios.Text = "Usuarios";
            // 
            // menuCargo
            // 
            this.menuCargo.Name = "menuCargo";
            this.menuCargo.Size = new System.Drawing.Size(157, 22);
            this.menuCargo.Text = "Cargo";
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(157, 22);
            this.menuFornecedores.Text = "Forncedores";
            // 
            // MenuProduto
            // 
            this.MenuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuEstoque});
            this.MenuProduto.Font = new System.Drawing.Font("Rantera", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProduto.ForeColor = System.Drawing.Color.White;
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(74, 20);
            this.MenuProduto.Text = "Produto";
            // 
            // menuCadastros
            // 
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(143, 22);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuEstoque
            // 
            this.menuEstoque.Name = "menuEstoque";
            this.menuEstoque.Size = new System.Drawing.Size(143, 22);
            this.menuEstoque.Text = "Estoque";
            // 
            // menuMovimentacoes
            // 
            this.menuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFluxo,
            this.menuVendas,
            this.menuEntradasSaidas,
            this.menuDespesas});
            this.menuMovimentacoes.Font = new System.Drawing.Font("Rantera", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMovimentacoes.ForeColor = System.Drawing.Color.White;
            this.menuMovimentacoes.Name = "menuMovimentacoes";
            this.menuMovimentacoes.Size = new System.Drawing.Size(123, 20);
            this.menuMovimentacoes.Text = "Movimentações";
            // 
            // menuFluxo
            // 
            this.menuFluxo.Name = "menuFluxo";
            this.menuFluxo.Size = new System.Drawing.Size(183, 22);
            this.menuFluxo.Text = "Fluxo";
            // 
            // menuVendas
            // 
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(183, 22);
            this.menuVendas.Text = "Lançar venda";
            // 
            // menuEntradasSaidas
            // 
            this.menuEntradasSaidas.Name = "menuEntradasSaidas";
            this.menuEntradasSaidas.Size = new System.Drawing.Size(183, 22);
            this.menuEntradasSaidas.Text = "Entradas /Saidas";
            // 
            // menuDespesas
            // 
            this.menuDespesas.Name = "menuDespesas";
            this.menuDespesas.Size = new System.Drawing.Size(183, 22);
            this.menuDespesas.Text = "Despesas";
            // 
            // menuRelatorio
            // 
            this.menuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProducts,
            this.menuSales,
            this.menuMovements,
            this.menuInOut,
            this.menuBills});
            this.menuRelatorio.Font = new System.Drawing.Font("Rantera", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRelatorio.ForeColor = System.Drawing.Color.White;
            this.menuRelatorio.Name = "menuRelatorio";
            this.menuRelatorio.Size = new System.Drawing.Size(80, 20);
            this.menuRelatorio.Text = "Relatório";
            // 
            // menuProducts
            // 
            this.menuProducts.Name = "menuProducts";
            this.menuProducts.Size = new System.Drawing.Size(181, 22);
            this.menuProducts.Text = "Produtos";
            // 
            // menuSales
            // 
            this.menuSales.Name = "menuSales";
            this.menuSales.Size = new System.Drawing.Size(181, 22);
            this.menuSales.Text = "Vendas";
            // 
            // menuMovements
            // 
            this.menuMovements.Name = "menuMovements";
            this.menuMovements.Size = new System.Drawing.Size(181, 22);
            this.menuMovements.Text = "Movimentacao";
            // 
            // menuInOut
            // 
            this.menuInOut.Name = "menuInOut";
            this.menuInOut.Size = new System.Drawing.Size(181, 22);
            this.menuInOut.Text = "Entradas / Saida";
            // 
            // menuBills
            // 
            this.menuBills.Name = "menuBills";
            this.menuBills.Size = new System.Drawing.Size(181, 22);
            this.menuBills.Text = "Despesas";
            // 
            // menuSair
            // 
            this.menuSair.Font = new System.Drawing.Font("Rantera", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSair.ForeColor = System.Drawing.Color.White;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(50, 20);
            this.menuSair.Text = " Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // img01
            // 
            this.img01.Image = ((System.Drawing.Image)(resources.GetObject("img01.Image")));
            this.img01.InitialImage = ((System.Drawing.Image)(resources.GetObject("img01.InitialImage")));
            this.img01.Location = new System.Drawing.Point(57, 77);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(176, 164);
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // img04
            // 
            this.img04.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img04.BackgroundImage")));
            this.img04.Location = new System.Drawing.Point(607, 293);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(176, 164);
            this.img04.TabIndex = 2;
            this.img04.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = ((System.Drawing.Image)(resources.GetObject("img03.Image")));
            this.img03.Location = new System.Drawing.Point(57, 293);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(176, 164);
            this.img03.TabIndex = 3;
            this.img03.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = ((System.Drawing.Image)(resources.GetObject("img02.Image")));
            this.img02.Location = new System.Drawing.Point(607, 77);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(176, 164);
            this.img02.TabIndex = 4;
            this.img02.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 484);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rantera", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "GMBC LTDA";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProduto;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuCargo;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuEstoque;
        private System.Windows.Forms.ToolStripMenuItem menuFluxo;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuEntradasSaidas;
        private System.Windows.Forms.ToolStripMenuItem menuDespesas;
        private System.Windows.Forms.ToolStripMenuItem menuProducts;
        private System.Windows.Forms.ToolStripMenuItem menuSales;
        private System.Windows.Forms.ToolStripMenuItem menuMovements;
        private System.Windows.Forms.ToolStripMenuItem menuInOut;
        private System.Windows.Forms.ToolStripMenuItem menuBills;
    }
}

