   M S B A M L   `   `   `  ����G  CSatronusNext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SatronusNextSatronusNext  5   	   ?$clr-namespace:SatronusNext.viewModelSatronusNext.viewModel  5   	        SatronusNext.ProgramWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SatronusNext     5   	   7local1$clr-namespace:SatronusNext.viewModel     5   	     � Title$  SatronuNEXT��5	   	   $	��600��6   $
��1000��6*    � Icon$ Resources/logo2.png��67   $	��575��6R   $	��600��6a    � ShowInTaskbar .  � DataContext 5
      +  %SatronusNext.viewModel.EventViewModel  5   
    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ AllStyles.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      .+�5   
   � $��0��6   ���#111221 � RowDefinitions 5      �� 5      $	��240 �6    �� 5      $��80 �6    �� 5      $��80 �6    �� 5      .+�5       � $��3��6    5!      �� 5"      $	��125 �6'   �� 5#      5%      �� 5&      -   5        	 ��Name$	 	UserPhoto��5&      $��0��6(   $��Resources/logo2.png��65   $
��Fill=�6R   �� 5'      -   5        
 ��Name$
 InformButton��5'      $
��auto��6+   $
��auto��69   $��Information��6G   $��1��6x      buttonStyle#��[  6�   $��36(�6�   �� 5(      -   5        $
 UserInformationButton��5(      $
��auto��64   $
��auto��6B   $��
Users Data��6s   $��2��6�   #��[  6�   $��36(�6�   5)      � 5*   
   $��1��6    5+      �� 5,      $��60 �6    �� 5-      �� 5.      $��25 �6    .+�50      � ���#111221$��2��6(    51      �� 52      $	��100 �6'   �� 53      �� 54      $	��100 �6'   �� 55      $	��100 �6'   .+�57      �� -   5        $
 ChangeButton��57      $��25��60   $
��auto��6<   $��Change��58      $��2��6*   #��[  6:   $	��Top=�6_   ��57   _   �� *ChangeCommand+58   _   �� 59      -   5        $
 DeleteButton��59      $
��auto��6Q   $
��auto��6_   $��Delete��5:      $��3��6*   #��[  6:   ��59   /   �� *DeleteCommand+5:   :   �� 5;      -   5        $
 	AddButton��5;      $��25��6K   $
��auto��6W   $	��Add��5<      $��0��6'   #��[  67   $	��Top=�6m   ��5;   ,   �� *
AddCommand+5<   m   5=      � 5>      ���	#FFC8C2F0$
��auto��6*    5?      �� 5@      $��72 �6'   �� 5A      .+�5C      �� $��Filter :��6   $��0��6,   $��Center=�6=   $
��Left=�6X   $��77��6t   $��Plantagenet Cherokee)�6�   $��24(�6�   $��2��6�   $��32��6�   $
��0,14q�6�   ���	#FF8500A26�   �� 5D      $��1��6[   $
��5,14q�6k   $��24(�6y   $��Plantagenet Cherokee)�6�   ���	#FF111221��6   �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=� �� TextDecorations 6�   Z� 6�   5E      �� 5F      -   5         ��Name$ 
EventsList��5F      $��1��6*   $��Stretch=�6^   ���	#FFC8C2F0 �� SelectedItem 67   �� *SelectedEvent+��6�   �� *Items+��5G      �� 5H      .R�5I      �� $
 EventButton��6!   $	��100��67     EventButtonStyle#��[ 6D   $��5q�6n    � ToolTip$ Click to change��5L   .   ��5M      � 5N   "    5O   &   �� 5P   *   $��60 �6;   �� 5Q   *   .+�5S   &   � $��1��6+    5T   *   �� 5U   .   �� 5V   .   .+�5X   *   �� $��0��6M   ��65   �� *Name+6M   �� 5Y   *   $��1��6r   ��65   �� *Time+ �� StringFormat$ {0:MM/dd/yyyy HH:mm}��6r   �� 5Z   *   $
 
buttonExit��62   $��0��6F   $��20��6S   $��20��6_   $��Right=�6k   $	��Top=�6�    J� Opacity$ 0.995Q�5[      ���	#00DDDDDD���	#00707070$ Click to delete��5^   >   .��5_   .   �� $��Resources/closeButton.png��64    J� OpacityMask �	#FF1D18186W   5`   +   5a   '   � 5b   &   $��0��6+    5d   *   �� 5e   .   �� 5f   .   .+�5h   *   �� $	 	ItemPhoto��60   $��28��6D   $��28��6O   $��0,0,0,30q�6[   $��0��6o   ��6   �� *PathPicture+5i   '   5j   #   5l      5m      5o      5p      5q      5r      