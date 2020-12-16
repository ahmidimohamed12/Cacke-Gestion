using System;
namespace cacke.Models
{
    public class works
    {
        public works()
        {
        }


        public int id { get; set; }

        public Nullable<DateTime> stardate { get; set; }

        public string company { get; set; }

        public string mediator { get; set; }

        public string callcenter { get; set; }

        public string customer { get; set; }

        public Nullable<double> sales { get; set; }

        public Nullable<int> profit { get; set; }

        public string material { get; set; }

        public string adress { get; set; }

        public string statuss { get; set; }

        public string paidby { get; set; }

        public string calculated { get; set; }

        public string phone { get; set; }

        public string moreinfo { get; set; }

        public Nullable<double> sales2 { get; set; }

        public string paydby2 { get; set; }

        public  string lastupdate { get; set; }

        public string latitude { get; set; }

        public string longtitud { get; set; }

        public string accepted { get; set; }

        public Nullable<int> monteur { get; set; }

        public Nullable<int> website { get; set; }

        public Nullable<int> gbits { get; set; }


        public virtual monteur monteur1 { get; set; }

        public  virtual website website1 { get; set; }
    }
}
