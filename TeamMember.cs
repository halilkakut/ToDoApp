using System;

namespace ToDoApp
{
    public class TeamMember
    {
        public int Id;
        public string FullName;

        public TeamMember(int id,string name, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
        }
    }
}