   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   
 Kvadro   Kvadro.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -   5          �Name$  MyWindow��5   :    � Title$ UnrealWindow��6	   $	��651��6   $��1358.5��6+    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   <   .��5      � $��
0,0,0,-260q�6   .+�5   
   �� $
��auto��6   
���2�2�$��2q�66    �� CornerRadius$ 	0,30,0,30��5	       J� 	AllowDrop . $��
0,0,60,282q�6;    J� Effect 5
      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 22Q�6#      Opacity$	 0.5Q�64   	   	Direction$		 318Q�6B   ��5      �� 5      ��5      � � 5      
 � Color$
 #e7ebf7��6+    � Offset$	 0.0Q�6;   � 5      $
 #cee3ff��6+   $	 0.5Q�6;   5      5      ._�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      �� 5      $
��auto �6$   .+�5      �� -   5        $��      Kvadro App��5       �� Padding$ 5q�64   6V   �� 5       -   5         ��Name$ cmdClose��5       $��Right=�6+   $��
500,5,30,0q�6^   $��x��6r    � Cursor$ UpArrow��6~   � 5#      $��1��6   ���#B5CBEF4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm . .+�5$      �� $��Center=�6    $��18(�6;   
�������$��Center=�5%   3   �� 6Q   $�This is listBox: ��6U   6q   �� 5'      -   5         ��Name$ Par_Types_Cmb��5'      $
��Left=�66   $��1115,33,0,0q�6Q   $	��Top=�6f   $	��169��6~   $��Times New Roman)�6�   $��14(�6�    �� SelectedIndex$ 1��6�   .@�5(      ��Parallel output��69   ��5)      Standart output��69   ��5*      Parallel with order output��6D   5+      �� 5,      -   5        $ 
Output_Btn��5,      $��GET DATA��61   $
��Left=�6D   $��1169,63,0,0q�6_   $	��Top=�6t   $	��115��6�   $��Times New Roman)�6�   $��14(�6�   $��29��6�   �� 5-      -   5         ��Name$ ListOut��5-      $
��Left=�6/   $��
10,306,0,0q�6J   $	��Top=�6^   $
��1096��6v   $	��236��6�   �� 5.      -   5         ��Name$ TextOut��5.      $
��Left=�6/   $��	10,28,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $
��1096��6�   $��Times New Roman)�6�   $��14(�6�   $	��236��6�    �� AcceptsReturn .  �� 
AcceptsTab . $ �� HorizontalScrollBarVisibility$
 Auto=�6�   " �� VerticalScrollBarVisibility$ Visible=�6  ��. 6@  �� 5/      -   5         ��Name$ Timer2��5/       $
��Left=�60   $��1204,164,0,0q�6K   $
��Wrap=�6a   $��	_________��6u   $	��Top=�6�   $��Times New Roman)�6�   $��16(�6�    J� RenderTransformOrigin$ -1.214,-3.354&�6�   �� 50      -	   5        $ Timer1��50       $
��Left=�60   $��1204,126,0,0q�6K   $
��Wrap=�6a   $��	_________��6u   $	��Top=�6�   $��Times New Roman)�6�   $��16(�6�   �� 51      -
   5        $ Clear��51      $��textBox Clear��6,   $
��Left=�6D   $��1170,229,0,0q�6_   $	��Top=�6u   $	��115��6�   $��Times New Roman)�6�   $��14(�6�   6�   �� 52      -   5        $��listBox Clear��52      $
��Left=�65   $��1170,256,0,0q�6P   $	��Top=�6f   $	��115��6~   $��Times New Roman)�6�   $��14(�6�   6�   �� 53      -   5        $ 
TypeChoose��53      $
��Left=�63   $��
1115,8,0,0q�6N   $	��Top=�6b   $	��169��6z   $ 0��6�   $��Times New Roman)�6�   $��14(�6�   .@�54      ��textBox��61   ��55      listBox��61   56      �� 57      $
��Left=�6    $��	972,4,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $��Times New Roman)�6z   $��16(�6�   �� 6�   $�Change input form:��6�   �� 6�   �� 6�   6�   �� 58      -   5        $ Count��58       $
��Left=�6/   $��1250,208,0,0q�6J   $
��Wrap=�6`   $	��Top=�6t   $��Times New Roman)�6�   $��0��6�   $��14(�6�   �� 59      $
��Left=�6    $��1127,208,0,0q�6;   $
��Wrap=�6Q   $��Records outputted:��6e   $	��Top=�6   $��Times New Roman)�6�   $��14(�6�   �� 5:      -   5        $ Timer1_Copy��5:       $
��Left=�65   $��1121,126,0,0q�6P   $
��Wrap=�6f   $��для textBox��6z   $	��Top=�6�   $��Times New Roman)�6�   $��16(�6�   �� 5;      -   5        $ Timer2_Copy��5;       $
��Left=�65   $��1121,164,0,0q�6P   $
��Wrap=�6f   $��для listBox��6z   $	��Top=�6�   $��Times New Roman)�6�   $��16(�6�   �� 5<      $��
Lead time:��6   $
��Left=�63   $	��100��6N   $��1116,97,0,0q�6[   $	��Top=�6p   $	��169��6�   $��Times New Roman)�6�   $��16(�6�   |�. ���	#FF085C8F6�   �� 5=      $
��Left=�6#   $��1��6>   $��1106,571,0,0q�6I   $	��Top=�6_   $��0��6w   �� 5>      $��Center=�6    $��18(�6;   
�������$��Center=�5?   ,   $��591,-1,590,549q�6I   �� 6b   $�This is textBox:��6f   6�   �� 5@      $�� ��6   $
��Left=�6)   $��87��6D   $��1116,197,0,0q�6P   $	��Top=�6f   $	��173��6~   $��Times New Roman)�6�   �� 5A      $�� ��6   $
��Left=�6)   $	��103��6D   $��1111,-6,0,0q�6Q   $	��Top=�6f   $	��180��6~   �� 5B      -   5        $ Button1_Copy��5B   l   $��Project��6   $��63��6/   $
��Left=�6;   $��1121,377,0,0q�6V   $	��Top=�6�   $	��170��6�   $��Showcard Gothic)�6�   $��36(�6�   ��5C      �� 5D       �� ImageSource$ Resources/images.jpg��6)   5F      �� 5G      -   5        $ Button1_Copy1��5G   n   $��	Customers��6   $��66��61   $
��Left=�6=   $��1121,306,0,0q�6X   $	��Top=�6�   $	��170��6�   $��Showcard Gothic)�6�   $��24(�6�   ��5H      �� 5I      $ Resources/images.jpg��6)   5K      �� 5L      $
��Left=�6    $��1121,289,0,0q�6;   $
��Wrap=�6Q   $��Using Entity EDM Model:��6e   $	��Top=�6�   $��Times New Roman)�6�   $��14(�6�   �� 5M      $
��Left=�6    $��1127,445,0,0q�6;   $
��Wrap=�6Q   $��Using ADO.NET:��6e   $	��Top=�6{   $��Times New Roman)�6�   $��14(�6�   �� 5N      -   5        $ Button1_Copy2��5N   m   $��Employee��6   $��65��60   $
��Left=�6<   $��1121,461,0,0q�6W   $	��Top=�6�   $	��170��6�   $��Showcard Gothic)�6�   $��30(�6�   ��5O      �� 5P      $ Resources/images.jpg��6)   5R      5S      �� 5T      $��Odessa 2017��6   $ 5q�6/   $��2��6;   $��Center=�6H   $��Times New Roman)�6e   $��14(�6�   �� 5U      $
��Left=�6   $��20��63   $��2,0,0,4q�6?   $��Bottom=�6P   $��19��6k   $��Resources/MainImage.bmp��6v   5V      5W      �� 5X   
   $�� ��6   $
��Left=�6   $	��258��68   $��6,42,0,0q�6E   $	��Top=�6W   $
��1110��6o   .��5Y      �� $�� ��6   $
��Left=�6!   $	��259��6<   $��-6,261,-5,-284q�6I   $	��Top=�6a   $
��1109��6y   5Z      �� 5[   
   -   5         ��Name$ mainImg��5[      $
��Left=�6!   $	��568��6<   $��0,31,0,0q�6I   $	��Top=�6[   $
��1298��6s   $��Resources/images.jpg��6�   $
��Fill=�6�    J� IsHitTestVisible .  J� Opacity$
 0.22Q�6�   $y�	Collapsed=�6�   5\      5]      