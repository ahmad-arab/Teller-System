   M S B A M L   `   `   `  ����d  `PresentationFramework.Classic, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35jMclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.ClassicMicrosoft.Windows.Themes  5   L   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   FocusVisual  �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  TextBox.Static.Background �� Color  ComboBoxEditableTextBox �� 
TargetType �� 
TargetType ��Name  ComboBox.Static.Background �� EndPoint	 �� 
StartPoint
 � Color � Offset  ComboBox.Static.Border  ComboBox.Static.Glyph ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background *	 &ComboBox.Static.Editable.Button.Border !
 ComboBox.MouseOver.Background  ComboBox.MouseOver.Border  ComboBox.MouseOver.Glyph * &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Background  ComboBox.Pressed.Border  ComboBox.Pressed.Glyph ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background + 'ComboBox.Pressed.Editable.Button.Border   ComboBox.Disabled.Background  ComboBox.Disabled.Border  ComboBox.Disabled.Glyph ) %ComboBox.Disabled.Editable.Background % !ComboBox.Disabled.Editable.Border 0 ,ComboBox.Disabled.Editable.Button.Background , (ComboBox.Disabled.Editable.Button.Border  ComboBoxToggleButton ��Name   
WhiteBrush �� CornerRadius F�Name �� Triggers ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value �� 
TargetName P� Property P� Value ! MainDarkBrush " ComboBoxEditableTemplate �Name � ColumnDefinitions �Name � AllowsTransparency5    /Microsoft.Windows.Themes.SystemDropShadowChrome   Name    Color �� MaxDropDownHeight �� ElementName  �� ClearTypeHint! ��Name" ��Name# ��Name-  'System.Windows.Input.KeyboardNavigation$   DirectionalNavigation% d�Name& d� 	IsChecked' �� Mode( ��Name) �� 
IsReadOnly* P� 
SourceName+ ]� 
Conditions, �� Property # ComboBoxTemplate- ��Name. �� SelectionBoxItemTemplate/ �� SelectionBoxItem#0 �� SelectionBoxItemStringFormat1 �� ContentStringFormat2 J� IsHitTestVisible $ TRegular3 �� Triggers�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      WthemeMclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Classic  6L   %s/  &	        &	 �     &	 �     &	     &	 �    &	 �    &	 �    &	     &	 5    &		 Z    &	
     &	     &	 >    &	 a    &	 �    &	 �    &	 C    &	 f    &	     &	 %    &	 H    &	 k    &	 �    &	 *    &	 M    &	 p    &	 �    &	 �    &	 �    &	 �    &	 !	    &	 F	    7   7  7  7  7  7  7 	 7  7 
 7 ! 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	" �    7  7  7  &	# q!    7  '�� 5*    7   7  7  7 # 7 $ 7 " �� 5      .�5   
   ��   � �� 5      �� 5      .R�5      �� $��2q�6    $	 1 2R�6+   $
 true��6A   $��1��6\   #��� ��6p   5      5
      5      �� 5      $ 	#FFFFFFFF��68   �� 5      " ��6,   .�5   
   ��   �@�OverridesDefaultStyle$
 true��62   �� 5   
     �@J�	AllowDrop$
 true��6&   �� 5   
     � ��$ 0��6%   �� 5   
     � ��$ 0��6&   �� 5   
     �@�FocusVisualStyle 6-   Z� �� 5   
     �@��PanningMode$ VerticalFirst=�65   �� 5   
     �@��IsFlicksEnabled$ False��63   �� 5   
     � �� 5      �� 5      " ��6"   .R�5      �� $ PART_ContentHost��6#   
������ $|�false��6V   $��Hidden=�6h   $��Hidden=�6�   5      5      5      �� 5      $	 0,1&�6=   $		 0,0&�6L   .��5   
   � $
 	#FFF0F0F0��6   $	 0.0Q�6)   � 5   
   $
 	#FFE5E5E5��6   $	 1.0Q�6)   5       �� 5!      $ 	#FFACACAC��65   �� 5"      $ 	#FF606060��64   �� 5#      $ 	#FFFFFFFF��6B   �� 5$      $ 	#FFABADB3��6>   �� 5%      $ Transparent��6I   �� 5&      $ Transparent��6E   �� 5'      $	 0,1&�6@   $		 0,0&�6O   .��5(   
   � $
 	#FFECF4FC��6   $	 0.0Q�6)   � 5)   
   $
 	#FFDCECFC��6   $	 1.0Q�6)   5*      �� 5+      $ 	#FF7EB4EA��68   �� 5,      $ 	#FF000000��67   �� 5-      $ 	#FFFFFFFF��6E   �� 5.      $ 	#FF7EB4EA��6A   �� 5/      $	 0,1&�6P   $		 0,0&�6_   .��50   
   � $
 	#FFEBF4FC��6   $	 0.0Q�6)   � 51   
   $
 	#FFDCECFC��6   $	 1.0Q�6)   52      �� 53      $ 	#FF7EB4EA��6H   �� 54      $	 0,1&�6>   $		 0,0&�6M   .��55   
   � $
 	#FFDAECFC��6   $	 0.0Q�6)   � 56   
   $
 	#FFC4E0FC��6   $	 1.0Q�6)   57      �� 58      $ 	#FF569DE5��66   �� 59      $ 	#FF000000��65   �� 5:      $ 	#FFFFFFFF��6C   �� 5;      $ 	#FF569DE5��6?   �� 5<      $	 0,1&�6N   $		 0,0&�6]   .��5=   
   � $
 	#FFDAEBFC��6   $	 0.0Q�6)   � 5>   
   $
 	#FFC4E0FC��6   $	 1.0Q�6)   5?      �� 5@      $ 	#FF569DE5��6F   �� 5A      $ 	#FFF0F0F0��6;   �� 5B      $ 	#FFD9D9D9��67   �� 5C      $ 	#FFBFBFBF��66   �� 5D      $ 	#FFFFFFFF��6D   �� 5E      $ 	#FFBFBFBF��6@   �� 5F      $ Transparent��6K   �� 5G      $ Transparent��6G   �� 5H      " d�6)   .�5I   
   ��   �@�OverridesDefaultStyle$
 true��62   �� 5J   
     � ��$ false��6&   �� 5K   
     � |�$ false��6&   �� 5L   
     �@��	ClickMode$ Press=�6&   �� 5M   
     � �� 5N      �� 5O      " d�6"   .R�5P      �� $ templateRoot��6   8��  #��z��6\   8�� $
 true��6�   $ 10��6�   ._�5Q      �� $ splitBorder��6!   $��1q�66   
������ $��Right=�6d   $��0q�6�   $
 true��6�   #��� r�6�   ._�5R      F� $ arrow��6#   F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�6�   $��0q�6�   $��Center=�6�   5S      5T       5U      ^� 5V       5W      �� 5X   "    6,   �� *
IsEditable+ �� " �� true6�   �� 5Y   "    6,   �� *IsMouseOver+ �� *Self+	 false6r   �� 5Z   "    6,   �� *	IsPressed+ �� *Self+	 false6p   �� 5[   "    6,   �� *	IsEnabled+ �� *Self+ true6p   .0�5]      �� $ templateRoot��6;   8    � ��6U   �� 5^      $ templateRoot��6<   8    � ��6V   �� 5_      $ splitBorder��6;   8    � ��6T   �� 5`      $ splitBorder��6<   8    � ��6U   5a      P� 5b       �@J�IsMouseOver$
 true��69   . �5c      �� $ arrow��65   8    � ��6H   5d      ^� 5e       5f      �� 5g   "    6,   �� *IsMouseOver+ �� *Self+ true6r   �� 5h   "    6,   �� *
IsEditable+ �� " ��	 false6�   .0�5j      �� $ templateRoot��6;   8    � ��6U   �� 5k      $ templateRoot��6<   8 	   � ��6V   5l      ^� 5m       5n      �� 5o   "    6,   �� *IsMouseOver+ �� *Self+ true6r   �� 5p   "    6,   �� *
IsEditable+ �� " �� true6�   .0�5r      �� $ templateRoot��6;   8 
   � ��6U   �� 5s      $ templateRoot��6<   8    � ��6V   �� 5t      $ splitBorder��6;   8    � ��6T   �� 5u      $ splitBorder��6<   8    � ��6U   5v      P� 5w       � ��$
 true��67   . �5x      �� $ arrow��65   8    � ��6H   5y      ^� 5z       5{      �� 5|   "    6,   �� *	IsPressed+ �� *Self+ true6p   �� 5}   "    6,   �� *
IsEditable+ �� " ��	 false6�   .0�5      �� $ templateRoot��6;   8    � ��6U   �� 5�      $ templateRoot��6<   8    � ��6V   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsPressed+ �� *Self+ true6p   �� 5�   "    6,   �� *
IsEditable+ �� " �� true6�   .0�5�      �� $ templateRoot��6;   8    � ��6U   �� 5�      $ templateRoot��6<   8    � ��6V   �� 5�      $ splitBorder��6;   8    � ��6T   �� 5�      $ splitBorder��6<   8    � ��6U   5�      P� 5�       � {�$ false��67   . �5�      �� $ arrow��65   8    � ��6H   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsEnabled+ �� *Self+	 false6p   �� 5�   "    6,   �� *
IsEditable+ �� " ��	 false6�   .0�5�      �� $ templateRoot��6;   8    � ��6U   �� 5�      $ templateRoot��6<   8    � ��6V   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsEnabled+ �� *Self+	 false6p   �� 5�   "    6,   �� *
IsEditable+ �� " �� true6�   .0�5�      �� $ templateRoot��6;   8    � ��6U   �� 5�      $ templateRoot��6<   8    � ��6V   �� 5�      $ splitBorder��6;   8    � ��6T   �� 5�      $ splitBorder��6<   8    � ��6U   5�      5�      5�      5�      �� 5�      " ��67   .R�5�   
   � $ templateRoot��6   $
 true��6%    5�      �� 5�      $��* �6#   �� 5�      #��� r�6#   $��0 �6v   .+�5�      � $ 
PART_Popup��6   $
 true��6(   $��2��6B   $��Bottom=�6�   #��� .�6�   ��6V   �� *IsDropDownOpen+ �� *TemplatedParent+.��5�         $ shadow��6/   $ Transparent��6?   #��z 6�   ��6S   �� *ActualWidth+$ templateRoot��._�5�      �� $ dropDownBorder��6   #��� ��65   $��1q�6{   #��� ��6�   ._�5�      �� $ DropDownScrollViewer��6'   .��5�      � $
 grid��6#   $  Enabled=�61   .+�5�   "   �� $! canvas��6)   $
��Left=�69   $��0��6T   $	��Top=�6_   $��0��6w   .+�5�   &   �� $" 
opaqueRect��60   ��6D   �� *
Background+$ dropDownBorder����6|   �� *ActualHeight+$ dropDownBorder����6�   �� *ActualWidth+$ dropDownBorder��5�   #   �� 5�   "   $# ItemsPresenter��61   $$ 	Contained=�6I   # z 6~   5�      5�      5�      5�      5�      d� 5�      $% toggleButton��6   #��z��61   #��z��6[   #��z��6�   $��2��6�   8��  & 6�   �� *IsDropDownOpen+$' TwoWay=� �� *TemplatedParent+62  �� 5�      $ border��6   8�� #��z��6]   ._�5�      �� $( PART_EditableTextBox��6   #��z��68   #��z��6�   8�� #��z��6)  ) 6�   �� *
IsReadOnly+ �� *TemplatedParent+6)  5�      5�       5�   
   P� 5�       � {�$ false��6+   . �5�      �� $ border��6,     �@J�Opacity$
 0.56Q�6@   5�      P� 5�       �@J�IsKeyboardFocusWithin$
 true��67   . �5�      ��   � ��
 �   �6/   5�      P� 5�      $* 
PART_Popup��6/    �@�HasDropShadow$
 true��6G   . �5�      �� $ shadow��6+     � ��$ 0,0,5,5q�6?   �� 5�      $ shadow��6*     �@  Color$ 	#71000000��6>   5�      P� 5�       �@��HasItems$ false��6*   . �5�      �� $ dropDownBorder��6+     � ��$ 95��6G   5�      ]� 5�      + 5�      �� 5�      , �@��
IsGrouping$
 true��66   �� 5�      ", �@%�IsVirtualizingWhenGrouping$ false��6X   ./�5�      ��   � ��$ false��6B   5�      P� 5�      $* DropDownScrollViewer��6?    � ��$ false��6a   . �5�      �� $ 
opaqueRect��6/    6G   �� *VerticalOffset+$ DropDownScrollViewer��  �@��Top�� 5�      $ 
opaqueRect��60    6H   �� *HorizontalOffset+$ DropDownScrollViewer��  �@��Left5�      5�      �� 5�      " ��6/   .R�5�   
   � $ templateRoot��6   $
 true��6%    5�      �� 5�      $��* �6#   �� 5�      #��� r�6#   $��0 �6v   .+�5�      � $ 
PART_Popup��6   $
 true��6(   $��2��6B   $��1q�6�   $��Bottom=�6�   #��� .�6�   ��6V   �� *IsDropDownOpen+$' TwoWay=� �� *TemplatedParent+.��5�         $ shadow��6/   $ Transparent��6?   #��z 6�   ��6S   �� *ActualWidth+$ templateRoot��._�5�      �� $ dropDownBorder��6   #��� ��65   $��1q�6{   #��� ��6�   ._�5�      �� $ DropDownScrollViewer��6'   .��5�      � $
 grid��6#   $  Enabled=�61   .+�5�   "   �� $! canvas��6)   $
��Left=�69   $��0��6T   $	��Top=�6_   $��0��6w   .+�5�   &   �� $" 
opaqueRect��60   ��6D   �� *
Background+$ dropDownBorder����6|   �� *ActualHeight+$ dropDownBorder����6�   �� *ActualWidth+$ dropDownBorder��5�   #   �� 5�   "   $# ItemsPresenter��61   $$ 	Contained=�6I   # z 6~   5�      5�      5�      5�      5�      d� 5�      $% toggleButton��6   #��z��61   #��z��6[   #��z��6�   $��2��6�   8��  & 6�   �� *IsDropDownOpen+$' TwoWay=� �� *TemplatedParent+62  �� 5�      $- contentPresenter��6   #��z. 69   #��z/ 6v   #��z��6�   #1 z0 6�   #��z��6)  $2 false��6l  #��z��6�  # z 6�  #��z��6�  5�       5�      P� 5�      $* 
PART_Popup��6/    �@�HasDropShadow$
 true��6G   . �5�      �� $ shadow��6+     � ��$ 0,0,5,5q�6?   �� 5�      $ shadow��6*     �@  Color$ 	#71000000��6>   5�      P� 5�       �@��HasItems$ false��6*   . �5�      �� $ dropDownBorder��6+     � ��$ 95��6G   5�      ]� 5�      + 5�      �� 5�      , �@��
IsGrouping$
 true��66   �� 5�      ", �@%�IsVirtualizingWhenGrouping$ false��6X   ./�5�      ��   � ��$ false��6B   5�      P� 5      $* DropDownScrollViewer��6?    � ��$ false��6a   . �5     �� $ 
opaqueRect��6/    6G   �� *VerticalOffset+$ DropDownScrollViewer��  �@��Top�� 5     $ 
opaqueRect��60    6H   �� *HorizontalOffset+$ DropDownScrollViewer��  �@��Left5     5     �� 5     " ��6   .�5  
   ��   �@�FocusVisualStyle8   6-   �� 5  
     � ��8  6'   �� 5	  
     � ��8  6(   �� 5
  
     � ��# � ��6'   �� 5  
     � ��$ 1q�6,   �� 5  
     � ��$
 Auto=�6G   �� 5  
     � ��$
 Auto=�6E   �� 5  
     � ��$ 6,3,5,3q�6$   �� 5  
     � ��$
 true��6:   �� 5  
     �@��PanningMode$
 Both=�65   �� 5  
     �@��IsFlicksEnabled$ False��63   �� 5  
     � ��8  6%   �� 5  
     � ��$ Right=�67   �� 5  
     � ��$ 	10,3,10,3q�6$   �� 5  
     � ��$ 14(�6%   �� 5  
     � ��8  6'   3 5  
   P� 5      �@��
IsEditable$
 true��6,   . �5     ��   � ��$ false��6.   �� 5       � ��$ 2q�6,   �� 5       � ��8  6-   5     5     5     