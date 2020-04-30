using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string convertirLaPrimerLetraEnMinuscula(string textoSeleccionado)
        {
            if(textoSeleccionado == null)
            {
                return null;
            }
            else if(textoSeleccionado.Length > 1)
            {
                return char.ToLower(textoSeleccionado[0]) + textoSeleccionado.Substring(1);
            }
            return textoSeleccionado.ToLower();
        }

        private string convertirLaPrimerLetraEnMayuscula(string textoSeleccionado)
        {
            if (textoSeleccionado == null)
            {
                return null;
            }
            else if (textoSeleccionado.Length > 1)
            {
                return char.ToUpper(textoSeleccionado[0]) + textoSeleccionado.Substring(1);
            }
            return textoSeleccionado.ToUpper();
        }

        private void cuentaLaCantidadTotlDePalabras()
        {
            int laCantidadDePalabras = 0;
            laCantidadDePalabras = txtCuadroDeTexto.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            MessageBox.Show("Cantidad total de palabras: " + laCantidadDePalabras, "Cantidad de palabras");
        }

        private void cuentaLaCantidadTotalDeLetras()
        {
            int laCantidadDeLetras = 0;
            int losEspaciosEnBlanco = 0;

            losEspaciosEnBlanco = txtCuadroDeTexto.Text.Count(Char.IsWhiteSpace);
            laCantidadDeLetras = txtCuadroDeTexto.Text.Length - losEspaciosEnBlanco;

            MessageBox.Show("Cantidad de letras totales: " + laCantidadDeLetras, "Cantidad de letras");
        }

        private void cuentaLasPalabrasDeUnParrafo()
        {
            int lasPalabrasDelParrafo = 0;
            lasPalabrasDelParrafo = txtCuadroDeTexto.SelectedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            MessageBox.Show("Cantidad de palabras en el párrafo: " + lasPalabrasDelParrafo, "Palabras en el párrafo");
        }

        private void cuentaLasLetrasDeUnParrafo()
        {
            int lasLetrasDelParrafo = 0;
            int losEspaciosEnBlanco = 0;

            losEspaciosEnBlanco = txtCuadroDeTexto.SelectedText.Count(Char.IsWhiteSpace);
            lasLetrasDelParrafo = txtCuadroDeTexto.SelectedText.Length - losEspaciosEnBlanco;

            MessageBox.Show("Cantidad de letras en el párrafo: " + lasLetrasDelParrafo, "Letras en el párrafo");
        }

        private void cuentaLaCantidadDeVecesQueSeRepiteUnaPalabra()
        {
            string[] arregloConElTextoCompleto = txtCuadroDeTexto.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string buscaLaPalabraRepetida = txtPalabraRepetidaABuscar.Text;
            int cuentaLasVecesQueSeRepiteLaPalabra = 0;

            foreach (var palabra in arregloConElTextoCompleto)
            {
                if(palabra == buscaLaPalabraRepetida.ToUpper() || palabra == buscaLaPalabraRepetida.ToLower())
                {
                    cuentaLasVecesQueSeRepiteLaPalabra++;
                }
            }
            MessageBox.Show("La palabra " + txtPalabraRepetidaABuscar.Text + " se repite " + cuentaLasVecesQueSeRepiteLaPalabra + " veces");
        }

        private void cuentaLaCantidadDeVecesQueSeRepiteUnaPalabraEnUnParrafo()
        {
            string[] arregloConElParrafoSeleccionado = txtCuadroDeTexto.SelectedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string laPalabraRepetida = txtPalabraABuscarEnElParrafo.Text;
            int vecesQueSeRepiteLaPalabra = 0;

            foreach (var palabra in arregloConElParrafoSeleccionado)
            {
                if (palabra == laPalabraRepetida.ToUpper() || palabra == laPalabraRepetida.ToLower())
                {
                    vecesQueSeRepiteLaPalabra++;
                }
            }
            MessageBox.Show("La palabra " + txtPalabraABuscarEnElParrafo.Text + " se repite " + vecesQueSeRepiteLaPalabra + " veces en el párrafo.");
            }

        private void convertirTodasLasLetrasEnMinusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String textoConvertidoAMinusculas;
            textoConvertidoAMinusculas = txtCuadroDeTexto.Text;
            txtCuadroDeTexto.Text = textoConvertidoAMinusculas.ToLower();
        }//listo

        private void convertirTodoAMayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String textoConvertidoAMayusculas;
            textoConvertidoAMayusculas = txtCuadroDeTexto.Text;
            txtCuadroDeTexto.Text = textoConvertidoAMayusculas.ToUpper();
        }//listo

        private void letrasDelPárrafoAMinusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCuadroDeTexto.SelectionLength == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún párrafo", "Advertencia");
            }
            else
                txtCuadroDeTexto.SelectedText = txtCuadroDeTexto.SelectedText.ToLower();
        }

        private void letrasDelPárrafoAMayúsculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCuadroDeTexto.SelectionLength == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún párrafo", "Advertencia");
            }
            else
                txtCuadroDeTexto.SelectedText = txtCuadroDeTexto.SelectedText.ToUpper();
        }

        private void primerLetraEnMinusculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCuadroDeTexto.SelectionLength == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún párrafo", "Advertencia");
            }
            else
                convertirLaPrimerLetraEnMinuscula(txtCuadroDeTexto.SelectedText);
            txtCuadroDeTexto.SelectedText = convertirLaPrimerLetraEnMinuscula(txtCuadroDeTexto.SelectedText).ToString();
        }

        private void primerLetraEnMayúsculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtCuadroDeTexto.SelectionLength == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún párrafo", "Advertencia");
            }else
            convertirLaPrimerLetraEnMayuscula(txtCuadroDeTexto.SelectedText);
            txtCuadroDeTexto.SelectedText = convertirLaPrimerLetraEnMayuscula(txtCuadroDeTexto.SelectedText).ToString();
        }

        private void reemplazarPalabraEnEspecíficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPalabraNueva.Visible = true;
            btnReemplazar.Visible = true;
            txtPalabraNueva.Visible = true;
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            if (txtCuadroDeTexto.SelectionLength == 0)
            {
                MessageBox.Show("Debe seleccionar la palabra que desea reemplazar", "Error");
            }
            else if(txtPalabraNueva.Text == "")
            {
                MessageBox.Show("Debe ingresar la palabra nueva con la que desea reemplazar la anterior", "Error");
            }
            else
            txtCuadroDeTexto.SelectedText = txtPalabraNueva.Text;
            txtCuadroDeTexto.Text.ToString();

            lblPalabraNueva.Visible = false;
            btnReemplazar.Visible = false;
            txtPalabraNueva.Visible = false;
        }

        private void cantidadTotalDePalabrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuentaLaCantidadTotlDePalabras();
        }

        private void cantidadDeLetrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuentaLaCantidadTotalDeLetras();
        }

        private void cantidadDeLetrasEnPárrafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCuadroDeTexto.SelectionLength == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún párrafo", "Advertencia");
            }
            else
                cuentaLasLetrasDeUnParrafo();
        }

        private void cantidadDePalabrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCuadroDeTexto.SelectionLength == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún párrafo", "Advertencia");
            }
            else
                cuentaLasPalabrasDeUnParrafo();
        }

        private void vecesQueSeRepiteUnaPalabraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPalabraABuscar.Visible = true;
            txtPalabraRepetidaABuscar.Visible = true;
            btnBuscar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCuadroDeTexto.Text == "")
            {
                MessageBox.Show("No hay ningún texto", "Error");
            }
            else if (txtPalabraRepetidaABuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar la palabra nueva con la que desea reemplazar la anterior", "Error");
            }
            else
                cuentaLaCantidadDeVecesQueSeRepiteUnaPalabra();
            lblPalabraABuscar.Visible = false;
            txtPalabraRepetidaABuscar.Visible = false;
            btnBuscar.Visible = false;
        }

        private void vecesQueSeRepitePalabraEnElPárrafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPalabraABuscarEnParrafo.Visible = true;
            txtPalabraABuscarEnElParrafo.Visible = true;
            btnBuscarRepetidaEnParrafo.Visible = true;
        }

        private void btnBuscarRepetidaEnParrafo_Click(object sender, EventArgs e)
        {
            if (txtCuadroDeTexto.SelectionLength == 0)
            {
                MessageBox.Show("Debe seleccionar la palabra que desea reemplazar", "Error");
            }
            else if (txtPalabraABuscarEnElParrafo.Text == "")
            {
                MessageBox.Show("Debe ingresar la palabra nueva con la que desea reemplazar la anterior", "Error");
            }
            else
                cuentaLaCantidadDeVecesQueSeRepiteUnaPalabraEnUnParrafo();
            lblPalabraABuscarEnParrafo.Visible = false;
            txtPalabraABuscarEnElParrafo.Visible = false;
            btnBuscarRepetidaEnParrafo.Visible = false;
        }
    }
}
