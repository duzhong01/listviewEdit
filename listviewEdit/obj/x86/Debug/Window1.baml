   M S B A M L   `   `   `  ����  listviewEdit    listviewEdit.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Window1��5   	   $	��275��6   $	��471��6&   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5
      $
��auto �6   �� 5      $��22 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	gridCitys��5      $��0��6'   $
��Left=�64   $	��Top=�6O      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ CityID��6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *CityID+   ClipboardContentBinding 6@   Z� 6c     5      $ CityName��6e    6%   �� *
CityName+ 6B   Z� 6e     5      $ ZipCode��6d    6%   �� *	ZipCode+ 6A   Z� 6d   4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        cboProvince��$ 
ProvinceID��5   a      SelectedValuePath$ 
ProvinceID��6u   	   DisplayMemberPath$	 ProvinceName��6�   
   ClipboardContentBinding
 6>   Z�    SelectedValueBinding 6�   ��  �� Path$ 
ProvinceID� �� UpdateSourceTrigger$ PropertyChanged=�   SelectedItemBinding 6  Z� 5         5"      $ DateCreated��6h    6%   �� *DateCreated+ 6E   Z� 6h     5$      $ DateUpdated��6h    6%   �� *DateUpdated+ 6E   Z� 6h   5*      �� 5,   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5.      �� $��显示信息��6    �� TextAlignment$ Center=�6$   �� 50      -   5        $��txtMsg��50       �� 
IsReadOnly . $�� ��66   $	��320��6>    �� TextAlignment$ Center=�6J   54      � 56   
   $��2��6    � Orientation$ 
Horizontal=�6!   $��Right=�6:   .+�58      �� -   5        $��
btnRefresh��58   3   $��Right=�6   $��22��6E   $	��Top=�6Q   $��65��6i   .��6�   刷新6�   �� 5:      -   5        $��	btnUpdate��5:   3   $��Right=�6   $��22��6D   $	��Top=�6P   $��65��6h   .��6�   更新6�   5<      5?      5@      