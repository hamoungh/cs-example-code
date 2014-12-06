
using System.Collections.Generic;
    class Boy
    {
        public string name;
        public List<Girl> girlfriends;
        public Boy(string name)
        {
            this.name = name;
            girlfriends = new List<Girl>();
        }
    }
