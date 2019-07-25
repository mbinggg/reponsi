using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("Keluar");
            Console.WriteLine();

        }

        static void TambahCustomer()
        {
            Console.Clear();

            Customer customer = new Customer();
            Console.WriteLine("Tambah Customer");
            Console.WriteLine();
            Console.WriteLine("Kode Customer");
            customer.Kode = Console.ReadLine();
            Console.WriteLine("Nama Customer");
            customer.Nama = Console.ReadLine();
            Console.WriteLine("Jumlah piutang");
            customer.Piutang = Console.ReadLine();

            daftarCustomer.Add(customer);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            Customer customer = new Customer();
            Console.Write("Kode Customer");
            string kode = Console.ReadLine();
            Customer delpro = daftarCustomer.SingleOrDefault(f => kode == kode);
            if (daftarCustomer.Contains(delpro) == true)
            {
                daftarCustomer.Remove(delpro);
                Console.WriteLine("Data Customer berhasil dihapus");

            }
            else
            {
                Console.WriteLine("Data customer tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();
            int no = 1;

            Console.WriteLine("Data customer");
            foreach (Customer  pdk in daftarCustomer)

                Console.WriteLine("{0},{1},{2},{3}", no, pdk.Kode, pdk.Nama, pdk.Piutang);

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
