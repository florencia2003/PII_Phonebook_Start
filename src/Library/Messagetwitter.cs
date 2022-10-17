using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    //Sebatian Martinez
    public class Messagetwitter : Message
    {

        public override Message(string from, string to, string text)
        {
            this.From = from;
            this.To = to;
            this.Text = text;
        }


    }
}