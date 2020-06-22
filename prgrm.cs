using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassAnak;
using TugasLab8.ClassInduk;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            // Membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.nik = "1113-4231-3131";
            karyawanTetap.nama = "muhammad sandiko";
            karyawanTetap.GajiBulanan = 8000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.nik = "4242-4552-2525";
            karyawanHarian.nama = "safa lina";
            karyawanHarian.upahperJam = 200000;
            karyawanHarian.jumlahjamkerja = 9;

            Sales sales = new Sales();
            sales.nik = "5342-4242-4245";
            sales.nama = "mikhael sujarwo";
            sales.jumlahPenjualan = 50;
            sales.komisi = 50000;

            // Objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. nik: {1}, nama: {2}, Gaji: {3}", noUrut, karyawan.nik, karyawan.nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadLine();
        }
    }
}
