using System;
namespace cacke.Models
{
    public class user
    {

        public int id { get; set; }

        public string username { get; set; }

        public string userpass { get; set; }

        public  string firstname { get; set; }

        public string lastname { get; set; }

        public string email { get; set; }

        public Nullable<int> profit { get; set; }

        public string registed { get; set; }

        public Nullable<int> statuss { get; set; }

        public Nullable<int> saless2 { get; set; }

        public Nullable<int> paysbay2 { get; set; }

        public Nullable<System.DateTime> logins { get; set; }

        public Nullable<DateTime> logout { get; set; }

        public statuss statuss1 { get; set; }

    }
}
