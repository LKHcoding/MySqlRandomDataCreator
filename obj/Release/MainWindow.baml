   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2      WpfApp2.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp2       � Title$+  %Mysql Random Data Creator [LKHcoding]��$	��450��$	��800��.���  � RowDefinitions �� $��30 ��� $��30 ��� $��30 ��� $��* �.+��� -    ��Name$ ListBox��$��3���� -   $��	DB Insert��$
��Left=�$��27,0,0,0q�$��1��$��Center=� J� RenderTransformOrigin$ -0.545,0.102&�$��30��$��71���� -    ��Name$ DBname��$
��Left=�$��	239,0,0,0q�$��1��$��	membersql�� �� TextWrapping$
 Wrap=�$��Center=�$	��123��$��28���� $��DBName��$
��Left=�$��	167,0,0,0q�$��1��$��Center=�$��30��$��67���� $��Table��$
��Left=�$��	428,0,0,0q�$��1��$��Center=�$��30��$��41���� -   $ 	TableName��$
��Left=�$��	488,0,0,0q�$��1��$	��mem��$
 Wrap=�$��Center=�$	��123��$��28���� $��howmuch��$
��Left=�$��	167,0,0,0q�$��Center=�$��32��$��72���� -   $ howmuch��$
��Left=�$��	239,0,0,0q�$��10��$
 Wrap=�$��Center=�$	��123��$��30���� $+��%Column 명을 6개 입력해주세요��$
��Left=�$��2��$��Center=��� -   $ Column1��$��2��$
��Left=�$��	200,0,0,0q�$��memberid��$
 Wrap=�$��30��$��80���� -    ��Name$
 Chk1��$��2��$
��Left=�$��	185,7,0,0q� d� 	IsChecked$
 TrueY�{�.  �� -   $
 Chk2��$��2��$
��Left=�$��	285,7,0,0q�$
 TrueY��� -	   $
 Chk3��$��2��$
��Left=�$��	385,7,0,0q�$
 TrueY��� -
   $
 Chk4��$��2��$
��Left=�$��	485,7,0,0q�$
 TrueY��� -   $
 Chk5��$��2��$
��Left=�$��	585,7,0,0q�$
 TrueY��� -   $
 Chk6��$��2��$
��Left=�$��	685,7,0,0q��� -   $ Column2��$��2��$
��Left=�$��	300,0,0,0q�$
��name��$
 Wrap=�$��30��$��80���� -   $ Column3��$��2��$
��Left=�$��	400,0,0,0q�$	��age��$
 Wrap=�$��30��$��80���� -   $ Column4��$��2��$
��Left=�$��	500,0,0,0q�$��address��$
 Wrap=�$��30��$��80���� -   $ Column5��$��2��$
��Left=�$��	600,0,0,0q�$��phoneNo��$
 Wrap=�$��30��$��80���� -   $ Column6��$��2��$
��Left=�$��	700,0,0,0q�$��email��$
 Wrap=�$��30��$��80���� -   $
 DBID��$
��Left=�$��	490,0,0,0q�$
��root��$
 Wrap=�$��Center=�$��76��$��24���� -   $
 DBPW��$
��Left=�$��	593,0,0,0q�$��rootroot��$
 Wrap=�$��Center=�$��87��$��24���� $��Mysql ID/PW��$
��Left=�$��	393,0,0,0q�$��Center=�$��87��