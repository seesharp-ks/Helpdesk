   M S B A M L   `   `   `  ����C  ?helpdesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:helpdesk.Windowshelpdesk.Windows  5   	   !    helpdesk.Windows.AuthWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:helpdesk.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Авторизация��5	   	   $	��300��6   $	��300��6-   $	��300��6<   $	��300��6H    � 
ResizeMode$ NoResize=�6U    � Icon$/ )pack://application:,,,/Resources/logo.png��6k   .��5
      � ���#000C40 � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��5* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��8* �6   .+�5   
   '  !MaterialDesignThemes.Wpf.PackIcon  $��0��6"   $��7q�62      Kind$ BookOpenPageVariant=�6=   $��30��6X   $��30��6c   $��Center=�6o   $��Center=�6�   
�������6�   �� 5   
   $��Cascadia Code)�6   $��1��6/   $)��#Справочная система��6?   $��10q�6Y       MaterialDesignBody1TextBlock#��[  6e   $
��Left=�6�   $��Center=�6�   
�������6�   � 5   
    � Orientation$ Vertical=�6   $��1��6+   $��Stretch=�68   $��Center=�6V   .+�5      �� $��Global Sans Serif)�6   $��Логин:��67   $��10q�6E   #��[  6Q   
�������$��Right=�6�   �� 5      $��Global Sans Serif)�6   $��Пароль:��67   $��10q�6F   #��[  6R   
�������$��Right=�6�   5      � 5   
   $ Vertical=�6   $��1��6+   $��1��68   $��Stretch=�6H   $��Center=�6f   .+�5      �� -   5         ��Name$ tbLogin��5   �   ���	#33F0F2F0  MaterialDesignTextBoxBase#��[ 6-   $	��200��6`   $��10q�6l   $��40��6x   $��14(�6�   $��Center=�6�   $��Bottom=�6�   ���#c0c0aa$
��Bold"�6�    � Cursor$ Arrow��6  G� 5      -   5        	 G�Name$	 pbPass��5   �   ���	#33F0F2F0 ) %MaterialDesignFloatingHintPasswordBox#��[ 61   $	��200��6p   $��10q�6|   $��40��6�   
 G� 	MaxLength$
 20��6�   $��14(�6�   $��Center=�6�   ���#c0c0aa$
��Bold"�6�   $��Bottom=�6  5      �� 5   
   -   5         ��Name$ btnAuthorize��5   �   ���#0071BC$��0��6&   $��3��66   $��2��6C   $��
Войти��6W    & "MaterialDesignFloatingActionButton#��[ 6g   6�   5      5       