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
	public partial class MainWindow : Window/*, IValueConverter*/
	{
		List<Question> selQuestion = new List<Question>();

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
			pbSavedQues.Value += 1;
		}

		private void lstQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			setVisibility();
			populateOptions();
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
				selQuestion.Add(new Question(Values.difficulty, ans.Next(0, 3)));
			}

			foreach (Question que in selQuestion)
				lstQuestions.Items.Add(que.m_question);
		}

		private void populateOptions()
		{
			lblQuestion.Content = selQuestion[lstQuestions.SelectedIndex].m_question;
			rdoOption1.Content = selQuestion[lstQuestions.SelectedIndex].questions[0];
			rdoOption2.Content = selQuestion[lstQuestions.SelectedIndex].questions[1];
			rdoOption3.Content = selQuestion[lstQuestions.SelectedIndex].questions[2];
			rdoOption4.Content = selQuestion[lstQuestions.SelectedIndex].questions[3];
		}

		#endregion
	}
}
