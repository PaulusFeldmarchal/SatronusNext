   M S B A M L   `   `   `  ���� G  CSatronusNext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SatronusNextSatronusNext  ?$clr-namespace:SatronusNext.viewModelSatronusNext.viewModel       SatronusNext.ProgramWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:SatronusNext     7local1$clr-namespace:SatronusNext.viewModel       � Title$  ProgramWindow��$	��600��$
��1000�� � DataContext +  %SatronusNext.viewModel.EventViewModel   � 	Resources  �� MergedDictionaries �� Source��  �� $ AllStyles.xaml?�%    .���  � ColumnDefinitions �� $	��250 ��� .+�� $��0�����#111221 � RowDefinitions �� $	��240 ��� $��80 ��� $��80 ��� .+�� $��3�� �� $	��125 ��� �� -    ��Name$ 	UserPhoto��$��0��$��Resources/logo2.png��$
��Fill=��� -    ��Name$ InformButton��$
��auto��$
��auto��$��Information��$��1��   buttonStyle#��[  $��36(��� -   $ UserInformationButton��$
��auto��$
��auto��$��
Users Data��$��2��#��[  $��36(�� $��1�� �� $��60 ��� �� $��25 �.+�� ���#111221$��2�� �� $	��100 ��� �� $	��100 ��� $	��100 �.+��� -   $ ChangeButton��$��25��$
��auto��$��Change��$��2��#��[  $	��Top=����� *ChangeCommand+�� -   $ DeleteButton��$
��auto��$
��auto��$��Delete��$��3��#��[  ���� *DeleteCommand+�� -   $ 	AddButton��$
��auto��$
��auto��$	��Add��$��0��#��[  ���� *
AddCommand+� ���	#FFC8C2F0$
��auto�� �� $��72 ��� .+��� $��Filter :��$��0��$��Center=�$
��Left=�$��77��$��Plantagenet Cherokee)�$��24(�$��2��$��32��$
��0,14q����	#FF8500A2�� $��1��$��5q�$��24(�$��Plantagenet Cherokee)����	#FF111221���� *
FilterText+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� TextDecorations
 Z� �� -    ��Name$ 
EventsList��$��1��$��Stretch=����	#FFC8C2F0 �� SelectedItem �� *SelectedEvent+���� *Items+���� .R��� $ EventButton��$	��100��  EventButtonStyle#��[ $��5q� � ToolTip$ Click to change�����  �� $��60 ��� .+�� $��1�� �� �� .+��� $��0������ *Name+�� $��1������ *Time+�� $ 
buttonExit��$��0��$��20��$��20��$��Right=�$	��Top=� J� Opacity$ 0.995Q����	#00DDDDDD���	#00707070$ Click to delete��.���� $��Resources/closeButton.png�� J� OpacityMask �	#FF1D1818� $��0�� �� �� .+��� $ 	ItemPhoto��$��28��$��28��$��0,0,0,30q�$��0������ *PathPicture+