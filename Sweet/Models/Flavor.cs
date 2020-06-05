using System.Collections.Generic;

namespace Sweet.Models
{
  public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string Tastes { get; set; }
        public virtual ICollection<FlavorTreat> Treats { get; set; }
    }
}





