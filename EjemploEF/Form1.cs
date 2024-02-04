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
    public partial class Form1 : Form
    {
        alumnos1 A=new alumnos1();
        public Form1()
        {
            InitializeComponent();
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            A.nombre = TxtNombre.Text.Trim();
            A.apellido = TxtApellido.Text.Trim();
            A.edad = Convert.ToInt32(TxtEdad.Text);
            A.direccion = TxtDireccion.Text.Trim();
            //A.fecha_de_nacimiento = dateNacimiento

        using (AlumnosEntities db=new AlumnosEntities()) 
            {
                db.alumnos1.Add(A);
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
                A.Id = Convert.ToInt32(dataGridViewAlumnos.CurrentRow.Cells["DataGridId"].Value);
                using (AlumnosEntities db = new AlumnosEntities())
                {
                    A = db.alumnos1.Where(x => x.Id == A.Id).FirstOrDefault();
                  db.alumnos1.Remove(A);
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
            if(dataGridViewAlumnos.CurrentRow.Index !=-1) 
            {
                A.Id = Convert.ToInt32(dataGridViewAlumnos.CurrentRow.Cells["DataGridId"].Value);
                using (AlumnosEntities db = new AlumnosEntities())
                {
                   A= db.alumnos1.Where(x=>x.Id==A.Id).FirstOrDefault();
                   TxtID.Text =A.Id.ToString();
                    TxtNombre.Text =A.nombre.ToString();
                    TxtApellido.Text=A.apellido.ToString();
                   TxtDireccion.Text=A.direccion.ToString();
                   TxtEdad.Text=A.edad.ToString();
                }
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.CurrentRow.Index != -1)
            {
                A.Id = Convert.ToInt32(TxtID.Text);
                using (AlumnosEntities db = new AlumnosEntities())
                {   A.nombre = TxtNombre.Text.Trim();
                    A.apellido = TxtApellido.Text.Trim();
                    A.edad = Convert.ToInt32(TxtEdad.Text);
                    A.direccion = TxtDireccion.Text.Trim();
                    db.Entry(A).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                CargarTabla();
            }
        }
    }
    }
