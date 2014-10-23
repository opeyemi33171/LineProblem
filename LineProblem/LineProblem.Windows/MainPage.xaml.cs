using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
//using System.Windows.Shapes.Line;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LineProblem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        Point guessLineCentre;
        double dx;
        double dy;
        private void plane_Loaded(object sender, RoutedEventArgs e)
        {
            
               guessLine.X1=0;
               guessLine.Y1=plane.ActualHeight/2;
               guessLine.X2=plane.ActualWidth;
               guessLine.Y2=plane.ActualHeight/2;
               guessLineCentre.X = (guessLine.X1+guessLine.X2)/2;
               guessLineCentre.Y = (guessLine.Y1+guessLine.Y2)/2;
        }

        private void plane_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Point mouseCooordinates = new Point();
            mouseCooordinates.X = (e.GetPosition(plane)).X;
            mouseCooordinates.Y = (e.GetPosition(plane)).Y;
            if (guessLineCentre.X - mouseCooordinates.X < 0) 
            {
                dx = (guessLineCentre.X - mouseCooordinates.X) * -1;
                diffX.Text = "Differnce in x : " + dx;
            }
            else
            {
                dx = guessLineCentre.X - mouseCooordinates.X;
                diffX.Text = "Difference in x : " + dx;
            }
            if (guessLineCentre.Y - mouseCooordinates.Y < 0)
            {
                dy = (guessLineCentre.Y - mouseCooordinates.Y)*-1;
                diffY.Text = "Difference in y : " + dy;
            }
            else
            {
                dy = guessLineCentre.Y - mouseCooordinates.Y;
                diffX.Text = "Difference in y : " + dy;
            }
        }

     
    }
}
