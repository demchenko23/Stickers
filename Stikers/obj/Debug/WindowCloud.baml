   M S B A M L   `   `   `  ����B  >Stikers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Stikers.ViewModelStikers.ViewModel  5   	       Stikers.WindowCloud   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   5	viewModelclr-namespace:Stikers.ViewModel     5   	   -   5        $	��200��5   	   $	��250��5   	     � WindowStyle$
  None=�5   	    � AllowsTransparency .  � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $# ResourceDictionaryButton.xaml?�6%   %    5       � DataContext 5      '   !Stikers.ViewModel.StikerViewModel  5   
   ��5      �� 5   
    �� ImageSource$ /Resources/cloud2.png��6   .��5      � $��45,25,45,40q�6    � ColumnDefinitions 5   
   �� 5      $��45 �6   �� 5      �� 5      $��40 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5!   
   ��    ButtonStyleCloud#��[  6   $��2��5$      $��0��5%      $��Stretch=�5&      $��Stretch=�5'      ��5"      �� *CloseWindow+��5#      �� .��5(      �� $��/Resources/delete.png��6   5)      �� 5*   
   #��[  6   $��Right=�5-      $��Center=�5.      $��25��5/      $��25��50      ��5+      �� *AddNewWindow+��5,      �� .��51      �� $��/Resources/addBlue.png��6   52      c� 53   
   $��0��6   $��0��54      $
��Left=�55      $��Center=�56      $��3q�57      $��15��58      $��20��59      .@�5:      �� ��6   �� *ClickStandart+��5;      �� .��5<      �� $��/Resources/first.png��6   $��40��5=      $��60��5>      5?      �� 5@      ��6   �� *
ClickHeart+��5A      �� .��5B      �� $��/Resources/heart4.png��6   $��40��5C      $��60��5D      5E      5F      �� 5G   
   $��0��5H      $��1��5I      $��3��5J      $��16(�5K      $��0q�5M      	 �� TextWrapping$
	 Wrap=�5N      
 �� 
AcceptsTab
 .  �� AcceptsReturn . ��5G      �� *Text+ �� UpdateSourceTrigger$ 	LostFocus=���5L      Z� 5P      5Q      5R      