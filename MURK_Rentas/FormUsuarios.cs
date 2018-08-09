using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//base de datos
using System.IO.Ports;

namespace MURK_Rentas
{
    public partial class FormUsuarios : Form
    {
    
       
        public FormUsuarios()
        {
            InitializeComponent();
        }
        string rfid_usuario = "";
        System.Data.SqlClient.SqlConnection con; //variable que lleva al servidor

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
          
            timer1.Start();
            //serialPort1.Open();
            con = new System.Data.SqlClient.SqlConnection(); //llamar conexion al form load
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";
         
            if (tituloForm.Text == "Editar Usuario")
            {
                BusquedaEditar();
            }
        }

private void buscarUltimo()
        {
         
            //Busca el usuario con el codigo RFId leido
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("exec ULTIMA_PERSONA");
                SqlDataReader busqueda;
                busqueda = query.ExecuteReader();
                while (busqueda.Read() == true)
                {
                  labelUltimo.Text = busqueda["Id"].ToString();
                 
                }
            }
            catch
            {

            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        private void editarRegistro()
        {
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("EXEC MOD_PERSONAS '" + labelUltimo.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox11.Text + "','" + textBox10.Text + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro modificado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo almacenar el registro");
                }
            }
            catch
            {
                MessageBox.Show("Error-catch");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                    this.Close();
                }
            }
        }
        private void guardarRFID()
        {
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("EXEC ULTIMO_REGISTRO '" + labelUltimo.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox11.Text + "','" + textBox10.Text + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro modificado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo almacenar el registro");
                }
            }
            catch
            {
                MessageBox.Show("Error-catch");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                    this.Close();
                }
            }
        }
        private void BusquedaEditar()
        {
            try
            {
                con.Open();
                SqlCommand consulta = con.CreateCommand();//crea comando
                consulta.CommandType = CommandType.Text;
                consulta.CommandText = string.Format("SELECT * FROM Personas WHERE Id = '" + labelUltimo.Text + "'");
                SqlDataReader busqueda;
                busqueda = consulta.ExecuteReader();
                while (busqueda.Read() == true)
                {
                    textBox1.Text = busqueda["Nombre"].ToString();
                    textBox2.Text = busqueda["Apellido_P"].ToString();
                    textBox3.Text = busqueda["Apellido_M"].ToString();
                    dateTimePicker1.Text= busqueda["FechaNacimiento"].ToString();
                    textBox4.Text = busqueda["Direccion"].ToString();
                    textBox5.Text = busqueda["Colonia"].ToString();
                    textBox6.Text = busqueda["Municipio"].ToString();
                    textBox7.Text = busqueda["Estado"].ToString();
                    textBox11.Text = busqueda["Email"].ToString();
                    textBox10.Text = busqueda["Telefono"].ToString();



                }
            }
            catch
            {
                MessageBox.Show("Error de busqueda catch");
            }
            finally
            {
                con.Close();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (tituloForm.Text == "Editar Usuario")
            {
                editarRegistro();
            }
            else
            {
                try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("EXEC ALTA_PERSONA'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox11.Text + "','" + textBox10.Text + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro almacenado exitosamente ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                     
                     

                    }
                    else
                {
                    MessageBox.Show("No se pudo almacenar el registro");
                }
            }
            catch
            {
                MessageBox.Show("Error-catch");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                  
                    }
                    buscarUltimo();

                    Alta_RFID ar = new Alta_RFID();
                    ar.lblName.Text = "Asignar Tarjeta RFID a Usuario";
                    //this.Hide();
                    ar.ShowDialog();
                    // this.Close();
                }
            }
        }
        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buscarUltimo();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[3];
        }


    
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Trae el codigo rfid de la tarjeta leída
            rfid_usuario = serialPort1.ReadLine().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
    }
    }

