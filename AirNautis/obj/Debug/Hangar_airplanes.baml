   M S B A M L   `   `   `  ����  	AirNautis     AirNautis.Hangar_airplanes   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Hangar Airplanes��5   	   $��306.768��6"   $��292.105��63    � WindowStartupLocation$ CenterScreen=�6C    � 
ResizeMode$ CanMinimize=�6h    � Icon$ paper_airplane_icon.ico��6�   .��5      � .+�5   
   �� $��Capacity��6   $
��Left=�6#   $��	10,24,0,0q�6>   $	��Top=�6Q   $��77��6i   �� 5   
   $��Current��6   $
��Left=�6"   $��	10,55,0,0q�6=   $	��Top=�6P   $��77��6h   �� 5
   
   -   5        $��txtBoxCapacity��5
      $
��Left=�6(   $��23��6C   $��
104,24,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��113��6�   �� 5   
   -   5        $��txtBoxCurrent��5      $
��Left=�6'   $��23��6B   $��
104,55,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��113��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgHangarAirplane��5      $
��Left=�6M   $	��142��6h   $��
10,115,0,0q�6u   $	��Top=�6�   $	��256��6�      AutoGenerateColumns .     
IsReadOnly . ��6+   �� *
Airplane+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Airplane��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 230 6W   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   ��  �� Path$ Model�6W   5      5      5      