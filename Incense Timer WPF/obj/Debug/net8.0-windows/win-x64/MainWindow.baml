   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      L HIncense Timer WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Incense_Timer_WPFIncense_Timer_WPF 5
      "   Incense_Timer_WPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      3System&clr-namespace:System;assembly=mscorlib  5      +localclr-namespace:Incense_Timer_WPF  5
      -   5          � Title$  Incense Timer��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��255��6D   $	��585��6Q    � WindowStyle$
 None=�6]    � AllowsTransparency$
 True��6p   
������  � 
ResizeMode$ NoResize=�6�    � Icon$ /Images/LIGHTLIGHT.png��6�    � DataContext 5      ��  �� RelativeSource �� *Self+.��5      � -   5         �Name$ 	main_grid��5      .+�5   
   �� ���	#FF24263F	 �� CornerRadius$	 20��6(   ._�5      � .+�5      �� -   5        
 ��Name$
 	timeLabel��5      $��00:00.00��6/   $��304,86,122,116q�6?   
�������$��Segoe UI Light)�6j   $��38(�6�   �� 5      -   5         ��Name$ startstopButton��5      $��
Start (F6)��62      MaterialDesignRaisedButton#��[  6H   
�������$
��Left=�6�   $��261,168,0,0q�6�   $	��Top=�6�   ���	#FF24284A
������ $��31��6  $	��110��6  $��12(�6>  5      �� 5      -   5        $ resetButton��5      $��
Reset (F8)��6.   #��[  6C   $
��Left=�6w   
�������$��387,168,0,0q�6�   $	��Top=�6�   ���	#FF24284A
������ $��31��6  $	��110��6  $��12(�65  5      �� 5      -   5        $ settingsButton��5      $��Settings��61    � Cursor$
 Hand��6D   
�������
������ $��10(�6   
������ $
��Left=�6�   $��
508,57,0,0q�6�   $	��Top=�6�   $��77��6�   $��23��6�   6  �� 5      -   5        $
 smudgedatLabel��5      $
��Left=�64   $��314,144,0,0q�6O   $
��Wrap=�6d   $��Smudged at: 00m 00s��6x   
�������$	��Top=�6�   $	��143��6�   5      5      �� 5   
   $��
0,57,390,0q�6   ���	#FF1F1E44$	 0,0,0,20��6<   ._�5      � .+�5      �� $��Ghosts��6   $��
0,10,0,147q�6)   
�������$��Nirmala UI Semilight)�6P   $��30(�6r   $��Center=�6�   �� 5      -   5        $ questionButton��5      #��[  61   
�������$��?��6x   
������ 
������ $
��Left=�6�   $��	154,0,0,0q�6�   $	��Top=�6�   $��30��6�   $��41��6	  $��20(�61   J� RenderTransformOrigin$ 0.5,0.5&�6?  z�5       V� 5!      .~�5"      �� �� 5#       �� AngleY$ 0Q�6,   �� 5$      T� 5%       T� Y$ 0Q�61   5&      5(      �� 5)      -	   5         ��Name$ 
demonLabel��5)      $��Demon��6,   
���  ��$��Center=�6M   $��Nirmala UI Semilight)�6j   $��20(�6�   $��0,62,0,0q�6�   $	��Top=�6�   �� 5*      -
   5        $ regularLabel��5*      $��Regular��6.   
���  ��$��Center=�6Q   $��Nirmala UI Semilight)�6n   $��20(�6�   $	��Top=�6�   $��0,98,0,0q�6�   �� 5+      -   5        $ spiritLabel��5+      $��Spirit��6-   
���  ��$��Center=�6O   $��Nirmala UI Semilight)�6l   $��20(�6�   $��	0,134,0,0q�6�   $	��Top=�6�   5,      5-      �� 5.   
   -   5        ���	#FF181E36$	 	20,20,0,0��5.   (   $��	0,0,0,198q�6A   ._�5/      �  � ColumnDefinitions 50      �� 51      $
��202* �6'   �� 52      $
��383* �6'   .+�54      �� $��Incense Timer��6   
�������$	��140��6C   $��Nirmala UI Semilight)�6O   $��20.25(�6q   $��37��6�   $��
58,10,4,10q�6�   �� 55      $��16,13,146,12q�6   $��/Images/LIGHTLIGHT.png��6.   56      57      �� 58   
   -   5        $ 
exitButton��58      #��[  6%   $�� ��6Y   
������ $
 Hand��6~   $
��Left=�6�   
�������$��
529,13,0,0q�6�   $	��Top=�6�   $��31��6�   $��31��6�   ��59      �� 5:       �� ImageSource$ /Images/close.png��6   5<      �� 5=   
   -   5        $ minimiseButton��5=      
������ #��[  6C   $�� ��6w   $
��Left=�6�   
�������$��
490,13,0,0q�6�   $	��Top=�6�   $
 Hand��6�   $��31��6�   $��31��6�   ��5>      �� 5?      $ /Images/minimize.png��6   5A      5C      5D      