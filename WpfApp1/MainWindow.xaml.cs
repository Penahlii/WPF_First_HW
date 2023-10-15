#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void info_btn(Button button)
        {
            byte r = (byte)Random.Shared.Next(0, 255);
            byte g = (byte)Random.Shared.Next(0, 255);
            byte b = (byte)Random.Shared.Next(0, 255);
            button.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

            SolidColorBrush buttonColor = button.Background as SolidColorBrush;
            Color buttonRGBColor = buttonColor.Color;
            double buttonX = Canvas.GetLeft(button);
            double buttonY = Canvas.GetTop(button);
            string buttonText = button.Content.ToString();
            string buttonName = button.Name;
            string buttonTooltip = button.ToolTip != null ? button.ToolTip.ToString() : "No tooltip set";
            Grid parentGrid = button.Parent as Grid;
            int row = Grid.GetRow(button);
            int column = Grid.GetColumn(button);
            DateTime clickTime = DateTime.Now;
            string message = $"Button Name: {buttonName}\n" +
                             $"Button Text: {buttonText}\n" +
                             $"Button Color: RGB({buttonRGBColor.R}, {buttonRGBColor.G}, {buttonRGBColor.B})\n" +
                             $"Button Coordinates: X={buttonX}, Y={buttonY}\n" +
                             $"Button Tooltip: {buttonTooltip}\n" +
                             $"Button is in Row {row}, Column {column} of the Grid\n" +
                             $"Click Time: {clickTime}";
            MessageBox.Show(message, "Button Information");
        }

        private void del_btn(Button button)
        {
            this.Title = button.Name;
            MainGrid.Children.Remove(button);
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            info_btn(button);
        }

        private void Tow_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            info_btn(button);
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            info_btn(button);
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            info_btn(button);
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            info_btn(button);
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            info_btn(button);
        }

        private void One_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            del_btn(button);
        }

        private void Tow_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            del_btn(button);
        }

        private void Three_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            del_btn(button);
        }

        private void Four_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            del_btn(button);
        }

        private void Five_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            del_btn(button);
        }

        private void Six_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            del_btn(button);
        }
    }
}
