using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Like
    {
        public int LikeId { get; private set; }
        public int UserId { get; private set; }
        public int LikedEntityId { get; private set; }

        public Like(int likeId, int userId, int likedEntityId)
        {
            LikeId = likeId;
            UserId = userId;
            LikedEntityId = likedEntityId;
        }
    }
}
