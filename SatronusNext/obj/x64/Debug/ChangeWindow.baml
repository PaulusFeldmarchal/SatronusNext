   M S B A M L   `   `   `  ����G  CSatronusNext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SatronusNextSatronusNext  5   	   ?$clr-namespace:SatronusNext.viewModelSatronusNext.viewModel  5   	       SatronusNext.ChangeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SatronusNext     5   	   7local1$clr-namespace:SatronusNext.viewModel     5   	     � Title$  Change��5	   	   $	��363��6   $	��627��6%    � 
ResizeMode$ CanMinimize=�61    � Icon$ Resources/logo2.png��6J    � DataContext 5
      2  ,SatronusNext.viewModel.ChangeWindowViewModel  5   
    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ AllStyles.xaml?�6%   %    5      .��5      � ���#111221 � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��300 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��280 �6   �� 5      $��* �6   .+�5   
   �� -   5        	 ��Name$	 backinMainMenuButton1��5      $��1��60   $��2��6=   $��	110,9,4,0q�6M      buttonStyle#���   6`   $
��Back��5      $��3��6!   6.   �� 5    
   -   5        $	 tryToregisterButton��5       $��1��6.   $��2��6;   $��
10,9,104,0q�6l   #���   6�   $��Continue��5!      $��3��6%   ��5    K   �� *ContCommand+5!   2   �� 5"   
   -   5        $	 
FileButton��5"      $��0��6%   $��2��62   $��124,248,17,10q�6�   #���   6�   $��Browse��5#      $��3��6#   ��5"   B   �� *BrowseCommand+{�6d   �� *IsEnablePath+5#   #   �� 5%   
   -   5        
 ��Name$
 ChangeNameTextBox��5%      $��0��6-   $��1��6:     textBoxStyle#��[ 6u   $��
0,20,0,236q�6�   ��6J   �� *ChangedName+ �� Mode$ TwoWay=�6�   �� 5'   
   -   5        $
 ChangeTextTextBox��5'      $��0��6-   $��1��6:   #��[ 6u   $��
0,80,0,115q�5(      $��85��6&   ��5'   J   �� *ChangedText+$ TwoWay=�5(   &   �� 5*   
   -   5        $
 DateTextBox��5*      $��0��6'   $��1��64   #��[ 6�   $��
0,192,0,63q�5+      $��25��6&   ��5*   E   �� *ChangedDate+$ TwoWay=� �� StringFormat$ {0:MM/dd/yyyy HH:mm}��5+   &   �� 5,   
   -   5        $
 FileTextBox��5,      $��0��6'   $��1��64   #��[ 6�   $��
0,245,0,10q�5-      $��25��6&   {�5,   D   �� *IsEnablePath+��6h   �� *PathToSound+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5-   &   �� 51   
   -   5         ��Name$ registrationNameLabel��51      $��0��6/   $��0��6?   $��Name :��6L     
labelStyle#��[ 52       J� RenderTransformOrigin$ 0.482,0.444&�61   $��	0,16,0,28q�6U   $��2��6h   �� 53   
   -	   5        $ registrationEMailLabel��53      $��0��60   $��0��6@   $��Text :��6N   #��[ 54      $ 0.482,0.444&�61   $��
0,76,0,-32q�6U   $��2��6i   �� 55   
   -
   5        $ DataChangeLabel��55      $��0��6)   $��0��69   $��Data :��6G   #��[ 56      $ 0.482,0.444&�61   $��0,188,0,-144q�6U   $��2��6k   �� 57   
   -   5        $ 	FileLabel��57      $��0��6#   $��0��61   $��Sound :��6B   #��[ 58      $ 0.482,0.444&�61   $��0,244,0,-200q�6U   $��2��6k   5:      5;      