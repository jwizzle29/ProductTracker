   M S B A M L   `   `   `  ����I  EProductTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ProductTrackerProductTracker  5   	   E'clr-namespace:ProductTracker.ViewModelsProductTracker.ViewModels  5   	   9!clr-namespace:ProductTracker.ViewProductTracker.View  5   	       ProductTracker.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ProductTracker     5   	   =	viewModel'clr-namespace:ProductTracker.ViewModels     5   	   6userCtrl!clr-namespace:ProductTracker.View     5   	     � Title$  
MainWindow��5
   	   $	��650��5   	   $
��1000��5   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5      &    ProductTracker.ViewModels.MainVM 
  MainVM*   $ProductTracker.ViewModels.ProductsVM  
ProductsVM  	HappyFill � MappingMode �� 
StartPoint �� EndPoint � Color � Offset��%�   &	        &	      &	 &       5   
   6     5   
   6   �� 5   
   $ Absolute=�60   $ 650,10&�6G   $ 800,350&�6[   .��5      � $ 	AliceBlue��6   $	 0.0Q�6-   � 5      $ Black��6   $	 1.0Q�6)   5      5      .��5      �� $��5q�6    �� CornerRadius$ 2��6!   	 �� Padding$	 15q�62   $��6��6?   $��2��6P   ._�5   
   �� $��6��6   $��2��5      .��5      �� $��6��6   $��2��6*   
 � DataContext#
 [  5       �� SelectedIndex 5      �� *SelectedIndex+.@�5      �� $��Product Entry��6   .��5      � #
 [  6   
������� � RowDefinitions 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'       � ColumnDefinitions 5*      �� 5+      $��* �6/   �� 5,      $��* �6/   �� 5-      $��2* �6/   .+�5/      ��  �� Orientation$ 
Horizontal=�6%   $��Right=�6>   $��1��6Z   $��2��6j   $��0,-44,22,52.667q�6{   .+�50      �� $��30��6%   $��30��61   ��6<   �� *ProductsVM.AddProductCommand+.��51   "   �� $��/Icons/add.png��6(   $	��Top=�6@   52      �� 53      $��30��6%   $��30��61   ��6<   �� *!ProductsVM.DeleteProductCommand+.��54   "   �� $��/Icons/garbage.png��6(   $	��Top=�6D   55      �� 56      $��30��6%   $��30��61   ��6<   �� *ProductsVM.SaveProductCommand+.��57   "   �� $��/Icons/save.png��6(   $	��Top=�6A   58      59      �� 5:      $��2��6#   $��6��5;   #   $��15q�5<   #   
���   �$��Product Grid��5>   #   $��13(�5?   #   .��5A          ProductTracker.View.GridUC  $��2��6.   $��6��5B   *   
���   �5C   *   5D      �� 5F      $��1��6#   $��6��5G   #   $��2��5H   #   $��15q�5I   #   
���   �$��Product Entry��5K   #   $��13(�5L   #   .��5M      #   ProductTracker.View.ProductUC  $��1��61   $��6��5N   -   $��2��5O   -   $��Stretch=�5P   -   
���   �5Q   -   5R      5S      5T      �� 5U      $��Portal View��6   .��5V      *   $ProductTracker.View.KeywordMappingUC  5W      �� 5X      $��Keyword History��6   .��5Y      *   $ProductTracker.View.KeywordHistoryUC  5Z      �� 5[      $��Product History��6   .��5\      *   $ProductTracker.View.ProductHistoryUC  5]      5^      5_      5`      5a      