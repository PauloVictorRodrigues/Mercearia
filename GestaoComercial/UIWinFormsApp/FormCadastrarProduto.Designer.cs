namespace UIWinFormsApp
{
    partial class FormCadastrarProduto
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.bindingSourceCadastro = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(5, 100);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(233, 27);
            this.textBoxNome.TabIndex = 0;
            // 
            // bindingSourceCadastro
            // 
            this.bindingSourceCadastro.DataSource = typeof(Models.Produto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(676, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(780, 53);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cadastrar produto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxConfirmacaoSenha
            // 
            this.textBoxConfirmacaoSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "CodigoDeBarras", true));
            this.textBoxConfirmacaoSenha.Location = new System.Drawing.Point(160, 156);
            this.textBoxConfirmacaoSenha.Name = "textBoxConfirmacaoSenha";
            this.textBoxConfirmacaoSenha.Size = new System.Drawing.Size(201, 27);
            this.textBoxConfirmacaoSenha.TabIndex = 3;
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Preco", true));
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(244, 100);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(117, 27);
            this.textBoxNomeUsuario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo de barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preço";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Estoque", true));
            this.textBoxSenha.Location = new System.Drawing.Point(5, 156);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(149, 27);
            this.textBoxSenha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estoque";
            // 
            // FormCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxConfirmacaoSenha);
            this.Controls.Add(this.textBoxNomeUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastrarProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private BindingSource bindingSourceCadastro;
        private Label label1;
        private Button buttonCancelar;
        private Button button1;
        private Label label5;
        private TextBox textBoxConfirmacaoSenha;
        private TextBox textBoxNomeUsuario;
        private Label label4;
        private Label label2;
        private TextBox textBoxSenha;
        private Label label3;
    }
}