using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Photo
    {
        public int PhotoId { get; private set; }
        public int TravelPlanId { get; private set; }
        public string FilePath { get; private set; }
        public string Description { get; private set; }

        public Photo(int photoId, int travelPlanId, string filePath, string description)
        {
            PhotoId = photoId;
            TravelPlanId = travelPlanId;
            FilePath = filePath;
            Description = description;
        }
    }
}
