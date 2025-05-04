using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCuatro
{
    public partial class Form1 : Form
    {
        List<Chicos> listaChicos = new List<Chicos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlumnos()
        {
            lstListadoChicos.Items.Clear();
            for (int i = 0; i < listaChicos.Count; i++)
            {
                lstListadoChicos.Items.Add(listaChicos[i]);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Chicos nuevoChico = new Chicos
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = txtEdad.Text,
                DNI = txtDni.Text,
            };
            listaChicos.Add(nuevoChico);
            MostrarAlumnos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string curItem = lstListadoChicos.SelectedItem.ToString();
            int index = lstListadoChicos.FindString(curItem);
            for (int i = 0; i < listaChicos.Count; i++)
            {
                if (i == index)
                {
                    listaChicos.RemoveAt(i);
                }
            }
            MostrarAlumnos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string curItem = lstListadoChicos.SelectedItem.ToString();
            int index = lstListadoChicos.FindString(curItem);

            if (index >= 0)
            {
                if (txtNombre.Text.Length > 0)
                {
                    listaChicos[index].Nombre = txtNombre.Text;
                }

                if (txtApellido.Text.Length > 0)
                {
                    listaChicos[index].Apellido = txtApellido.Text;
                }

                if (txtEdad.Text.Length > 0)
                {
                    listaChicos[index].Edad = txtEdad.Text;
                }

                if (txtDni.Text.Length > 0)
                {
                    listaChicos[index].DNI = txtDni.Text;
                }
                MostrarAlumnos();
            }
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            string curItem = lstListadoChicos.SelectedItem.ToString();
            int index = lstListadoChicos.FindString(curItem);
            Chicos nuevoChico = new Chicos
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = txtEdad.Text,
                DNI = txtDni.Text,
            };
            listaChicos.Insert(index + 1, nuevoChico);
            MostrarAlumnos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }
    }
}
