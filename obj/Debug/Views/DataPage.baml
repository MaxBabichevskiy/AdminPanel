   M S B A M L   `   `   `  ����C  ?WpfApp14, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp14.ViewsWpfApp14.Views  5          WpfApp14.Views.DataPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfApp14.Views     5      -   5          N� Title$  DataPage��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.8* �6   �� 5      $
��0.1* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      .+�5      �� $��Найти: ��6   $��16(�6'   �� 5      $	��300��6   $��16(�6"   5      �� 5   
   -   5        $��20��5      $	��100��6   $
��Left=�6)   $��	20 0 0 0 q�6D   $
��Back��6W   6f   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ UserGrid��5       $��1��6      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Id+  5      $ Login��6%   $ * 64    6>   �� *Login+  5       $ Password��6%   $ * 67    6A   �� *
Password+  5!      $ Roles��6%   $ * 64    6>   �� *Roles.Names+5#      �� 5&   
   $��2��6   .+�5'      �� -   5        $��20��5'      $	��100��6!   $
��Left=�6.   $��
20 10 0 0 q�6I   $��Delete��6]   6n   �� 5(      -   5        $��20��5(      $	��100��6!   $��Center=�6.   $��
0 -20 0 0 q�6K   $��Change��6_   6p   �� 5)      -   5        $��20��5)      $	��100��6!   $��Right=�6.   $��0 -20 20 0 q�6J   $	��Add��6_   6m   5*      5+      5,      