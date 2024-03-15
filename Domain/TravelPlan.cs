using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TravelPlan : PostableContent, ILikeable, ISearchable
    {
        public int TravelPlanId { get; private set; }
        private int userId;
        public string Title { get; set; }
        public string Destination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private bool isPublic;
        private string status = "Pending"; 

        private List<Activity> activities = new List<Activity>();

        public TravelPlan(int contentId, string title, string description, DateTime postDate) : base(contentId, title, description, postDate)
        {
        }

        public IReadOnlyList<Activity> Activities => activities.AsReadOnly();

        public void MakePublic()
        {
            isPublic = true;
            status = "Approved";
        }

        public void Decline()
        {
            status = "Declined";
        }

    }
}
