   M S B A M L   `   `   `  ����E  AWorkoutApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WorkoutApp
WorkoutApp  5      =#clr-namespace:WorkoutApp.ConvertersWorkoutApp.Converters  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089*    $WorkoutApp.Converters.DateConverterr   DateConverter3   -WorkoutApp.Converters.DayBorderColorConverter  DayBorderColorConverter  ImageButtonStyleOk  �� 
TargetType �� Property �� Value �� 
TargetType  backGroundColor  ChangeBackgroundStoryboard �� 
TargetName �� TargetProperty R� KeyTime R� Value  myButtonStyle �� Triggers	 P� Property
 P� Value   WorkoutApp.MyCalendar �� Padding �� TextAlignment �� Color A� Rows A� Columns �� Path �� 	Converter �� Binding �� Value �� EndPoint �� 
StartPoint � Color � Offset ��Name �� ConverterParameter�� 5
      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      #Jarlooclr-namespace:WorkoutApp  5      2
Converters#clr-namespace:WorkoutApp.Converters  5      %H  &	        &	      &	 &     &	 �    &	 �    &	 p    '  �    7  7  7      5      68     5      6K   �� 5      "  ��6'   .�5   
   ��  �@�OverridesDefaultStyle . 62   �� 5   
    � ��$ 50��6"   �� 5   
    � ��$ 50��6#   �� 5   
    � ��
 �����6'   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $e��_C:\\Users\david\\Documents\Visual Studio 2015\\Projects\\WorkoutApp\\WorkoutApp\\Images\\ok.png��6   5      5      5      ��5      	BLACK��5       �� 5!      .��5"   
   T� $ MyButton��6(   $ 
Background�5#   (   ..�5%      i� $ 0:0:0��6%   $ Black��5&   %   5'      5(      �� 5)      "  ��6"   .�5*   
   ��  � �� 6'   �� 6;   �� 5,   
    � ��$ Stretch=�67   �� 5-   
    � ��$ Stretch=�65   �� 5.   
    � ��$ Stretch=�60   6B   �� 5/   
    � ��$ Stretch=�6.   6@    50   
   P� 52      	 �@J�IsMouseOver
 . . �53      ��  � ��
 �� ��6A   54      57      �� 58      "   6   .�59   
   ��  � �� 5:      �� 5;      "  6"   .R�5=      �� #��z��6   #��z��5>      #��z��5?      ._�5A      ]� .+�5B      �� ��6(   �� *Date+�� 5D      $	��Top=�6L   ��6+   �� *
DayNames+��5E   "   �� 5F   &   .R�5G   *   �� 
���   �$��2q�6E   $ 0q�6Y   ._�5I   ,   �� $ Center=�66   $��30(�6^   ��6M   �� ��5J   .   �� 5K   6   	textColor�� 6Y   �� 5M   +   5N   +   5O   '   ��5Q   "   �� 5R   &   .R�5S   *   A� $ 1��66   $ 7��6?   5T   '   5V      �� 5X      ��6+   �� *Days+��5Y   "   �� 5Z   &   .R�5\   *   �� 
���   �$��2q�6E   $ 0q�6Y   ._�5^   .   �� $��InnerBorder��65   $��0q�6�   ��6H   �� $ Workout�8   ��5_   G   �� 5`   6   "  ��6<    5a   :   �� 5b   =    6I   �� *	IsToday+ true6e   .a�5c   B   ��  � �� 5d   F   �� 5e   J   $ 0.5,1&�6^   $ 0.5,0&�6o   .��5f   N   � $ 	#FF1EA6C8��6[   $ 0Q�6m   � 5g   N   $ 	#FF0691B3��6[   $ 1Q�6m   5h   K   5j   C   5k   ?   5m   7   ._�5p   2   ]� .+�5q   6   ]� $	��Top=�6@   $��RightToLeft=�6U   .+�5r   :   �� $ 	buttonito��6A   8�� ��5t   <   �� 5v   <   
�������$��20(�5w   z   ��5v   U   �� *Date+8  $	 DAY����5x   @   �� 5y   D   "  ��6J   .�5z   L   ��  � ��
 �   �6y    5{   H   �� 5|   L    6X   �� *IsTargetMonth+	 false6z   .a�5}   P   ��  � ��
 �����6�   5~   M   �� 5   L    6X   �� *	IsToday+ true6t   .a�5�   P   ��  � ��
 �  ��6�   5�   M   5�   E   5�   =   5�   ;   5�   7   5�   3   5�   /   5�   +   5�   '   ��5�   "   �� 5�   &   .R�5�   *   A� $ 6��66   $ 7��6?   5�   '   5�      5�      5�      5�      5�      5�      5�      