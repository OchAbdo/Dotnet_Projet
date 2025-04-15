namespace Projet.Models
{
    public class Project
    {
        public long id { set; get; }
        public string titre { set; get; }
        public string description { set; get; }
        public DateTime datedebut { set; get; }
        public DateTime datefin { set; get; }
        public string status { set; get; }
    }
}
