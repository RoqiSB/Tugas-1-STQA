using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activ1_PAW 
{

    class Rerata
    {
        ///deklarasi variabel yang bertipe data double yaitu ada nilaiMTK, nilaiInggris dan juga rerata
        double nilaiMTK, nilaiInggris, rerata;
        /// <summary>
        /// proses input data, user dapat memasukkan data pada nilai Matematika
        /// mengconvertert data nilaiMTK ke double 
        /// proses input data, user dapat memasukkan data pada nilai Bahasa Inggris
        /// nilaiInggris dikonvertert ke tipe data double
        /// </summary>
        public void inputData()
        {
            Console.Write("Masukan Nilai Matematika = ");
            nilaiMTK = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Nilai Bahasa Inggris = ");
            nilaiInggris = Convert.ToDouble(Console.ReadLine());
        }

        public double rumus()
        {
            ///rumus untuk mencari rata rata dengan menghitung nilai MTK ditambah nilai Inggris lalu dibagi 2
            rerata = (nilaiMTK + nilaiInggris) / 2;
            return rerata;
        }
        /// <summary>
        /// Penggunaan fungsi if else
        /// </summary>
        public void output()
        {
            /// Jika nilai hasil dari rata rata >=80 maka akan mendapatkan nilai A
            if (rumus() >= 80)
            {

                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("Anda Mendapatkan Nilai A");
            }
            /// Jika nilai hasil dari rata rata <80 dan >=70 maka akan mendapatkan nilai B
            else if (rumus() < 80 && rumus() >= 70)
            {

                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("Anda Mendapatkan Nilai B");
            }
            /// Jika nilai hasil dari rata rata <70 dan >=60 maka akan mendapatkan nilai C
            else if (rumus() < 70 && rumus() >= 60)
            {

                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("Anda Mendapatkan Nilai C");
            }
            /// Jika nilai hasil dari rata rata <60 maka akan mendapatkan nilai D
            else
            {

                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("Anda Mendapatkan Nilai D");
            }
        }
        /// <summary>
        /// Memanggil method dari class yang sudah ada
        /// </summary>
        internal class Program
        {
            static void Main(string[] args)
            {
                ///menampilkan index rata rata
                Rerata index = new Rerata();
                ///menampilkan index method input data
                ///menampilkan index method rumus
                ///menampilkan index method output
                index.inputData();
                index.rumus();
                index.output();

                Console.ReadLine();
            }
        }
    }
}