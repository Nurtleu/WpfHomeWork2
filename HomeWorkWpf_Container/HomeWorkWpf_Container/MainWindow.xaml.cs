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

namespace HomeWorkWpf_Container
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double positionButtonXOne;
        private double positionButtonXTwo;
        private double positionButtonYOne;
        private double positionButtonYTwo;
        Random randomXPosition = new Random();
        Random randomYPosition = new Random();
        private double ButtonSpace = 50;
        int startButtonX = 50;
        int startButtonY = 50;
        int endButtonX = 380;
        int endButtonY = 250;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void TheButton()
        {
            positionButtonXOne = movingButton.Margin.Right - movingButton.Height + movingButton.Width + ButtonSpace;
            positionButtonXTwo = movingButton.Margin.Left - movingButton.Height + movingButton.Width + ButtonSpace;
            positionButtonYOne = movingButton.Margin.Bottom - movingButton.Height + movingButton.Width + ButtonSpace;
            positionButtonYTwo = movingButton.Margin.Top - movingButton.Height + movingButton.Width + ButtonSpace;
        }

        private bool ButtonChase(MouseEventArgs e)
        {
            if (e.GetPosition(null).X >= positionButtonXOne && e.GetPosition(null).X <= positionButtonXTwo)
            {
                if (e.GetPosition(null).Y >= positionButtonYOne)
                {
                    return true;
                }

                else if (e.GetPosition(null).Y >= positionButtonYTwo)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        private void DockPanel_MouseMove(object sender, MouseEventArgs e)
        {
            TheButton();
            if (ButtonChase(e))
            {
                movingButton.Margin = new Thickness(Convert.ToDouble(randomYPosition.Next(startButtonX, endButtonX)), Convert.ToDouble(randomYPosition.Next(startButtonY, endButtonY)), 0, 0);
            }
            else
            {
                return;
            }
        }

        private void ButtonChase_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush backColor = new SolidColorBrush();
            this.Background = backColor;
        }
    }
}
