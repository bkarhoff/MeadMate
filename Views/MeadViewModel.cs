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
            OnPropertyChanged("ActiveMeads");
        }

        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<Mead> ActiveMeads;

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
