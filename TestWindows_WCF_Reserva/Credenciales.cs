using System;
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
    public partial class Credenciales : Form
    {
        public Credenciales()
        {
            InitializeComponent();
        }

        private void Credenciales_Load(object sender, EventArgs e)
        {

        }

        private bool AlgoritmoContrasenaSegura(String password)
        {
            //bool mayuscula = false, minuscula = false, numero = false, carespecial = false;
            chkMayus.Checked = false; chkMinus.Checked = false; chkNum.Checked = false; chkEspecial.Checked = false; chkMinCaracter.Checked = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length >= 8)
                {
                    chkMinCaracter.Checked = true;
                }
                if (char.IsUpper(password, i))
                {
                    chkMayus.Checked = true;
                }
                else if (char.IsLower(password, i))
                {
                    chkMinus.Checked = true;
                }
                else if (char.IsDigit(password, i))
                {
                    chkNum.Checked = true;
                }
                else
                {
                    chkEspecial.Checked = true;
                }
            }
            if (chkMayus.Checked && chkMayus.Checked && chkNum.Checked && chkEspecial.Checked && password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (AlgoritmoContrasenaSegura(txtPass.Text))
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }
    }
}
