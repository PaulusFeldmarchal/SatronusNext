   M S B A M L   `   `   `  ����G  CSatronusNext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SatronusNextSatronusNext  5   	   ?$clr-namespace:SatronusNext.viewModelSatronusNext.viewModel  5   	       SatronusNext.AddWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SatronusNext     5   	   7local1$clr-namespace:SatronusNext.viewModel     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	     � Title$	  Add��5
   	   $	��372��6   $	��640��6"    � 
ResizeMode$ CanMinimize=�6.    � ShowInTaskbar .   � Icon$ Resources/logo2.png��6]    � DataContext 5      )  #SatronusNext.viewModel.AddViewModel  5   
    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ AllStyles.xaml?�6%   %    5      .��5      � ���#111221 � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��300 �6   �� 5      $��* �6   	 � RowDefinitions	 5   
   �� 5      $	��280 �6   �� 5      $��* �6   .+�5   
   �� -   5        
 ��Name$
 backinMainMenuButton1��5      $��1��60   $��
99,10,23,8q�6>      buttonStyle#���   6R   $
��Back��5       $��3��6!   $��2��6<   �� 5!   
   -   5        $
 tryToregisterButton��5!      $��1��6.   $��10,10,112,8q�6]   #���   6r   $��Continue��5"      $��3��6%   $��2��6?   ��5!   <   �� *ContCommand+5"   ?   �� 5#   
   -   5        $
 
FileButton��5#      $��0��6%   #��[  62   $��99,246,23,12q�6�   $��Browse��5$      $��3��6#   $��2��60   ��5#   W   �� *BrowseCommand+{�6y   �� *IsEnablePath+5$   0   �� 5%   
   -   5         ��Name$ ChangeNameTextBox��5%      $��0��6-   $��1��6:     textBoxStyle#��[ 6s   $��
0,20,0,234q�6�   ��6J   �� *	AddedName+ �� Mode$ TwoWay=�6�   �� 5&   
   -   5        $ ChangeTextTextBox��5&      $��0��6-   $��1��6:   #��[ 6s   $��
0,60,0,135q�6�   $
��Auto��6�   ��6J   �� *	AddedText+$ TwoWay=�6�   �� 5'   
   -   5        $ DateTextBox��5'      $��0��6'   $��1��65   #��[ 6�   $��
0,174,0,81q�6�   ��6E   �� *	AddedDate+ �� StringFormat$ {0:MM/dd/yyyy HH:mm}��$ TwoWay=�6�   �� 5(   
   -   5        $ FileTextBox��5(      $��0��6'   $��1��64   #��[ 6�   $��
0,242,0,12q�6�   {�6D   �� *IsEnablePath+��6h   �� *PathToSound+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5,   
   -   5         ��Name$ registrationNameLabel��5,      $��0��6/   $��Name :��6=     
labelStyle#��[ 5-       J� RenderTransformOrigin$ 0.482,0.444&�61   $��	0,20,0,10q�6U   $��2��6h   �� 5.   
   -	   5        $ registrationEMailLabel��5.      $��0��60   $��Text :��6>   #��[ 5/      $��2��62   $��
0,60,0,-60q�6C   �� 50   
   -
   5        $ DataChangeLabel��50      $��0��6)   $��Data :��67   #��[ 51      $ 0.482,0.444&�61   $��0,174,0,-134q�6U   $��2��6k   �� 52   
   -   5        $ 	FileLabel��52      $��0��6#   $��Sound :��61   #��[ 53      $ 0.482,0.444&�61   $��0,242,0,-212q�6U   $��2��6k   �� 54   
   $��2��6   $	��Top=�6d   $ 0.528,-2.693&�6|   $��
44,20,23,0q�6�    �� SelectedIndex 6#   �� *SelectedBoxIndex+$ OneWayToSource=�.  (System.Windows.Interactivity.Interaction   Triggers 55      /  )System.Windows.Interactivity.EventTrigger  56         	EventName$ SelectionChanged��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 57      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *
BoxCommand+58      .@�5:      ��  �� 
IsSelected . .��5<      ��  �� Orientation$ 
Horizontal=�6   .+�5=      �� $��Resources/1.png��6   $��30��66   $��20��6A   �� 5>      
AlarmClock6,   5?      5@      �� 5A      $ 
Horizontal=�6   .+�5B      �� $��Resources/tasks.png��6   $��30��65   $��20��6@   �� 5C      Note6"   5D      5E      5G      5H      