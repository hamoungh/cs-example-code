
using System.Collections.Generic;
class Girl
{
    public string name;
    public List<Boy> boyfriends;
    public Girl(string name)
    {
        this.name = name;
        boyfriends = new List<Boy>();
    }
}
