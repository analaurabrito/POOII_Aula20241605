using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240515Agenda
{
    public partial class Form2 : Form
    {
        FormHome origem;
        public Form2(FormHome origem)
        {
            InitializeComponent();
            this.origem = origem;

            cbxTipoTelefone.Items.Add(new TipoTelefone(1, "Pessoal"));
            cbxTipoTelefone.Items.Add(new TipoTelefone(1, "Profissional"));
            cbxTipoTelefone.Items.Add(new TipoTelefone(1, "Whatsapp"));
            cbxTipoTelefone.Items.Add(new TipoTelefone(1, "Recado"));

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int proxID = origem.listaContatos.Count + 1;

            Contato aux = new Contato(proxID,
                txbNome.Text, 
                txbSobrenome.Text, 
                txbTelefone.Text, 
                (TipoTelefone)cbxTipoTelefone.SelectedItem
                );

            origem.listaContatos.Add(aux);

            origem.dgvContatos.DataSource = null;
            origem.dgvContatos.DataSource = origem.listaContatos;
            origem.dgvContatos.Refresh();

            this.Close();

        }
    }
}
