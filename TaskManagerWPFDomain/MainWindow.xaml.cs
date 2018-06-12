using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace TaskManagerWPFDomain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ModelTaskManager _model;
        public MainWindow()
        {
            InitializeComponent();
            _model = new ModelTaskManager(this);
        }

        private void ButtonKill_OnClick(object sender, RoutedEventArgs e)
        {
            if (ProcessesListView.SelectedItem != null)
            {
                _model.KillProcess();
            }
        }

        private void ButtonOpen_OnClick(object sender, RoutedEventArgs e)
        {
            _model.StartProcess();
        }
    }

    
}
