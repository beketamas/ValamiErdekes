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
using System.Windows.Media.Animation;
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
		private int ballPosX = 0;
		private int ballPosY = 0;
		private int moveX = 20;
		private int moveY = 20;

		public MainWindow()
		{
			InitializeComponent();
		}


		private void Button_Click(object sender, RoutedEventArgs e)
		{

			ThicknessAnimation igen = new ThicknessAnimation();

			igen.Duration = new Duration(TimeSpan.FromMilliseconds(300));
			ballPosX += moveX;

			if (ballPosX < 0 || ballPosX + epLabda.Width > 800)
			{
				moveX = -moveX;
			}

			ballPosY += moveY;
			if (ballPosY < 0 || ballPosY + epLabda.Height > 450)
			{
				moveY = -moveY;

			}
			igen.To = new Thickness(ballPosX, ballPosY, 0, 0);
			epLabda.BeginAnimation(MarginProperty, igen);




		}

		
	}
}
