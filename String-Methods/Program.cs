using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="Ders CSharp,Hoşgeldiniz";
            string degisken2="Charp";

            // Length--> Metinsel  ifadelerin uzunluğunu getirir.
            Console.WriteLine(degisken.Length);

            // ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat --> Parametre olarak verilen nesneleri string türünde birbirine peşi sıra ekler ve geriye string türünde değer döndürür.
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            // Compare , CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); // 0 , 1, -1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            // Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            // IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            // Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));

            // PadLeft , PadRight;
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            // Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
           
           // Replace
           Console.WriteLine(degisken.Replace("CSharp","C#"));

           // Split
           Console.WriteLine(degisken.Split(' ')[1]);

           // Substring
           Console.WriteLine(degisken.Substring(4));
           Console.WriteLine(degisken.Substring(4,6));


        }
    }
}
