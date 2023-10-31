namespace UIWinFormsApp
{
    partial class FormCadastrarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.bindingSourceCadastro = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(5, 94);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(370, 27);
            this.textBoxNome.TabIndex = 0;
            // 
            // bindingSourceCadastro
            // 
            this.bindingSourceCadastro.DataSource = typeof(Models.Usuario);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome de usuário";
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "NomeUsuario", true));
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(381, 94);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(322, 27);
            this.textBoxNomeUsuario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Senha", true));
            this.textBoxSenha.Location = new System.Drawing.Point(5, 149);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(222, 27);
            this.textBoxSenha.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirmação de senha";
            // 
            // textBoxConfirmacaoSenha
            // 
            this.textBoxConfirmacaoSenha.Location = new System.Drawing.Point(233, 150);
            this.textBoxConfirmacaoSenha.Name = "textBoxConfirmacaoSenha";
            this.textBoxConfirmacaoSenha.Size = new System.Drawing.Size(257, 27);
            this.textBoxConfirmacaoSenha.TabIndex = 3;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceCadastro, "Ativo", true));
            this.checkBoxAtivo.Location = new System.Drawing.Point(496, 150);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(66, 24);
            this.checkBoxAtivo.TabIndex = 4;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(786, 53);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cadastrar usuário";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(676, 409);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(786, 447);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.textBoxConfirmacaoSenha);
            this.Controls.Add(this.textBoxNomeUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastrarUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private TextBox textBoxNomeUsuario;
        private Label label3;
        private TextBox textBoxSenha;
        private Label label4;
        private TextBox textBoxConfirmacaoSenha;
        private CheckBox checkBoxAtivo;
        private Label label5;
        private Button button1;
        private BindingSource bindingSourceCadastro;
        private Button buttonCancelar;
    }
}