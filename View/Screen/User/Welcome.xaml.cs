using BeautyBrows.Action.Navigation;
using BeautyBrows.View.Screen.Admin;
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

namespace BeautyBrows.View.Screen.User
{
	/// <summary>
	/// Логика взаимодействия для Welcome.xaml
	/// </summary>
	public partial class Welcome : Page
	{
		public Welcome()
		{
			InitializeComponent();
		}

		private void ButtonContinueAsUser_Click(object sender, RoutedEventArgs e)
		{
			FrameNavigation.Frame.Navigate(new Service());
        }

		private void ButtonContinueAsAdmin_Click(object sender, RoutedEventArgs e)
		{
			FrameNavigation.Frame.Navigate(new Login());
        }
    }
}
