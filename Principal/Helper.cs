using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Datos;
using System.Windows.Forms;


namespace Principal
{
    public static class Helper
    {
        public static bool ValidarFiltro(ComboBox Campo, ComboBox Criterio, TextBox Filtro)
        {
            if(Campo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un campo");
                return true;
            }
            if(Criterio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un criterio");
                return true;
            }
            if(string.IsNullOrEmpty(Filtro.Text))
            {
                MessageBox.Show("Debes cargar el filtro");
                return true;
            }
            if(Campo.SelectedItem.ToString() == "Cantidad de canciones")
            {
                if (!(SoloNumeros(Filtro.Text)))
                {
                    MessageBox.Show("Solo numeros si se usa el campo de cantidad de canciones");
                    return true;
                }
            }
            return false;
        }
        public static bool SoloNumeros(string Cadena)
        {
            foreach (char Caracter in Cadena)
            {
                if (!(char.IsNumber(Caracter)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
