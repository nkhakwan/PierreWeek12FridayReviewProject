using System.Collections.Generic;

namespace Sweet.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string Products { get; set; }
        public virtual ApplicationUser User { get; set; }

        public ICollection<FlavorTreat> Flavors { get;}
    }
}