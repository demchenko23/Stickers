   M S B A M L   `   `   `  ����B  >Stikers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Stikers.ViewModelStikers.ViewModel  5   	       Stikers.WindowStandart   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   5	viewModelclr-namespace:Stikers.ViewModel     5   	   -   5        $
��view��5
   	   $	��200��5   	   $	��250��5   	     � AllowsTransparency  .  � WindowStyle$
 None=�5   	   
������  � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $# ResourceDictionaryButton.xaml?�6%   %    5       � DataContext 5      '   !Stikers.ViewModel.StikerViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   �� -   5        $
��auto��5      $
��auto��5      
���2�2�$��2q�5       �� CornerRadius$ 	0,30,0,30��5      $��3��5       $��2��5!      ��5"      �� 5#      ��5%      � � 5&       � Color$ Honeydew��6+   	 � Offset$		 0.0Q�5'   +   � 5(      $ Beige��6+   $		 0.5Q�5)   +   5*      5,      ._�5.      � 
 � ColumnDefinitions
 5/      �� 50      $��45 �6'   �� 51      $��* �6'   �� 52      $��45 �6'    54      �� 55      $��30 �6$   �� 56      �� 57      $
��auto �6$   .+�59      ��    ButtonStyleStandart#��[  6   $��0��5<      $��2��5=      $��Center=�5>      $��Center=�5?      $��30��5@      $��30��5A      ��5:      �� *CloseWindow+��5;      �� .��5B      �� $��/Resources/delete.png��6   5C      �� 5D      #��[  6   $��0��5G      $��0��5H      $��Right=�5I      $��Center=�5J      $��25��5K      $��25��5L      ��5E      �� *AddNewWindow+��5F      �� .��5M      �� $��/Resources/add.png��6   5N      c� 5O      $��0��6   $��0��5P      $
��Left=�5Q      $��Center=�5R      $��15��5S      $��20��5T      .@�5U      �� ��6   �� *
ClickCloud+��5V      �� .��5W      �� $��/Resources/cloud2.png��6    $��40��5X       $��60��5Y       5Z      �� 5[      ��6   �� *
ClickHeart+��5\      �� .��5]      �� $��/Resources/heart4.png��6    $��40��5^       $��60��5_       5`      5a      �� 5b      $��1��5c      $��0��5d      $��3��5e      $��
10,0,10,10q�5f      $��16(�5g      $��0q�5i       �� TextWrapping$
 Wrap=�5j       �� AcceptsReturn .  �� 
AcceptsTab . ��5b      �� *Text+ �� UpdateSourceTrigger$ 	LostFocus=���5h      Z� 5l      5m      5n      5o      5p      