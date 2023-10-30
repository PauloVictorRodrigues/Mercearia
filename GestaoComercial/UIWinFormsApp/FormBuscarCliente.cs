using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormBuscarCliente : Form
    {
        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceCliente.DataSource = new ClienteBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceCliente.DataSource = new ClienteBLL().BuscarPorFone(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceCliente.DataSource = new ClienteBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarCliente frm = new FormCadastrarCliente())
            {
                frm.ShowDialog();
            }  
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Cliente)bindingSourceCliente.Current).Id;
            using (FormCadastrarCliente frm = new FormCadastrarCliente(id))
            {
                frm.ShowDialog();
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Cliente)bindingSourceCliente.Current).Id;
            new ClienteBLL().Excluir(id);
            bindingSourceCliente.RemoveCurrent();
            MessageBox.Show("Registro excluído com sucesso!");
        }
        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = comboBoxBuscarPor.Items.Count - 1;
            buttonBuscar_Click(null, null);
        }
    }
}
