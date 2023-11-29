namespace SL.Models
{
    public class Personajes
    {
        

            public int id { get; set; }
            public string name { get; set; }
            public string status { get; set; }
            public string species { get; set; }
            public string gender { get; set; }
            public string image { get; set; }

            public List<Personajes> results { get; set; }


        
    }
}
