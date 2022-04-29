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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string cc = @"Data Source=DESKTOP-P492IAI;Initial Catalog=Ejercicio_G12;Integrated Security=True";
        private void registrar_Click(object sender, EventArgs e)
        {
            if (txtusuarioREG.Text == "" || textCONT.Text == "")
            {
                MessageBox.Show("Por favor escriba usuario y/o contraseña");
                return;
            }
            try
            {


                SqlConnection con = new SqlConnection(cc);
                SqlCommand cmd = new SqlCommand("INSERT INTO usuario (Usuario, Clave) VALUES (@Usuario, @Clave)", con);
                cmd.Parameters.AddWithValue("@Usuario", txtusuarioREG.Text);
                cmd.Parameters.AddWithValue("@Clave", textCONT.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();

                MessageBox.Show("USUARIO REGISTRADO!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ATRAS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
