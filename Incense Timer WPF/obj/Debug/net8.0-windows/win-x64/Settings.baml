   M S B A M L   `   `   `  ����L  HIncense Timer WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Incense_Timer_WPFIncense_Timer_WPF  5   	        Incense_Timer_WPF.Settings   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Incense_Timer_WPF     5   	     � Title$  Settings��5	   	   $	��306��6   $	��306��6'    � WindowStyle$
 None=�63    � AllowsTransparency$
 True��6F    � Icon$ /Images/LIGHTLIGHT.png��6`   
������  � 
ResizeMode$ NoResize=�6�    � WindowStartupLocation$ CenterScreen=�6�   .��5
      � -   5         �Name$ 	main_grid��5
      .+�5   
   �� 
������ ���	#FF24263F �� CornerRadius$ 20��6B   ._�5      � $��0,0,0,0q�6   .+�5      � .+�5      �� -   5         ��Name$ topmostCheckbox��5       +  'MaterialDesignFilterChipOutlineCheckBox#��[  68   ���	#FF707070$��Topmost��6�   	 d� 	IsChecked$	 FalseY�6�   
����������	#FF4F73CC$��	30,98,0,0q�6�   $	��Top=�6�   $��30��6
  $	��115��6  6D  �� 5      $
��Main��6   $��Nirmala UI Semilight)�6+   $��23.25(�6M   
�������$��Center=�6q   $��0,54,0,0q�6�   $	��Top=�6�   �� 5      -   5        $ clockLayoutCheckbox��5      #��[  6<   ���	#FF707070$��Clock Layout��6�   $	 FalseY�6�   
����������	#FF4F73CC$��Center=�6�   $��30��6  $	��115��6  $��30,0,0,0q�6k  �� 5      -   5        $ soundsCheckbox��5      $��Sounds��67   
�������#��[  6[   ���	#FF707070$	 FalseY�6�   ���	#FF4F73CC$��164,98,0,178q�6�   $	��115��6�   $��30��6E  �� 5      $��Nirmala UI Semilight)�6   $��Keybinds��6?   $��23.25(�6R   
�������$��Center=�6v   $��	0,173,0,0q�6�   $	��Top=�6�   �� 5      -   5        
 ��Name$
 StartKeybind_textBox��5       % !MaterialDesignFloatingHintTextBox#��[ 6<    �� 
IsReadOnly$
 True��6w   $��10,237,208,0q�6�   ���	#FF707070
�������$	��Top=�6�   $��34��6�    �� TextAlignment$ Center=�6�   �� 5      $��Nirmala UI Semilight)�6   $��Start Keybind��6>   $��10(�6V   
�������$
��Left=�6w   $��
20,216,0,0q�6�   $	��Top=�6�   $��68��6�   $��21��6�   �� 5      -   5        $
 StopKeybind_textBox��5      #��[ 6;   $
 True��6v   $��109,237,109,0q�6�   ���	#FF707070
�������$	��Top=�6�   $��34��6�   $ Center=�6�   �� 5      $��Nirmala UI Semilight)�6   $��Stop Keybind��6>   $��10(�6U   
�������$��Center=�6v   $��	0,216,0,0q�6�   $	��Top=�6�   $��68��6�   $��21��6�   �� 5      -   5        $
 ResetKeybind_textBox��5      #��[ 6<   $
 True��6w   $��209,237,9,0q�6�   ���	#FF707070
�������$	��Top=�6�   $��34��6�   $ Center=�6�   �� 5      $��Nirmala UI Semilight)�6   $��Reset Keybind��6>   $��10(�6V   
�������$
��Left=�6w   $��219,216,0,0q�6�   $	��Top=�6�   $��68��6�   $��21��6�   �� 5      -   5         ��Name$ resetKeyBindButton��5      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 17��69   $��Nirmala UI Semilight)�6g   $��Reset Keybinds��6�   $��13(�6�   $��30��6�      MaterialDesignOutlinedButton#��[ 6�   ���	#FF707070
�������$��164,138,27,138q�6  
������ $	��115��6o  5      � 5      $��	0,0,0,332q�6   .+�5      �� -	   5        
������ ���	#FF181E36$ 	20,20,0,0��5   N   $��	0,0,0,-53q�6g   ._�5      � .+�5      �� $��/Images/LIGHTLIGHT.png��6$   $��15,-3,259,-4q�6D   �� 5       $��Settings��6$   $��Nirmala UI Semilight)�67   $��19(�6Y   
������ 
�������$
��Left=�6�   $��	52,11,0,0q�6�   $	��Top=�6�   $��38��6�   $��82��6�   �� 5!      -
   5        $�� ��5!   %   $��258,12,17,10q�60   $��31��6F   $��31��6Q   
������ ��5"   "   �� 5#   &    �� ImageSource$ /Images/close.png��61   5%      5&      5'      5(      5)      5*      5+      5,      