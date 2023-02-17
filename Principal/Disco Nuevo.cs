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
using System.Configuration;
using System.IO;

namespace Principal
{
    public partial class FrmDiscoNuevo : Form
    {
        private Discos Discos = null;
        private OpenFileDialog Archivo = null;
        public FrmDiscoNuevo()
        {
            InitializeComponent();
        }
        public FrmDiscoNuevo(Discos Discos)
        {
            InitializeComponent();
            this.Discos = Discos;
        }
        private void FrmDiscoNuevo_Load(object sender, EventArgs e)
        {
            EstilosDatos EstilosDatos = new EstilosDatos();
            TipoEdicionDatos TipoEdicionDatos = new TipoEdicionDatos();
            try
            {
                cboEstilos.DataSource = EstilosDatos.Listar();
                cboEstilos.ValueMember = "Id";
                cboEstilos.DisplayMember = "Descripcion";
                cboEstilos.SelectedIndex = -1;
                cboEdicion.DataSource = TipoEdicionDatos.Listar();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Descripcion";
                cboEdicion.SelectedIndex = -1;
                if(Discos != null)
                {
                    txtTitulo.Text = Discos.Titulo;
                    dtpFechaLanzamiento.Value = Discos.FechaLanzamiento;
                    nudCantidadCanciones.Value = Discos.CantidadCanciones;
                    txtUrlImagen.Text = Discos.UrlImagen;
                    CargarImagen(Discos.UrlImagen);
                    cboEstilos.SelectedValue = Discos.Estilos.Id;
                    cboEdicion.SelectedValue = Discos.Edicion.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscosDatos Datos = new DiscosDatos();
            try
            {
                if (Discos == null)
                    Discos = new Discos();
                string Titulo = txtTitulo.Text;
                int Cantidad = (int)nudCantidadCanciones.Value;
                string Imagen = txtUrlImagen.Text;
                Estilos Estilo = (Estilos)cboEstilos.SelectedItem;
                TipoEdicion Edicion = (TipoEdicion)cboEdicion.SelectedItem;
                Discos.Titulo = Titulo;
                Discos.FechaLanzamiento = dtpFechaLanzamiento.Value;
                Discos.CantidadCanciones = Cantidad;
                Discos.UrlImagen = Imagen;
                Discos.Estilos = Estilo;
                Discos.Edicion = Edicion;
                bool ban = true;
                if(Discos.Id != 0)
                {
                    //Modificar
                    Datos.Modificar(Discos);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    //Agregar
                    if (ValidarDiscoNuevo(Titulo, Cantidad, Imagen, Estilo, Edicion))
                    {
                        Datos.Agregar(Discos);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Debes Completar todos los campos");
                        ban = false;
                    }
                }
                
                if (Archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(Archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + Archivo.SafeFileName);
                if (ban)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool ValidarDiscoNuevo(string Titulo, int Cantidad, string Imagen, Estilos estilo, TipoEdicion tipoEdicion)
        {
            int con = 0;
            if (Titulo == null || Titulo == "")
            {
                lblValidarTitulo.BackColor = Color.Red;
                lblValidarTitulo.Text = "X";
            }
            else
                con++;
            if (string.IsNullOrEmpty(nudCantidadCanciones.Text)||Cantidad == 0)
            {
                lblValidarCantidad.BackColor = Color.Red;
                lblValidarCantidad.Text = "X";
            }
            else
                con++;
            if (Imagen == null || Imagen == "")
            {
                lblValidarImagen.BackColor = Color.Red;
                lblValidarImagen.Text = "X";
            }
            else
                con++;
            if (estilo == null)
            {
                lblValidarEstilo.BackColor = Color.Red;
                lblValidarEstilo.Text = "X";
            }
            else
                con++;
            if (tipoEdicion == null)
            {
                lblValidarEdicion.BackColor = Color.Red;
                lblValidarEdicion.Text = "X";
            }
            else
                con++;
            if (con == 5)
                return true;

            return false;

        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImagen.Text);
        }

        private void CargarImagen(string Imagen)
        {
            try
            {
                pbxDiscoNuevo.Load(Imagen);
            }
            catch (Exception ex)
            {

                pbxDiscoNuevo.Load("https://tse4.mm.bing.net/th?id=OIP.dxt2_gkvMt-3ZUVo8RF9SQHaHa&pid=Api&P=0");
            }
        }

        private void btnImagenLocal_Click(object sender, EventArgs e)
        {
            Archivo = new OpenFileDialog();
            Archivo.Filter = "jpg|*.jpg|png|*.png";
            if(Archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = Archivo.FileName;
                CargarImagen(Archivo.FileName);
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblValidarTitulo.BackColor = Color.LightCyan;
            lblValidarTitulo.Text = "";
        }

        private void nudCantidadCanciones_ValueChanged(object sender, EventArgs e)
        {
            lblValidarCantidad.BackColor = Color.LightCyan;
            lblValidarCantidad.Text = "";
        }

        private void nudCantidadCanciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblValidarCantidad.BackColor = Color.LightCyan;
            lblValidarCantidad.Text = "";
        }
        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            lblValidarImagen.BackColor = Color.LightCyan;
            lblValidarImagen.Text = "";
        }

        private void cboEstilos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValidarEstilo.BackColor = Color.LightCyan;
            lblValidarEstilo.Text = "";
        }

        private void cboEdicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValidarEdicion.BackColor = Color.LightCyan;
            lblValidarEdicion.Text = "";
        }
    }
}
