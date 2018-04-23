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
using System.Windows.Threading;

namespace DungeonCrawler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static Grid gameGridRef;
        public static Grid pauseGridRef;
        public static ListBox pauseMenuRef;

        public static List<string> PauseOptions = new List<string>()
        {
            "Resume", "Quit"
        };


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitialiseReferences();

            listboxPauseOptions.ItemsSource = PauseOptions;


            ApplicationManager.StartApplication();
        }


        private void InitialiseReferences()
        {
            gameGridRef = GameGrid;
            pauseGridRef = PauseGrid;
            pauseMenuRef = listboxPauseOptions;
        }

        private void listboxPauseOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var selectedItem = listboxPauseOptions.SelectedItem as ListItem;

            //if(selectedItem != null)
            //{
            //    selectedItem.Foreground = Brushes.Yellow;

            //    listboxPauseOptions.SelectedItem = selectedItem;
            //}
        }
    }
}
