   M S B A M L   `   `   `  ����D  @SchoolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaEscola.ViewSistemaEscola.View  5   	   7 clr-namespace:SistemaEscola.EnumSistemaEscola.Enum  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   .    (SistemaEscola.View.FormularioFuncionario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SistemaEscola.View     5   	   3local2 clr-namespace:SistemaEscola.Enum     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
Formulario��5
   	   $	��220��6   $	��280��6)    � 	Resources 5         dataEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%s   &	        S� 5   
   $ 	GetValues��6.   "  6E    5      M� 5      $ local2:Cargo��6   5      5      .��5      �� .+�5   
   � $��5q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5       $
��Auto �6#   �� 5!      .+�5$      �� $��0��5%      $��0��5&      .��6   Nome6   �� 5'      -   5        $��StringTextBoxNome��5(      $��0��5)      $��1��5*      $��Center=�5+      ��5,      �� *Nome+6   �� 5.      $��1��5/      $��0��50      .��6   	Sobrenome6!   �� 51      -   5        $��StringTextBox��52      $��1��53      $��1��54      $��Center=�55      ��56      �� *	Sobrenome+6#   �� 5:      $��3��5;      $��0��5<      .��6   	Salario6   �� 5=      -   5        $��3��5@      $��1��5A      $��Center=�5B      ��5C      �� *	Salario+6!   �� 5E      $��4��5F      $��0��5G      .��6   CodFuncionario6&   �� 5H      -   5         ��Name$ CodFuncionario��5I      $��4��5K      $��1��5L      $��Center=�5M      ��5N      �� *CodFuncionario+�� 5R      $��4��5S      $��0��5T      $��
0,30,0,-30q�6%   .��69   Cargo6@   �� 5U      -   5        $��
ComboCargo��5U      $��71,32,0,-22q�6�   $��4��6�   $��2��6�   ��6)   �� 	 �� Source#	 [  
 �� SelectedItem
 6b   �� *Cargo+ �� Text 6�   �� *Cargo+5W      5Z      �� 5[   
   -   5        $	��100��5\      $��	Confirmar��5]      
�������$��Stretch=�6?   $��0,30,0,0q�6]   ���	#FF993399���	#FF993399$��24��6�   $	��278��6�    5^       �� 
TargetType �� Property �� Value��%_   '��       �� 5_      " ��6   .�5`      ��  �@��CornerRadius$ 3.��65   5a      5b      5c      5e      5g      