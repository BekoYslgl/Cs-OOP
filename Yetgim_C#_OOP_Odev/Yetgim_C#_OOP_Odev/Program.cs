using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace Yetgim_C__OOP_Odev
{

    //Encapsulation kullanarak (C#'ın prob özelliği ile) kelimenin polindrom olup olmadığını öğrenip ,konsola yazdırmak.
    internal class Program
    {
        static void Main(string[] args)
        {
            //PalindromBulucu sınıfından bir nesne üretiyorum
            PalindromBulucu kelime1 = new PalindromBulucu();

            kelime1.Kelime = kelime1.KelimeAl();
            kelime1.PalindromMu(kelime1.Kelime);
            kelime1.Goster();
            Console.ReadLine();
        }




    }

    public class PalindromBulucu
    {
        string kelime;
        bool kontrol;



        //PROPERTIES

        //kelime değişkeni public olmadığı için ,bu class'ın içerisindeki kelime değişkenine main metodundan erişilemiyordu,bu yüzden prob uyguladım.
        public string Kelime 
        {
            get
            {
                return kelime;
            }
            set
            {
                kelime = value;
            }
        }

        
        


        //METODLAR 

        //KelimeAl diye bir metod oluşturdum çünkü kullanıcı bu metodu istediği zaman çağırabilir ve bu şekilde kullanıcı , her kelime oluşturmak istediğinde main metodunda işlem yapıp düzensiz bir şekilde yer kaplamak yerine böyle daha düzenli bir şekilde kullanıcıdan kelime alacağız.
        public string KelimeAl()
        {
            string _kelime;
            Console.WriteLine("Lütfen girmek istediğiniz kelimeyi yazınız");
            _kelime = Console.ReadLine();

            //Kelime değişkenin içindeki tüm harfleri ,küçük harf yapar 
            _kelime = _kelime.ToLower();


        //Kullanıcının girmiş olduğu kelimenin harf sayısı 3'ten küçük ise koşul içerisinde kontrol ederken else durumuna düşecek ve kullanıcı yeniden bir kelime girecek ve bu girmiş olduğu kelimeyi de tekrardan kontrol etmemiz gerektiği için buraya bir etiket koyarak ,else içerisinde bu etikete döneceğim.
        KontrolEt:

            //Kullanıcının girmiş olduğu kelimenin palindrom olup olmadığını bulmak istediğim için, kullanıcının girmiş olduğu kelimenin en az 4 harfli olmasını istiyorum ve buradaki koşulum da bunu kontrol edecek.
            if (_kelime != null && _kelime.Length >= 3 && !_kelime.Contains(" "))
            {
                Console.WriteLine($"Girmiş olduğunuz kelime: {_kelime}");
                return _kelime;
            }
            else
                Console.WriteLine("Lütfen girdiğiniz kelime en az 3 harfli olsun ve harfler arasında boşluk olmasın ,tekrar kelime girebilirsiniz :");
            _kelime = Console.ReadLine();
            goto KontrolEt;

        }

        //Buradaki metod,kullanıcının girmiş olduğu kelimeyi parametre alacak ve kelimenin palindrom olup olmadınığını kontrol ederek , kontrol değişkeninin bool değerini belirleyecek
        public void PalindromMu(string kel)
        {
            int j=kel.Length-1;
            int i = 0;

            while(i<j)
            {
                if (kel[j] != kel[i]) kontrol = false;
                else kontrol=true;
                i++;
                j--;
            }
        }
        
        //Buradaki metod, koşul olarak kontrol değişkenini kontrol edecek ve sonucunda ise konsola bir metin bastıracak (kelimenin palindrom olup olmadığına dair bir metin)
        public void Goster()
        {
            if (kontrol) Console.WriteLine("Kelime Palindromdur");

            else Console.WriteLine("Kelime Palindrom değildir");
        }

    }
}
   


