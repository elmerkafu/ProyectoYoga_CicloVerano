﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows_WCF_Reserva
{
    public partial class ReservaMan01 : Form
    {
        ProxyClaseProgramada.ServicioClaseProgramadaClient objServiceClaseProgramada = new ProxyClaseProgramada.ServicioClaseProgramadaClient();
        ProxyClaseProgramada.ClaseProgramadaDC objClaseProgramadaDC = new ProxyClaseProgramada.ClaseProgramadaDC();

        ProxyCliente.ServicioClienteClient objServiceCliente = new ProxyCliente.ServicioClienteClient();
        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();

        ProxyReserva.ServicioReservaClient objServiceReserva = new ProxyReserva.ServicioReservaClient();
        ProxyReserva.ReservaDC objReservaDC = new ProxyReserva.ReservaDC();

        public ReservaMan01()
        {
            InitializeComponent();
        }

        private void ReservaMan01_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturarFec_Click(object sender, EventArgs e)
        {
            String strId = monthCalendar1.SelectionStart.ToShortDateString();
            dtgClasesReserva.AutoGenerateColumns = false;
            dtgClasesReserva.DataSource = objServiceClaseProgramada.ListarClasesPorFecha(Convert.ToDateTime(strId));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                String strDni = mskDNI.Text.Trim();
                objClienteDC = objServiceCliente.ConsultaClienteDNI(strDni);

                if (strDni == "")
                {
                    throw new Exception("Ingrese un DNI válido");
                }
                else
                {
                    lblIdCli.Text = objClienteDC.Id_Cliente.ToString();
                    lblNombre.Text = objClienteDC.Nombres;
                    lblApePa.Text = objClienteDC.ApePaterno;
                    lblApaMa.Text = objClienteDC.ApeMaterno;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dtgClasesReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (this.dtgClasesReserva.Columns[e.ColumnIndex].Name == "Reservar")
                {
                    //lblCodClase.Text = dtgClasesReserva.CurrentRow.Cells[0].Value.ToString();

                    if (MessageBox.Show("¿Está seguro que desea Reservar?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        objReservaDC.Id_Cliente = Convert.ToInt16(lblIdCli.Text);
                        objReservaDC.Usu_reg = "Leslye";
                        objReservaDC.Id_Clase_Prog = Convert.ToInt16(dtgClasesReserva.CurrentRow.Cells[0].Value.ToString());

                        objServiceReserva.InsertarReserva(objReservaDC);

                    }
                    // Falta a agregar que se cambie el estado cada vez que se cancela la reserva. DONDE LO PONGO??? !!!
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }
    }
}
