using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikGigiWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            
            string selectedOption = comboBoxPilihan.SelectedItem?.ToString();
           // dataGridView1.AutoGenerateColumns = true;

            if (selectedOption == "Registrasi")
            {
                // Kosongkan DataGridView terlebih dahulu
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Tambahkan kolom untuk form registrasi pasien
                dataGridView1.Columns.Add("Nama", "Nama");
                dataGridView1.Columns.Add("NIK", "NIK");
                dataGridView1.Columns.Add("Alamat", "Alamat");
                dataGridView1.Columns.Add("TanggalLahir", "Tanggal Lahir");
            }
            else if (selectedOption == "Tampilkan Data")
            {
                // Kosongkan DataGridView terlebih dahulu
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Tambahkan kolom untuk rekam medis
                dataGridView1.Columns.Add("NamaPasien", "Nama Pasien");
                dataGridView1.Columns.Add("TanggalKunjungan", "Tanggal Kunjungan");
                dataGridView1.Columns.Add("Diagnosis", "Diagnosis");
                dataGridView1.Columns.Add("Pengobatan", "Pengobatan");

                // Tambahkan data contoh (jika ada)
                dataGridView1.Rows.Add("Budi", "2024-01-20", "Flu", "Parasetamol");
            }
            else if (selectedOption == "Daftar Harga")
            {
                // Kosongkan DataGridView terlebih dahulu
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Tambahkan kolom untuk daftar harga
                dataGridView1.Columns.Add("Layanan", "Layanan");
                dataGridView1.Columns.Add("Harga", "Harga");

                // Tambahkan data contoh untuk daftar harga
                dataGridView1.Rows.Add("Konsultasi", "Rp. 100.000");
                dataGridView1.Rows.Add("Pembersihan Gigi", "Rp. 150.000");
                dataGridView1.Rows.Add("Penambalan Gigi", "Rp. 200.000");
            }
            else if (selectedOption == "Jadwal Praktek")
            {
                // Kosongkan DataGridView terlebih dahulu
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Tambahkan kolom untuk jadwal praktek
                dataGridView1.Columns.Add("Dokter", "Dokter");
                dataGridView1.Columns.Add("Hari", "Hari");
                dataGridView1.Columns.Add("Jam", "Jam");

                // Tambahkan data contoh untuk jadwal praktek
                dataGridView1.Rows.Add("Dr. Siti", "Senin", "08:00 - 12:00");
                dataGridView1.Rows.Add("Dr. Andi", "Selasa", "13:00 - 17:00");
            }
            else if (selectedOption == "Antrean")
            {
                // Kosongkan DataGridView terlebih dahulu
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Tambahkan kolom untuk antrean
                dataGridView1.Columns.Add("NomorAntrean", "Nomor Antrean");
                dataGridView1.Columns.Add("Nama", "Nama");
                dataGridView1.Columns.Add("WaktuKunjungan", "Waktu Kunjungan");

                // Tambahkan data contoh untuk antrean
                dataGridView1.Rows.Add("A01", "Joko", "2024-01-21 09:00");
                dataGridView1.Rows.Add("A02", "Mira", "2024-01-21 09:30");
            }
            else
            {
                MessageBox.Show("Silakan pilih opsi yang valid.");
            }

            
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Ambil data dari TextBox (misalnya: txtNama, txtNIK)
            string nama = txtNama.Text;
            string nik = txtNIK.Text;

            // Tambahkan data ke antrean (DataGridView)
            dataGridView1.Rows.Add(nama, nik);

            // Kosongkan kembali form registrasi
            txtNama.Clear();
            txtNIK.Clear();

            // Fokuskan kembali ke TextBox Nama untuk kemudahan
            txtNama.Focus();

        }
    }
}
