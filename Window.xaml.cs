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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.Data.Xml.Dom; 
using Windows.UI.Notifications;

namespace Debug
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MouseDown += OnMouseDown;
        }
        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }


        private void Close(object sender, RoutedEventArgs e)
        {

        }

        private string Status { get; set; }
        private void OnTextBoxChanged(object sender, TextChangedEventArgs e)
        {
            //Status = e.Changes.
            //Status = theLabel.text;
            Status = theLabel?.Text;
        }

        private void OnChangeButtonClicked(object sender, RoutedEventArgs e)
        {
            Globals.Lib.CreateWin10Notification("");
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}