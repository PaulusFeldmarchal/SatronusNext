   M S B A M L   `   `   `  ���� G  CSatronusNext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SatronusNextSatronusNext      SatronusNext.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:SatronusNext       � Title$  SatronusNext��$	��450��$	��600�� � Icon$ Resources/logo2.png�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � 	Resources  �� MergedDictionaries �� Source��  �� $ AllStyles.xaml?�%    .��� ���#111221 � RowDefinitions �� $��50 ��� $	��200 ��� $	��110 ��� $��30 ��� .+��� -   	 ��Name$
	 logo��$��1��$��Resources/logo1.png���� -   
 ��Name$
 
buttonExit��$��0��$��570,10,10,18q� J� Opacity$ 0.995Q����	#00DDDDDD���	#00707070$
��Auto��.���� $��Resources/closeButton.png�� J� OpacityMask �	#FF1D1818� $��2�� �� $��10 ��� $��25 ��� $��15 ��� $��25 ��� .+��� -    ��Name$ 
emailLabel��$��1��$��180,0,375,0q�$��Email:��   
labelStyle#��[  �� -    ��Name$ emailTextBox��$��1��  textBoxStyle#��[ $��1��$��230,0,200,0q�G� -    G�Name$ passwordBox��$��3��$��1��$��230,0,200,0q�  passwordBoxStyle#��[ �� -   $ passwordLabel��$��3��$��156,0,370,0q�$��	Password:��#��[  �� -   $
 singInButton��$��3��$��155,4,290,4q�  buttonStyle#��[ $��Sign On��$��2���� -   $
 signUpButton��$��3��$��290,4,155,4q�#��[ $��Sign Up��$��3���� -	   $	 EMailAlertImg��$��2��$��Resources/alertImg.png��$��413,13,169,79q�$y�Hidden=��� -
   $	 PasswordlAlertImg��$��2��$��Resources/alertImg.png��$��413,53,169,39q�$y�Hidden=�