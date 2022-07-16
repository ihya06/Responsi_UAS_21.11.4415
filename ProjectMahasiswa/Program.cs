using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        Mahasiswa Mahasiswa = new Mahasiswa();
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";


            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.Clear();

            Mahasiswa Mahasiswa = new Mahasiswa();

            Console.Write("NIM: ");
            Mahasiswa.NIM = Console.ReadLine();
            Console.Write("Nama: ");
            Mahasiswa.NAMA = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P]: ");
            Mahasiswa.GENDER = Console.ReadLine();
            if (Mahasiswa.GENDER == "L")
            {
                Mahasiswa.GENDER = "Laki-Laki";
            }
            else if (Mahasiswa.GENDER == "P")
            {
                Mahasiswa.GENDER = "Perempuan";
            }
            Console.Write("IPK: ");
            Mahasiswa.IPK = Console.ReadLine();

            daftarMahasiswa.Add(Mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.Clear();

            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;

            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {

                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", no, mahasiswa.NIM, mahasiswa.NAMA, mahasiswa.GENDER, mahasiswa.IPK);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
