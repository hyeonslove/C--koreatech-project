   M S B A M L   `   `   `  ����Z  Vkoreatech-bachelor Post Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:koreatech_bachelor_Post_Projectkoreatech_bachelor_Post_Project  5   	   0    *koreatech_bachelor_Post_Project.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:koreatech_bachelor_Post_Project     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  
MainWindow��5
   	    J� SnapsToDevicePixels .    BasedWindowStyle#��[  5   	    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius � ColumnDefinitions	 F�Name
 ��Name
 � Tag �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��
 �   �6+   �� 5       �@J�SnapsToDevicePixels . 64   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 4��6!   
���   �$��1q�6G   $��	10,5,10,5q�6[   #��z��6n   ._�5      �  5   "   �� 5   &   $��* �67   �� 5   &   $��3* �67   .+�5   "   F� $	 PathIcon��6'   �� 5   "   $
 MyContentPresenter��6C   $��0��63   #��z��6_   $��Center=�6�   $��Center=�6�   $��5,0,5,0q�6�   �� 5   "   $��1��6,   $��20(�6<   $��Center=�6J   $
��Bold"�6e   $��Center=�6w   $��0,0,25,0q�6�   #��z 6�   5      5       5!      P� 5"       �@J�IsMouseOver . . �5#   "   ��  � ��
 �����6?   �� 5$   "   $ PathIcon��6)    � ��
 �   �6O   5%      P� 5'       � �� . . �5(   "   ��  � ��
 ��d�6?   �� 5)   "    � ��
 �����6?   5*      5,      5.      5/      51      .��54      �� $	 2.5��6   
�������
���   �$	��1.3q�6G   $��1q�6]   ._�55   
   �  56      �� 57      $	��250 �6#   �� 58      $��* �6#   .+�5:      �� $��0��6   
�������
���   �$��	0,0,1.3,0q�6Q   ._�5;      � .+�5<      �� -   5         ��Name$ 
HomeButton��5<      $
��auto��5=      $��50��6&   $	��Top=�62   $��0,20,0,0q�6J   $ 메　　인��5>      .��5?      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�62   $��30��6>   $��30��6J   5@      �� 5B      -   5        $ 
PostButton��5B      $
��auto��5C      $��50��6&   $	��Top=�62   $��0,70,0,0q�6J   $ 게 시 판��6\   .��5D        $
 Post=�62   $��30��6>   $��30��6J   5E      5G      5I      � 5J      $��1��6   $��2��6#    � RowDefinitions 5K      �� 5L      $��30 �6$   �� 5M      $��* �6$   .+�5O      �� $��0��6   
�������
���   �$��0,0,0,1q�6M   ._�5P      � .+�5Q      �� -   5        .��5R      �� -   5        $��titlebar��5R   (   
������ $
��auto��6K   $
��auto��6X   }�. 5S   ,   5T      �� 5U      -   5        $ AppCloseButton��5U   !   $��1q�5V        BasedIconButtonStyle#��[ 5X       � ToolTip$ CloseApp��5Y      $��Right=�5Z      .��5[        $ Close=�66   $��25��6C   $��25��6N   5\      5^      5_      � 5`      $��1��6   .+�5a      �� -   5         ��Name$ ContentPage��5a   %   ��6:   �� *Page+5b      5c      5d      5e      5f      