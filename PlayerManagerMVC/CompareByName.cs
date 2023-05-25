using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class CompareByName : IComparer<Player>
    {

        private bool ascend;

        private bool score = false;

        public CompareByName()
        {
            score = true;
        }
        public CompareByName(bool ascend)
        {
            this.ascend = ascend;
        }

        public int Compare(Player x, Player y)
        {
            if(score)
            {
                return (y.Score - x.Score);
            }
            
            if (ascend)
            {
                return (string.Compare(x.Name, y.Name));
            }
            else if (!ascend)
            {
                return (string.Compare(x.Name, y.Name) * -1);
            }

            return (0);

        }

    }
}