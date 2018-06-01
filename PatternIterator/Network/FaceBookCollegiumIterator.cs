using PatternIterator.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator.Network
{
    public class FaceBookCollegiumIterator:iIterator
    {
        private int position = 0;
        Human[] friends = null;
        public FaceBookCollegiumIterator(Human[] friends)
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
            if (friends[position].getIsCollegia()) return friends[position++];
            this.position++;
            return null;
        }
    }
}
