   M S B A M L   `   `   `  ����D  @SportClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SportClub	SportClub  5   	   $    SportClub.AbonementsTypeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SportClub     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowStyle$
 None=�5
   	    � WindowState$ 	Maximized=�5   	   $��Corbel Light)�5   	   $��18(�5   	   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $��50 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��3q�6;   .+�5      �� -   5         ��Name$ 	AddButton��5   2   $)��#Добавить абонемент��6   $	��200��6]   $��5q�6i   �� 5      $��Поиск:��6   $��Center=�6%   $��5q�6G   �� 5      -   5         ��Name$ SearchFilterTextBox��5   "   $	��200��6   $��Center=�6a   $��5q�6�   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $
��Left=�6;   $��3q�6V   .+�5      �� -   5        $ 
ExitButton��5      $��
Выход��6)   $
��Left=�69   $	��150��6m   $��5q�6y   �� 5      -   5        $ StartWinButton��5      $��Главное окно��6-   $
��Left=�6D   $	��150��6|   $��5q�6�   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��Right=�6;   $��3q�6W   .+�5       �� -   5        $ PrevPage��5       $��
Назад��6'   $	��100��6N   $��5q�6Z   �� 5!      $��Center=�6P   $��5q�6k   ��6   �� *CurrentPage+ �� StringFormat$ Страница {0}��6k   �� 5"      -   5        $ NextPage��5"      $��Вперёд��6'   $	��100��6O   $��5q�6[   5#      �� 5%   
   -   5        	 ��Name$	 AbonementsTypeListView��5(      $��1��5&      $��Disabled=�5)      
 � Cursor$

 Hand��6C   ��5'      �� *AbonementsTypeList+��5+      �� 5,       �� 
TargetType" ��6   .�5-      ��  �� Property � �� �� Value$
 Left=�6C   5.       � ContextMenu 51      �� 52      .@�53      m� -   5         m�Name$ EditItem��53   6   $ ��Редактировать��6   6H   m� 54      -	   5        $ 
DeleteItem��54   0   $��Удалить��6   6D   55      ��58      �� 59      .R�5:      �  � Orientation$ 
Horizontal=�6    $
��1100��69   $��Center=�6I   5;      ��5>      �� 5?      .R�5@      �� $��1q�6   
���   � �� CornerRadius$ 3��6E   ._�5A      � $��10q�6   .+�5B      �� $	��300��6)   $	��100��65   .+�5C   "   �� $��20(�6,   $��Center=�6:   ��6W   �� *	Abonement+5D      5E      5F      5G      5I      5J      5K      