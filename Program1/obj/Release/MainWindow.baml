   M S B A M L   `   `   `  ����   Program1    Program1.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$&   Метод Монте-Карло��$��384.426��$��694.836��$��Center=����	#FFE1F0EE.���  � RowDefinitions �� $	��95* ��� $
��259* � � ColumnDefinitions �� $
��114* ��� $
��115* �.+��� $��X��$
��Left=�$��
127,11,0,0q�$	��Top=�$��66�� J� RenderTransformOrigin$ 0.533,0.146&�$��20(�$
��Bold"�$��37���� $��Y��$
��Left=�$��
258,11,0,0q�$	��Top=�$ -0.537,0.513&�$��20(�$
��Bold"�$��37��$��22���� $��Точка a��$
��Left=�$��	15,42,0,0q�$	��Top=�$��16(�$��34��$��75���� $��Точка c��$
��Left=�$��	15,81,0,0q�$	��Top=�$��16(�$��34��$��75��$��2���� -   $��	textBoxAX��$
��Left=�$��25��$��	90,48,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��103���� -   $��	textBoxAY��$
��Left=�$��25��$��
218,48,0,0q�$
 Wrap=�$�� ��$	��Top=�$��99���� -   $��
textBoxСX��$
��Left=�$��25��$��	90,87,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��103��$��2���� -   $��
textBoxСY��$
��Left=�$��25��$��
218,87,0,0q�$
 Wrap=�$�� ��$	��Top=�$��99��$��2���� $
��Left=�$	��165��$��1,10,0,0q�$	��Top=�$	��316��$ 0.705,0.304&�$��Images/KR.png��$��1��$��2���� -   $��	calculate��$��Вычислить��$
��Left=�$��	15,25,0,0q�$	��Top=�$��75��$��22��$��1���� -   $��example��$)��#Контрольный пример��$
��Left=�$��	95,25,0,0q�$	��Top=�$	��142��$��22��$��1���� -   $��Clear��$��Очистить��$
��Left=�$��
242,25,0,0q�$	��Top=�$��75��$ 
0.701,0.47&�$��22��$��1��&   System.Windows.Controls.DataGrid  -   $��dataGridResults��$��Center=�$��15,85.134,28,0q�$	��Top=�$	��160��$	��644��$��2��$	 1,0&�   FrozenColumnCount$ 6��$��1q�   AutoGenerateColumns .  $��1��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 №��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 20 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Id+  $&  Общее число точек��$		 120 
 �� *Points+  $* $Площадь Монте-Карло��$		 140 
 �� *MonteCarloSquare+ �� StringFormat$ 0.000��  $, &Число попавших точек��$		 140 
 �� *CountPoints+  $ Погрешность, %��$		 105 
 �� *Uncertainity+$ 0.000��  $% Время расчёта, мс��$		 115 
 �� *Time+$ 0.0000���� $&�� Реальная площадь:��$
��Left=�$��	15,52,0,0q�$��1��$	��Top=�$	��121��$��28���� -	   $��TextBoxRealSquare��$
��Left=�$��26��$��
141,54,0,0q�$��1��$
 Wrap=�$��
��$	��Top=�$	��129��