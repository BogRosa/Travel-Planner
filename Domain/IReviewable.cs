using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IReviewable
    {
        void SubmitForReview();
        void Approve();
        void Decline();
    }
}
