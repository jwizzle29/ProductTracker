   M S B A M L   `   `   `  ����I  EProductTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProductTracker.ViewProductTracker.View  5      9!clr-namespace:ProductTracker.ViewProductTracker.View  5      *    $ProductTracker.View.KeywordMappingUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ProductTracker.View     5      6userCtrl!clr-namespace:ProductTracker.View     5        � 	Resources  5
         	HappyFill � MappingMode �� 
StartPoint �� EndPoint � Color � Offset��%�   &	        �� 5   
   $ Absolute=�60   $ 50,10&�6G   $ 800,350&�6Z   .��5      � $ 	AliceBlue��6   $	 0.0Q�6-   � 5      $ Black��6   $	 1.0Q�6)   5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��1��6J   $��1��6Z   $��
0,-4,21,10q�6k   .+�5       �� $��30��6   $��30��6!   ��6,   �� *ProductsVM.AddProductCommand+.��5!      �� $ ��/Icons/speech-bubble-1.png��6   $	��Top=�6<   5"      �� 5#      $��30��6   $��30��6!   ��6,   �� *ProductsVM.SaveProductCommand+.��5$      �� $��/Icons/save.png��6   $	��Top=�61   5%      5&      �� 5'   
   $��2��5(      $��6��5)      $��15q�5*      
���   �$��Product Grid��5,      $��13(�5-      .��5.      &   System.Windows.Controls.DataGrid  $��2��6   $��6��5/      $	��400��50      
���   �	   AutoGenerateColumns	 .  
   
IsReadOnly
 . 
���   �
�������$��0��59       � DataContext 54      �� *PortalViewVM+��55      �� *PortalViewItems+ �� SelectedItem 56      �� *SelectedProduct+   Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ Date Modified��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *DateModified+  5=      $ Portal��6)    69   �� *Portal+  5>      $ Product Name��6)    6?   �� *ProductName+  5?      $ Keyword��6)    6:   �� *	Keyword+  5@      $
 Rank��6)    67   �� *Rank+  5A      $ Review��6)    69   �� *Review+  5B      $
 Note��6)    67   �� *Note+5D      5E      �� 5F   
   $��1��6   $��6��5G      $��2��5H      $��15q�5I      
���   �$��Product Modification��5K      $��13(�5L      .��5M      .   (ProductTracker.View.KeywordMappingDataUC  $��1��6,   $��6��5N   -   $��2��5O   -   
���   �5P   -   5Q      5R      5S      