using PatternIterator.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator.Network
{
    public class FaceBook
    {
        public int allFriends=5;
        Human[] friends;
        //private string network;
        public FaceBook()
        {
           
            friends = new Human[allFriends];
            connectToData();
        }
        private void connectToData()
        {
            friends[0]= new Human(19,"Никита",123123123,false,"Лошара");
            friends[1] = new Human(23,"Сергей",123456,true,"Совгуть");
            friends[2] = new Human(36, "Максим", 123234, true, "Бондаренко");
            friends[3] = new Human(20, "Марина", 456123, false, "Никонорычева");
            friends[4] = new Human(23, "Валентин", 777777, true, "Прядко");
        }
        public iIterator createAllFriendIterator()
        {

        }
        public void createCollegiumIterator()
        {

        }
    }
}
