using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Drawing.Imaging;

namespace QuizProject
{
	public class Values
	{
		public static string userName { get; set; }
		public static int numQuestions { get; set; }
		public static string difficulty { get; set; }
		public static List<Question> selQuestion = new List<Question>();
	}

	public class Colour
	{
		public static SolidColorBrush saltwater = (SolidColorBrush)(new BrushConverter().ConvertFrom("#257985"));
		public static SolidColorBrush lagoon = (SolidColorBrush)(new BrushConverter().ConvertFrom("#5EA8A7"));
		public static SolidColorBrush whitewash = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F5FFFF"));
		public static SolidColorBrush raspberry = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF4447"));
	}

	public class Question
	{
		public string m_name { get; set; }
		public string m_saveIcon { get; set; }
		public string m_correctIcon { get; set; }
		public bool m_isRight { get; set; }
		public int m_valueChosen { get; set; }
		public string m_question { get; set; }
		public int m_option1 { get; set; }
		public int m_option2 { get; set; }
		public int m_option3 { get; set; }
		public int m_answer { get; set; }
		public char m_symbol { get; set; }
		private static Random sRand10 = new Random();
		private static Random sRand100 = new Random();

		public List<int> questions = new List<int>();

		public string difficulty { get; set; }
		public int rightValue { get; set; }

		public Question(string diff, int answer, string name)
		{
			difficulty = diff;
			rightValue = answer;
			m_name = name;
			m_saveIcon = "floppyIconRed.png";
			m_correctIcon = "greenCheck.png";
			m_isRight = false;

			setRandomValue();

			addToQuestions();
		}

		private void addToQuestions()
		{
			questions.Add(m_option1);
			questions.Add(m_option2);
			questions.Add(m_option3);
			questions.Insert(rightValue, m_answer);
		}

		private void setSymmbol(int rand10)
		{
			if (rand10 % 2 == 0)
			{
				if (difficulty == "Easy")
					m_symbol = '+';
				else
					m_symbol = '*';
			}
			else
			{
				if (difficulty == "Easy")
					m_symbol = '-';
				else
					m_symbol = '/';
			}
		}

		private void setRandomValue()
		{
			int rand10 = sRand10.Next(1, 10);
			int rand100 = sRand100.Next(11, 100);

			setSymmbol(rand10);

			m_question = "What is " + rand100 + " " + m_symbol + " " + rand10 + "?";

			switch (m_symbol)
			{
				case '+':
					m_answer = rand100 + rand10;
					while (m_option1 == m_answer || m_option1 == 0)
						m_option1 = sRand100.Next(11, 100) + sRand10.Next(1, 10);
					while (m_option2 == m_answer || m_option2 == m_option1 || m_option2 == 0)
						m_option2 = sRand100.Next(11, 100) + sRand10.Next(1, 10);
					while (m_option3 == m_answer || m_option3 == m_option2 || m_option3 == m_option1 || m_option3 == 0)
						m_option3 = sRand100.Next(11, 100) + sRand10.Next(1, 10);
					break;
				case '-':
					m_answer = rand100 - rand10;
					while (m_option1 == m_answer || m_option1 == 0)
						m_option1 = sRand100.Next(11, 100) - sRand10.Next(1, 10);
					while (m_option2 == m_answer || m_option2 == m_option1 || m_option2 == 0)
						m_option2 = sRand100.Next(11, 100) - sRand10.Next(1, 10);
					while (m_option3 == m_answer || m_option3 == m_option2 || m_option3 == m_option1 || m_option3 == 0)
						m_option3 = sRand100.Next(11, 100) - sRand10.Next(1, 10);
					break;
				case '*':
					m_answer = rand100 * rand10;
					while (m_option1 == m_answer || m_option1 == 0)
						m_option1 = sRand100.Next(11, 100) * sRand10.Next(1, 10);
					while (m_option2 == m_answer || m_option2 == m_option1 || m_option2 == 0)
						m_option2 = sRand100.Next(11, 100) * sRand10.Next(1, 10);
					while (m_option3 == m_answer || m_option3 == m_option2 || m_option3 == m_option1 || m_option3 == 0)
						m_option3 = sRand100.Next(11, 100) * sRand10.Next(1, 10);
					break;
				case '/':
					m_answer = rand100 / rand10;
					while (m_option1 == m_answer || m_option1 == 0)
						m_option1 = sRand100.Next(11, 100) / sRand10.Next(1, 10);
					while (m_option2 == m_answer || m_option2 == m_option1 || m_option2 == 0)
						m_option2 = sRand100.Next(11, 100) / sRand10.Next(1, 10);
					while (m_option3 == m_answer || m_option3 == m_option2 || m_option3 == m_option1 || m_option3 == 0)
						m_option3 = sRand100.Next(11, 100) / sRand10.Next(1, 10);
					break;
			}
		}
	}
}
