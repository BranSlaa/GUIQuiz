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
	/// Interaction logic for ReportWindow.xaml
	/// </summary>
	public partial class ReportWindow : Window
	{
		public int selectedValue = -1;
		public ReportWindow()
		{
			InitializeComponent();
			lblUserName.Content = "Thank you " + Values.userName + "for taking The Quiz!";

			calculateResult();
			this.Loaded += ReportWindow_Loaded;
			populateList();
		}

		public void ReportWindow_Loaded(object sender, RoutedEventArgs e)
		{
			this.DataContext = this;
		}

		private void btnNewQuiz_Click(object sender, RoutedEventArgs e)
		{
			changeWindowToIntro();
		}

		private void lstQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			setSelectedValue();
			populateResults();
		}
		#region "functions"

		private void calculateResult()
		{
			int y = 0;
			foreach (Question val in Values.selQuestion)
			{
				if (val.m_isRight)
					y++;
			}
			lblResult.Content = "You got " + y.ToString() + "/" + Values.numQuestions + " correct!";
		}

		private void changeWindowToIntro()
		{
			Values.userName = "";
			Values.numQuestions = 0;
			Values.difficulty = "Easy";
			Values.selQuestion = new List<Question>();

			IntroWindow Intro = new IntroWindow();
			Intro.Show();
			this.Close();
		}

		private void populateList()
		{
			foreach (Question que in Values.selQuestion)
			{
				if (!que.m_isRight)
					que.m_correctIcon = "redX.png";
				lstQuestions.Items.Add(que);
			}
		}

		private void setSelectedValue()
		{
			selectedValue = lstQuestions.SelectedIndex;
		}

		private void populateResults()
		{
			lblQuestion.Content = Values.selQuestion[selectedValue].m_question;
			lblOption1.Content = Values.selQuestion[selectedValue].questions[0];
			lblOption2.Content = Values.selQuestion[selectedValue].questions[1];
			lblOption3.Content = Values.selQuestion[selectedValue].questions[2];
			lblOption4.Content = Values.selQuestion[selectedValue].questions[3];

			resetAllLabelBackgrounds();
			setWrongBackgrounds();
			setRightBackgrounds();
		}

		private void resetAllLabelBackgrounds()
		{
			lblOption1.ClearValue(Label.BackgroundProperty);
			lblOption2.ClearValue(Label.BackgroundProperty);
			lblOption3.ClearValue(Label.BackgroundProperty);
			lblOption4.ClearValue(Label.BackgroundProperty);
		}

		private void setWrongBackgrounds()
		{
			if (Values.selQuestion[selectedValue].m_valueChosen == 1)
				lblOption1.Background = Brushes.Red;
			else if (Values.selQuestion[selectedValue].m_valueChosen == 2)
				lblOption2.Background = Brushes.Red;
			else if (Values.selQuestion[selectedValue].m_valueChosen == 3)
				lblOption3.Background = Brushes.Red;
			else if (Values.selQuestion[selectedValue].m_valueChosen == 4)
				lblOption4.Background = Brushes.Red;
		}

		private void setRightBackgrounds()
		{
			if (Values.selQuestion[selectedValue].rightValue == 0)
				lblOption1.Background = Brushes.ForestGreen;
			else if (Values.selQuestion[selectedValue].rightValue == 1)
				lblOption2.Background = Brushes.ForestGreen;
			else if (Values.selQuestion[selectedValue].rightValue == 2)
				lblOption3.Background = Brushes.ForestGreen;
			else if (Values.selQuestion[selectedValue].rightValue == 3)
				lblOption4.Background = Brushes.ForestGreen;
		}
		#endregion
	}
}
