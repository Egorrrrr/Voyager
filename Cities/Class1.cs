using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cities
{
    public class City
    {
        private int x;
        private int y;
        private string name;
        public int X
        {
            get
            {
                return x;

            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }
        }
        public City(int x, int y, string name)
        {
            Name = name;
            X = x;
            Y= y;
        }
        
    }
}
