   M S B A M L   `   `   `  ����D  @Pogodynka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pogodynka	Pogodynka  5   	       Pogodynka.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Pogodynka     5   	     � Title$  	Pogodynka��5   	   $	��450��6   $	��800��6(   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ White��6    � Offset$	 0.0Q�6-   � 5      $ 	#FFACB6E5��6   $	 1.0Q�61   5       � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��2* �6   6,   �� 5      $��9* �6   6,   �� 5      6!   .+�5   
   �� $��0��6   $��0��6   $��/Media/pogodynka-icon.jpg��6-   $��40��6P   6]   �� 5   
   $��Candara)�6   $
��Bold"�6)   $��15(�6;   $��Center=�6I   $��0��5      $��1��6!   $��PogodynkaApp��61   6G   �� 5    
   $��1��6   $��4��6"   $��Center=�66   $	��400��6S   $��Center=�6_   $	��100��6z   .+�5!      ��  �� CornerRadius$ 10��6   
�������$��1q�6:   
������� �� Padding$ 0q�6a   $��10q�6m   ._�5"      �� -   5        $��cb_capitals��5#   .   
������ $��0q�6   $��3q�6#   	 �� 
IsEditable	 . $��30��6T   5$      �� 5&      $	��200��6   $ 10��6!   
�������$��1q�6F   ���	#FFD8F5FF$ 0q�6q   $��10q�6}   ._�5'      �� -   5        $��3q�5'      $��Szukaj��6$   $��0q�6Q   
������ 6�   5(      5+      �� 5,   
   -   5        
 ��Name$
 WeatherInfo��5,   P   $��2��6   $��4��6   $��Center=�63   $y�Hidden=�6e   
�������$ 15��6�   $	��300��6�   $	��150��6�   ._�5-      �� .+�5.      �� -   5         ��Name$ Display_city��5.      $��28(�62   $��Right=�6@   $
��10 3q�6\   $
��Bold"�6j   �� 5/      -   5        $ Display_json��5/      $	��100��62   $
��Wrap=�6?   $��Visible=�6S   $��5q�6�   50      51      53      54      