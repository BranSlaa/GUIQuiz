   M S B A M L   `   `   `  ����F  BQuizProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuizProjectQuizProject  5      ?$clr-namespace:QuizProject.PropertiesQuizProject.Properties  5          QuizProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      +localclr-namespace:QuizProject     5      5prop$clr-namespace:QuizProject.Properties     5        � WindowStartupLocation$  CenterScreen=�5       � Title$ The Quiz��5
      $	��350��5      $	��450��6   ���#257985 � 	Resources 5       �� Source�� 5      $ Dictionary1.xaml?�6   %    .��5      �  � ColumnDefinitions 5      �� 5      $
��auto �6   �� 5      $��3* �6    � RowDefinitions 5      �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5      �� $��2��6      	raspberry#��[  6   $��0 0 0 3q�6H   ._�5      �� -   5         ��Name$ lblUserName��5      $��15(�6      	whitewash#��[ 6.   $��Center=�6V   $��Center=�6s   5      �� 5!      -   5         ��Name$ lstQuestions��5!      $
��Auto=�6"   $��1��6R   $��0q�6_    
 lagoon#��[ 6s   ��5"      �� 5#      .R�5$      ��  �� Orientation$ 
Horizontal=�6   .+�5%      �� $��20��6   $��0 0 5 0q�6=   ��6   �� 	 �� Path$	 
m_saveIcon�6=   �� 5&      ��6   �� $	 m_name�5'      5(      5*      � 5,      $��1��6	   $��1��6    5-      �� 5.      �� 5/      $
��auto �6   �� 50      $
��auto �6   .+�53      �� $��0��6   .+�54      �� -   5        $ lblQuestion��54      	� 55      -   5        
 	�Name$
 
rdoOption1��55      	� 56      -   5        $
 
rdoOption2��56      	� 57      -   5        $
 
rdoOption3��57      	� 58      -   5        $
 
rdoOption4��58      59      �� 5;      $��1��6   #��[  6   $��0 3 0 0q�6B   y�6\   �� *VisibilityProperty+  	boolToVis �� 	Converter# [ ._�5<      �� &    QuizProject.Properties.Resources   mustBeSaved#��Z 6   y�6<   �� *VisibilityProperty+# [ 5=      �� 5?      $ 
Horizontal=�6   $��2��6)   .+�5@      �� 
���   �$��2q�6!   $��45��65   $��5q�6@   $
��Left=�6K   y�6f   �� *VisibilityProperty+# [ ._�5A      �� -   5         ��Name$ btnSave��5A         save#��Z 6   $��19��6�   $	��Top=�6�   y�6H   �� *VisibilityProperty+# [ 6�   5B      �� 5C      
���   �$��2q�6!   $��65��65   $��5q�6@   $
��Left=�6K   y�6f   �� *VisibilityProperty+# [ ._�5D      �� -	   5        $ btnPrevious��5D         previous#��Z 6#   $��19��6�   $	��Top=�6�   y�6P   �� *VisibilityProperty+# [ 6�   5E      �� 5F      
���   �$��2q�6!   $��45��65   $��5q�6@   $
��Left=�6K   y�6f   �� *VisibilityProperty+# [ ._�5G      �� -
   5        $ btnNext��5G         next#��Z 6   $��19��6�   $	��Top=�6�   y�6H   �� *VisibilityProperty+# [ 6�   5H      5I      5J      �� 5L      $��2��6   $��2��6   #��[  6,   $��0 3 0 0q�6U   ._�5M      �  5N      �� 5O      $��* �6   �� 5P      $
��auto �6   .+�5S      �� $ 
Horizontal=�6   $��Center=�6*   .+�5T      � -   5         �Name$ pbSavedQues��5T       � Minimum$ 0Q�6(   $	��175��64   $��10��6@     	saltwater#��[ 6L   ���#35fc5c$��1q�6�   
���   �6�   �� 5V      -   5        $ lblSaved��5V         	xQueSaved �� ContentStringFormat# Z 6W   $��0 2 0 0q�6�   ��6   ��  �� ElementName$ pbSavedQues��$	 Value�6�   5W      �� 5Y      
���   �$��2q�6!   $��1��65   $��75��6E   $��5q�6P   ._�5Z      �� -   5        $ 	btnSubmit��5Z         submit#��Z 6!   6L   5[      5]      5^      5`      5a      