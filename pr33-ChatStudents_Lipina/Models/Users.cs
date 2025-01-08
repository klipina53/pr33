﻿namespace pr33_ChatStudents_Lipina.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public byte[] Photo { get; set; }
        public Users(string Lastname, string Firstname, string Surname, byte[] Photo)
        {
            this.Lastname = Lastname;
            this.Firstname = Firstname;
            this.Surname = Surname;
            this.Photo = Photo;
        }
        public string ToFIO()
        {
            return $"{Lastname} {Firstname} {Surname}";
        }
    }
}
