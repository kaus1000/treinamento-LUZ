   M S B A M L   `   `   `  ����D  @SchoolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaEscola.ViewSistemaEscola.View  5   	   7 clr-namespace:SistemaEscola.EnumSistemaEscola.Enum  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   (    "SistemaEscola.View.FormularioAluno   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SistemaEscola.View     5   	   3local2 clr-namespace:SistemaEscola.Enum     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
Formulario��5
   	   $	��190��6   $	��280��6)    � 	Resources 5         dataEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%s   &	        S� 5   
   $ 	GetValues��6.   "  6E    5      M� 5      $ local2:Serie��6   5      5      .��5      �� .+�5   
   � $��5q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5       .+�5#      �� $��0��5$      $��0��5%      .��6   Nome6   �� 5&      -   5        $��StringTextBoxNome��5'      $��0��5(      $��1��5)      $��Center=�5*      ��5+      �� *Nome+6   �� 5-      $��1��5.      $��0��5/      .��6   	Sobrenome6!   �� 50      -   5        $��StringTextBox��51      $��1��52      $��1��53      $��Center=�54      ��55      �� *	Sobrenome+6#   �� 57      $��2��58      $��0��59      .��6   Serie6   �� 5:      -   5        $��
ComboSerie��5:      $��	71,0,0,26q�6�   $��2��6�   $��2��6�   $��2��6�   ��6)   ��  �� Source# [  	 �� SelectedItem	 6b   �� *Serie+
 �� Text
 6�   �� *Serie+5<      �� 5>      $��3��5?      $��0��5@      .��6   	Matricula6!   �� 5A      -   5        $��NumberTextBox��5B      $��4��5C      $��1��5D      $��Center=�5E      ��5F      �� *	Matricula+6#   5H      �� 5I   
   -   5        $	��100��5J      $��	Confirmar��5K      
����������	#FF993399���	#FF993399$��26��6n   $	��300��6z    5L       �� 
TargetType �� Property �� Value��%^   '��       �� 5M      " ��6   .�5N      ��  �@��CornerRadius$ 3��65   5O      5P      5Q      5T      5U      