   M S B A M L   `   `   `  ����F  BQuizProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuizProjectQuizProject  5      ?$clr-namespace:QuizProject.PropertiesQuizProject.Properties  5          QuizProject.IntroWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      +localclr-namespace:QuizProject     5      5prop$clr-namespace:QuizProject.Properties     5        � WindowStartupLocation$  CenterScreen=�5       � Title$ IntroWindow��5
      $	��200��5      $	��400��6    � 
ResizeMode$ NoResize=�5      ���#257985 � 	Resources 5       �� Source�� 5      $ Dictionary1.xaml?�6   %    .��5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5      �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5       �� $��QuizImage.png��6
   $	��150��6!   $��Bottom=�6.   $��4��6I   �� 5"      &    QuizProject.Properties.Resources   userName#��Z 6
   $��Bottom=�67   $��Right=�6R   $��1��6n   �� 5#         	numOfQues#��Z 6
   $��Center=�68   $��Right=�6S   $��1��6o   $��1��6   �� 5$      	   diff#��Z	 6
   $	��Top=�63   $��Right=�6L   $��1��6h   $��2��6x   �� 5&      -   5        
 ��Name$
 
tbUserName��5&      $��Bottom=�6    $��5q�6;   $��2q�6F   $��2��6Z    �� 	MaxLength$ 15��6j    �� TextWrapping$
 Wrap=�6y   �� 5'      -   5         ��Name$ cboNumQuestions��5'      $��Center=�6&   $��5q�6A   $��2��6L   $��1��6\   .@�5(      ��  �� 
IsSelected . .��6$   56'   �� 5)      .��6   106   �� 5*      .��6   156   �� 5+      .��6   206   5,      �� 5-      -   5        $ cboDifficulty��5-      $	��Top=�6$   $��5q�6<   $��2��6G   $��2��6W   .@�5.      ��  . .��6$   Easy6*   �� 5/      .��6   Hard6   50      �� 52      
���   �$��2q�6   $��1��63   $��3��6C   $��2��6P   $��5q�6d   ._�53      �� -   5         ��Name$ btnGo��53         goToQuiz#��Z 6   6H   54      57      58      