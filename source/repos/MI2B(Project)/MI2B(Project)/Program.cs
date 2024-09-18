using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI2B_Project_
{
    public class Mahasiswa
    {

        private string nim;
        private string nama;
        

        public string Nim
        {
            get { return nim; }
            set { nim = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        
    }

    public enum Hari { Senin, Selasa, Rabu, Kamis, Jumat, Sabtu, Minggu }

    class Program
    {
        static void Main(string[] arg)
        {
            int a = 5;
            int b = a;
            a = 12;

           // Console.WriteLine($"A : {a} ");
            //Console.WriteLine($"B : {b} ");
            //Console.ReadLine();


            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "2301092010";
            mhs1.Nama = "Fadhil Dzaky Arhab";          

            Mahasiswa mhs2 = mhs1;

            Console.WriteLine($"Mahasiswa1 - Nim : {mhs1.Nim}, Nama : { mhs1.Nama} ");
            Console.WriteLine($"Mahasiswa2 - Nim : {mhs2.Nim}, Nama : { mhs2.Nama} ");
            
            mhs1.Nama = "Ambatron";         


            Console.WriteLine($"Mahasiswa1 - Nim : {mhs1.Nim}, Nama : { mhs1.Nama} ");
            Console.WriteLine($"Mahasiswa2 - Nim : {mhs2.Nim}, Nama : { mhs2.Nama} ");
            

            var nama = "Fadhil Arhab";
            var bil1 = 10;
            var bil2 = 12.5;
            var isSelected = true;

            Console.WriteLine(nama.GetType().ToString());
            Console.WriteLine(bil1.GetType().ToString());
            Console.WriteLine(bil2.GetType().ToString());
            Console.WriteLine(isSelected.GetType().ToString());
            

            Hari testHari = Hari.Senin;
            switch (testHari)
            {
                case Hari.Senin :
                Console.WriteLine("Hari Senin");
                    
                    break;
                

                case Hari.Selasa:
                    Console.WriteLine("Hari Selasa");
                    
                    break;

                case Hari.Rabu:
                    Console.WriteLine("Hari Rabu");
                    
                    break;

                case Hari.Kamis:
                    Console.WriteLine("Hari Kamis");
                    
                    break;

                case Hari.Jumat:
                    Console.WriteLine("Hari Jum'at ");
                    
                    break;

                case Hari.Sabtu:
                    Console.WriteLine("Hari Sabtu");
                    
                    break;

                case Hari.Minggu:
                    Console.WriteLine("Hari Minggu");
                    
                    break;
            }

            /*String Nama="";
                 string alamat = string.Empty;
            Console.Write("Masukkan Nama Anda");
             nama = Console.ReadLine();
            Console.Write("Masukkan Alamat");
            alamat = Console.ReadLine();
             */
            Console.ReadLine();


        }
    }
}
