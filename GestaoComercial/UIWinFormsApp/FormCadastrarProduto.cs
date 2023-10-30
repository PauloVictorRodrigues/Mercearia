using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;

namespace UIWinFormsApp
{
    public partial class FormCadastrarProduto : Form
    {
        private int id;
        public FormCadastrarProduto(int _id = 0)
        {
            InitializeComponent();
            id = _id;

            if (id == 0)
                bindingSourceCadastro.AddNew();

            else
                bindingSourceCadastro.DataSource = new ProdutoBLL().BuscarPorId(id);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastro.EndEdit();
                Produto produto = (Produto)bindingSourceCadastro.Current;

                if (id == 0)
                    new ProdutoBLL().Inserir(produto);

                else
                    new ProdutoBLL().Alterar(produto);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
