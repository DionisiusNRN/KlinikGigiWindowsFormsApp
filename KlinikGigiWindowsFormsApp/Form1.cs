using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlinikGigiWindowsFormsApp2;


namespace KlinikGigiWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            string inputPassword = textBoxPassword.Text; //mendaoatkanteks dari TExtBOx password
            string correctPassword = "Admin123"; // password benar

            if (inputPassword == correctPassword)
            {
                KlinikGigiWindowsFormsApp2.Form1 form2 = new KlinikGigiWindowsFormsApp2.Form1(); // Membuat instance form dari project KlinikGigiWindowsFormsApp2
                form2.Show();  // Menampilkan form dari KlinikGigiWindowsFormsApp2
                this.Hide();   // Menyembunyikan form dari KlinikGigiWindowsFormsApp
            } else
            {
                labelError.Text = "Password yang diinputkan salah";
                labelError.Visible = true;
            }
        }
    }
}
