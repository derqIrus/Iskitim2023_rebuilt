   M S B A M L   `   `   `  ����  Iskitim2023_rebuilt$    Iskitim2023_rebuilt.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$2  ,База Данных поллютантов��5   
   $	��400��6*   $	��610��67    � WindowStartupLocation$ CenterScreen=�6C    � 	Resources 5	       �� 
TargetType �� Property �� Value��%u   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 60��6)   �� 5       � ��$ 8q�6'   5      5      .��5      � 
�����p� � RowDefinitions 5   
   �� 5      �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ 	usersList��5      
���������6%   �� *	polutions+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��20(�6C   
���   ���6$   �� *Polution_name+6Q   �� 5      $��  Кол-во: ��6$   $��20(�66   $
��Bold"�6D   
���   �6V   �� 5      $��20(�6<   
���   ���6$   �� *Amount+6J   �� 5      $��  Точка: ��6$   $��20(�65   $
��Bold"�6C   
���   �6U   �� 5      $��20(�6>   
���   ���6$   �� *
Point_id+6L   �� 5      $��
  Год: ��6$   $��20(�63   $
��Bold"�6A   
���   �6S   �� 5      $��20(�6:   
���   ���6$   �� *Year+6H   5       5!      5#      �� 5$   
   $��1��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5%      �� $��Добавить��6   $��10q�6(   $��3q�64   ��6@   �� *
AddCommand+�� 5&      $��Изменить��6   $��10q�6(   ��64   �� *EditCommand+��5'      �� 	 �� ElementName$	 	usersList��
 �� Path$
 SelectedItem��� 5(      $��Удалить��6   $��10q�6'   ��63   �� *DeleteCommand+��5)      �� $	 	usersList��$
 SelectedItem�5*      5+      5,      