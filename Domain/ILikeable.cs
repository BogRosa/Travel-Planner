using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ILikeable
    {
        void Like(int userId);
        void Unlike(int userId);
        int GetLikesCount();
    }
}
