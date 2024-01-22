using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project;

public class Astronaut
{
    public long Id { get; set; }
    public string Name { get; set; }
    public int Missions { get; set; }
    public bool IsRetired { get; set; }

    public Astronaut(long id, string name, int missions, bool isRetired)
    {
        Id = id;
        Name = name;
        Missions = missions;
        IsRetired = isRetired;
    }
}