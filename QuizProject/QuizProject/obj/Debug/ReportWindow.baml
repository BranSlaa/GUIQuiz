   M S B A M L   `   `   `  ����F  BQuizProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuizProjectQuizProject  5      ?$clr-namespace:QuizProject.PropertiesQuizProject.Properties  5          QuizProject.ReportWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      +localclr-namespace:QuizProject     5      5prop$clr-namespace:QuizProject.Properties     5        � WindowStartupLocation$  CenterScreen=�5       � Title$ The Quiz��5
      $	��310��5      $	��400��6   ���#257985 � 	Resources 5       �� Source�� 5      $ Dictionary1.xaml?�6   %    .��5      �  � ColumnDefinitions 5      �� 5      $
��auto �6   �� 5      $��3* �6    � RowDefinitions 5      �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5      �� $��2��6      	raspberry#��[  6   $��0 0 0 3q�6H   ._�5      �� .+�5      �� -   5         ��Name$ lblUserName��5      $��15(�6!     	whitewash#��[ 6/   $��Center=�6W   $��Center=�6t   �� 5       -   5        $ 	lblResult��5       $��15(�6   #��[ 6-   $��Center=�6U   $��Center=�6r   5!      5"      �� 5%      -   5         ��Name$ lstQuestions��5%      $
��Auto=�6"   $��1��6R   $��0q�6_    
 lagoon#��[ 6s   ��5&      �� 5'      .R�5(      ��  �� Orientation$ 
Horizontal=�6   .+�5)      �� $��20��6   $��0 0 5 0q�6@   ��6   �� 	 �� Path$	 m_correctIcon�6@   �� 5*      ��6   �� $	 m_name�5+      5,      5.      � 50      $��1��6	   $��1��6    51      �� 52      �� 53      $
��auto �6   �� 54      $
��auto �6   .+�57      �� $��0��6   .+�58      �� -   5        $ lblQuestion��58      $
��Left=�6!   $	��200��6<   $	��5 0q�6H   �� 59      -   5        $ 
lblOption1��59      $
��Left=�6    $	��200��6;   $	��5 1q�6G   �� 5:      -   5        $ 
lblOption2��5:      $
��Left=�6    $	��200��6;   $	��5 1q�6G   �� 5;      -   5        $ 
lblOption3��5;      $
��Left=�6    $	��200��6;   $	��5 1q�6G   �� 5<      -   5        $ 
lblOption4��5<      $
��Left=�6    $	��200��6;   $	��5 1q�6G   5=      5>      �� 5@      $��2��6   $��2��6   #��[  6,   $��0 3 0 0q�6U   ._�5A      �� 
���   �$��2q�6    $��1��64   $��75��6D   $��5q�6O   $��Right=�6Z   ._�5B      �� -	   5        
 ��Name$
 
btnNewQuiz��5B      &    QuizProject.Properties.Resources   newQuiz#��Z 6!   6M   5C      5D      5F      5G      