   M S B A M L   `   `   `  ���� L  HIncense Timer WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Incense_Timer_WPFIncense_Timer_WPF       Incense_Timer_WPF.Settings   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Incense_Timer_WPF       � Title$  Settings��$	��306��$	��306�� � WindowStyle$
 None=� � AllowsTransparency$
 True�� � Icon$ /Images/LIGHTLIGHT.png��
������  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� -    �Name$ 	main_grid��.+��� 
������ ���	#FF24263F �� CornerRadius$ 20��._�� $��0,0,0,0q�.+�� .+��� -    ��Name$ topmostCheckbox�� +  'MaterialDesignFilterChipOutlineCheckBox#��[  ���	#FF707070$��Topmost��	 d� 	IsChecked$	 FalseY�
����������	#FF4F73CC$��	30,98,0,0q�$	��Top=�$��30��$	��115���� $
��Main��$��Nirmala UI Semilight)�$��23.25(�
�������$��Center=�$��0,54,0,0q�$	��Top=��� -   $ clockLayoutCheckbox��#��[  ���	#FF707070$��Clock Layout��$	 FalseY�
����������	#FF4F73CC$��Center=�$��30��$	��115��$��30,0,0,0q��� -   $ soundsCheckbox��$��Sounds��
�������#��[  ���	#FF707070$	 FalseY����	#FF4F73CC$��164,98,0,178q�$	��115��$��30���� $��Nirmala UI Semilight)�$��Keybinds��$��23.25(�
�������$��Center=�$��	0,173,0,0q�$	��Top=��� -   
 ��Name$
 StartKeybind_textBox�� % !MaterialDesignFloatingHintTextBox#��[  �� 
IsReadOnly$
 True��$��10,237,208,0q����	#FF707070
�������$	��Top=�$��34�� �� TextAlignment$ Center=��� $��Nirmala UI Semilight)�$��Start Keybind��$��10(�
�������$
��Left=�$��
20,216,0,0q�$	��Top=�$��68��$��21���� -   $
 StopKeybind_textBox��#��[ $
 True��$��109,237,109,0q����	#FF707070
�������$	��Top=�$��34��$ Center=��� $��Nirmala UI Semilight)�$��Stop Keybind��$��10(�
�������$��Center=�$��	0,216,0,0q�$	��Top=�$��68��$��21���� -   $
 ResetKeybind_textBox��#��[ $
 True��$��209,237,9,0q����	#FF707070
�������$	��Top=�$��34��$ Center=��� $��Nirmala UI Semilight)�$��Reset Keybind��$��10(�
�������$
��Left=�$��219,216,0,0q�$	��Top=�$��68��$��21���� -    ��Name$ resetKeyBindButton��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 17��$��Nirmala UI Semilight)�$��Reset Keybinds��$��13(�$��30��   MaterialDesignOutlinedButton#��[ ���	#FF707070
�������$��164,138,27,138q�
������ $	��115��� $��	0,0,0,332q�.+��� -	   
������ ���	#FF181E36$ 	20,20,0,0��$��	0,0,0,-53q�._�� .+��� $��/Images/LIGHTLIGHT.png��$��15,-3,259,-4q��� $��Settings��$��Nirmala UI Semilight)�$��19(�
������ 
�������$
��Left=�$��	52,11,0,0q�$	��Top=�$��38��$��82���� -
   $�� ��$��258,12,17,10q�$��31��$��31��
������ ����  �� ImageSource$ /Images/close.png��