   M S B A M L   `   `   `  ����D  @SchoolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchoolApp.ViewsSchoolApp.Views  5   	   7 clr-namespace:SistemaEscola.EnumSistemaEscola.Enum  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	        SchoolApp.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SchoolApp.Views     5   	   3local2 clr-namespace:SistemaEscola.Enum     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��854��6)    � 	Resources 5         dataEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%~   &	        S� 5   
   $ 	GetValues��6.   "  6E    5      M� 5      $ local2:AdicionarPessoas��6   5      5      .��5      � .+�5   
   �� -   5        $	��Top=�5       J� RenderTransformOrigin$ 0.371,0.488&�5   `   $��	4,2,222,7q�6�   ��5      ��  �� Path$ listaPessoas� �� Mode$ OneWay=�	 �� SelectedItem	 5      �� $ PessoaSelecionada�z�5      V� 5      .~�5      �� �� 5      
 �� AngleY$
 -0.536Q�6$   �� 5      T� 5       T� Y$ -2.977Q�6)   5       �� View 5!      �� 5"      .P�5$      �� $
��Nome��6%    �� DisplayMemberBinding 65   �� $
 Nome��� 5%      $��	Sobrenome��6%    68   �� $ 	Sobrenome��� 5&      $��Serie��6%    64   �� $ Serie��� 5'      $��	Matricula��6%    68   �� $ 	Matricula��� 5(      $��Cargo��6%    64   �� $ Cargo��� 5)      $��Salario��6%    66   �� $ Salario��� 5*      $��CodFuncionario��6%    6=   �� $ CodFuncionario�5,      5/      �� 54   
   -   5         ��Name$ Button1��54   t   ���	#FF993399���	#FF993399
�������$��	Adicionar��6�   $
��Left=�6�   $��
672,95,0,0q�6�   $	��Top=�6�   $��41��6  $	��142��6  {�6S   �� *
Desativado+��6�   �� $ CadastroPessoa�6  �� 55   
   ���	#FF993399���	#FF993399
�������$��Editar��6S   $
��Left=�6�   $��674,299,0,0q�6�   $	��Top=�6�   $	��140��6�   $��38��6�   $ 
0.496,1.04&�6�   ��6d   �� $ AtualizarPessoa�6�   �� 56   
   ���	#FF993399���	#FF993399
�������$��Remover��6S   $
��Left=�6�   $��674,368,0,0q�6�   $	��Top=�6�   $ 
0.611,3.96&�6�   $	��140��6�   $��38��6  ��6e   �� $ RemoverPessoa�6  �� 57   
   -   5        $��ComboAdicionarPessoas��57      $
��Left=�6�   $��
672,37,0,0q�6�   $	��Top=�6�   $	��142��6�   $��22��6  ��60   ��  �� Source# [  	 6i   �� *PessoaAdicionar+ �� Text 6�   �� *PessoaAdicionar+6  5=      5>      