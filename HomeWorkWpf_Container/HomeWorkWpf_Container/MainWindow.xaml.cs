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
        Random randomXTwo = new Random();
        Random randomYTwo = new Random();
        Random randomX = new Random();
        Random randomY = new Random();
        private double positionButtonXOne;
        private double positionButtonXTwo;
        private double positionButtonXFour;
        private double positionButtonXThree;
        private double positionButtonY;
        private double positionButtonYTwo;
        private double ButtonSpace = 30;
        int startButtonX = 30;
        int startButtonY = 30;
        int endButtonX = 380;
        int endButtonY = 200;
        private double ButtonSpaceTwo = 50;
        int startButtonXTwo = 50;
        int startButtonYTwo = 50;
        int endButtonXTwo = 480;
        int endButtonYTwo = 300;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void CatchTheButton()
        {
            positionButtonY = buttonChase.Margin.Top - ButtonSpace;
            positionButtonXOne = buttonChase.Margin.Left - ButtonSpace;
            positionButtonXTwo = buttonChase.Margin.Left + buttonChase.Width + ButtonSpace;
        }

        private void ButtonTheCatch()
        {
            positionButtonYTwo = buttonChaseTwo.Margin.Top - ButtonSpaceTwo;
            positionButtonXThree = buttonChaseTwo.Margin.Right - ButtonSpaceTwo;
            positionButtonXFour = buttonChaseTwo.Margin.Right + buttonChaseTwo.Width + ButtonSpaceTwo;
        }

        private void DockPanel_MouseMove(object sender, MouseEventArgs e)
        {
            CatchTheButton();
            if (ButtonChase(e))
            {
                buttonChase.Margin = new Thickness(Convert.ToDouble(randomY.Next(startButtonX, endButtonX)), Convert.ToDouble(randomY.Next(startButtonY, endButtonY)), 0, 0);
            }
        }

        private bool ButtonChase(MouseEventArgs e)
        {
            if (e.GetPosition(null).X >= positionButtonXOne && e.GetPosition(null).X <= positionButtonXTwo)
            {
                if (e.GetPosition(null).Y >= positionButtonY)
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

        private void DockPanelTwo_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonTheCatch();
            if (ButtonChaseTwo(e))
            {
                buttonChaseTwo.Margin = new Thickness(Convert.ToDouble(randomYTwo.Next(startButtonXTwo, endButtonXTwo)), Convert.ToDouble(randomYTwo.Next(startButtonYTwo, endButtonYTwo)), 0, 0);
            }
        }

        private bool ButtonChaseTwo(MouseEventArgs e)
        {
            if (e.GetPosition(null).X >= positionButtonXThree && e.GetPosition(null).X <= positionButtonXFour)
            {
                if (e.GetPosition(null).Y >= positionButtonYTwo)
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
    }
}
