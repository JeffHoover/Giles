using System.Collections.Generic;
using System.ComponentModel;

namespace Giles.Core.Configuration
{
    public class GilesConfig : INotifyPropertyChanged
    {
        public IDictionary<string, RunnerAssembly> TestRunners = new Dictionary<string, RunnerAssembly>();
        public string TestAssemblyPath { get; set; }
        public string SolutionPath { get; set; }
        long buildDelay = 500;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged == null) return;
            
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        public long BuildDelay
        {
            get
            {
                return buildDelay;
            }
            set
            {
                if (value == buildDelay) return;
                
                buildDelay = value;
                NotifyPropertyChanged("BuildDelay");
            }
        }
    }
}