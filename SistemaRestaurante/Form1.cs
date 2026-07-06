using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SistemaRestaurante
{
    public partial class FrmMesas : Form
    {
        private int idMesa = 0;

        public FrmMesas()
        {
            InitializeComponent();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add("Disponible");
            cboEstado.Items.Add("Ocupada");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();

                    string consulta = @"INSERT INTO Mesas
                                        (NumeroMesa, Capacidad, Estado)
                                        VALUES
                                        (@NumeroMesa, @Capacidad, @Estado)";

                    SqlCommand cmd = new SqlCommand(consulta, con);

                    cmd.Parameters.AddWithValue("@NumeroMesa", txtNumeroMesa.Text);
                    cmd.Parameters.AddWithValue("@Capacidad", txtCapacidad.Text);
                    cmd.Parameters.AddWithValue("@Estado", cboEstado.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Mesa guardada correctamente.");

                    btnMostrar.PerformClick();
                    btnLimpiar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Mesas", con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvMesas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMesas.Rows[e.RowIndex];

                idMesa = Convert.ToInt32(fila.Cells["IdMesa"].Value);

                txtNumeroMesa.Text = fila.Cells["NumeroMesa"].Value.ToString();
                txtCapacidad.Text = fila.Cells["Capacidad"].Value.ToString();
                cboEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void dgvMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMesas_CellClick(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();

                    string consulta = @"UPDATE Mesas
                                        SET NumeroMesa=@NumeroMesa,
                                            Capacidad=@Capacidad,
                                            Estado=@Estado
                                        WHERE IdMesa=@IdMesa";

                    SqlCommand cmd = new SqlCommand(consulta, con);

                    cmd.Parameters.Add("@NumeroMesa", SqlDbType.Int).Value = Convert.ToInt32(txtNumeroMesa.Text);
                    cmd.Parameters.Add("@Capacidad", SqlDbType.Int).Value = Convert.ToInt32(txtCapacidad.Text);
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = cboEstado.Text;
                    cmd.Parameters.Add("@IdMesa", SqlDbType.Int).Value = idMesa;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Mesa actualizada correctamente.");

                    btnMostrar.PerformClick();
                    btnLimpiar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMesa == 0)
                {
                    MessageBox.Show("Seleccione una mesa.");
                    return;
                }

                if (MessageBox.Show("¿Desea eliminar esta mesa?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Conexion conexion = new Conexion();

                    using (SqlConnection con = conexion.ObtenerConexion())
                    {
                        con.Open();

                        string consulta = "DELETE FROM Mesas WHERE IdMesa=@IdMesa";

                        SqlCommand cmd = new SqlCommand(consulta, con);

                        cmd.Parameters.AddWithValue("@IdMesa", idMesa);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Mesa eliminada correctamente.");

                        btnMostrar.PerformClick();
                        btnLimpiar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroMesa.Clear();
            txtCapacidad.Clear();
            cboEstado.SelectedIndex = -1;
            idMesa = 0;
            txtNumeroMesa.Focus();
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNumeroMesa_Click(object sender, EventArgs e)
        {

        }
    }
}