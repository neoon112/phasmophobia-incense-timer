   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  L HIncense Timer WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Incense_Timer_WPFIncense_Timer_WPF "   Incense_Timer_WPF.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9System&clr-namespace:System;assembly=mscorlib     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  +localclr-namespace:Incense_Timer_WPF  -     � Title$  
MainWindow�� � WindowStartupLocation$ CenterScreen=�$	��255��$	��585�� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������  � 
ResizeMode$ NoResize=� � Icon$ /LIGHTLIGHT.png�� � DataContext ��  �� RelativeSource �� *Self+.��� .+��� ���	#FF24263F �� CornerRadius$ 20��._�� .+��� -   	 ��Name$	 	timeLabel��$��00:00.00��$��304,86,138,116q�
�������$��Segoe UI Light)�$��38(��� -   
 ��Name$
 startstopButton��$��
Start (F6)��   MaterialDesignRaisedButton#��[  $
��Left=�$��266,168,0,0q�$	��Top=����	#FF24284A
������ $��31��$��96���� -   $
 resetButton��$��
Reset (F8)��#��[  $
��Left=�$��387,168,0,0q�$	��Top=����	#FF24284A
������ $��31��$��96���� $��
0,57,390,0q����	#FF1F1E44$ 0,0,0,20��._�� .+��� $��Ghosts��$��
6,3,61,154q�
�������$��Nirmala UI Semilight)�$��30(��� -   $
 questionButton��#��[  $��?��
������ 
������ $
��Left=�$��	153,0,0,0q�$	��Top=�$��33��$��42��$��20(��� -    ��Name$ 
demonLabel��$��Demon��
���  ��$
��Left=�$��Nirmala UI Semilight)�$��25(�$��	49,55,0,0q�$	��Top=��� -   $ regularLabel��$��Regular��
���  ��$
��Left=�$��Nirmala UI Semilight)�$��25(�$��	49,96,0,0q�$	��Top=��� -   $ spiritLabel��$��Spirit��
���  ��$
��Left=�$��Nirmala UI Semilight)�$��25(�$��
49,136,0,0q�$	��Top=��� $	��●��
�������$
��Left=�$��Nirmala UI Semilight)�$��17(�$��	30,59,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.684,0.692&��� $	��●��
�������$
��Left=�$��Nirmala UI Semilight)�$��17(�$��
30,102,0,0q�$	��Top=�$ 0.938,0.716&��� $	��●��
�������$
��Left=�$��Nirmala UI Semilight)�$��17(�$��
30,140,0,0q�$	��Top=��� -	   ���	#FF181E36$ 	20,20,0,0��$��	0,0,0,198q�._��  � ColumnDefinitions �� $
��202* ��� $
��383* �.+��� $��Incense Timer��
�������$	��140��$��Nirmala UI Semilight)�$��20.25(�$��37��$��
58,10,4,10q��� $��16,13,146,12q�$��/LIGHTLIGHT.png���� -
   $
 
exitButton��#��[  $�� ��
������  � Cursor$
 Hand��$
��Left=�
�������$��
529,13,0,0q�$	��Top=�$��31��$��31������  �� ImageSource$ 
/close.png���� -   $
 minimiseButton��#��[  $�� ��$
��Left=�
�������$��
490,13,0,0q�$	��Top=�$
 Hand��$��31��$��31������ $ /minimize.png������ $ /minimize.png��