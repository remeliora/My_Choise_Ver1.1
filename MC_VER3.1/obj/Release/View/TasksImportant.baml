   M S B A M L   `   `   `  ���� B  >MC_VER3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MC_VER3.ViewMC_VER3.View  5clr-namespace:MC_VER3.ViewModelMC_VER3.ViewModel  !    MC_VER3.View.TasksImportant   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:MC_VER3.View     .vmclr-namespace:MC_VER3.ViewModel     
������   � DataContext  (  "MC_VER3.ViewModel.TasksImportantVM  .��� .+��� 
������  �� CornerRadius$ 10��
�������._�� -    �Name$ 	Main_Grid�� � RowDefinitions �� $��40 ��� $	��315 ��� $	��270 �.+��� $��0�� �� Orientation$ 
Horizontal=�$
��Left=�.+��� ���#1e2a3b$	��845��$��40��$��
0, 0, 0, 0q�
������ $��1q�$ 10��._��� $��Center=�
������ ���#9ea4ad$��
0, 5, 0, 5q��� $��15��$��15��$��10, 0, 0, 3.5q�$&�� /Images/icons8-поиск-91.png�� �� 
 � Tag$ Поиск...��$	��795�����#1e2a3b���#9ea4ad$��
Nirmala UI)�$��15(�$��0q�$��Center=�$
��Left=�$��
5, 0, 0, 2q���Z� ���� *ImpTaskFilter+ �� UpdateSourceTrigger$ PropertyChanged=�.����    TasksButtonStyle#���   $��20, 0, 0, 0q�$��40������ *	AddTask+$ PropertyChanged=�.����   ImageButtonsStyle#���  $$��/Images/icons8-плюс-90.png���� #���   $��20, 0, 0, 0q�$��40������ *
SaveList+.���� #���  $.��(/Images/icons8-сохранить-90.png���� #���   $��20, 0, 0, 0q�$��40������ *
RemoveTask+.���� #���  $&�� /Images/icons8-мусор-90.png���� #���   $��20, 0, 0, 0q�$��40������ *RemoveAllList+.���� #���  $@��:/Images/icons8-удалить-базу-данных-90.png���� $��1��$ 
Horizontal=�$��Center=�$��0, 20, 5, 0q�.+��� $��Center=����#1e2a3b���#000000$��0q�$
��1080��$	��295��$��
0, 0, 0, 0q�$ 15��._��� $��1��$
��1050��$	��265��$��0q�
������ $��10, 10, 10, 10q����� *ImportantCollectionView+$ PropertyChanged=� �� SelectedItem �� *SelectedTask+����  �� 
TargetType" ��.��� 	 �� Property	 � ��
 �� Value
 ��  �� 
TargetType" ��.R��� #��z��$ 10��._��� $��10, 5, 10, 5q� �� Triggers P�  P� Property �@��
IsSelected P� Value . . ��� 	 � ��
 �#36465c�� 	 � ��
 �#FFFFFF���� .R��� $��5q�.+���   TextHeadingStyle#���  ���#1E90FF$��
0, 3, 0, 5q�$��18(�����  �� Path$
 Task���   TextDescriptionStyle#���  ���#FFFFFF$��15(�$��
0, 5, 0, 3q����� $ SubTask��� $��2��$ 
Horizontal=�$��Center=�$��0, 20, 5, 0q�.+��� $��Center=����#1e2a3b���#000000$��0q�$
��1080��$	��250��$��
0, 0, 0, 0q�$ 15��._��� $��1��$
��1050��$	��220��$��10, 10, 10, 10q�  �� *SelectedTask+.+��� $@��:Редактировать заголовок задачи��$��
Nirmala UI)����#FFFFFF$��18(�$��SemiBold"�$��15, 10, 10, 5q��� ���#36465c
���   �$��0q�$
��1030��$��40��$ 10��$
��Left=�$��10, 10, 10, 10q�._��� $0 *Редактировать задачу...�����#36465c���#FFFFFF$��
Nirmala UI)�$��15(�$��0q�$��Center=�$��10, 0, 10, 0q���Z� ���� *Task+$ PropertyChanged=��� $>��8Редактировать описание задачи��$��
Nirmala UI)����#FFFFFF$��18(�$��SemiBold"�$��15, 30, 10, 5q��� ���#36465c
���   �$��0q�$
��1030��$��40��$ 10��$
��Left=�$��10, 10, 10, 10q�._��� $4 .Редактировать описание...�����#36465c���#FFFFFF$��
Nirmala UI)�$��15(�$��0q�$��Center=�$��10, 0, 10, 0q���Z� ���� *	SubTask+$ PropertyChanged=�