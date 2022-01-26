using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoOperations operations = new ToDoOperations();

            Card card1 = new Card("todo app", "c sharp", 2, 1, 1);
            Card card2 = new Card("Angular App", "angular", 1, 2, 2);
            Card card3 = new Card("HackerRank Challenge", "c sharp", 1, 2);
            Card card4 = new Card("Portal Web App",".Net",2,1,1);
            
            List<Card> cardList = new List<Card>();

            cardList.Add(card1);
            cardList.Add(card2);
            cardList.Add(card3);
            cardList.Add(card4);

            
            while(true)
            {
                int choice;
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");// getBoard and printLine (from getBoard) methods call
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                choice = Int32.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        operations.ViewTodoList(cardList);
                        break;
                    case 2:
                        operations.AddTodo(cardList);
                        break;
                    case 3:
                        operations.DeleteTodo(cardList);
                        break;
                    case 4:
                        operations.UpdateStatus(cardList);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim yaptınız!");
                        break;
                }
            }
            
        }
    }
}
