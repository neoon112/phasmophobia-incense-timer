   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  L HIncense Timer WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Incense_Timer_WPFIncense_Timer_WPF "   Incense_Timer_WPF.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  :d2http://schemas.microsoft.com/expression/blend/2008  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  3System&clr-namespace:System;assembly=mscorlib  +localclr-namespace:Incense_Timer_WPF  -     � Title$  Incense Timer�� � WindowStartupLocation$ CenterScreen=�$	��255��$	��585�� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������  � 
ResizeMode$ NoResize=� � Icon$ /Images/LIGHTLIGHT.png�� � DataContext ��  �� RelativeSource �� *Self+.��� -    �Name$ 	main_grid��.+��� ���	#FF24263F	 �� CornerRadius$	 20��._�� .+��� -   
 ��Name$
 	timeLabel��$��00:00.00��$��304,86,122,116q�
�������$��Segoe UI Light)�$��38(��� -    ��Name$ startstopButton��$��
Start (F6)��   MaterialDesignRaisedButton#��[  
�������$
��Left=�$��261,168,0,0q�$	��Top=����	#FF24284A
������ $��31��$	��110��$��12(��� -   $ resetButton��$��
Reset (F8)��#��[  $
��Left=�
�������$��387,168,0,0q�$	��Top=����	#FF24284A
������ $��31��$	��110��$��12(��� -   $ settingsButton��$��Settings�� � Cursor$
 Hand��
�������
������ $��10(�
������ $
��Left=�$��
508,57,0,0q�$	��Top=�$��77��$��23���� -   $
 smudgedatLabel��$
��Left=�$��314,144,0,0q�$
��Wrap=�$��Smudged at: 00m 00s��
�������$	��Top=�$	��143���� $��
0,57,390,0q����	#FF1F1E44$	 0,0,0,20��._�� .+��� $��Ghosts��$��
0,10,0,147q�
�������$��Nirmala UI Semilight)�$��30(�$��Center=��� -   $ questionButton��#��[  
�������$��?��
������ 
������ $
��Left=�$��	154,0,0,0q�$	��Top=�$��30��$��41��$��20(� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� ��  �� AngleY$ 0Q��� T�  T� Y$ 0Q��� -	    ��Name$ 
demonLabel��$��Demon��
���  ��$��Center=�$��Nirmala UI Semilight)�$��20(�$��0,62,0,0q�$	��Top=��� -
   $ regularLabel��$��Regular��
���  ��$��Center=�$��Nirmala UI Semilight)�$��20(�$	��Top=�$��0,98,0,0q��� -   $ spiritLabel��$��Spirit��
���  ��$��Center=�$��Nirmala UI Semilight)�$��20(�$��	0,134,0,0q�$	��Top=��� -   ���	#FF181E36$	 	20,20,0,0��$��	0,0,0,198q�._��  � ColumnDefinitions �� $
��202* ��� $
��383* �.+��� $��Incense Timer��
�������$	��140��$��Nirmala UI Semilight)�$��20.25(�$��37��$��
58,10,4,10q��� $��16,13,146,12q�$��/Images/LIGHTLIGHT.png���� -   $ 
exitButton��#��[  $�� ��
������ $
 Hand��$
��Left=�
�������$��
529,13,0,0q�$	��Top=�$��31��$��31������  �� ImageSource$ /Images/close.png���� -   $ minimiseButton��
������ #��[  $�� ��$
��Left=�
�������$��
490,13,0,0q�$	��Top=�$
 Hand��$��31��$��31������ $ /Images/minimize.png��