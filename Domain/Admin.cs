using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Admin : Person, IReviewable
    {
        public void SubmitForReview()
        {
            throw new NotImplementedException();
        }

        public void Approve()
        {
            throw new NotImplementedException();
        }

        public void Decline()
        {
            throw new NotImplementedException();
        }

        public void BanUser(User user)
        {

        }

        public void UnbanUser(User user)
        {

        }
    }
}

