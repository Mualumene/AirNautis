   M S B A M L   `   `   `  ����  	AirNautis    AirNautis.Historic_Travel   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Historic of Flights��5   	   $��272.933��6%   $��509.774��66    � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ CanMinimize=�6k    � Icon$ paper_airplane_icon.ico��6�   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
dgHistoric��5      $
��Left=�6E   $	��213��6`   $��	10,10,0,0q�6m   $	��Top=�6�   $	��468��6�      AutoGenerateColumns .     
IsReadOnly . ��6%   �� *Travel+   Columns 5	      0  *System.Windows.Controls.DataGridTextColumn  5
      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6R   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   �� 
 �� Path$

 Date�6R     5      $ Airplane��6%   $	 100 6Z   	 67   �� $
 Airplane�6Z     5      $ Origin��6%   $	 100 6V   	 65   �� $
 Origin�6V     5      $ Destination��6%   $	 100 6`   	 6:   �� $
 Destination�6`   5      5      5      