using System;

namespace ToDoUygulaması
{
    public static class OperationController
    {
        public static void UsersPrint()
        {

        }

        public static string PeopleIdName(int id)
        {
            foreach (var item in TeamUsersList.TeamList)
            {
                if (item.İd == id)
                {
                    return item.Username;
                }
            }
            return null;
        }

        public static int Control(int number)
        {
           if(number >=1 && number <= 4)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public static void StartPrint()
        {
            System.Console.WriteLine("*****************************************");
            System.Console.WriteLine("(1) Board Listelemek ");
            System.Console.WriteLine("(2) Board'a Kart Eklemek ");
            System.Console.WriteLine("(3) Board'dan Kart Silmek");
            System.Console.WriteLine("(4) Kart Taşımak ");
            System.Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seçiniz : ");
        }

       public static string EnumToSize(int number)
       {
           if (number == 1)
           {
               return CardSizeEnumModel.XS.ToString();
           }
           else if (number == 2)
           {
               return CardSizeEnumModel.S.ToString();
           }
           else if (number == 3)
           {
               return CardSizeEnumModel.M.ToString();
           }
           else if (number == 4)
           {
               return CardSizeEnumModel.L.ToString();
           }
           else
           {
               return CardSizeEnumModel.XL.ToString();
           }
       }

       public static void PrintBoard()
       {
           foreach (var item in BoarModel.BoardModelDict)
           {
               System.Console.WriteLine(item.Key);
               System.Console.WriteLine("*******************");
               int Sayac = item.Value.Count;
               if (Sayac == 0)
               {
                   System.Console.WriteLine("Boş");
               }
               foreach (var item2 in item.Value)
               {
                   Sayac--;
                   System.Console.WriteLine("Başlık : {0} ",item2.Title);
                   System.Console.WriteLine("İçerik : {0} ",item2.Content);
                   System.Console.WriteLine("Atanan Kişi Numarası : {0} , Atanan Kişi Adı : {1} ",item2.PeopleId , PeopleIdName(item2.PeopleId));
                   System.Console.WriteLine("Büyüklük : {0} ", item2.Size);
               }
               if (Sayac >= 1)
               {
                  Console.WriteLine("-"); 
               }
               System.Console.WriteLine("");
               System.Console.WriteLine("");
           }
       }

       public static void AddCard()
       {
           System.Console.WriteLine("Başlık Giriniz : ");
           string Title = Console.ReadLine();
           System.Console.WriteLine("İçerik Giriniz : ");
           string Content = Console.ReadLine();
           System.Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
           Console.WriteLine("Eğer 1-5 Aralığı Dışında değer girerseniz default olarak XL atanacaktır.");
           int SizeNumber = int.Parse(Console.ReadLine());
           string Size = EnumToSize(SizeNumber);
           UsersPrint();
           System.Console.WriteLine("Eklemek İstediğiniz Kişi Listede Mevcutmu ? (Y/N) ");
           string UserControl = Console.ReadLine();

           if (UserControl.ToLower() == "y")
           {
               System.Console.WriteLine("Görev Eklemek istediğiniz Kişinin İd Numarasını Giriniz : ");
               int IdNum = int.Parse(Console.ReadLine());
               int Sayac = 0;

               foreach (var item in TeamUsersList.TeamList)
               {
                   if (item.İd == IdNum)
                   {
                       System.Console.WriteLine("Kişi Mevcut Ekleme Başarılı...");
                       TodoLine.TodoLineList.Add(new CardModel(Title,Content,IdNum,Size));
                       Sayac++;
                   }
               }

               if (Sayac == 0)
               {
                   System.Console.WriteLine("Kişi bulunamadı, Çıkılıyor.");
               }

               else if (UserControl.ToLower() == "n")
               {
                   Console.WriteLine("Kişi Eklemek İstermisiniz (Y/N) : ");
                   string UserAddControl = Console.ReadLine();

                   if (UserAddControl.ToLower() == "y")
                   {
                       UsersPrint();
                       Console.Write("Kişinin Adını Giriniz : ");
                       string UserAddUserName = Console.ReadLine();
                       int UserAddId = ((TeamUsersList.TeamList.Count) + 1);
                       TeamUsersList.TeamList.Add(new TeamUserModel(UserAddUserName,UserAddId));
                       Console.WriteLine("Ekleme Başarılı...");
                       TodoLine.TodoLineList.Add(new CardModel(Title,Content,UserAddId,Size));
                   }
                   else
                   {
                       Console.WriteLine("Çıkılıyor...");
                   }
               }
            }
            else
            {
                Console.WriteLine("Hatalı Karakter Girdiniz Çıkılıyor...");
            }
       }

       public static void DeletCard()
       {
           int control = 0;
           int select = 0;
           
           while (control == 0)
           {
               YenidenDene:
               Console.Write("Silmek İstediğiniz Kartın Başlığını Giriniz : ");
               string title = Console.ReadLine();
               foreach (var item in BoarModel.BoardModelDict)
               {
                   foreach (var item2 in item.Value)
                   {
                       if (item2.Title == title)
                       {
                           Console.WriteLine("Kartınız bulundu siliniyor...");
                           item.Value.Remove(item2);
                           control++;
                           break;
                       }
                   }
               }

               if (control == 0)
               {
                   Console.WriteLine("Aradığınız kritere uygun kart bulunamadı. Lütfen Seçim Yapınız.");
                   System.Console.WriteLine("Silme İşlemini sonlandırmak için : (1)");
                   System.Console.WriteLine("Yeniden Denemek İçin : (2)");
                   System.Console.Write("Seçiminizi Giriniz : ");
                   select = int.Parse(Console.ReadLine());
                   
                   if (select == 1)
                   {
                       control++;
                       break;
                   }
                   else if (select == 2)
                   {
                       goto YenidenDene;
                   }
               }
           }
       }

       public static void MoveCard()
       {
           int select = 0;
           int Control = 0;
           int LineNumber;

           while (Control == 0)
           {

                System.Console.WriteLine("Öncelikle Taşımak İstediğiniz Kartı Seçmeniz Gerekiyor.");
                System.Console.Write("Lütfen Kart Başlığını Yazınız : ");
                string title = Console.ReadLine();

                foreach (var item in BoarModel.BoardModelDict)
                {
                    if (Control == 0)
                    {
                        foreach (var item2 in item.Value)
                        {
                            if (item2.Title == title)
                            {
                                System.Console.WriteLine("Bulunan Kart Bilgileri:");
                                System.Console.WriteLine("*******************************");
                                System.Console.WriteLine("Başlık: {0}",item2.Title);
                                System.Console.WriteLine("İçerik: {0}",item2.Content);
                                System.Console.WriteLine("Atanan Kişi: {0}",item2.PeopleId);
                                System.Console.WriteLine("Büyüklük: {0}",item2.Size);
                                System.Console.WriteLine("Line: {0}",item.Key);
                                System.Console.WriteLine("Lütfen Taşımak İstediğiniz Line Numarasını Giriniz :");
                                System.Console.WriteLine("(1) TODO");
                                System.Console.WriteLine("(2) IN PROGRESS");
                                System.Console.WriteLine("(3) DONE");
                                LineNumber = int.Parse(Console.ReadLine());

                                if (LineNumber == 1)
                                {
                                    TodoLine.TodoLineList.Add(new CardModel(item2.Title,item2.Content,item2.PeopleId,item2.Size));
                                    item.Value.Remove(item2);
                                    Control++;
                                    break;
                                }
                                else if(LineNumber == 2)
                                {
                                    InProgress.InProgressList.Add(new CardModel(item2.Title,item2.Content,item2.PeopleId,item2.Size));
                                    Control++;
                                    item.Value.Remove(item2);
                                    break;

                                }
                                else if (LineNumber == 3)
                                {
                                    DoneLine.DoneLineList.Add(new CardModel(item2.Title,item2.Content,item2.PeopleId,item2.Size));
                                    Control++;
                                    item.Value.Remove(item2);
                                    break;
                                }
                                else
                                {
                                    System.Console.WriteLine("Hatalı Giriş Çıkılıyor...");
                                }
                            }
                        }

                    }
                }
                if (Control == 0)
                {
                    System.Console.WriteLine("Aradığınız kriterlere uygun kart bulunamadı lütfen seçim yapınız.");
                    System.Console.WriteLine("Silmeyi sonlandırmak için: (1)");
                    System.Console.WriteLine("Yeniden Denemek için : (2)");
                    select = int.Parse(Console.ReadLine());
                    if (select == 1)
                    {
                        Control++;
                    }
                }
           } 
       }
    }
}