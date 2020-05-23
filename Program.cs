using System;

namespace SwitchCase_BagII__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Yang Anda Masukkan Salah, Coba Lagi");
            Console.Write("Masukkan Password  : ");

            String pass = Console.ReadLine();

            switch (pass)
            {
                case "Password":
                    Console.Clear();
                    Console.WriteLine("Selamat datang di ruang administrator ");
                    Console.WriteLine("======================================");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Anda tidak berhak masuk kedalam sistem ini");
                    break;
            }
            Console.Read();
        }
    }
}

