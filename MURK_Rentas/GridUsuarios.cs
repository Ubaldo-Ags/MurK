﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MURK_Rentas
{

    public partial class GridUsuarios : Form
    {
        System.Data.SqlClient.SqlConnection con; //variable que lleva al servidor

        public GridUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormUsuarios fu = new FormUsuarios();
            fu.ShowDialog();
        }

        private void GridUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mURKDataSet5.V_PERSONAS' Puede moverla o quitarla según sea necesario.
            this.v_PERSONASTableAdapter2.Fill(this.mURKDataSet5.V_PERSONAS);
          

            con = new System.Data.SqlClient.SqlConnection(); //llamar conexion al form load
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string ID_Usuario = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea editar el usuario ", "MURK - Editar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormUsuarios FU = new FormUsuarios();
                FU.labelUltimo.Text = ID_Usuario;
                FU.tituloForm.Text = "Editar Usuario";
                FU.ShowDialog();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID_Proveedor = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            MessageBox.Show(ID_Proveedor);
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("EXEC ELIMINAR_PERSONA'" + ID_Proveedor + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro eliminado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el registro");
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
                    this.v_PERSONASTableAdapter2.Fill(this.mURKDataSet5.V_PERSONAS);


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.v_PERSONASTableAdapter2.Fill(this.mURKDataSet5.V_PERSONAS);


        }
    }
}
