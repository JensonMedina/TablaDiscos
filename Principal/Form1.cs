using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Datos;

namespace Principal
{
    public partial class FrmPrincipal : Form
    {
        private List<Discos> ListaDiscos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();
            OcultarColumnas();
            cboCampo.Items.Add("Titulo");
            cboCampo.Items.Add("Cantidad de canciones");
            cboCampo.Items.Add("Estilo");
            cboCampo.Items.Add("Tipo de edicion");
        }
        private void Cargar()
        {
            try
            {
                DiscosDatos Datos = new DiscosDatos();
                ListaDiscos = Datos.Listar();
                dgvDiscos.DataSource = ListaDiscos;
                CargarImagen(ListaDiscos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void OcultarColumnas()
        {
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["UrlImagen"].Visible = false;
        }

        private void CargarImagen(string Imagen)
        {
            try
            {
                pbxDiscos.Load(Imagen);
            }
            catch (Exception)
            {

                pbxDiscos.Load("https://tse4.mm.bing.net/th?id=OIP.dxt2_gkvMt-3ZUVo8RF9SQHaHa&pid=Api&P=0");
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)
            {
                Discos Seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                CargarImagen(Seleccionado.UrlImagen);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmDiscoNuevo DiscoNuevo = new FrmDiscoNuevo();
            DiscoNuevo.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null && dgvDiscos.CurrentRow.DataBoundItem != null)
            {
                Discos Seleccionado;
                Seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                FrmDiscoNuevo ModificarDisco = new FrmDiscoNuevo(Seleccionado);
                ModificarDisco.Text = "Modificar Disco";
                ModificarDisco.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de modificar un disco", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Discos> ListaFiltrada;
            string Filtro = txtFiltroRapido.Text;
            if(Filtro.Length >= 3)
            {
                ListaFiltrada = ListaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(Filtro.ToUpper()) || x.Estilos.Descripcion.ToUpper().Contains(Filtro.ToUpper()));
            }
            else
            {
                ListaFiltrada = ListaDiscos;
            }
            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = ListaFiltrada;
            OcultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Opcion = cboCampo.SelectedItem.ToString();
            if(Opcion == "Cantidad de canciones")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DiscosDatos Datos = new DiscosDatos();
            try
            {
                if (Helper.ValidarFiltro(cboCampo, cboCriterio, txtFiltroAvanzado))
                    return;
                string Campo = cboCampo.SelectedItem.ToString();
                string Criterio = cboCriterio.SelectedItem.ToString();
                string Filtro = txtFiltroAvanzado.Text.ToString();
                dgvDiscos.DataSource = Datos.Filtrar(Campo, Criterio, Filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscosDatos Datos = new DiscosDatos();
            Discos Seleccionado;
            try
            {
                DialogResult Resultado = MessageBox.Show("¿Esta seguro que quiere eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    Seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                    Datos.Eliminar(Seleccionado.Id);
                }
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Cargar();
            OcultarColumnas();
            cboCampo.Items.Clear();
            cboCriterio.Items.Clear();
            txtFiltroAvanzado.Text = "";
            cboCampo.Items.Add("Titulo");
            cboCampo.Items.Add("Cantidad de canciones");
            cboCampo.Items.Add("Estilo");
            cboCampo.Items.Add("Tipo de edicion");
        }
    }
}
