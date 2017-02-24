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
using System.Windows.Shapes;

namespace QuizProject
{
	/// <summary>
	/// Interaction logic for IntroWindow.xaml
	/// </summary>
	public partial class IntroWindow : Window
	{
		public IntroWindow()
		{
			InitializeComponent();
			this.Loaded += IntroWindow_Loaded;
		}

		public void IntroWindow_Loaded(object sender, RoutedEventArgs e)
		{
			this.DataContext = this;
		}

		private void btnGo_Click(object sender, RoutedEventArgs e)
		{
			//if (Validate())
				changeWindowToMain();
		}

		#region "functions"

		private void passValuesToUtility()
		{
			Values.userName = tbUserName.Text;

			ComboBoxItem numQuestions = (ComboBoxItem)cboNumQuestions.SelectedItem;
			Values.numQuestions = int.Parse(numQuestions.Content.ToString());

			ComboBoxItem difficulty = (ComboBoxItem)cboDifficulty.SelectedItem;
			Values.difficulty = difficulty.Content.ToString();
		}

		private bool Validate()
		{
			bool valid = true;

			if (string.IsNullOrWhiteSpace(tbUserName.Text))
			{
				valid = false;
				tbUserName.BorderBrush = Colour.raspberry;
			}
			else
				tbUserName.BorderBrush = Colour.lagoon;


			if (cboDifficulty.SelectedIndex == -1)
			{
				valid = false;
			}
				

			if (cboNumQuestions.SelectedIndex == -1)
			{
				valid = false;
			}

			return valid;
		}

		private void changeWindowToMain()
		{
			passValuesToUtility();

			MainWindow Main = new MainWindow();
			Main.Show();
			this.Close();
		}

		#endregion
	}
}
