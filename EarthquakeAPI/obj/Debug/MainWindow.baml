   M S B A M L   `   `   `  ����H  DEarthquakeAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EarthquakeAPIEarthquakeAPI  5   	       EarthquakeAPI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:EarthquakeAPI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��infoDataGrid��5
   &      
IsReadOnly . $��Center=�6:   $	��297��6W   $��0,36,0,0q�6d   $	��Top=�6v   $	��750��6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6L      FontSize$ 14Q�6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Date+6X     5      $ 
Место��6?   $	 400 6N   $ 14Q�6Z    6%   �� *Place+6Z     5      $ Магнитуда��6C   $	 110 6V   $ 14Q�6b    6%   �� *	Magnituda+6b     5      $' !Глубина эпицентра��6A   $	 115 6\   $ 14Q�6h    6%   �� *	Glubina+6h   5      �� 5   
   -   5        $��Обновить��5      $
��Left=�6$   $��411,359,0,0q�6?   $	��Top=�6T   $	��133��6l   $��24��6x    J� RenderTransformOrigin$ 0.957,0.126&�6�   6�   �� 5   
   -   5        $��	textCount��5      $
��Left=�6%   $��23��6@   $��215,362,0,0q�6L   	 �� TextWrapping$
	 Wrap=�6a   $��5��6u   $	��Top=�6~   $	��120��6�   $ 0.675,0.596&�6�   �� 5   
   $'��!Количество строк
��6   $
��Left=�65   $��
58,362,0,0q�6P   $	��Top=�6d   $	��152��6|   $��23��6�   5      5      