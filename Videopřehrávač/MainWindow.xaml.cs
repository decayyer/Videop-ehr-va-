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

namespace Videopřehrávač
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isPlaying = false;
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            if (isPlaying)
            {
                media.Pause();
                play.Content = "Play";
                isPlaying = false;
            }
            else
            {
                media.Play();
                play.Content = "Stop";
                isPlaying = true;
            }
        }

        private void media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            Debug.WriteLine(e.ErrorException.Message);
        }
    }
}
