using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioSimple1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Paso 1: Validar que ambas contraseñas sean iguales
            // Paso 2: Validar que la contraseña cuente con 12 caracteres, mayúsculas,
            // minúsculas, 3 símbolos especiales y al menos un número
            //Contraseña válida: 1Ss456@!!234

            string regexPattern = @"^(?=(?:[^A-Z]*[A-Z]){1})(?=(?:[^a-z]*[a-z]){1})(?=(?:\D*\d){1})(?=(?:[^\W_]*[\W_]){3}[^\W_]*$)[A-Za-z\d\W_]{12}$";
            string PrimeraContrasena = txtPrimeraContrasena.Text;
            string SegundaContrasena = txtSegundaContrasena.Text; // Corrección aquí

            if (!PrimeraContrasena.Equals(SegundaContrasena))
            {
                MessageBox.Show("Las contraseñas NO son iguales", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(PrimeraContrasena, regexPattern))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("La contraseña fue valida", "Éxito");
        }

    }
}

