   M S B A M L   `   `   `  ����  	AirNautis    AirNautis.Full_Details   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Full Details��5   	   $��412.007��6   $��516.128��6/    � WindowStartupLocation$ CenterScreen=�6?    � 
ResizeMode$ CanMinimize=�6d    � Icon$ paper_airplane_icon.ico��6}   .��5      � .+�5   
   �� $��Airplane Information��6   $
��Left=�61   $��	10,23,0,0q�6L   $	��Top=�6_   $	��123��6w   $	��481��6�   �� 5	   
   $��Model��6   $
��Left=�6    $��	27,50,0,0q�6;   $	��Top=�6N   $��77��6f   �� 5
   
   $
��Year��6   $
��Left=�6   $��
266,53,0,0q�6:   $	��Top=�6N   $��77��6f   �� 5   
   $��Capacity��6   $
��Left=�6#   $��	27,91,0,0q�6>   $	��Top=�6Q   $��77��6i   �� 5   
   $��Active��6   $
��Left=�6!   $��
266,94,0,0q�6<   $	��Top=�6P   $��77��6h   �� 5   
   -   5        $��txtBoxModelData��5      $
��Left=�6)   $��23��6D   $��	89,56,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��151��6�   �� 5   
   -   5        $��txtBoxYearData��5      $
��Left=�6(   $��23��6C   $��
328,56,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��151��6�   �� 5   
   -   5        $��txtBoxCapacityData��5      $
��Left=�6,   $��23��6G   $��	89,94,0,0q�6S   $
 Wrap=�6f   $	��Top=�6z   $	��151��6�   �� 5   
   -   5        $��txtBoxActiveData��5      $
��Left=�6*   $��23��6E   $��
328,94,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��151��6�   �� 5   
   $��Travels��6   $
��Left=�6$   $��
10,166,0,0q�6?   $	��Top=�6S   $	��207��6k   $	��481��6x   .��5      &   System.Windows.Controls.DataGrid  -   5        $��	dgTravels��5      $
��Left=�6H   $	��162��6c   $��0,10,0,0q�6p   $	��Top=�6�   $	��462��6�      AutoGenerateColumns .     
IsReadOnly . ��6(   �� *Travel+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 140 6V   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   ��  �� Path$
 Date�6V     5      $ Origin��6)   $		 150 6Z   
 69   �� $ Origin�6Z     5      $ Destination��6)   $		 145 6d   
 6>   �� $ Destination�6d   5      5      5!      5"      