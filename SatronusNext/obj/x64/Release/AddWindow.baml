   M S B A M L   `   `   `  ���� G  CSatronusNext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SatronusNextSatronusNext  ?$clr-namespace:SatronusNext.viewModelSatronusNext.viewModel      SatronusNext.AddWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:SatronusNext     7local1$clr-namespace:SatronusNext.viewModel     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity    � Title$	  Add��$	��372��$	��640�� � 
ResizeMode$ CanMinimize=� � ShowInTaskbar .   � Icon$ Resources/logo2.png�� � DataContext )  #SatronusNext.viewModel.AddViewModel   � 	Resources  �� MergedDictionaries �� Source��  �� $ AllStyles.xaml?�%    .��� ���#111221 � ColumnDefinitions �� $	��100 ��� $	��300 ��� $��* �	 � RowDefinitions	 �� $	��280 ��� $��* �.+��� -   
 ��Name$
 backinMainMenuButton1��$��1��$��
99,10,23,8q�   buttonStyle#���   $
��Back��$��3��$��2���� -   $
 tryToregisterButton��$��1��$��10,10,112,8q�#���   $��Continue��$��3��$��2������ *ContCommand+�� -   $
 
FileButton��$��0��#��[  $��99,246,23,12q�$��Browse��$��3��$��2������ *BrowseCommand+{��� *IsEnablePath+�� -    ��Name$ ChangeNameTextBox��$��0��$��1��  textBoxStyle#��[ $��
0,20,0,234q����� *	AddedName+ �� Mode$ TwoWay=��� -   $ ChangeTextTextBox��$��0��$��1��#��[ $��
0,60,0,135q�$
��Auto������ *	AddedText+$ TwoWay=��� -   $ DateTextBox��$��0��$��1��#��[ $��
0,174,0,81q����� *	AddedDate+ �� StringFormat$ {0:MM/dd/yyyy HH:mm}��$ TwoWay=��� -   $ FileTextBox��$��0��$��1��#��[ $��
0,242,0,12q�{��� *IsEnablePath+���� *PathToSound+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� -    ��Name$ registrationNameLabel��$��0��$��Name :��  
labelStyle#��[  J� RenderTransformOrigin$ 0.482,0.444&�$��	0,20,0,10q�$��2���� -	   $ registrationEMailLabel��$��0��$��Text :��#��[ $��2��$��
0,60,0,-60q��� -
   $ DataChangeLabel��$��0��$��Data :��#��[ $ 0.482,0.444&�$��0,174,0,-134q�$��2���� -   $ 	FileLabel��$��0��$��Sound :��#��[ $ 0.482,0.444&�$��0,242,0,-212q�$��2���� $��2��$	��Top=�$ 0.528,-2.693&�$��
44,20,23,0q� �� SelectedIndex �� *SelectedBoxIndex+$ OneWayToSource=�.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ SelectionChanged��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
BoxCommand+.@���  �� 
IsSelected . .����  �� Orientation$ 
Horizontal=�.+��� $��Resources/1.png��$��30��$��20���� 
AlarmClock�� $ 
Horizontal=�.+��� $��Resources/tasks.png��$��30��$��20���� Note