   M S B A M L   `   `   `  ����  	AirNautis    AirNautis.Details_Hangar   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Details of Hangars��5   	   $��268.422��6$   $��292.105��65    � WindowStartupLocation$ CenterScreen=�6E    � 
ResizeMode$ CanMinimize=�6j    � Icon$ paper_airplane_icon.ico��6�   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgHangar��5      $
��Left=�6C   $	��213��6^   $��	10,10,0,0q�6k   $	��Top=�6~   $	��256��6�      AutoGenerateColumns .     
IsReadOnly . ��6#   �� *Hangar+   Columns 5	      0  *System.Windows.Controls.DataGridTextColumn  5
      ,  &System.Windows.Controls.DataGridColumn   Header$ Hangar Number��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6]   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6<   �� 
 �� Path$
 Number�6]     5      $ Capacity��6%   $	 100 6Z   	 67   �� $
 Capacity�6Z   5      5      5      