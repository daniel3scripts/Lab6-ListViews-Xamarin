using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;



namespace Lab6ListView
{
    public class SoccerTeams:ObservableCollection<Teams>

    {
        public string Name { get; private set; }
        public SoccerTeams(string name)
            : base()
        {
            Name = name;
            
        }
        public SoccerTeams(string name,IEnumerable<Teams>source)
            :base(source)
        {
            Name = name;
        }

    }
}
