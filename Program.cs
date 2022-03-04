using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiMenghitungBangunRuang
{
    /// <summary>
    ///     Public Class Persegi Panjang
    /// </summary>
    /// <remarks>
    ///     Public CLass Persegi Panjang dibuat Public agar nantinya dapat diakses oleh kelas lainnya,
    ///     didalam class ini memuat aktivitas input, menghitung luas, dan menampilkan hasil.
    /// </remarks>
    public class PersegiPanjang
    {
        /// <summary>
        /// <var> panjang </var>
        /// <var> lebar </var>
        /// </summary>
        /// <remarks>
        ///     membuat variable panjang dan lebar menjadi public agar dapat diakses oleh method lain
        /// </remarks>
        public double panjang, lebar;

        /// <summary>
        /// <para name="panjang">panjang persegi panjang untuk menerima inputan </para>
        /// <para name="lebar">lebar persegi panjang untuk menerima inputan </para>
        /// </summary>
        public void sisiPP()
        {
            Console.Write("Masukan Panjang : ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Lebar : ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        ///     Operasi hitung Luas Persegi Panjang
        /// </summary>
        /// <param name="p">panjang dalam method perhitungan luas persegi panjang</param>
        /// <param name="l">lebar akan di operasikan dalam method perhitungan luas dengan panjang</param>
        /// <returns>hasil rumus luas persegi panjang, dari panjang dan lebar</returns>
        /// <remarks>
        ///     method LuasPP bertugas untuk menghitung luas persegi panjang yang terdapat parameter inputan sebelumnya
        /// </remarks>
        public double LuasPP(double p, double l)
        {
            return p * l;
        }

        /// <summary>
        ///     menampilkan hasil perhitungan LuasPP
        /// </summary>
        public void TampilPP()
        {
            Console.WriteLine("Luas Persegi Panjang = " + this.LuasPP(panjang, lebar));
            Console.WriteLine();
            Console.WriteLine();
            //Console.ReadKey();
        }
    }

    /// <summary>
    ///     Public CLass Lingkaran
    /// </summary>
    /// <remarks>
    ///     Public CLass Lingkaran dibuat Public agar nantinya dapat diakses oleh kelas lainnya,
    ///     didalam class ini memuat aktivitas input, menghitung luas, dan menampilkan hasil.
    /// </remarks>
    public class Lingkaran
    {
        /// <summary>
        /// <var> jari </var>
        /// </summary>
        /// <remarks>
        ///     membuat variable jari menjadi public agar dapat diakses oleh method lain
        /// </remarks>
        public double jari;

        /// <summary>
        /// <para name="jari">menyimpan input jari-jari lingkaran yang akan di hitung</para>
        /// </summary>
        public void jariLing()
        {
            Console.Write("Masukan Jari Lingkaran : ");
            jari = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        ///     Operasi Hitung Luas Lingkaran
        /// </summary>
        /// <param name="r">jari-jari lingkaran yang dihitung</param>
        /// <returns>hasil perhitungan menggunakan rumus luas lingkaran </returns>
        public double LuasLing(double r)
        {
            return 3.14 * r * r;
        }

        /// <summary>
        ///     menampilkan hasil perhitungan LuasLing
        /// </summary>
        public void TampilLing()
        {
            Console.WriteLine("Luas Lingkaran = " + this.LuasLing(jari));
            Console.WriteLine();
            Console.WriteLine();
            //Console.ReadKey();
        }
    }

    /// <summary>
    ///     Public Class Segitiga
    /// </summary>
    /// <remarks>
    ///     Public CLass Segitiga dibuat Public agar nantinya dapat diakses oleh kelas lainnya,
    ///     didalam class ini memuat aktivitas input, menghitung luas, dan menampilkan hasil.
    /// </remarks>
    public class Segitiga
    {
        /// <summary>
        /// <var>alas</var>
        /// <var>tinggi</var>
        /// </summary>
        /// <remarks>
        ///     membuat variable alas dan tinggi menjadi public agar dapat diakses oleh method lain
        /// </remarks>
        public double alas, tinggi;

        /// <summary>
        /// <para name="alas">menyimpan input alas yang akan di hitung</para>
        /// <para name="tinggi">menyimpan input tinggi yang akan di hitung dengan alas</para>
        /// </summary>
        public void sisiS3()
        {
            Console.Write("Masukan Alas : ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Tinggi : ");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        ///     Operasi Hitung Luas Segitiga
        /// </summary>
        /// <param name="a">alas dalam perhitungan luas segitiga</param>
        /// <param name="t">tinggi yang akan dihitung dengan alas</param>
        /// <returns>hasil dari operasi perhitungan rumus luas segitiga</returns>
        public double LuasS3(double a, double t)
        {
            return 0.5 * a * t;
        }

        /// <summary>
        ///     menampilkan hasil dari operasi hitung LuasS3
        /// </summary>
        public void TampilS3()
        {
            Console.WriteLine("Luas Segitiga = " + this.LuasS3(alas, tinggi));
            Console.WriteLine();
            Console.WriteLine();
            //Console.ReadKey();
        }
    }

    /// <summary>
    ///     Sub Class Program
    /// </summary>
    /// <remarks>memanggil setiap method untuk di eksekusi di dalam class program</remarks>
    public class Program
    {
        /// <summary>
        ///     static method
        /// </summary>
        /// <param name="args">menyimpan arguments yang di passing melalui command line ketika mengeksekusi program</param>
        static void Main(string[] args)
        {
            PersegiPanjang pp = new PersegiPanjang();
            Lingkaran lk = new Lingkaran();
            Segitiga s3 = new Segitiga();

            int pilih;
            string ulang;
            ulang = "Y";
            while (ulang == "Y")

            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("______________MENU PILIHAN__________________");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1.   Luas Persegi Panjang");
                Console.WriteLine("2.   Luas Lingkaran");
                Console.WriteLine("3.   Luas Segitiga");
                Console.WriteLine("4.   Keluar");
                Console.WriteLine("Pilihan (1/2/3/4) : ");
                pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (pilih)
                {
                    case 1:
                        pp.sisiPP();
                        pp.TampilPP();
                        break;
                    case 2:
                        lk.jariLing();
                        lk.TampilLing();
                        break;
                    case 3:
                        s3.sisiS3();
                        s3.TampilS3();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Pilihan Salah !!!!");
                        break;
                }

                Console.WriteLine("Kembali Kemenu (Y/T) : ");
                ulang = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
