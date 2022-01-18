using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
             // 1-> Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet
            // pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar ekrana yazdırın.
            Console.WriteLine("******  Qestion1  ********");

            Console.Write("Pozitif bir sayı giriniz:");
            int sayi =int.Parse(Console.ReadLine());
            int [] SayiDizisi=new int [sayi];
            for (int i = 0; i < sayi; i++)
            {
                Console.Write("{0}. pozitif sayı:",i+1);
                SayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < SayiDizisi.Length; i++)
            {
                if(SayiDizisi[i]%2==0)
                {
                    Console.WriteLine("Çift sayı:"+SayiDizisi[i]);
                }
                else
                  Console.WriteLine(SayiDizisi[i]+" "+ "çift değildir.");
                 
            }

            // 2->  Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n,m). Sonrasında kullanıcıdan 
            // n adet pozitif sayı girmesini isteyin .Kullanıcının girmiş olduğu sayılardan m'e eşit ya da tam bölünenleri  yazdırın
            Console.WriteLine("******  Qestion2  ********");

            Console.Write("N pozitif tam sayısını giriniz:");
            int sayi1=int.Parse(Console.ReadLine());
            Console.Write("M pozitif tam sayısını giriniz:");
            int sayi2=int.Parse(Console.ReadLine());
            int[] dizi=new int[sayi1];
            for (int i = 0; i < sayi1; i++)
            {
                Console.Write("{0}. pozitif sayı:",i+1);
                dizi[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]%sayi2==0)
                {
                    Console.WriteLine("M sayısına tam bölünebilmektedir:"+dizi[i]);
                }
                else if (dizi[i]==sayi2)
                {
                    Console.WriteLine("M sayısına eşittir:"+dizi[i]);
                }
                else
                {
                    Console.WriteLine("M sayısına eşit değildir ve tam bölünememektedir:"+dizi[i]);
                }
            }

            // 3-> Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime 
            // girmesini isteyin.Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
             
            Console.WriteLine("******  Qestion3  ********");
            
            Console.Write("Pozitif bir sayı giriniz:");
            int sayi3 =int.Parse(Console.ReadLine());
            string [] KelimeDizisi=new string [sayi3];
            for (int i = 0; i < sayi3; i++)
            {
                Console.Write("{0}.kelime:",i+1);
                KelimeDizisi[i]=Console.ReadLine();
            }
            Array.Reverse(KelimeDizisi);
            foreach (var item in KelimeDizisi)
            {
                Console.WriteLine(item);
            }
             
            // 4-> Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki
            //  toplam kelime ve harf sayısını console'a yazdırın
            Console.WriteLine("******  Qestion4  ********");
            int harfSayisi=0;
            Console.Write("Bir cümle yazınız:");
            string cumle=Console.ReadLine();
            string[] kelime=cumle.Split(" ");
            Console.WriteLine("Verilen cümlede {0} kelime vadır",kelime.Length);
            for (int i = 0; i < kelime.Length; i++)
            {
                char[] harf=kelime[i].ToCharArray();
                harfSayisi+=harf.Length;
            }
            Console.WriteLine("Cümlede {0} harf vardır",harfSayisi);
            

           
            
















        }
    }
}
