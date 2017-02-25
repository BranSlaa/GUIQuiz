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

namespace QuizProject
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public int selectedValue = -1;

		public MainWindow()
		{
			InitializeComponent();
			lblUserName.Content = "Welcome " + Values.userName + ", good luck on The Quiz!";
			pbSavedQues.Maximum = Values.numQuestions;

			this.Loaded += MainWindow_Loaded;
			populateList();
		}

		public void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			this.DataContext = this;
		}

		private void btnSubmit_Click(object sender, RoutedEventArgs e)
		{
			BeginSubmit();
		}

		private void lstQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			setSelectedValue();
			uncheckRadioButtons();
			setVisibility();
			populateOptions();
		}
		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			if (isRdoBtnChecked())
			{
				changeIcon();
				saveAnswer();
			}
		}

		private void btnNext_Click(object sender, RoutedEventArgs e)
		{
			goToNextQuestion();
		}

		private void btnPrevious_Click(object sender, RoutedEventArgs e)
		{
			goToPreviousQuestion();
		}

		#region "Properties"

		public new bool VisibilityProperty
		{
			get { return (bool)GetValue(VisibilityPropertyProperty); }
			set { SetValue(VisibilityPropertyProperty, value); }
		}

		// Using a DependencyProperty as the backing store for VisibilityProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty VisibilityPropertyProperty =
			DependencyProperty.Register("VisibilityProperty", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));

		#endregion

		#region "functions"

		private void setSelectedValue()
		{
			selectedValue = lstQuestions.SelectedIndex;
		}

		private void uncheckRadioButtons()
		{
			rdoOption1.IsChecked = false;
			rdoOption2.IsChecked = false;
			rdoOption3.IsChecked = false;
			rdoOption4.IsChecked = false;

			switch (Values.selQuestion[selectedValue].m_valueChosen)
			{
				case 1:
					rdoOption1.IsChecked = true;
					break;
				case 2:
					rdoOption2.IsChecked = true;
					break;
				case 3:
					rdoOption3.IsChecked = true;
					break;
				case 4:
					rdoOption4.IsChecked = true;
					break;
				default:
					break;
			}
		}

		private void setVisibility()
		{
			if (lstQuestions.SelectedIndex == -1)
			{
				VisibilityProperty = false;
			}
			else
			{
				VisibilityProperty = true;
			}
		}

		private void populateList()
		{
			Random ans = new Random();
			for (int x = 0; x < Values.numQuestions; x++)
			{
				Values.selQuestion.Add(new Question(Values.difficulty, ans.Next(0, 3), "Question " + (x + 1)));
			}

			foreach (Question que in Values.selQuestion)
			{
				lstQuestions.Items.Add(que);
			}
		}

		private void populateOptions()
		{
			lblQuestion.Content = Values.selQuestion[selectedValue].m_question;
			rdoOption1.Content = Values.selQuestion[selectedValue].questions[0];
			rdoOption2.Content = Values.selQuestion[selectedValue].questions[1];
			rdoOption3.Content = Values.selQuestion[selectedValue].questions[2];
			rdoOption4.Content = Values.selQuestion[selectedValue].questions[3];
		}

		private bool isRdoBtnChecked()
		{
			if (rdoOption1.IsChecked == true || rdoOption2.IsChecked == true || rdoOption3.IsChecked == true || rdoOption4.IsChecked == true)
				return true;
			else
				return false;
		}

		private int getSelectedNumber()
		{
			if (rdoOption1.IsChecked == true)
				return 1;
			else if (rdoOption2.IsChecked == true)
				return 2;
			else if (rdoOption3.IsChecked == true)
				return 3;
			else if (rdoOption4.IsChecked == true)
				return 4;
			else return 0;
		}

		private void saveAnswer()
		{
			pbSavedQues.Value += 1;
			Values.selQuestion[selectedValue].m_valueChosen = getSelectedNumber();

			switch (getSelectedNumber())
			{
				case 1:
					if (rdoOption1.Content.ToString() == Values.selQuestion[selectedValue].m_answer.ToString())
						Values.selQuestion[selectedValue].m_isRight = true;
					break;
				case 2:
					if (rdoOption2.Content.ToString() == Values.selQuestion[selectedValue].m_answer.ToString())
						Values.selQuestion[selectedValue].m_isRight = true;
					break;
				case 3:
					if (rdoOption3.Content.ToString() == Values.selQuestion[selectedValue].m_answer.ToString())
						Values.selQuestion[selectedValue].m_isRight = true;
					break;
				case 4:
					if (rdoOption4.Content.ToString() == Values.selQuestion[selectedValue].m_answer.ToString())
						Values.selQuestion[selectedValue].m_isRight = true;
					break;
				default:
					break;
			}
		}

		private void changeIcon()
		{
			Values.selQuestion[selectedValue].m_saveIcon = "floppyIconGreen.png";
			lstQuestions.SelectedItem = Values.selQuestion[selectedValue];
			lstQuestions.Items.Refresh();
		}

		private void goToNextQuestion()
		{
			if (selectedValue < Values.numQuestions)
				lstQuestions.SelectedIndex += 1;
		}

		private void goToPreviousQuestion()
		{
			if (selectedValue > 0)
				lstQuestions.SelectedIndex -= 1;
		}

		private void BeginSubmit()
		{
			if (pbSavedQues.Value == Values.numQuestions)
			{
				ReportWindow Report = new ReportWindow();
				Report.Show();
				this.Close();
			}
		}

		#endregion
	}
}
