using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormWithRadioAndCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
              
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cmbLista.Items.Add(txtTexto.Text);
            txtTexto.Text = "";
            txtTexto.Focus();
            lblQuantidade.Text = cmbLista.Items.Count.ToString();    
        }



        private void btnRemover_Click(object sender, EventArgs e)
        {
            cmbLista.Items.Remove(cmbLista.SelectedItem);
            cmbLista.Text = "";
            lblQuantidade.Text = cmbLista.Items.Count.ToString();

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            cmbLista.Sorted = true; 
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
           if(cmbLista.SelectedIndex != -1)
            {
            txtConteudo.Text = cmbLista.SelectedItem.ToString();
            txtIndice.Text = cmbLista.SelectedIndex.ToString(); 

            }
            

        }
    }
}
