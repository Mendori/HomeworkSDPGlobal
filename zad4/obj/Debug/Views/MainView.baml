   M S B A M L   `   `   `  ����?  ;zad4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:zad4.Views
zad4.Views  5   	       zad4.Views.MainView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:zad4.Views     5   	     � Title$  MainView��5   	   $��346.524��6   $��737.968��6+   .��5	      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� $��
_Open File��6    m� Command 6/   �� *
OpenFile+m� 5      $��
_Save File��6    6/   �� *
SaveFile+m� 5      $��_Exit��6   5      5      � 5   
   $��0��6   $
��Left=�6   $
��5,25q�67   $��Center=�6E    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    .+�5&      �� $��0��6   $��Inv. No.��6%   �� 5'      $��1��6   $	��100��6#   ��6/   ��  �� Path$ NewBook.InventoryNumber� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . �� 5(      $��2��6   $��Author��6%   �� 5)      $��3��6   $	��200��6#   ��6/   �� $ NewBook.Author�$ TwoWay=�$ PropertyChanged=� . �� 5*      $��4��6   $��Title��6%   �� 5+      $��5��6   $	��200��6#   ��6/   �� $ NewBook.Title�$ TwoWay=�$ PropertyChanged=� . �� 5,      $��6��6   $��Year/Publisher��6%   �� 5-      $��7��6   $	��200��6#   ��6/   �� $ NewBook.YearPublisher�$ TwoWay=�$ PropertyChanged=� . �� 5.      $��8��6   $��Price��6%   �� 5/      $��9��6   $��80��6#   ��6.   �� $ NewBook.Price�$ TwoWay=�$ PropertyChanged=� . �� 50      -   5         ��Name$ btnAddStudent��50   #   $��10��6   $��Add new book��6:   ��6Q   �� *	AddBook+ � 	Resources 54      	 �� 
TargetType
 �� Property �� Value   ValidatedTextBoxTemplate �� Orientation ��Name �� Triggers P� Property P� Value �� Self �� RelativeSource��%�  '��       &	  p     '�� :    7   �� 55      "	 ��6   .�56      �� 
 � ��$
 Bold"�63   �� 57      
 � ��$
 Left=�6<   58      �� 5;      .R�5<      �� $ 
Horizontal=�6!   .+�5=      �� $ textBox��64   �� 5>      $��Center=�5?      $
��Bold"�6   $��20(�6.   $��!��6<   
���  ��6E   5@      5A      �� 5B      "	 ��6    5C      P� 5D       �@=�HasError . . �5E      �� 
 �@�ToolTip 68   �� # Z $) #(Validation.Errors)[0].ErrorContent�5F      .�5H      �� 
 � ��$
 Left=�6<   �� 5I      
 � ��$ 0  , 0, 0, 10q�6/   �� 5J      
 �@=�ErrorTemplate8   5K   %   5L      5P      5Q      �� 5T   
   $��1��6   
�������$��Stretch=�5U      ��5T   4   �� $ Books� �� View 5V      �� 5W      .P�5X      �� $��Inventory Number��6%    �� DisplayMemberBinding 5Y      �� $ InventoryNumber��� 5Z      $��Author��6%    5[      �� $ Author��� 5\      $��Title��6%    5]      �� $ Title��� 5^      $��Year/Publisher��6%    5_      �� $ YearPublisher��� 5`      $��Price��6%    5a      �� $ Price�5b       5g      ��%�   '��       �� 5h      "	 ��6   .�5i      �� 
 � ��$
 Bold"�63   �� 5j      
 � ��
 �  ��63   �� 5k      
 � ��
 ����63   5l      5m      5o      5r      5s      