   M S B A M L   `   `   `  ����H  DTellerDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TellerDesktopTellerDesktop  5   	   $    TellerDesktop.PopUpMessageView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TellerDesktop     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ PopUpMessageView��5	   	   $
��auto��6"   $	��500��60    � WindowStartupLocation$ CenterScreen=�5
   	    � Topmost$ False��5   	    � SizeToContent$ Height=�5   	    � WindowStyle$
 None=�5   	   .��5      � -   5         �Name$ MainGrid��5         MainDarkBrush#��[  6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� -   5         ��Name$ TitleBorder��5        MainLightBrush#��[ 6*   $��42��5      $��0��6%   $��2,2,2,0q�62   ._�5      �� 	 �� Orientation$	 
Horizontal=�6   $��Right=�66   .+�5      �� -   5        
 ��Name$
 TheTitle��5        	 TBold#��[ 62   $
��Bold"�5   $   $��16(�66   #��[  5   $   $��Right=�5   $   $��Center=�5   $   $"��رسالة من النظام��5   $   $��0,0,10,0q�5   $   �� 5      -   5         ��Name$ TheImage��5      $��Right=�6.   $��32��6J   $��32��6V   $��0,5,5,5q�5       5      5       �� 5!      -   5        $ ContentBorder��5!        
WhiteBrush#��[ 6,   $��1��5"      $��2,0,2,2q�6&   ._�5#      �  5$      �� 5%      $
��auto �6(   �� 5&      $
��auto �6(   �� 5'      $
��auto �6(   .+�5)      �� -   5        $ PrimaryMessageBox��5)      $��0��68   $��10q�6E   ._�5*      �� $	 Vertical=�6%   $	��478��6<   $��RightToLeft=�6H   $��Right=�6d   .+�5+      �� -   5        $
 PrimaryMessage��5+   (     TRegular#��[ 6@   $��Regular"�5,   $   $��16(�69   #��[  5-   $   $��Center=�5.   $   $
��Wrap=�5/   $   $-��'رسالة أولية من النظام��50   $   51      52      �� 53      -   5        $ SecondaryMessageBox��53      $��1��6:   $��10q�6G   ._�54      �� $	 Vertical=�6%   $	��478��6<   $��RightToLeft=�6H   $��Right=�6d   .+�55      �� -	   5        $
 SecondaryMessage��55   (   #��[ 6B   $��Regular"�56   $   $��14(�69   #��[  57   $   $��Center=�58   $   $
��Wrap=�59   $   $/��)رسالة ثانوية من النظام��5:   $   5;      5<      �� 5>      -
   5        $ 
ButtonsBox��5>      $��2��61   $��10q�6>   ._�5?      �� -   5         ��Name$ ButtonsStackPanel��5?   %   $	 
Horizontal=�6@   $
��auto��6Y   $��Center=�6f   .+�5@      �� -   5         ��Name$ OkButton��5B   5     DefaultButton#��[ 5@   %   $��Right=�5A   )   $
��تم��6E   $��10,10,10,10q�6R   $	��100��5B   )   6G   �� 5C      -   5        $ 	YesButton��5E   5   #��[ 5C   %   $��Right=�5D   )   $��نعم��6E   $��10,10,10,10q�6S   $	��100��5E   )   6H   �� 5F      -   5        $ NoButton��5H   5   #��[ 5F   %   $��Right=�5G   )   $
��لا��6E   $��10,10,10,10q�6R   $	��100��5H   )   6G   5I      5J      5K      5L      5M      5N      