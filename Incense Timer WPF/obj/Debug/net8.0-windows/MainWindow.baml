   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      L HIncense Timer WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Incense_Timer_WPFIncense_Timer_WPF 5
      "   Incense_Timer_WPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      9System&clr-namespace:System;assembly=mscorlib     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      +localclr-namespace:Incense_Timer_WPF  5
      -   5          � Title$  
MainWindow��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��255��6A   $	��585��6N    � WindowStyle$
 None=�6Z    � AllowsTransparency$
 True��6m   
������  � 
ResizeMode$ NoResize=�6�    � Icon$ /LIGHTLIGHT.png��6�    � DataContext 5      ��  �� RelativeSource �� *Self+.��5      � .+�5   
   �� ���	#FF24263F �� CornerRadius$ 20��6(   ._�5      � .+�5      �� -   5        	 ��Name$	 	timeLabel��5      $��00:00.00��6/   $��304,86,138,116q�6?   
�������$��Segoe UI Light)�6j   $��38(�6�   �� 5      -   5        
 ��Name$
 startstopButton��5      $��
Start (F6)��62      MaterialDesignRaisedButton#��[  6G   $
��Left=�6{   $��266,168,0,0q�6�   $	��Top=�6�   ���	#FF24284A
������ $��31��6�   $��96��6   6  �� 5      -   5        $
 resetButton��5      $��
Reset (F8)��6.   #��[  6C   $
��Left=�6w   $��387,168,0,0q�6�   $	��Top=�6�   ���	#FF24284A
������ $��31��6�   $��96��6�   6  5      5      �� 5   
   $��
0,57,390,0q�6   ���	#FF1F1E44$ 0,0,0,20��6<   ._�5      � .+�5      �� $��Ghosts��6   $��
6,3,61,154q�6)   
�������$��Nirmala UI Semilight)�6P   $��30(�6r   �� 5      -   5        $
 questionButton��5      #��[  61   $��?��6e   
������ 
������ $
��Left=�6�   $��	153,0,0,0q�6�   $	��Top=�6�   $��33��6�   $��42��6�   $��20(�6  5      �� 5      -   5         ��Name$ 
demonLabel��5      $��Demon��6,   
���  ��$
��Left=�6M   $��Nirmala UI Semilight)�6h   $��25(�6�   $��	49,55,0,0q�6�   $	��Top=�6�   �� 5      -   5        $ regularLabel��5      $��Regular��6.   
���  ��$
��Left=�6Q   $��Nirmala UI Semilight)�6l   $��25(�6�   $��	49,96,0,0q�6�   $	��Top=�6�   �� 5      -   5        $ spiritLabel��5      $��Spirit��6-   
���  ��$
��Left=�6O   $��Nirmala UI Semilight)�6j   $��25(�6�   $��
49,136,0,0q�6�   $	��Top=�6�   �� 5       $	��●��6   
�������$
��Left=�67   $��Nirmala UI Semilight)�6R   $��17(�6t   $��	30,59,0,0q�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.684,0.692&�6�   �� 5!      $	��●��6   
�������$
��Left=�67   $��Nirmala UI Semilight)�6R   $��17(�6t   $��
30,102,0,0q�6�   $	��Top=�6�   $ 0.938,0.716&�6�   �� 5"      $	��●��6   
�������$
��Left=�67   $��Nirmala UI Semilight)�6R   $��17(�6t   $��
30,140,0,0q�6�   $	��Top=�6�   5#      5$      �� 5%   
   -	   5        ���	#FF181E36$ 	20,20,0,0��5%   (   $��	0,0,0,198q�6A   ._�5&      �  � ColumnDefinitions 5'      �� 5(      $
��202* �6'   �� 5)      $
��383* �6'   .+�5+      �� $��Incense Timer��6   
�������$	��140��6C   $��Nirmala UI Semilight)�6O   $��20.25(�6q   $��37��6�   $��
58,10,4,10q�6�   �� 5,      $��16,13,146,12q�6   $��/LIGHTLIGHT.png��6.   5-      5.      �� 5/   
   -
   5        $
 
exitButton��5/      #��[  6%   $�� ��6Y   
������  � Cursor$
 Hand��6~   $
��Left=�6�   
�������$��
529,13,0,0q�6�   $	��Top=�6�   $��31��6�   $��31��6�   ��50      �� 51       �� ImageSource$ 
/close.png��6   53      �� 54   
   -   5        $
 minimiseButton��54      #��[  6)   $�� ��6]   $
��Left=�6h   
�������$��
490,13,0,0q�6�   $	��Top=�6�   $
 Hand��6�   $��31��6�   $��31��6�   ��55      �� 56      $ /minimize.png��6   ��58      �� 59      $ /minimize.png��6   5;      5<      5=      