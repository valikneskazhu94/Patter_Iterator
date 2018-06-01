using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator.Network
{
    public class Human
    {
        private int Age { get; set; }
        private string FirstName { get; set; }
        private int Id { get; set; }
        private bool IsCollegia {get;set;}
        private string LastName { get; set; }
        public Human(int age,string firstName,int id,bool isCollegia,string lastName)
        {
            Age = age;
            FirstName = firstName;
            Id = id;
            IsCollegia = isCollegia;
            LastName = lastName;
        }
        public bool getIsCollegia()
        {
            return this.IsCollegia;
        }
        public override string ToString()
        {
            string colleg = "Collegia";
            string notColleg = "Not Collegia";
            if (IsCollegia = true)
                return colleg;
            else
                return notColleg;
        }
    }
}
