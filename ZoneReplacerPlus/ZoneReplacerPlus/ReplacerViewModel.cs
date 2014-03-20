using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoneReplacerPlus;

namespace ZoneReplacerPlus
{
    public class ReplacerViewModel
    {
        private ObservableCollection<Zone> _zones;

        public ObservableCollection<Zone> Zones
        {
            get { return _zones; }
            set { _zones = value; }
        }

        private Zone _selectedZone;

        public Zone SelectedZone
        {
            get { return _selectedZone; }
            set { _selectedZone = value; }
        }
    }
}
