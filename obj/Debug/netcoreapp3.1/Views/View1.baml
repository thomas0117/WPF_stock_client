   M S B A M L   `   `   `  ����  WPF_stock_client"    WPF_stock_client.Views.View1   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Z VPrism.DryIoc.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5      .��5      � 
�������$	��500��6"   $	��500��6/   .+�5   
   ��  �� Orientation$ Vertical=�5      .+�5	      �� $��View1��6   $��Center=�5
      $��Center=�61   $��48(�5      
�������6"   �� 5      $��Center=�5      $��Center=�65   $��30(�5      
��� � ���5      �� *	Message+5      �� 5      $��Center=�5      ��5      �� *GoNextCommand+.��63   導航到下頁6:   �� 5      -   5         ��Name$ button��5      $��Center=�6i   ��6%   �� *ConnectText+��6E   �� *ConnectCommand+6i   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dataGrid��5      $	��185��6)      
IsReadOnly$
 True��66      AutoGenerateColumns$ False��6H      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 股票代碼��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *	StockId+6U     5      $ 股票名稱��6)    67   �� *	StockName+6W     5      $ 價格��6)    65   �� *CurrentPrice+6X     5      $ 	漲跌幅��6)    66   �� *
ChangeRate+6W   	   RowDetailsTemplate	 5      �� 5      .R�5      �� $��0q�6!   
�������
 �� Padding$
 10q�6Q   ._�5      �� $ Vertical=�6)   .+�5   "   �� $ 
Horizontal=�6-   .+�5    &   �� $��12(�60   $��Email: ��6>   $��Center=�6M   �� 5!   &   $��16(�60   
���p�$��Center=�6v   ��6X   �� *EmailAddress+6v   5"   #   �� 5#   "   $ 
Horizontal=�6-   .+�5$   &   �� $��12(�60   $��Phone: ��6>   $��Center=�6M   �� 5%   &   $��16(�60   
���p�$��Center=�6o   ��6X   �� *Phone+6o   5&   #   �� 5'   "   $ 
Horizontal=�6-   .+�5(   &   �� $��12(�60   $��Sales Person: ��6>   $��Center=�6T   �� 5)   &   $��16(�60   
���p�$��Center=�6u   ��6X   �� *SalesPerson+6u   5*   #   5+      5,      5-      5/      50      51      52      