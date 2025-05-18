using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CSharp_01_TemelKonular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişkenler
            // Variables
            //string name, surname;
            //    int number, examNote1, examNote2;

            //    name = "Ali";
            //    surname = "Tunçer";
            //    number = 1234567890;
            //    examNote1 = 80;
            //    examNote2 = 90;

            //    int finalNote = (examNote1 + examNote2) / 2;

            //    // Yazdırma
            //    Console.WriteLine("***** Öğrenciler *****");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("İsim Soyisim: " + name + " " + surname);
            //    Console.WriteLine("Numara: " + number);
            //    Console.WriteLine("1. Sınav Notu: " + examNote1);
            //    Console.WriteLine("2. Sınav Notu: " + examNote2);
            //    Console.WriteLine("Final Notu: " + finalNote);
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------------");
            #endregion

            #region Double

            //double strawberryPrice, bananaPrice, applePrice, totalPrice;

            //strawberryPrice = 5.99;
            //bananaPrice = 3.4;
            //applePrice = 2.5;

            //totalPrice = strawberryPrice * 2 + bananaPrice * 3 + applePrice * 4;

            //Console.WriteLine("***** Meyve Fiyatları *****");
            //Console.WriteLine();
            //Console.WriteLine("Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("Muz Birim Fiyatı: " + bananaPrice + " TL");
            //Console.WriteLine("Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine();

            //Console.WriteLine("Çilek 2 kg, Muz 3 kg, Elma 4 kg alındığında toplam fiyat: " + totalPrice + " TL");

            #endregion

            #region Char Değişkeni

            //char karakter;

            //Console.WriteLine(karakter = 'A');

            #endregion

            #region Veri Girişleri

            #region String

            //string passingerName, passingerSurname, passingerAge, passingerDistrict, pasisngerCity,
            //    passingerIdentityNumber;

            //Console.WriteLine("***** CSharp Hava Yolu *****");
            //Console.WriteLine();

            //// Okuma

            //Console.WriteLine("Lütfen yolcu bilgilerini giriniz.");
            //Console.WriteLine();
            //Console.Write("TC Kimlik No: ");
            //passingerIdentityNumber = Console.ReadLine();
            //Console.Write("Adınız: ");
            //passingerName = Console.ReadLine();
            //Console.Write("Soyadınız: ");
            //passingerSurname = Console.ReadLine();
            //Console.Write("Yaşınız: ");
            //passingerAge = Console.ReadLine();
            //Console.Write("İlçeniz: ");
            //passingerDistrict =  Console.ReadLine();
            //Console.Write("Şehir: ");
            //pasisngerCity = Console.ReadLine();

            //// Yazdırma

            //Console.WriteLine();
            //Console.WriteLine("***** Yolcu Bilgileri *****");
            //Console.WriteLine();
            //Console.WriteLine("TC Kimlik No: " + passingerIdentityNumber);
            //Console.WriteLine("Ad: " + passingerName);
            //Console.WriteLine("Soyad: " + passingerSurname);
            //Console.WriteLine("Yaş: " + passingerAge);
            //Console.WriteLine("İlçe: " + passingerDistrict);
            //Console.WriteLine("Şehir: " + pasisngerCity);
            //Console.WriteLine();
            //Console.WriteLine("***** CSharp Hava Yolu *****");


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int tvPrice = 47000, computerPrice = 35000, phonePrice = 90000, totalPrice;
            //int tvCount, computerCount, phoneCount;

            //Console.WriteLine("***** CSharp Elektronik *****");
            //Console.WriteLine();
            //Console.WriteLine("Lütfen almak istediğiniz ürünlerin adetlerini giriniz.");
            //Console.Write("Televizyon Adedi: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.Write("Bilgisayar Adedi: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Telefon Adedi: ");
            //phoneCount = int.Parse(Console.ReadLine());

            //totalPrice = (tvPrice * tvCount) + (computerPrice * computerCount) + (phonePrice * phoneCount);

            //Console.WriteLine();
            //Console.WriteLine("***** CSharp Elektronik *****");
            //Console.WriteLine();
            //Console.WriteLine("***** Alışveriş Özeti *****");
            //Console.WriteLine();
            //Console.WriteLine("Toplam Fatura: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            //double exam1, exam2, exam3, average;

            //Console.WriteLine("***** CSharp Not Hesaplama *****");
            //Console.WriteLine();
            //Console.WriteLine("Notlarınızı giriniz.");
            //Console.Write("1. Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("***** Not Bilgileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1. Sınav Notu: " + exam1);
            //Console.WriteLine("2. Sınav Notu: " + exam2);
            //Console.WriteLine("3. Sınav Notu: " + exam3);
            //Console.WriteLine("Ortalama Not: " + average);
            //Console.WriteLine();
            //Console.WriteLine("***** CSharp Not Hesaplama *****");
            //Console.WriteLine();

            #endregion

            #region Klavyeden Karakter Girişi

            //char gender;

            //Console.Write("Cinisyet Giriniz: ");
            ////Eğer tek karakterden fazlla grirlirse hata verir
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Girdiğiniz Cinsiyet: " + gender);



            #endregion

            #endregion

            #region Döngüler

            //int n;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int k = 1; k <= n - i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= 2*i - n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n; i >= 0; i--)
            //{
            //    for (int k = 1; k <= n - i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= 2*i - n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Dizi

            //string [] cities = new string[5];

            //cities[0] = "İstanbul";
            //cities[1] = "Ankara";
            //cities[2] = "İzmir";
            //cities[3] = "Bursa";
            //cities[4] = "Antalya";
            ////cities[5] = "Sakarya"; // Hata verir
            //Console.WriteLine(cities[0]);

            //string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };


            //int[] numbers = new int[5];

            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            ////numbers[5] = 6; // Hata verir
            //Console.WriteLine(numbers[0]); // Atanmamış bir dizinin elemanını yazdırırsa 0 yazar


            //string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };

            //foreach (string eleman in cities)
            //{
            //    Console.WriteLine(eleman);
            //}

            #endregion

            #region Son Uygulama (Öğrenci Not Sitemi)

            //Console.WriteLine("***** Öğrenci Not Sistemi *****");
            //Console.Write("Lütfen öğrenci sayısını giriniz: ");


            //string[] students = new string[int.Parse(Console.ReadLine())];
            //int examNote1 = 0, examNote2 = 0, examNote3 = 0;

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
            //    students[i] = Console.ReadLine();

            //    // Öğrenci Notlarını alma
                
            //    {
            //        Console.Write($"{students[i]} isimli öğrencinin 1. sınav notunu giriniz: ");
            //        examNote1 = int.Parse(Console.ReadLine());
            //        Console.Write($"{students[i]} isimli öğrencinin 2. sınav notunu giriniz: ");
            //        examNote2 = int.Parse(Console.ReadLine());
            //        Console.Write($"{students[i]} isimli öğrencinin 3. sınav notunu giriniz: ");
            //        examNote3 = int.Parse(Console.ReadLine());
            //    }

            //    // Öğrenci Notlarını Hesaplama
            //    int average = (examNote1 + examNote2 + examNote3) / 3;

            //    // Öğrenci Notlarını Yazdırma
            //    Console.WriteLine();
            //    Console.WriteLine("***** Öğrenci Not Bilgileri *****");
            //    Console.WriteLine();
            //    Console.WriteLine($"Öğrenci Adı: {students[i]}");
            //    Console.WriteLine($"1. Sınav Notu: {examNote1}");
            //    Console.WriteLine($"2. Sınav Notu: {examNote2}");
            //    Console.WriteLine($"3. Sınav Notu: {examNote3}");
            //    Console.WriteLine($"Ortalama Not: {average}");

            //    if (average >= 50)
            //    {
            //        Console.WriteLine("Öğrenci Geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Öğrenci Kaldı");
            //    }
            //}



            #endregion

            Console.ReadLine();
        }
    }
}