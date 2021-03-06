using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class Board
    {
        public List<Card> TODO = new List<Card>();
        public List<Card> IN_PROGRESS = new List<Card>();
        public List<Card> DONE = new List<Card>();

        public Board()
        {
            TODO.Add(new Card("Ödev Yap", "Patika'daki cs-101 modülünün son ödevini yap.", 1, 1));
            IN_PROGRESS.Add(new Card("DEPLOY", "Book Store uygulamasını yayınla.", 2, 3));
            DONE.Add(new Card("Build Al", "Book Store uygulamasının build'ini al.", 3, 4));
        }

    }
}