   M S B A M L   `   `   `  ���� B  >MC_VER3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MC_VER3MC_VER3  5clr-namespace:MC_VER3.ViewModelMC_VER3.ViewModel      MC_VER3.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:MC_VER3     .vmclr-namespace:MC_VER3.ViewModel     X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  MyChoice�� � Title$ 
MainWindow��$	��720��$
��1235�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency .  � DataContext $  MC_VER3.ViewModel.MainWindowVM  .��� .+��� ���#151f2d �� CornerRadius$ 30��._�� -    �Name$ 	Main_Grid��	 � ColumnDefinitions	 �� $	��110 ��� $
��1125 �.+�� -   $ 	Left_Grid��$��0��
 � RowDefinitions
 �� $	��130 ��� $��* �.+��� $��2�����#1e2a3b$ 30, 0, 0, 30���� $��0�� �� Orientation$ 
Horizontal=�$��Center=�.+��� $��/Images/logo.png��$��60��$��60��$��10, 0, 10, 0q��� $��1��$ Vertical=�$��0, 15, 0, 0q�.+�	� -    	�Name$ Button_Tasks��   MenuButtonsStyle#���   
 � Tag$ #FFFFFF��$��1�� d� 	IsChecked$
 TrueY����� *ShowTasksView+.���� $ 
Horizontal=�  ButtonStackPanelMenuStyle#���  .+�!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ FileAlt=�  menuButtonIcon#���  	� -   $ Button_Importants��#���   $ #FFFFFF��$��1������ *ShowImportantView+.���� $ 
Horizontal=�#���  .+�  $ FileClipboard=�#���  	� -   $ Button_Notes��#���   $ #FFFFFF��$��1������ *ShowNotesView+.���� $ 
Horizontal=�#��[ .+�  $ 	TableList=�#���  � -   $ 
Right_Grid��$��1��
 �� $��70 ��� $	��650 �.+��� -   $��0��
������ �� $��0��$ 
Horizontal=�$��Right=�.+��� -	    ��Name$ Button_Hide��$��Right=�$��35��$��35��$��10, 27 20, 0q�����  �� 
TargetType" ��.���  �� Property � �� �� Value$. (/Images/icons8-вычитание-90.png�� �� Triggers ��  �� Binding �� *IsMouseOver+ �� ElementName$ Button_Hide�� �� Value True.a���  � ��$/ )/Images/icons8-вычитание1-90.png���� -
   $ Button_Close��$��Right=�$��35��$��35��$��0, 10, 20, 0q����� " ��.���  � ��$. (/Images/icons8-умножение-90.png�� ��  �� *IsMouseOver+$ Button_Close�� True.a���  � ��$/ )/Images/icons8-умножение1-90.png���� $��0��$ 
Horizontal=�$
��Left=�
������ .+�#  MaterialDesignThemes.Wpf.Card  $��Center=�$��Center=�
������ +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�.���� $ 
Horizontal=�
������ $��
0, 5, 0, 0q�.+�  $ Clock=�$��25��$��25��$��25, 10, 10, 10q�   
Foreground �#9ea4ad#���  �� -    ��Name$ TxtClock��$��
5, 0, 0, 0q�$��NoWrap=�$��Center=�$��Center=�$��20(����#9ea4adTime�� $��1��$��1��$��20, 5, 20, 20q����� *CurrentView+