using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    //Sebatian Martinez
    public class Messagetwitter : Message
    {

        public override Message(string from, string to)
        {
            this.From = from;
            this.To = to;
        }


    }
}