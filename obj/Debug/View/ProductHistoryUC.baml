   M S B A M L   `   `   `  ����I  EProductTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProductTracker.ViewProductTracker.View  5      *    $ProductTracker.View.ProductHistoryUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ProductTracker.View     5        � 	Resources  5
         	HappyFill � MappingMode �� 
StartPoint �� EndPoint � Color � Offset��%�   &	        �� 5   
   $ Absolute=�60   $ 650,10&�6G   $ 800,350&�6[   .��5      � $ 	AliceBlue��6   $	 0.0Q�6-   � 5      $ Black��6   $	 1.0Q�6)   5      5      .��5      � 
������� � RowDefinitions 5   
    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��1��6   $��6��6'   $��15q�68   
���   �$��13(�5      $��Product History��5      .��5      &   System.Windows.Controls.DataGrid  $	��400��6      AutoGenerateColumns .  	   
IsReadOnly	 . 
���   �
�������
���   �
 �� SelectedItem
 5      �� *ProductsVM.SelectedProduct+   Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Date Modified��6)     5%      $ Portal��6)     5&      $ Product Name��6)     5'      $ Keyword��6)     5(      $
 Rank��6)     5)      $ Review��6)     5*      $
 Note��6)   5,      5-      5.      5/      