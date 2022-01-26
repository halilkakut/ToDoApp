using System;

namespace ToDoApp
{
    public class Card
    {
        private string _title;
        private string _content;
        private int _memberID;
        private int _size;

        private int _status;
        
        public Card(string title, string content, int size, int member_id=1, int status=0) 
        {
            this._title = title;
            this._content = content;
            this._memberID = member_id;
            this._size = size;
            this._status = status;
        }

        public string GetTitle(){ return this._title;}
        public string GetContent(){ return this._content;} 
        public string GetMember(){ 
            if(this._memberID == 1) {return "Halil Kakut";}
            else if(this._memberID == 2) {return "Ahmet Yılmaz";}
            else if(this._memberID == 3) {return "Ali Can";}
            else if(this._memberID == 4) {return "Canan Mert";}  
            else {
                return "Atanan yok.";
            }         
        }
        public string GetSize(){
            string size = Enum.GetName(typeof(SizeEnum), this._size);
            return size;
        }
        public int GetStatus(){ return this._status;}

        public void SetTitle(string value) {
            this._title = value;
        }
        public void SetContent(string value) {
            this._content = value;
        }public void SetMember(int value) {
            this._memberID = value;
        }public void SetSize(int value) {
            this._size = value;
        }public void SetStatus(int value) {
            // 0: TODO  1: IN PROGRESS 2: DONE 
            if (value == 0 || value == 1 || value == 2) { 
                this._status = value;
            }
            else {  
                throw new Exception("Todo durumu 0(TODO), 1(IN PROGRESS) ya da 2(DONE) olabilir.");
            }
            
        }
        public void TodoDetails() {
            Console.WriteLine("Başlık      :" + GetTitle());
            Console.WriteLine("İçerik      :" + GetContent());
            Console.WriteLine("Atanan Kişi :" + GetMember() );
            Console.WriteLine("Büyüklük    :" + GetSize() );  
        }
    }
}