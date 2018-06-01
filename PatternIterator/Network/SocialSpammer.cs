using PatternIterator.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator.Network
{
    public class SocialSpammer
    {
        FaceBook facebook = null;

        public SocialSpammer(FaceBook facebook)
        {
            this.facebook = facebook;
            this.Send();
        }
        public void Send()
        {

        }


        public void SendView(iIterator it)
        {
            Human human = it.next() as Human;
            if (human != null)
            {
                Console.WriteLine(human.GetType().Name);
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(human.ToString());
            }
        }
    }
}
