   M S B A M L   `   `   `  ����U  QMapControl.WPF, Version=8.1.0.0, Culture=neutral, PublicKeyToken=f26fcf0059638459?0clr-namespace:MapControl;assembly=MapControl.WPF
MapControl  5   	   d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5   	   N JIskitim2023_rebuilt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Iskitim2023_rebuilt.ViewIskitim2023_rebuilt.View 5   	   E'clr-namespace:Iskitim2023_rebuilt.ModelIskitim2023_rebuilt.Model 5	   	   *   $Iskitim2023_rebuilt.View.Calculation   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @map0clr-namespace:MapControl;assembly=MapControl.WPF     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	   8local&clr-namespace:Iskitim2023_rebuilt.View     5   	   9model'clr-namespace:Iskitim2023_rebuilt.Model     5	   	     � Title$%  Расчётный модуль��5   	   $	��494��6"   $	��959��6/    � WindowStartupLocation$ CenterScreen=�6;   .��5      � 
�����p�.+�5   
   � $��10,10,243,47q�6   .+�5      '  !Microsoft.Maps.MapControl.WPF.Map  -   5          Name$ myMap��5      +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$r leZNgmmR40DyTunPmOrBp~kolAxjG20pwiJF7fIm2QRw~AgWBvZTh2hKwZ5-mh8lAl9VPhPh9CcU0YgZtlG62RHVmxwhFLrPTU1UecR96Old1 5         Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$
 road 5         	ZoomLevel$ 10Q�6$      Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$  54.656908,83.310743,0.0000 63   $	��421��6W   $��Bottom=�6d   $��Center=�6   $	��706��6�      Children. 5      +  %Microsoft.Maps.MapControl.WPF.Pushpin     Location$ 54.656908,83.310743 6   	 � ToolTip$	 Трубы завода��6;   ���	#FFE541106R   3  -Microsoft.Maps.MapControl.WPF.MapItemsControl  5      ��6$   �� *points+��5      �� 5      .R�5        ���	#FF104EE5 5   ,   �� *
Location+��5   (   �� *	Point_num+5      5      5      5       �� 5!   
   
 �� Orientation$
 
Horizontal=�6   $��42��6/   $��Bottom=�6;   $
��Left=�6V   $	��400��6q   .+�5"      �� $��5q�6   $��Расчёт��6    �� 5#      $��5q�6   $��Выбор года��6    �� 5$      $��5q�6   $��Экспорт��6    �� 5%      -   5        $��	cmbColors��5%      $	��202��6N   $��34��6Z   ��6(   �� *polutionNames+5'      5*      � 5,   
   $��Right=�6   $��93��6+    � RowDefinitions 5-      �� 5.      �� 5/      �� 50      �� 51      �� 52      �� 53      �� 54      �� 55      �� 56      �� 57      �� 58      �� 59      �� 5:      �� 5;      �� 5<      .+�5>      �� $��Точка №1��6   $��0��6*   $
��Left=�67   $��Center=�6S   �� 5?      $��Точка №2��6   $��1��6*   $
��Left=�67   $��Center=�6S   �� 5@      $��Точка №3��6   $��2��6*   $
��Left=�67   $��Center=�6S   �� 5A      $��Точка №4��6   $��3��6*   $
��Left=�67   $��Center=�6S   �� 5B      $��Точка №5��6   $��4��6*   $
��Left=�67   $��Center=�6S   �� 5C      $��Точка №6��6   $��5��6*   $
��Left=�67   $��Center=�6S   �� 5D      $��Точка №7��6   $��6��6*   $
��Left=�67   $��Center=�6S   �� 5E      $��Точка №8��6   $��7��6*   $
��Left=�67   $��Center=�6S   �� 5F      $��Точка №9��6   $��8��6*   $
��Left=�67   $��Center=�6S   �� 5G      $��Точка №10��6   $��9��6+   $
��Left=�68   $��Center=�6T   �� 5H      $��Точка №11��6   $��10��6+   $
��Left=�69   $��Center=�6U   �� 5I      $��Точка №12��6   $��11��6+   $
��Left=�69   $��Center=�6U   �� 5J      $��Точка №13��6   $��12��6+   $
��Left=�69   $��Center=�6U   �� 5K      $��Точка №14��6   $��13��6+   $
��Left=�69   $��Center=�6U   �� 5L      $��Точка №15��6   $��14��6+   $
��Left=�69   $��Center=�6U   5M      � 5N   
   $��0,0,98,0q�6   $	��239��6!   $��Bottom=�6.   $��Right=�6I   $	��140��6e   .+�5O      �� 
���   �$��1q�6)   $��10,10,83,187q�6=   ���	#FF2892136S   �� 5P      
���   �$��1q�6)   $��10,57,83,140q�6=   ���	#FFE6FF076S   �� 5Q      
���   �$��1q�6)   $��10,104,83,93q�6=    J� OpacityMask �	#FFB73E3E���	#FFFFBB006k   �� 5R      
���   �$��1q�6)   $��10,151,83,46q�6=    �	#FFB73E3E���	#FFFF3A006k   �� 5S      $��70,23,29,200q�6   $
��Wrap=�6.   $��:0-100��6B   �� 5T      $��70,70,10,153q�6   $
��Wrap=�6.   $��:100-200��6B   �� 5U      $��70,117,10,106q�6   $
��Wrap=�6/   $��:200-300��6C   �� 5V      $��70,164,29,59q�6   $
��Wrap=�6.   $��: >300��6B   5W      5Z      5[      