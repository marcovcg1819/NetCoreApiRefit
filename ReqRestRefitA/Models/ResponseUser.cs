using System;
namespace ReqrestRefitA.Models
{

    
   
        
    public class ResponseUser
        {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public IList<Data> data { get; set; }
        public Support support { get; set; }

    }
   
}

