   M S B A M L   `   `   `  ����G  CSatronusNext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SatronusNextSatronusNext  5   	       SatronusNext.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SatronusNext     5   	     � Title$  SatronusNext��5   	   $	��450��6   $	��600��6+    � Icon$ Resources/logo2.png��67    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�6.    � 
ResizeMode$ NoResize=�6A    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ AllStyles.xaml?�6%   %    5      .��5      � ���#111221 � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��200 �6   �� 5      $	��110 �6   �� 5      $��30 �6   �� 5      .+�5   
   �� -   5        	 ��Name$
	 logo��5      $��1��6   $��Resources/logo1.png��6+   �� 5   
   -   5        
 ��Name$
 
buttonExit��5      $��0��6%   $��570,10,10,18q�62    J� Opacity$ 0.995Q�5      ���	#00DDDDDD���	#00707070$
��Auto��6P   .��5      �� $��Resources/closeButton.png��6    J� OpacityMask �	#FF1D181867   5      � 5   
   $��2��6    5       �� 5!      $��10 �6    �� 5"      $��25 �6    �� 5#      $��15 �6    �� 5$      $��25 �6    �� 5%      .+�5'      �� -   5         ��Name$ 
emailLabel��5'      $��1��6(   $��180,0,375,0q�65   $��Email:��6J      
labelStyle#��[  5(      �� 5)      -   5         ��Name$ emailTextBox��5)      $��1��6,     textBoxStyle#��[ 69   $��1��5*      $��230,0,200,0q�6#   68   G� 5+      -   5         G�Name$ passwordBox��5+      $��3��60   $��1��6=   $��230,0,200,0q�6J     passwordBoxStyle#��[ 5,      6E   �� 5-      -   5        $ passwordLabel��5-      $��3��6+   $��156,0,370,0q�68   $��	Password:��6M   #��[  5.      5/      �� 50   
   -   5        $
 singInButton��50      $��3��6'   $��155,4,290,4q�64     buttonStyle#��[ 6I   $��Sign On��51      $��2��6>   �� 52   
   -   5        $
 signUpButton��52      $��3��6'   $��290,4,155,4q�64   #��[ 6I   $��Sign Up��53      $��3��6>   �� 55   
   -	   5        $	 EMailAlertImg��55      $��2��6   $��Resources/alertImg.png��64   $��413,13,169,79q�6T   $y�Hidden=�6k   �� 56   
   -
   5        $	 PasswordlAlertImg��56      $��2��6   $��Resources/alertImg.png��68   $��413,53,169,39q�6X   $y�Hidden=�6o   57      58      