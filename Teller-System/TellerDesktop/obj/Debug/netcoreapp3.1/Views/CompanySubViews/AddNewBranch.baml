   M S B A M L   `   `   `  ����H  DTellerDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TellerDesktopTellerDesktop  5           TellerDesktop.AddNewBranch   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:TellerDesktop     5      -   5          >�Name$  TheUser��5      .��5	      �� -   5         ��Name$ 	Container��5	      ���#5D6B99 �� CornerRadius$ 10��66    � Triggers 5
   
   :� 5       :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Height�6*    �� 
TargetName$ 	Container��5   *    W� From 05   *    g� Duration$ 0:0:0.5D�5   *   		 W� To	 5   3   �� *ActualHeight+
 �� ElementName$
 TheUser��5      5      5      5      ._�5   
   �� 
�������$��5,5,5,5q�6$   ._�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      �� $��0��6   $ ��إضافة فرع جديد��5      $��Right=�5        	  TBold#��[  68   $
��Bold"�5!      $��16(�6.   $��	0,10,10,0q�6<     MainDarkBrush#��[ 5"      � 5#      $��1��6    � ColumnDefinitions 5$      �� 5%      $��* �6+   �� 5&      $
��auto �6+    5(      �� 5)      $
��auto �6(   �� 5*      $
��auto �6(   �� 5+      $
��auto �6(   �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   .+�5/      �� $��Right=�6      TRegular#��[ 6<   $��Regular"�50      $��14(�61   $��	5,10,10,0q�6?   #��[ 51      $��2��52       $��0��60   $��اسم الفرع��53       �� 54      $��0��6   $��0��6.   $��10,5,5,5q�55   !   ��56      �� *
BranchName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 57      $��Right=�6    #��[ 6<   $��Regular"�58      $��14(�61   $��	5,10,10,0q�6?   #��[ 59      $��2��5:       $��1��60   $#��العملة الرئيسية��5;       �� 5<      -   5        $��
Currencies��5<   1   $��10,5,5,5q�6   $��1��6C    �� DisplayMemberPath$
 Name��5=   B   ��6   �� *
Currencies+ �� SelectedItem 5>      �� *SelectedCurrency+$ TwoWay=�$ PropertyChanged=��� 5?        DefaultButton#��[ 6   $��10,5,5,5q�6D   $��2��5@      $
��تم��6*   ��67   �� *AcceptCommand+5A      5B      5C      5D      5E      