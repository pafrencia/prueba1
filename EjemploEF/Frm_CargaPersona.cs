using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploEF
{
    public partial class Frm_CargaPersona : Form
    {
        alumnos1 Alumno_Seleccionado = new alumnos1();
        public Frm_CargaPersona()
        {
            InitializeComponent();
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            Alumno_Seleccionado.nombre = TxtNombre.Text.Trim();
            Alumno_Seleccionado.apellido = TxtApellido.Text.Trim();
            Alumno_Seleccionado.edad = Convert.ToInt32(TxtEdad.Text);
            Alumno_Seleccionado.direccion = TxtDireccion.Text.Trim();
            Alumno_Seleccionado.fecha_de_nacimiento = dateNacimiento.Value;

            using (AlumnosEntities db = new AlumnosEntities())
            {
                db.alumnos1.Add(Alumno_Seleccionado);
                db.SaveChanges();
            }
            Clear();
            CargarTabla();
            MessageBox.Show("nombre agregado");

        }
        void CargarTabla()
        {


            using (AlumnosEntities db = new AlumnosEntities())
                dataGridViewAlumnos.DataSource = db.alumnos1.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.CurrentRow.Index != -1)
            {
                Alumno_Seleccionado.Id = Convert.ToInt32(dataGridViewAlumnos.CurrentRow.Cells["DataGridId"].Value);
                using (AlumnosEntities db = new AlumnosEntities())
                {
                    Alumno_Seleccionado = db.alumnos1.Where(x => x.Id == Alumno_Seleccionado.Id).FirstOrDefault();
                    db.alumnos1.Remove(Alumno_Seleccionado);
                    db.SaveChanges();
                }
                Clear();
                CargarTabla();
            }
        }

        private void btmLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            TxtApellido.Text = TxtNombre.Text = TxtDireccion.Text = TxtID.Text = TxtEdad.Text = "";
        }

        private void dataGridViewAlumnos_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.CurrentRow.Index != -1)
            {
                Alumno_Seleccionado.Id = Convert.ToInt32(dataGridViewAlumnos.CurrentRow.Cells["DataGridId"].Value);
                using (AlumnosEntities db = new AlumnosEntities())
                {
                    Alumno_Seleccionado = db.alumnos1.Where(x => x.Id == Alumno_Seleccionado.Id).FirstOrDefault();
                    TxtID.Text = Alumno_Seleccionado.Id.ToString();
                    TxtNombre.Text = Alumno_Seleccionado.nombre.ToString();
                    TxtApellido.Text = Alumno_Seleccionado.apellido.ToString();
                    TxtDireccion.Text = Alumno_Seleccionado.direccion.ToString();
                    TxtEdad.Text = Alumno_Seleccionado.edad.ToString();
                }
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.CurrentRow.Index != -1)
            {
                Alumno_Seleccionado.Id = Convert.ToInt32(TxtID.Text);
                using (AlumnosEntities db = new AlumnosEntities())
                {
                    Alumno_Seleccionado.nombre = TxtNombre.Text.Trim();
                    Alumno_Seleccionado.apellido = TxtApellido.Text.Trim();
                    Alumno_Seleccionado.edad = Convert.ToInt32(TxtEdad.Text);
                    Alumno_Seleccionado.direccion = TxtDireccion.Text.Trim();
                    Alumno_Seleccionado.fecha_de_nacimiento = dateNacimiento.Value;
                    db.Entry(Alumno_Seleccionado).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                CargarTabla();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
