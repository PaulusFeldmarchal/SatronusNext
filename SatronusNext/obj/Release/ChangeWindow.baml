   M S B A M L   `   `   `  ���� G  CSatronusNext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SatronusNextSatronusNext  ?$clr-namespace:SatronusNext.viewModelSatronusNext.viewModel      SatronusNext.ChangeWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:SatronusNext     7local1$clr-namespace:SatronusNext.viewModel       � Title$  Change��$	��363��$	��627�� � 
ResizeMode$ CanMinimize=� � Icon$ Resources/logo2.png�� � DataContext 2  ,SatronusNext.viewModel.ChangeWindowViewModel   � 	Resources  �� MergedDictionaries �� Source��  �� $ AllStyles.xaml?�%    .��� ���#111221 � ColumnDefinitions �� $	��100 ��� $	��300 ��� $��* � � RowDefinitions �� $	��280 ��� $��* �.+��� -   	 ��Name$	 backinMainMenuButton1��$��1��$��2��$��	110,9,4,0q�   buttonStyle#���   $
��Back��$��3���� -   $	 tryToregisterButton��$��1��$��2��$��
10,9,104,0q�#���   $��Continue��$��3������ *ContCommand+�� -   $	 
FileButton��$��0��$��2��$��124,248,17,10q�#���   $��Browse��$��3������ *BrowseCommand+{��� *IsEnablePath+�� -   
 ��Name$
 ChangeNameTextBox��$��0��$��1��  textBoxStyle#��[ $��
0,20,0,236q����� *ChangedName+ �� Mode$ TwoWay=��� -   $
 ChangeTextTextBox��$��0��$��1��#��[ $��
0,80,0,115q�$��85������ *ChangedText+$ TwoWay=��� -   $
 DateTextBox��$��0��$��1��#��[ $��
0,192,0,63q�$��25������ *ChangedDate+$ TwoWay=� �� StringFormat$ {0:MM/dd/yyyy HH:mm}���� -   $
 FileTextBox��$��0��$��1��#��[ $��
0,245,0,10q�$��25��{��� *IsEnablePath+���� *PathToSound+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� -    ��Name$ registrationNameLabel��$��0��$��0��$��Name :��  
labelStyle#��[  J� RenderTransformOrigin$ 0.482,0.444&�$��	0,16,0,28q�$��2���� -	   $ registrationEMailLabel��$��0��$��0��$��Text :��#��[ $ 0.482,0.444&�$��
0,76,0,-32q�$��2���� -
   $ DataChangeLabel��$��0��$��0��$��Data :��#��[ $ 0.482,0.444&�$��0,188,0,-144q�$��2���� -   $ 	FileLabel��$��0��$��0��$��Sound :��#��[ $ 0.482,0.444&�$��0,244,0,-200q�$��2��