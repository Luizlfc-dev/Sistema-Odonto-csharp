using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace Sistema_Odonto
{
    public partial class frmEditarDentista : Form
    {
        public string status;
        Dentista obj = new Dentista();
        DentistaService service = new DentistaService();


        public frmEditarDentista(Dentista obj)
        {
            InitializeComponent();
            IniciarFormulario(obj);
        }

        private void IniciarFormulario(Dentista objP)
        {
            this.obj = objP;
            lblCodigo.Text = this.obj.Id.ToString();
            txtNome.Text = this.obj.Nome;
            txtCro.Text = this.obj.Cro;
            txtEspecialidade.Text = this.obj.Especialidade;
            txtTelefone.Text = this.obj.Telefone.ToString();
            txtCelular.Text = this.obj.Celular.ToString();
            txtEmail.Text = this.obj.Email;
            status = "editando";


        }

        private void frmEditarDentista_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            ts.Text = ValidarCad();
            if(ts.Text == "Sucesso!")
            {
                if (lblCodigo.Text != this.obj.Id.ToString()) 
                {
                    status = "Apagado";
                    MessageBox.Show("Este registro acabou de ser alterado");
                }
                else
                {
                    status = "Editado";
                    this.obj.Nome = txtNome.Text;
                    this.obj.Cro = txtCro.Text;
                    this.obj.Especialidade = txtEspecialidade.Text;
                    obj.Telefone= txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
                    obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
                    this.obj.Email = txtEmail.Text;
                    service.Editar(this.obj);
                    this.Close();
                }


            }
        
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            if (validarExclusao())
            {
                service.Excluir(this.obj.Id);
                MessageBox.Show("Registro excluído com sucesso!");
                status = "Apagado";
                this.Close();
            }




        }
        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtNome.Text == "")
            {
                return "O campo Nome é obrigatório.\n";
            }
            else if (txtCelular.Text == "")
            {
                return "O campo Celular é obrigatório.\n";
            }
            else if (txtEmail.Text == "")
            {
                return "O campo Email é obrigatório.\n";
            }
            else if (txtCro.Text == "")
            {
                return "O campo CRO é obrigatório.\n";
            }
            else if (txtEspecialidade.Text == "")
            {
                return "O campo Especialidade é obrigatório.\n";
            }
            else if (txtTelefone.Text == "")
            {
                return "O campo Telefone é obrigatório.\n";
            }
            else
            {
                ts.ForeColor = Color.Blue;
                return "Sucesso!";
            }

        }
        public bool validarExclusao() {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
               return true;
                
               
            }
            else
            {
               return false;
            }
        }

    }
}
