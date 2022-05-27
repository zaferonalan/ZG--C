using System;

namespace ToDoUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
             //Takım ataması
            TeamUsersList.TeamList.Add(new TeamUserModel("Ahmet",1));
            TeamUsersList.TeamList.Add(new TeamUserModel("Aylin",2));
            TeamUsersList.TeamList.Add(new TeamUserModel("Selin",3));
            TeamUsersList.TeamList.Add(new TeamUserModel("Mehmet",4));
            TeamUsersList.TeamList.Add(new TeamUserModel("Selami",5));

            //Default Göre Ataması
            TodoLine.TodoLineList.Add(new CardModel("c#", "c# dersi", 1, CardSizeEnumModel.S.ToString()));
            TodoLine.TodoLineList.Add(new CardModel("sql", "sql dersi", 2, CardSizeEnumModel.M.ToString()));

            //Linelar Boarda Atanıyor, yani kart oluşturuluyor
            BoarModel.BoardModelDict.Add("TODO Line", TodoLine.TodoLineList);
            BoarModel.BoardModelDict.Add("IN PROGRESS Line", InProgress.InProgressList);
            BoarModel.BoardModelDict.Add("DONE Line", DoneLine.DoneLineList);

            OperationController.StartPrint();
            int select = int.Parse(Console.ReadLine());
            int control = OperationController.Control(select);
            while (control == 0)
            {
                OperationController.EnumToSize(select);
                OperationController.PrintBoard();
                OperationController.StartPrint();
                select = int.Parse(Console.ReadLine());
                control = OperationController.Control(select);
            }
            Console.WriteLine("1-4 Aralığı Dışında bir Sayı Girildi, Çıkılıyor...");
            Console.WriteLine("Programı Sonlandırmak için Bir Tuşa Basınız...");
            //OperationController.PrintBoard();
            Console.ReadKey();
        }
    }
}
