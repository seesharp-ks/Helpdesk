   M S B A M L   `   `   `  ����C  ?helpdesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:helpdesk.Pageshelpdesk.Pages  5           helpdesk.Pages.DividedPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:helpdesk.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  DividedPage��5
      .��5      � ���#000C40 � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��9* �6   .+�5   
   �� $��2��6   .+�5      � .+�5      �� -   5         ��Name$
 Open��5       &  "MaterialDesignFloatingActionButton#��[  6'   $��11(�6c   $��Ввод��6q   $��1q�6�   $��1 1 25 1q�6�   $��Center=�6�   ���#0071BC6�   �� 5      -   5        $
 Save��5      #��[  6'   $��11(�6c   $��
Вывод��6q   $��1q�6�   $��1 1 25 1q�6�   $��Center=�6�    � Cursor$
 Hand��6�   ���#0071BC6�   5      �� 5      -   5         ��Name$ tbSearch��5      $��Bottom=�6(   $��Stretch=�6C   $��0q�6a   $��10q�6m   6y   5      �� 5   
   $��1��6   $��Stretch=�6"   $��Stretch=�6@   .@�5       �� ��5!      �� 5"       �� Orientation$ 
Horizontal=�6!   .+�5#      �� $��3q�6$   Содержание6;   5$      ��5&      �� 5'      -   5         ��Name$ lvMenu��5'      $��Disabled=�6/   
������ .@�5(      �� -   5         ��Name$ 
lviWelcome��5(   '   $��60��6;   	 �� 
IsSelected	 .  .��5)      � 
������ .+�5*   "   '  !MaterialDesignThemes.Wpf.PackIcon  $��7q�6:   
   Kind$
 HumanGreetingVariant=�5+   )   $��30��6E   $��30��6P   �� 5,   "   $&�� Добро пожаловать!��6,   $��20 10q�5-   ,   $��Center=�6;   5.      5/      �� 50      -   5        $ lviTemporary��50   '   $��60��6=   .��51      � .+�52   "     $��7q�6:   $
 QuestionMark=�53   )   $��30��6=   $��30��6H   �� 54   "   $"��Пример вопроса.��6,   $��20 0 0 0q�55   ,   $��Center=�6>   56      57      �� 58      -   5        $ lviAddEditDelete��58   '   $��60��6A   .��59      � .+�5:   "     $��7q�6:   $
 CommentEditOutline=�5;   )   $��30��6C   $��30��6N   �� 5<   "   $T��NРабота со справочной системой -- Сотрудник.��6,   $��20 0 0 0q�5=   ,   $��Center=�6>   5>      5?      �� 5@      -   5        $ lviAddEditDeleteOp��5@   '   $��60��6C   $y�Hidden=�6v   .��5A      � .+�5B   "     $��7q�6:   $
 CommentEditOutline=�5C   )   $��30��6C   $��30��6N   �� 5D   "   $\��VРабота со справочной системой -- Администратор.��6,   $��20 0 0 0q�5E   ,   $��Center=�6>   5F      5G      5H      5J      �� 5K      ��5L      �� 5M      $ 
Horizontal=�6!   .+�5N      �� $��3q�6$   О программе6<   5O      ��5Q      �� 5R      $G��AВыпускная квалификационная работа.��6    5T      5U      �� 5V   
   -	   5         ��Name$ 	rtbAnswer��5V   ^    �� 
IsReadOnly .  �� IsDocumentEnabled . $��1��6A   $��1��6Q   
�������. �5W      /� -
   5         /�Name$ 	fdAnswers��5W      .T�5X      J� $��18(�6    �� TextAlignment$ Center=�6*   .*�6A   .*�5Y      �� -   5         ��Name$ RunTest��5Y   ,   $
��Bold"�6   6,   5Z      5[      5\      5]      5^      