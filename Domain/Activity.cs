using System;

namespace Domain
{
    public class Activity
    {
        
        public Guid Id{ get; set; }
        public string Title{ get; set; }
        public DateTime Date{ get; set; }

        public DateTime Time { get; set; }
        public string Description { get; set; }
        public string Topic { get; set; }
        public string Module { get; set; }
        public string Campus { get; set; }

        public int Atendenees { get; set; }
    }
}