   M S B A M L   `   `   `  ����M  ISocialMediaProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   !localclr-namespace:WpfApp1  5   	   -   5          � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � Title$ 
MainWindow��5   	   $	��850��6   $
��1200��6)   .��5      �  � 	Resources 5   
   '  !MaterialDesignThemes.Wpf.PackIcon �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��$ 30��6*   67   �� 5       � ��$ 30��6+   68   5      5      .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6   	   UniformCornerRadius$	 15Q�6*   .��5      � 
 � ColumnDefinitions
 5      �� 5      $��1* �6'   64   �� 5      $	��15* �6'   65   .+�5      � .+�5      �� $
��0 15q�6   .@�5      �� $��Center=�6'   $
��0 10q�6D   .��5       ��  &  "MaterialDesignFloatingActionButton#��[  6%   $
��Left=�6a   
���   ���5!   %   Z� ��6<   Z� .��5"   "   �� $��-5q�6-   .+�5#   &        Kind$ Resistor=�6>   5$   #   5%      5&      �� 5'      $��Center=�6'   $��0q�6D   .��5(      �� #��[  6%   $
��Left=�6a   
���   ���5)   %   Z� ��6<   Z� .��5*   "   �� $��-5q�6-   .+�5+   &     $ CircleSlice6=�6>   5,   #   5-      5.      �� 5/      $��Center=�6'   $
��0 10q�6D   .��50      �� #��[  6%   $
��Left=�6a   
���   ���51   %   Z� ��6<   Z� .��52   "   �� $��-5q�6-   .+�53   &     $ CalendarBlankOutline=�6>   54   #   55      56      �� 57      $��Center=�6'   $��0q�6D   .��58      �� #��[  6%   $
��Left=�6a   
���   ���59   %   Z� ��6<   Z� .��5:   "   �� $��-5q�6-   .+�5;   &     $ EqualiserVertical=�6>   5<   #   5=      5>      �� 5?      $��Center=�6'   $
��0 10q�6D   .��5@      �� #��[  6%   $
��Left=�6a   
���   ���5A   %   Z� ��6<   Z� .��5B   "   �� $��-5q�6-   .+�5C   &     $ ChatOutline=�6>   5D   #   5E      5F      �� 5G      $��Center=�6'   $��0 60 0 0q�6D   .��5H      �� -   5         ��Name$ btnExit��5L   8   #��[  5H   %   $
��Left=�5I   %   
���   ���5J   %   �� *
CloseCmd+��5K   %   Z� ��6<   Z� .��5M   "   �� $��-5q�6-   .+�5N   &     $ 	ExitToApp=�6>   5O   #   5P      5Q      5R      5S      � 5U      -   5        $��RenderPages��5U   <   $��1��6   ���#F6F5F85W      5X      5Y      5Z      5[      