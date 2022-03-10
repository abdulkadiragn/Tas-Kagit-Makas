using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tas_Kagit_Makas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pcTKM = { "taş", "kağıt", "makas" };
            int pcToplam = 0;
            int kullaniciToplam = 0;
            while (true)
            {
                Console.WriteLine("taş kağıt makas giriniz : (çıkmak için q tuşuna basınız)");
                string girilen = Console.ReadLine();
                Random r = new Random(3);
                int randomSayi = r.Next(3);
                string randomSeçim = pcTKM[randomSayi];

                if (girilen.ToLower() == "taş" || girilen.ToLower() == "kağıt" || girilen.ToLower() == "makas")
                {
                    if (randomSeçim == "taş")
                    {
                        if (girilen.ToLower() == "taş")
                        {
                            Console.WriteLine($"berabere {randomSeçim} = {girilen}");
                        }
                        else if (girilen.ToLower() == "makas")
                        {
                            Console.WriteLine($"pc kazandı. {randomSeçim} > {girilen}");
                            pcToplam++;
                        }
                        else if (girilen.ToLower() == "kağıt")
                        {
                            Console.WriteLine($"tebrikler kazandın {girilen} > {randomSeçim}");
                            kullaniciToplam++;
                        }

                    }
                    if (randomSeçim == "kağıt")
                    {
                        if (girilen.ToLower() == "taş")
                        {
                            Console.WriteLine($"pc kazandı {randomSeçim} > {girilen}");
                            pcToplam++;
                        }
                        else if (girilen.ToLower() == "makas")
                        {
                            Console.WriteLine($" kazandın. {randomSeçim} < {girilen}");
                            kullaniciToplam++;
                        }
                        else if (girilen.ToLower() == "kağıt")
                        {
                            Console.WriteLine($"berabere {girilen} = {randomSeçim}");
                        }
                    }
                    if (randomSeçim == "makas")
                    {
                        if (girilen.ToLower() == "taş")
                        {
                            Console.WriteLine($"kazandın {randomSeçim} < {girilen}");
                            kullaniciToplam++;
                        }
                        else if (girilen.ToLower() == "makas")
                        {
                            Console.WriteLine($" berabere. {randomSeçim} = {girilen}");
                        }
                        else if (girilen.ToLower() == "kağıt")
                        {
                            Console.WriteLine($"pc kazandı {girilen} < {randomSeçim}");
                            pcToplam++;
                        }
                    }

                }
                else if (girilen == "q")
                {
                    Console.WriteLine("çıkış yapılıyor lütfen bekleyiniz...");
                    break;
                }
                else
                {
                    Console.WriteLine("düzgün bir deger giriniz.");
                    continue;
                }
            }
            if (pcToplam > kullaniciToplam)
            {
                Console.WriteLine($"bilgisayarın kazandığı oyun sayısı : {pcToplam} sizin kazandığınız oyun sayısı : {kullaniciToplam}");
                Console.WriteLine("sonuçlara göre kazanan Bilgisayar ");
            }
            else if (kullaniciToplam == pcToplam)
            {
                Console.WriteLine($"berabere kullanıcı : {pcToplam} pc : {kullaniciToplam}");
            }
            else
            {
                Console.WriteLine($"kullanıcı kazandı. Tebrikler. kullanıcı : {kullaniciToplam} pc : {pcToplam}");
            }
            Console.ReadLine();
        }
    }
}
