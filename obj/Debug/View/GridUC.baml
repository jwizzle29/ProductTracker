   M S B A M L   `   `   `  ����I  EProductTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProductTracker.ViewProductTracker.View  5           ProductTracker.View.GridUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ProductTracker.View     5        � 	Resources  5
         	HappyFill � MappingMode �� 
StartPoint �� EndPoint � Color � Offset��%�   &	        �� 5   
   $ Absolute=�60   $ 650,10&�6G   $ 800,350&�6[   .��5      � $ 	AliceBlue��6   $	 0.0Q�6-   � 5      $ Black��6   $	 1.0Q�6)   5      5      .��5      �� $��0q�6    �� CornerRadius$ 10��6!   
���   �._�5   
   � .+�5      &   System.Windows.Controls.DataGrid  $	��400��5         AutoGenerateColumns .     
IsReadOnly . 
�������
���   �
���   ���5      �� *ProductsVM.Products+	 �� SelectedItem	 5      �� *ProductsVM.SelectedProduct+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Portal��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Portal+  5      $ Product Name��6)    6?   �� *ProductName+  5      $ Keyword��6)    6:   �� *	Keyword+  5       $ Category��6)    6;   �� *
Category+  5!      $
 Rank��6)    67   �� *Rank+  5"      $ Review Count��6)    6?   �� *ReviewCount+  5#      $ 
Entry Date��6)    6=   �� *	EntryDate+  5$      $ Description��6)    6>   �� *Description+5&      5'      5(      5)      