   M S B A M L   `   `   `  ����@  <demo2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:demo2.UIdemo2.UI  5   	       demo2.UI.WindowQLHV   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:demo2.UI     5   	   -   5          � Title$  
WindowQLHV��5	   	   $	��450��6   $	��800��6)    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5        them��   Command$ local:WindowQLHV.lenhThem��5   '   5   ,     5   
   -   5        sua��$ local:WindowQLHV.lenhSua��5   &   5   !     5   
   -   5        xoa��$ local:WindowQLHV.lenhXoa��5   &   5      .��5      �� z�5   
   V� 5      .~�5      �� �� 5       �� AngleX$ 1.734Q�6    �� 5      T� 5       T� X$
 6.57Q�6%   5      .+�5   
   �� $��Quản lý hàng hóa��6   
������$��16(�6?   $
��Bold"�6M   $��Center=�6_   $��	0,10,0,10q�6|   � 5   
   -   5         �Name$ gridHocvien��5         	rsHocvien � DataContext# [  6$   $��10q�6M    � ColumnDefinitions 5      �� 5      $��2* �6#   �� 5       $��3* �6#   �� 5!      $��2* �6#   �� 5"      $��3* �6#   �� 5#      $��2* �6#    � RowDefinitions 5&      �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    .+�5-      �� $��0��6   $��0��6%   $��Mã học viên:��65   $��Center=�6I   �� 5.      $��0��6   $��1��6#   ��63   �� *Mshv+�� 50      $��1��6   $��0��6%   $��Tên học viên:��65   $��Center=�6J   �� 51      $��1��6   $��1��6#   ��63   �� *Tenhv+�� 53      $��2��6   $��0��6%   $��Ngày sinh:��65   $��Center=�6G   (  "System.Windows.Controls.DatePicker  54      $��2��6   $��1��6&   	   SelectedDate	 66   �� *
Ngaysinh+�� 56      $��0��6   $��2��6%   $��Phái:��65   $��Center=�6B   �� 57      $��0��6   $��3��6$    
 rsPhai#��[ 64   
 �� DisplayMemberPath$
 value��6Z    �� SelectedValuePath$	 key��6t    �� SelectedValue 6�   �� *Phai+�� 59      $��1��6   $��2��6%   $��
Mã lớp:��65   $��Center=�6D   �� 5:      -   5         ��Name$ cmbMalop��5:   4   $��1��6   $��3��6$   $
 Malop��6F   $ Malop��6`    6z   �� *Malop+�� 5<      $��2��6   $��2��6%   $��Tên lớp:��65   $��Center=�6E   �� 5=      $��2��6   $��3��6#    �� 
IsReadOnly$
 True��63   ��6E   ��  �� ElementName$ cmbMalop�� �� Path$ SelectedItem.Tenlop��� 5?      $��3��6   $��5��6&    �� Orientation$ 
Horizontal=�6:   $��Center=�6S   $��10q�6p   .+�5@      �� $��Thêm��6   $��local:WindowQLHV.lenhThem��6(   $��80��6L   $��5q�6W   �� 5A      $��Sửa��6   $��local:WindowQLHV.lenhSua��6'   $��80��6J   $��5q�6U   �� 5B      $
��Xóa��6   $��local:WindowQLHV.lenhXoa��6'   $��80��6J   $��5q�6U   5C      5D      &   System.Windows.Controls.DataGrid  5F   
   -   5          Name$ 	dgHocvien��5F         AutoGenerateColumns$ False��6U   
����� �$��10q�6�      Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5H      ,  &System.Windows.Controls.DataGridColumn   Header$
 Mshv��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Mshv+  5I      $ Tên HV��6%    65   �� *Tenhv+  5J      $ 
Ngày sinh��6%    68   �� *
Ngaysinh+  5K      $ Phái��6%    63   �� *Phai+  5L      $ 	Mã lớp��6%    65   �� *Malop+  5M      $ 
Tên lớp��6%    66   �� *Tenlop+5O      5P      5Q      