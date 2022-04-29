using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rrc_loginapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Cadena de Conexion
        string cc = @"Data Source=DESKTOP-P492IAI;Initial Catalog=Ejercicio_G12;Integrated Security=True";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text=="" || txtclave.Text=="")
            {
                MessageBox.Show("Por favor escriba usuario y/o contraseña");
                return;
            }
            try
            {
                //crear conexion
                SqlConnection con = new SqlConnection(cc);
                SqlCommand cmd = new SqlCommand("Select * from usuario where Usuario=@Usuario and Clave=@Clave", con);
                cmd.Parameters.AddWithValue("@Usuario", txtusuario.Text);
                cmd.Parameters.AddWithValue("@Clave", txtclave.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int contar = ds.Tables[0].Rows.Count;
                if (contar>0)
                {
                    MessageBox.Show("Sesion iniciada Correctamente!");
                    this.Hide();
                    frmDashboard frm = new frmDashboard();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Ingreso Fallido!");

                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROCESO DE REGISTRO!");
            this.Hide();
                    Form2 frm2 = new Form2();
                    frm2.Show();
        }
    }
}
