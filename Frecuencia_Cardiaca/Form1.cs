using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;

namespace Frecuencia_Cardiaca
{

    public partial class Form1 : Form
    {

        private string DataSerIn;
        private Stopwatch stopwatch = new Stopwatch();
        private string _seg, _min;
        private bool UmbralEdo = true;
        private int LCor = 0;
        private int contLc = 0;
        private int FreclPMResult;
        private int MostrarLCor;
        private bool SB = true;
        private bool SR = false;
        private string connectionstring = "Data Source=.;Initial Catalog=fcardiaca;Integrated Security=True";

        public Form1()
        {    InitializeComponent();
            cmbBaudios.Text = "115200";

        }

        private void cmbPuerto_DropDown(object sender, EventArgs e)
        {
            
        }

        private void ConectArduino()
        {
            try
            {
                Serialport.PortName = cmbPuerto.Text;
                Serialport.BaudRate = int.Parse(cmbBaudios.Text);
                Serialport.Open();
                IniciaGraficaUmbral();
                IniciaTiempo();
            }
            catch  (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el puerto. Asegurate de que el arduino este bien conectado correctamente y de seleccionar el puerto correcto.{Environment.NewLine}Error:{ex.Message}","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DesconectArduino()
        {
            try
            {
                timer1.Stop();
                Thread.Sleep(500);
                Serialport.Close();
                Reiniciar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }



        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Conectar")
            {
                ConectArduino();
            }

            else
            {
                DesconectArduino();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (btnGrabar.Text == "Grabar")
            {
                IniciarCaptura();

            }
            else
            {
                DetenerCaptura();
            }
        }


        private void IniciarCaptura ()
        {
            Console.WriteLine("IniciarCaptura llamado");
            btnGrabar.Text = "Detener";
            
            dataGridView1.Rows.Clear();
            chrRegistro.Series["Series1"].Points.Clear();
            btnConectar.Enabled = false;
            btnExportar.Enabled = false;    
            btnLimpiar.Enabled = false;
            contLc = 0;
            SR = true;
            stopwatch.Start();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear ();
            chrRegistro.Series["Series1"].Points.Clear ();
            for (int i = 0; i <= 13; i++)
            {
                chrRegistro.Series["Series1"].Points.AddXY("00:00", 0);
            }
        }

        private void GuardarBD()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    pbGuardar.Visible = true;
                    pbGuardar.Value = 2;

                    connection.Open();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string query = "INSERT INTO frecCardiaca (Tiempo,FCardiaca) VALUES (@Tiempo, @HR";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            pbGuardar.Value = 8;
                            cmd.Parameters.AddWithValue("@Tiempo", row.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@HR", row.Cells[1].Value);
                            cmd.ExecuteNonQuery();
                        }
                        pbGuardar.Value = 10;
                    }
                    MessageBox.Show("Data Guardada exitosamente en la base de datos", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbGuardar.Visible = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error saving Data to Database: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }



        private void IniciaGraficaUmbral()
        {
            for (int i = 0; i <= 101; i++)
            {
                chTiempoRealHR.Series["Series2"].Points.AddY(int.Parse(txtUmbral.Text));
                if (chTiempoRealHR.Series["Seies"].Points.Count ==101)
                {
                    chTiempoRealHR.Series["series2"].Points.RemoveAt(0);
                }
            }
        }

        private void IniciaTiempo()
        {
            timer1.Start();
            btnConectar.Text = "Desconectar";
            btnGrabar.Enabled = true;
            lblstatus.Text = "Status : Conectado";
            btnPuerto.Enabled = false;
            btnGrabar.Enabled = true;
            cmbPuerto.Enabled = false;
            cmbBaudios.Enabled = false;
        }


        private void Reiniciar()
        {
            btnConectar.Text = "Conectar";
            btnGrabar.Enabled = false;
            lblstatus.Text = "Status : Desconectado";
            btnPuerto.Enabled = true;
            btnGrabar.Enabled = false;
            cmbPuerto.Enabled = true;
            cmbBaudios.Enabled = true;
            txtUmbral.Enabled = true;
            InicializaGraficas();
        }





        private void InicializaGraficas()
        {
            for (int i = 0; i <= 101; i++)
            {
                chTiempoRealHR.Series["Series1"].Points.AddY(0);
                if (chTiempoRealHR.Series["Series1"].Points.Count == 101) 
                {
                    chTiempoRealHR.Series["Series1"].Points.RemoveAt(0);
                }                   
            }

            for (int i = 0;i <= 13; i++)
            {
                chrRegistro.Series["Series1"].Points.AddXY("00:00",0);
            }


        }

        private void txtUmbral_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chTiempoRealHR.Series["series1"].Points.Count == 101) 
            {
                chTiempoRealHR.Series["series1"].Points.RemoveAt(0);
            }

            chTiempoRealHR.Series["series1"].Points.AddXY(0, DataSerIn);
            chTiempoRealHR.Series["series1"].LegendText = $"Real Time HeartBeat Signal({DataSerIn})";
            if (SR)
            {
                LCor = int.Parse(DataSerIn);
                if (LCor > int.Parse(txtUmbral.Text) && UmbralEdo)
                {
                    contLc++;
                    UmbralEdo = false;
                }

                TimeSpan elapsed = stopwatch.Elapsed;
                _seg = elapsed.Seconds.ToString("00");
                _seg = elapsed.Minutes.ToString("00");
                lblTiempo.Text = $"Timer {_min}: {_seg}";

                MostrarLCor = int.Parse(_seg) % 10;
                if (MostrarLCor == 0 && SB)
                {
                    FreclPMResult = -contLc * 6;
                    dataGridView1.Rows.Add($"{_min}: {_seg}", FreclPMResult);
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;

                    if (chrRegistro.Series["Series1"].Points.Count == 13)
                    {
                        chrRegistro.Series["series1"].Points.RemoveAt(0);
                    }

                    chrRegistro.Series["Series1"].Points.AddXY($"{_min}: {_seg}", FreclPMResult);
                    contLc = 0;
                    SB = false;
                }

                if (MostrarLCor != 0) 
                {
                    SB = true;
                }
            }
        }

        private void Serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataSerIn = Serialport.ReadLine();
        }

        private void txtUmbral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '+')
            {
                MessageBox.Show("Formato de dato incorrecto! solo se permiten numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void cmbBaudios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPuerto_Click(object sender, EventArgs e)
        {
            string[] myport = SerialPort.GetPortNames();
            cmbPuerto.Items.AddRange(myport);
            cmbPuerto.SelectedIndex = 0;
            btnConectar.Enabled = true;
            cmbPuerto.DroppedDown = true;
        }

        private void DetenerCaptura()
        {
            Console.WriteLine("IniciarCaptura llamado");
            btnGrabar.Text = "Grabar";       
            btnConectar.Enabled = true;
            btnExportar.Enabled = true;
            btnLimpiar.Enabled = true;
           
            SR = false;
            stopwatch.Reset();
            stopwatch.Stop();
            contLc = 0;
            lblTiempo.Text = "Timer 00:00";
        }
    }

        
    
}
