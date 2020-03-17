using System;
using System.Collections.Generic;
using System.Text;

namespace VirusSuck
{
    class Virus
    {
        public string Name { get; set; }

        // symptoms should be list of strings because it's multiple things
        public List<string> Symptoms { get; set; }
        public int NumOfDeathsWorldWide { get; set; }
        public int IncubationDays { get; set; }

        public Virus(string name, int incubationDays)
        {
            Name = name;
            IncubationDays = incubationDays;
            // if did not define symptoms to empty List, will cause error as it will return null
            Symptoms = new List<string>();
        }

    }
}
