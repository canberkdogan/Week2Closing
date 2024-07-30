
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
{
        /*// FIRST EXAMPLE
        
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın");

        Console.WriteLine("---------------------------------------------------------");

        // SECOND EXAMPLE

        int number  = 0;
        string text = "Ha bu akan dereler";
        {
            Console.WriteLine(text);
            Console.WriteLine(number);
        }

        Console.WriteLine("----------------------------------------------------------");
        

        //THIRD EXAMPLE
        
        Random rnd = new Random();

        int randomNum = rnd.Next(0, 100);
        
            Console.WriteLine("rastgele sayınız: " + randomNum);
        
       

        //FOURTH EXAMPLE
        
        Random rnd = new Random();

        int randomNum = rnd.Next(0, 100);

        int bolumdenKalan = randomNum % 3;

        Console.WriteLine("YOUR RANDOM NUMBER: " + randomNum);
        Console.WriteLine("remainder after dividing a number by 3: " + bolumdenKalan);

        

        // FIFTH EXAMPLE

        Console.WriteLine("Yaşınızı giriniz");
        
        int age = Convert.ToInt32(Console.ReadLine());
        
        
            if(age < 18)
            {
             Console.WriteLine("-");
            }
            else 
            {
            Console.WriteLine("+");
            }
             
         

        // SIXTH EXAMPLE 

        string message = "Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.";

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(message);
        }

       

       

        // SEVENTH EXAMPLE  BURAYA TEKRAR BAKILACAK 

        Console.WriteLine("Gülse Birsel");
        string text1 = Console.ReadLine();
        Console.WriteLine("Demet Evgar");
        string text2 = Console.ReadLine();


        Console.WriteLine("Değiştirmeden önce: Gülse Birsel " + text1 + ", Demet Evgar  " + text2);

        // Metinlerin yerlerini değiştir  
        string temp = text1;
        text1 = text2;
        text2 = temp;

        // Metinleri değiştirdikten sonra ekrana yazdır
        Console.WriteLine("Değiştirdikten sonra: Demet Evgar  " + text2 + ", Gülse Birsel  " + text1);

        


        //EIGHTH EXAMPLE

       static void benDegerDondurmem()
        {
            Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");

        }
        benDegerDondurmem();

        

        // NINE EXAMPLE

       

        static int Toplam (int num1, int num2)
        {
            return num1 + num2;
        }

        // static void Main değerini en başta yazdığımız için şimdi yazma gereği duymuyoruz.
        {
           int sonuc = Toplam(5, 10);

            Console.WriteLine("sonuc" + sonuc);
        }
        

        // TENTH EXAMPLE

        bool kullaniciGirisi()
        {
            return true;    // KULLANICI GİRİŞİ KONTROLÜ YAPILAN YER 
        }

        bool deger = kullaniciGirisi();

        if (deger)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        

        // ELEVENTH EXAMPLE

       int EnYasli(int yas1, int yas2, int yas3)
        {
            int max1 = Math.Max(yas1, yas2);
          
            return Math.Max(max1, yas3);
        }
        Console.WriteLine("first person age");
        int yas1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("first person age");
        int yas2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("first person age");
        int yas3 = Convert.ToInt32(Console.ReadLine());

        int enBuyuk = EnYasli(yas1, yas2, yas3);
        Console.WriteLine("en büyük" + enBuyuk);

        // TWELWETH EXAMPLE

         
        
        
       
    


        // THİRTEENTH EXAMPLE

        /*Console.WriteLine("Birinci ismi giriniz:");
        string name1 = Console.ReadLine();

        Console.WriteLine("İkinci ismi giriniz:");
        string name2= Console.ReadLine();

        Console.WriteLine("---------İlk Durum-------");
        Console.WriteLine("Birinci isim" + name1);
        Console.WriteLine("İkinci isim" + name2);


        DegerDegistir(ref name1, ref name2);


        Console.WriteLine("---------Son Durum-------");
        Console.WriteLine("Birinci isim:" + name1);
        Console.WriteLine("İkinci isim:" + name2);


        void DegerDegistir(ref string n1,ref string n2)
        {
            string gecici = n1;
            n1 = n2;
            n2 = gecici;


        }



        //14TH EXAMPLE

        static void Main()
        {
            Console.WriteLine("Sayı giriniz");
            int sayi = 0; Convert.ToInt32(Console.ReadLine());

            // Sayının çift olup olmadığını kontrol eden metodu çağır
            bool ciftMi = CiftMi(sayi);

            // Sonucu ekrana yazdır
            Console.WriteLine(ciftMi);
        }
            static bool CiftMi(int sayi)
            {
                if (sayi % 2 == 0)

                    return true;

            else return false;


        }*

        //15TH EXAMPLE

        Console.WriteLine("Hızınızı Giriniz");
        int speed = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Gittiğiniz Zaman Giriniz");
        int time = Convert.ToInt32(Console.ReadLine());

        int gidilenYol = GidilenYol(speed, time);
        Console.WriteLine("Gittiğiniz Yol: " + gidilenYol + " km");

        int GidilenYol(int h1, int t1)
        {
            return h1 * t1; 
        } 


        //16TH EXAMPLE

        Console.WriteLine("Dairenin yarıçapını giriniz: ");
        int yariCap = Convert.ToInt32(Console.ReadLine());

        double alanHesabi = Alan(yariCap);
        Console.WriteLine("Dairenizin alanı:" + alanHesabi);

        double Alan(int x) 
            {
            double pi = Math.PI;
            return Math.Pow(x, 2) * pi;

        }

        //17TH EXAMPLE

        string cumle = "Zaman bir GeRi SayIm";

        string buyukHarf = cumle.ToUpper();
        string kucukHarf = cumle.ToLower();

        Console.WriteLine("Büyük Harf:" + buyukHarf);
        Console.WriteLine("Küçük Harf:" + kucukHarf);
        */
        /*
        //18TH EXAMPLE

        string cumle = "    Selamlar   ";

        cumle = cumle.Trim();

        Console.WriteLine("Düzenlenmiş Metin:" + cumle);

       */
    }


}



