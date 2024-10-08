using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoClosing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Aşağıdaki çıktıyı yazan bir program.
            //Merhaba
            //Nasılsın ?
            //İyiyim
            //Sen nasılsın ?
            //2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.Bunların değerlerini atayıp , ekrana yazdırınız.
            //3 - Rastgele bir sayı üretip , ekrana yazdırınız.
            //4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            //5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
            //6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
            //7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz
            //8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            //9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
            //10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            //11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
            //12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
            //13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
            //14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini(true / false) dönen bir metot.
            //15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
            //16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
            //17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.
            //18 - "    Selamlar   " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

            #region 1->
            //Console.WriteLine("Merhaba");
            //Console.WriteLine("Nasılsın ?");
            //Console.WriteLine("İyiyim");
            //Console.WriteLine("Sen nasılsın ? ");
            #endregion
            #region 2->
            //int age = 26;
            //string isim = "yıldız";
            //Console.WriteLine($"isim :{isim}  yaş :{age}");
            #endregion
            #region 3->
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next());
            #endregion
            #region 4->
            //Random rnd = new Random();
            //int x = rnd.Next();
            //Console.WriteLine(x/3);
            #endregion
            #region 5->
            //Console.Write("Lütfen yaşınızı giriniz :");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age > 18)
            //{
            //    Console.WriteLine("+");
            //}
            //else
            //{
            //    Console.WriteLine("-");
            //}
            #endregion
            #region 6->
            //int count = 10;
            //for (int i = 0; i<count; i++)
            //{
            //    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            //}
            #endregion
            #region 7->
            //Console.Write("Bir metinsel değer giriniz :");
            //string valueOne = Console.ReadLine();
            //Console.Write("\nBir metinsel değer giriniz :");
            //string valueTwo= Console.ReadLine();
            //Console.WriteLine($"\nİlk girilen metin : {valueOne}  İkinci girilen metin : {valueTwo}");
            //string temp = valueOne;
            //valueOne = valueTwo;
            //valueTwo = temp;
            //Console.WriteLine("\nYerleri değiştikden sonraki halleri");
            //Console.Write($"\nİlk girilen metin : {valueOne}  İkinci girilen metin : {valueTwo}");
            #endregion
            #region 8->
            //BenBenDegerDondurmem();
            #endregion
            #region 9->
            //Console.WriteLine(Sum(3,6));
            #endregion
            #region 10->
            //Console.Write("Lütfen 'true' veya 'false' değeri giriniz: ");
            //bool kullaniciGirdisi = Convert.ToBoolean(Console.ReadLine());
            //string sonuc = TrueFalseMesaj(kullaniciGirdisi);
            //Console.WriteLine("Sonuç: " + sonuc);
            #endregion
            #region 11->
            //Console.Write("Birinci kişinin yaşı: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci kişinin yaşı: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Üçüncü kişinin yaşı: ");
            //int z = Convert.ToInt32(Console.ReadLine());
            //int oldest = Oldest(x, y, z);
            //Console.WriteLine($"En yaşlı kişinin yaşı : {oldest}");
            #endregion
            #region 12->
            //int enBuyukSayi = EndlessBigger();
            //Console.WriteLine("Geri dönen en büyük sayı: " + enBuyukSayi);
            #endregion
            #region 13->
            //Console.Write("Lütfen Sırası ile görmek istediğiniz ilk ismi giriniz :");
            //string name1 = Console.ReadLine();
            //Console.Write("Lütfen Sırası ile görmek istediğiniz ikinci ismi giriniz :");
            //string name2 = Console.ReadLine();
            //Converter(ref name1 ,ref name2);
            //Console.WriteLine($"Sırası ile isimler : {name2} ,{name1}");
            #endregion
            #region 14->
            //Console.WriteLine("Bir sayı iyi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //bool check = TrueFalse(sayi);
            //if (check)
            //{
            //    Console.WriteLine("Sayınız çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayınız tektir");

            #endregion
            #region 15->
            //Console.Write("Lütfen hızı giriniz (km/saat):");
            //double v = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen zamanı giriniz (saat):");
            //double t = Convert.ToInt32(Console.ReadLine());
            //double answer = Calculator(t, v);
            //Console.WriteLine($"\nGidilen yol {answer}km");
            #endregion
            #region 16->
            //Console.Write("Dairenin yarıçapını giriniz: ");
            //double yaricap = Convert.ToDouble(Console.ReadLine());
            //double alan = FlatArea(yaricap);
            //Console.WriteLine($"Dairenin alanı: {alan}");
            #endregion
            #region 17->
            //string s = "Zaman bir GeRi SayIm";
            //Console.WriteLine(s);
            //string y =s.ToLower();
            //Console.WriteLine(y);
            //string x =s.ToUpper();
            //Console.WriteLine(x);
            #endregion
            #region 18->
            //string x = "- Selamlar -";
            //Console.WriteLine(x);
            //string y = string.Join("",x.Split(' '));
            //Console.WriteLine(y);
            #endregion



            Console.ReadLine();
        }
        static double FlatArea(double yaricap)
        {
            return Math.PI * Math.Pow(yaricap, 2);
        }
        static bool TrueFalse(int sayi)
        {
            return sayi % 2 == 0;
        }
        static double Calculator(double x, double y)
        {
            return x * y;
        }
        static void Converter(ref string id1, ref string id2)
        {
            string temp = id1;
            id1 = id2;
            id2 = temp;
        }
        static int EndlessBigger()
        {
            int enBuyuk = 0;
            bool devam = true;
            while (devam)
            {
                Console.Write("Lütfen bir sayı giriniz (döngüden çıkmak için 'çıkış' yazın) : ");
                string sayi = Console.ReadLine();
                if (sayi.ToLower() == "çıkış")
                {
                    devam = false;
                }
                if (int.TryParse(sayi, out int buyuk))
                {
                    if (buyuk > enBuyuk)
                    {
                        enBuyuk = buyuk;
                    }
                    Console.WriteLine("En büyük sayı: " + enBuyuk);
                }
                else
                {
                    Console.WriteLine("Geçersiz karakter girdiniz.");
                }



            }
            return enBuyuk;
        }
        static int Oldest(int x, int y, int z)
        {
            int sonuç = x;
            if (y > sonuç)
                sonuç = y;
            if (z > sonuç)
                sonuç = z;
            return sonuç;
        }
        static string TrueFalseMesaj(bool deger)
        {
            if (deger)
            {
                return "Evet";
            }
            else
            {
                return "Hayır";
            }
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void BenBenDegerDondurmem()
        {
            Console.WriteLine("\"Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma\"");
        }
    }
}