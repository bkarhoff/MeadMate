using MeadMate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeadMate.Views {
    public class MeadViewModel : INotifyPropertyChanged {
        public MeadViewModel() {
            ActiveMeads = Mead.GetActiveBrews();
        }

        private void OnPropertyChanged(string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Mead> meads;
        public List<Mead> ActiveMeads {
            get { return meads; }
            set {
                meads = value;
                OnPropertyChanged("ActiveMeads");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
