   M S B A M L   `   `   `  ����G  CSatronusNext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SatronusNextSatronusNext  5   	   %    SatronusNext.RegistrationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SatronusNext     5   	     � Title$  SatronusNext��5      $	��310��6   $	��600��6*    � Icon$ Resources/logo2.png��66    � WindowStartupLocation$ CenterScreen=�6Q    � WindowStyle$
 None=�6v    � 
ResizeMode$ NoResize=�6�    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ AllStyles.xaml?�6%   %    5      .��5      � ���#111221 � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��200 �6   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      .+�5   
   �� -   5        	 ��Name$	 
buttonExit��5      $��0��6%   $��570,10,10,18q�62   
 J� Opacity$
 0.995Q�5      ���	#00DDDDDD���	#00707070$
��Auto��6P   .��5      �� $��Resources/closeButton.png��6    J� OpacityMask �	#FF1D181867   5      �� 5   
   -   5        $	 backinMainMenuButton1��5      $��3��60   $��
425,4,95,4q�6=      buttonStyle#���   6Q   $
��Back��5      $��3��6D   �� 5   
   -   5        $	 tryToregisterButton��5      $��3��6.   $��
510,4,10,4q�6;   #���   6O   $��Continue��5       $��3��6F   �� 5!   
   -   5         ��Name$ registrationNameTextBox��5!      $��1��63     textBoxStyle#��[ 6@   $��143,46,315,129q�5"      6*   �� 5#   
   -   5        $  registrationSurnameTextBox��5#      $��1��66   #��[ 6C   $��410,46,46,129q�5$      6)   �� 5%   
   -   5        $ registrationEMailTextBox��5%      $��1��64   #��[ 6A   $��143,100,315,75q�5&      6*   G� 5'   
   -   5         G�Name$ registrationPasswordBox��5'      $��1��68     passwordBoxStyle#��[ 6E   $��143,156,315,19q�5(      6.   G� 5)   
   -   5        $" registrationRetryPasswordBox��5)      $��1��6<   #��[ 6I   $��410,156,46,19q�5*      6-   �� 5+   
   -	   5         ��Name$ logoOnRegistration��5+      $��1��6,   $��25��69   $��25��6E   $��Resources/logo2.png��6P   $��10,10,565,165q�5,      �� 5-   
   -
   5         ��Name$ registrationLabel��5-      $��1��6+   $��35,7,475,165q�68   $��Registration��6N     
labelStyle#��[ 5.       J� RenderTransformOrigin$ 0.482,0.444&�68   �� 50   
   -   5        $ registrationNameLabel��50      $��1��6/   $��88,43,462,129q�6<   $
��Name��6S   #��[ 51      $ 0.482,0.444&�61   �� 52   
   -   5        $ registrationSurnameLabel��52      $��1��62   $��340,43,195,129q�6?   $��Surname��6W   #��[ 53      $ 0.482,0.444&�61   �� 54   
   -   5        $ registrationEMailLabel��54      $��1��60   $��94,97,462,75q�6=   $��eMail��6S   #��[ 55      $ 0.482,0.444&�61   �� 56   
   -   5        $ registrationPasswordLabel��56      $��1��63   $��70,153,462,19q�6@   $��Password��6W   #��[ 57      $ 0.482,0.444&�61   �� 58   
   -   5        $ registrationRetryLabel��58      $��1��60   $��362,153,195,19q�6=   $��Retry��6U   #��[ 59      $ 0.482,0.444&�61   �� 5:   
   -   5        $ registNameAlertImg��5:      $��1��6   $��Resources/alertImg.png��69   $��300,46,282,129q�6Y   $y�Hidden=�6q   �� 5;   
   -   5        $ registSurnameAlertImg��5;      $��1��6   $��Resources/alertImg.png��6<   $��570,46,12,129q�6\   $y�Hidden=�6s   �� 5<   
   -   5        $ registEMailAlertImg��5<      $��1��6   $��Resources/alertImg.png��6:   $��300,100,282,75q�6Z   $y�Hidden=�6r   �� 5=   
   -   5        $ registPasswordAlertImg��5=      $��1��6   $��Resources/alertImg.png��6=   $��300,156,282,19q�6]   $y�Hidden=�6u   �� 5>   
   -   5        $ registRetryAlertImg��5>      $��1��6   $��Resources/alertImg.png��6:   $��570,156,12,19q�6Z   $y�Hidden=�6q   5?      5@      