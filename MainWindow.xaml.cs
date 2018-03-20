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

namespace U2ElipseKeegan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Create a StackPanel to contain the shape.
            StackPanel myStackPanel = new StackPanel();

            // Create an Ellipse.
            Ellipse myEllipse = new Ellipse();
            // or you can use System.Windows.Shapes.Ellipse

            // Create a SolidColorBrush with a red color to fill the 
            // Ellipse with.
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();

            // Describes the brush's color using RGB values. 
            // Each value has a range of 0-255.
            mySolidColorBrush.Color = Color.FromArgb(255, 255, 255, 255); //ARGB =Alpha Red Green Blue, you can also use fromRGB
            myEllipse.Fill = mySolidColorBrush;
            myEllipse.StrokeThickness = 5;
            myEllipse.Stroke = Brushes.MediumPurple;

            // Set the width and height of the Ellipse.
            myEllipse.Width = 100;
            myEllipse.Height = 100;

            //Rectangle values
            Rectangle myRectangle = new Rectangle();
            SolidColorBrush myOtherSolidColorBrush = new SolidColorBrush();
            myOtherSolidColorBrush.Color = Color.FromArgb(255, 0, 0, 0);
            myRectangle.Fill = myOtherSolidColorBrush;
            myRectangle.StrokeThickness = 5;
            myRectangle.Stroke = Brushes.MediumSlateBlue;
            myRectangle.Width = 100;
            myRectangle.Height = 120;

            Rectangle my2ndRectangle = new Rectangle();
            my2ndRectangle.Fill = myOtherSolidColorBrush;
            my2ndRectangle.StrokeThickness = 5;
            my2ndRectangle.Stroke = Brushes.MediumSlateBlue;
            my2ndRectangle.Width = 200;
            my2ndRectangle.Height = 20;

            //new elipse
            Ellipse bodyBall = new Ellipse();
            bodyBall.Fill = mySolidColorBrush;
            bodyBall.StrokeThickness = 5;
            bodyBall.Stroke = Brushes.MediumPurple;
            bodyBall.Width = 150;
            bodyBall.Height = 150;

            // Add the Ellipse to the StackPanel.
            myStackPanel.Children.Add(myRectangle);
            myStackPanel.Children.Add(my2ndRectangle);
            myStackPanel.Children.Add(myEllipse);
            myStackPanel.Children.Add(bodyBall);
            

            this.Content = myStackPanel;
        }
    }
}
