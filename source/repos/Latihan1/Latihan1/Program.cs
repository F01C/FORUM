using System;

namespace Latihan1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data pribadi
            Console.Write("Masukkan Nama: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan Nomor BP: ");
            string nobp = Console.ReadLine();

            Console.Write("Masukkan Kelas: ");
            string kelas = Console.ReadLine();

            Console.Write("Masukkan Mata Kuliah: ");
            string mataKuliah = Console.ReadLine();

            // Input nilai UTS dan UAS
            Console.Write("Masukkan Nilai UTS: ");
            double nilaiUTS = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai UAS: ");
            double nilaiUAS = Convert.ToDouble(Console.ReadLine());

            // Menghitung nilai akhir (40% UTS + 60% UAS)
            double nilaiAkhir = (0.4 * nilaiUTS) + (0.6 * nilaiUAS);

            // Menampilkan hasil
            Console.WriteLine("\n--- Hasil ---");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Nomor BP: {nobp}");
            Console.WriteLine($"Kelas: {kelas}");
            Console.WriteLine($"Mata Kuliah: {mataKuliah}");
            Console.WriteLine($"Nilai Akhir: {nilaiAkhir}");

            
        }
    }
}
