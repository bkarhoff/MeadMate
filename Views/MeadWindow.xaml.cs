using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MeadMate.Views {
    /// <summary>
    /// Interaction logic for MeadWindow.xaml
    /// </summary>
    public partial class MeadWindow : Window {
        private MeadViewModel VM;
        public MeadWindow() {
            InitializeComponent();
            VM = new MeadViewModel();
            MainContent.DataContext = VM;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            InvalidateVisual();
            MessageBox.Show("Hello");
        }
    }
}
