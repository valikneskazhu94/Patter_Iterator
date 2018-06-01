using PatternIterator.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator.Iterators
{
    public class AllFriendIterator:iIterator
    {
       // private int friends;
        private int position = 0;
        Human[] friends = null;
        public AllFriendIterator(Human[] friends)
        {
            this.friends = friends;
        }
        public bool hasNext()
        {
            if (position >= friends.Length || friends[position] == null) return false;
            return true;
        }

        public object next()
        {
            return friends[position++];
        }
    }
}
