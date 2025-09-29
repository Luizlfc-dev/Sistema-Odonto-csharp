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
    public partial class frmCadDentista : Form
    {
        DentistaService service = new DentistaService();
        public frmCadDentista()
        {
            InitializeComponent();
            txtNome.Text = txtCelular.Text;
        }
        private string ValidarCad(){
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            try
            {
                ts.Text = ValidarCad();
                if (ts.Text == "Sucesso!")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Dados salvos com sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados. \n" + ex.Message);


            }
        }
        public Dentista objGerado()
        {
            Dentista obj = new Dentista();
            obj.Nome = txtNome.Text;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.Email = txtEmail.Text;
            obj.Cro = txtCro.Text;
            obj.Especialidade = txtEspecialidade.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            return obj;
        }

        private void frmCadDentista_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConDentista frm = new frmConDentista();
            frm.ShowDialog();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        public void LimparCampos()
        {
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtCro.Text = "";
            txtEspecialidade.Text = "";
            txtTelefone.Text = "";
        }
    }



}
