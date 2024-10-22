using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //string password;
            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}


            //int number;

            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}



            //int exam1, exam2, exam3, average;
            //string result = "Hata !";

            //Console.Write("Sınav 1: ");
            //exam1 =int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması: " + average);


            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average >50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average >70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);


            //string city;

            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}


            //string username;

            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}


            #endregion


            #region Mod İşlemleri


            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //int number1, number2, number3, result;

            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //number1 =int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.Sayıyı Giriniz: ");
            //number3 = int.Parse(Console.ReadLine());

            //result = number1 % number2 % number3;

            //Console.WriteLine("Bütün Sayıların Birbirine Bölümünden Kalan: " + result);


            //int number;

            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number %2==0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}


            #endregion


            #region Char Değişkenleri

            //char team;

            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team =='g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team =='f'| team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion


            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();

            //string MenuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //MenuItem = Console.ReadLine();

            //if (MenuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Ana Yemekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fırında Somon");
            //    Console.WriteLine("4-Fasulye Pilav");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("---------Ana Yemekler---------");
            //}
            //if (MenuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Çorbalar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine();
            //    Console.WriteLine("---------Çorbalar---------");
            //}
            //if (MenuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Pizzalar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine();
            //    Console.WriteLine("---------Pizzalar---------");
            //}
            //if (MenuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------İçecekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine();
            //    Console.WriteLine("---------İçecekler---------");
            //}
            //if (MenuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Tatlılar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Triliçe");
            //    Console.WriteLine();
            //    Console.WriteLine("---------Tatlılar---------");
            //}

            #endregion


            #region Switch Case

            //int monthNumber;
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan");break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Veri Girişi!"); break;
            //}

            #endregion


            #region Switch Case Hesap Makinesi


            //int number1, number2, result;
            //char symbol;

            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //number1 =int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-': result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;


            //}


            #endregion

            
            Console.Read();

        }
    }
}
