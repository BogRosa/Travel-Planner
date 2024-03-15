using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        public int ActivityId { get; private set; }
        private int travelPlanId;
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
