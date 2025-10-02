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
    public partial class frmConDentista : Form
    {
        DentistaService service = new DentistaService();
        public frmConDentista()
        {
            InitializeComponent();
            IniciarForm();
        }
        public void IniciarForm()
        {
            var lista = service.Listar();
            if(lista == null)
            {
                MessageBox.Show("Nenhum dentista cadastrado.");
            }
            else 
            {                 
                char letraAnterior = '#';
                int numTabela = -1;
                DataGridView data = new DataGridView();
                foreach (var dado in lista)
                {
                    char primeiraLetra = dado.Nome.Trim()[0];
                    if (primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper())
                    {
                        //mesma letra, continua na mesma tabela
                        GerarLinha(data, dado);
                    }
                    else
                    {
                        numTabela += 1;
                        tc.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dg = new DataGridView();
                        data = dg;
                        tc.TabPages[numTabela].Controls.Add(dg);
                        GerarTabela(dg);
                        GerarLinha(dg, dado);
                    }
                    letraAnterior = primeiraLetra;

                }






            }


        }

        private void GerarLinha(DataGridView data, Dentista dado)
        {
            int linhaAtual = data.Rows.Add();
            data.Rows[linhaAtual].Cells[0].Value = dado.Id;
            data.Rows[linhaAtual].Cells[1].Value = dado.Nome;
            data.Rows[linhaAtual].Cells[2].Value = dado.Cro;
            data.Rows[linhaAtual].Cells[3].Value = dado.Especialidade;
            data.Rows[linhaAtual].Cells[4].Value = dado.Telefone.ToString("(00) 0000-0000");
            data.Rows[linhaAtual].Cells[5].Value = dado.Celular.ToString("(00) 00000-0000");



        }

        private void GerarTabela(DataGridView dg)
        {
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false;
            dg.BackgroundColor = Color.LightSteelBlue;
            dg.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dg.Columns.Add("Código", "Código");
            dg.Columns[0].Visible = false;

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Nome";

            link.Name = "Nome";
            dg.Columns.Add(link);
            dg.Columns.Add("CRO", "CRO");
            dg.Columns.Add("Especialidade", "Especialidade");
            dg.Columns.Add("Telefone", "Telefone");
            dg.Columns.Add("Celular", "Celular");

            dg.CellContentClick += new DataGridViewCellEventHandler(this.tb_click);

        }

        private void tb_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            try
            {
                if (e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                   int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells[0].Value);
                   Dentista obj = service.Buscar(Convert.ToInt32(id));
                   if (obj != null)
                   {
                      var form = new frmEditarDentista(obj);
                      form.ShowDialog();
                      if (form.status == "Apagado")
                      {
                         this.Close();
                         frmConDentista frm = new frmConDentista();
                         frm.ShowDialog();

                      }
                      else if (form.status == "Editado")
                      {
                         dg.Rows.RemoveAt(e.RowIndex);
                         GerarLinha(dg, obj);
                         
                      }

                   }
                   else
                   {
                       MessageBox.Show("Dentista não encontrado.");
                   }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o dentista: " + ex.Message);

            }
        }
    }
}
