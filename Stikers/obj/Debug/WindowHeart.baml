   M S B A M L   `   `   `  ����B  >Stikers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Stikers.ViewModelStikers.ViewModel  5   	       Stikers.WindowHeart   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   5	viewModelclr-namespace:Stikers.ViewModel     5   	   -   5        $	��200��5   	   $	��250��5   	     � WindowStyle$
  None=�5   	    � AllowsTransparency .  � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $# ResourceDictionaryButton.xaml?�6%   %    5       � DataContext 5      '   !Stikers.ViewModel.StikerViewModel  5   
   ��5      �� 5   
    �� ImageSource$ /Resources/heart4.png��6   .��5      � $��	25,0,25,0q�6    � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��40 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��110 �6   �� 5       $��* �6   .+�5"   
   ��    ButtonStyleHeart#��[  6   $��0��5%      $��2��5&      $��Center=�5'      $��Center=�5(      $��30��5)      ��5#      �� *CloseWindow+��5$      �� .��5*      �� $��/Resources/delete.png��6   5+      �� 5,   
   #��[  6   $��0��5/      $��0��50      $��Right=�51      $��Center=�52      $��20��53      ��5-      �� *AddNewWindow+��5.      �� .��54      �� $��/Resources/addPink.png��6   55      c� 56   
   $��0��6   $��0��57      $
��Left=�58      $��Center=�59      $��15��5:      $��20��5;      $��5q�5<      .@�5=      �� ��6   �� *ClickStandart+��5>      �� .��5?      �� $��/Resources/first.png��6   $��40��5@      $��60��5A      5B      �� 5C      ��6   �� *
ClickCloud+��5D      �� .��5E      �� $��/Resources/cloud2.png��6   $��40��5F      $��60��5G      5H      5I      �� 5J   
   $��1��5K      $��0��5L      $��3��5M      $��16(�5N      $��Stretch=�5O      $��Stretch=�5P      $��0q�5R      	 �� TextWrapping$
	 Wrap=�5S      
 �� AcceptsReturn
 .  �� 
AcceptsTab . ��5J      �� *Text+ �� UpdateSourceTrigger$ 	LostFocus=���5Q      Z� 5U      5V      5W      