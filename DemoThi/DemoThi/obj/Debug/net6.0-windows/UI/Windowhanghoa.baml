   M S B A M L   `   `   `  ����B  >DemoThi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DemoThi.UI
DemoThi.UI  5   	   /clr-namespace:DemoThi.ModelsDemoThi.Models  5   
       DemoThi.UI.Windowhanghoa   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DemoThi.UI     5   	   4localModelsclr-namespace:DemoThi.Models     5   
   -   5          � Title$  Windowhanghoa��5	   	   $	��450��6   $	��800��6,    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5        them��   Command$" local:Windowhanghoa.lenhThem��5   '   5        5   
   -   5        xoa��$! local:Windowhanghoa.lenhXoa��5   &   5   	     5   
   -   5        sua��$! local:Windowhanghoa.lenhSua��5   &   5       � 	Resources 5         DemoThi.Models.Hanghoa   	rsHanghoa��%   &	          5   
   6   5      .��5      �� .+�5   
   �� $��Quản lý hàng hóa��6   $��18(�6+   $
��Bold"�69   
�������
����=H�$��5q�6y   $��Center=�6�   �� 5   
    �� Padding$ 10q�6   ���#f4f4f4 �� CornerRadius$ 5��63   ._�5      � -   5         �Name$ gridHanghoa��5       � DataContext# [  6(    � ColumnDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      	 � RowDefinitions	 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      .+�5(      �� $��0��6   $��1��6)   $��
Mã hàng:��69   $
��Bold"�6I   �� 5)      $��1��6   $��1��6)   $��Tên hàng:��69   $
��Bold"�6J   �� 5*      $��2��6   $��1��6)   $��Đơn vị tính:��69   $
��Bold"�6M   �� 5+      $��3��6   $��1��6)   $��Đơn giá:��69   $
��Bold"�6I   �� 5-      $��0��6   $��2��6'   $	��200��6O   ��67   �� *Mahang+6O   �� 5.      $��1��6   $��2��6'   $	��200��6P   ��67   �� *	Tenhang+6P   �� 5/      $��2��6   $��2��6'   $	��200��6L   ��67   �� *Dvt+6L   �� 50      $��3��6   $��2��6'   $	��200��6O   ��67   �� *Dongia+6O   �� 52      $��0��6   $��3��6*   $��3��6:   
 �� Orientation$
 Vertical=�6K   $��10,0,0,0q�6b   .+�53      �� $��Thêm��6   $"��local:Windowhanghoa.lenhThem��6,   
��� � �
�������6f   �� 54      $
��Xóa��6   $!��local:Windowhanghoa.lenhXoa��6+   
���  ��
�������$��0,5,0,5q�6u   �� 55      $��Sửa��6   $!��local:Windowhanghoa.lenhSua��6+   
����  �
�������6c   56      57      58      &   System.Windows.Controls.DataGrid  59   
   -   5          Name$ 	dgHanghoa��59         AutoGenerateColumns$ False��6&   
�������   AlternatingRowBackground �#EFEFEF$��1q�5:   *   ���#CCC   Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã hàng��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Mahang+6Q     5=      $ 
Tên hàng��6%   $ 2* 6S    67   �� *	Tenhang+6S     5>      $ Đơn vị tính��6%   $ * 6R    6:   �� *Dvt+6R     5?      $ 
Đơn giá��6%   $ * 6Q    66   �� *Dongia+6Q   5A      5B      5C      