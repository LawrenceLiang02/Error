using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace BosunBot.Modules
{
    abstract class products
    {
        protected string name;
        protected double price;
        protected string description;

        public string getName
        {
            get
            {
                return name;
            }

        }

        public double getPrice
        {
            get
            {
                return price;
            }

        }

        public string getDescription
        {
            get
            {
                return description;
            }

        }

        public products(string n, double p, string d)
        {
            this.name = n;
            this.price = p;
            this.description = d;
        }


    }
}
