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
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		private int ballPosX = 0;
		private int ballPosY = 0;
		private int moveX = 20;
		private int moveY = 20;
		public MainWindow()
        {
            InitializeComponent();
			DispatcherTimer utemezo = new DispatcherTimer();
			utemezo.Interval = TimeSpan.FromMilliseconds(500);
            utemezo.Tick += Utemezo_Tick;
			utemezo.Start();
        }

        private void Utemezo_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
		{

			ThicknessAnimation igen = new ThicknessAnimation();

			igen.Duration = new Duration(TimeSpan.FromMilliseconds(300));
			ballPosX += moveX;

			if (ballPosX < 0 || ballPosX + epLabda.Width > this.Width)
			{
				moveX = -moveX;
			}

			ballPosY += moveY;
			if (ballPosY < 0 || ballPosY + epLabda.Height > this.Height)
			{
				moveY = -moveY;

			}
			//igen.RepeatBehavior = RepeatBehavior.Forever;
			igen.To = new Thickness(ballPosX, ballPosY, 0, 0);
			epLabda.BeginAnimation(MarginProperty, igen);
		}
	}
}
