   M S B A M L   `   `   `  ����C  ?WPF5_1_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF5_1_2.WindowsWPF5_1_2.Windows  5   	   '    !WPF5_1_2.Windows.NewStudentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPF5_1_2.Windows     5   	   -   5          � Title$  NewStudentWindow��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   �� $
��Left=�6   $��23��6-   $��
150,88,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6|   $	��120��6�   ��6a   �� *	FirstName+6�   �� 5   
   $
��Left=�6   $��23��6-   $��150,116,0,0q�69   $
 Wrap=�6N   $	��Top=�6|   $	��120��6�   ��6b   �� *
LastName+6�   �� 5   
   $
��Left=�6   $��
150,53,0,0q�6/   $
��Wrap=�6C   $	��Top=�6q   ��6W   �� *
FullName+6q   �� 5   
   $
��Left=�6   $��	84,95,0,0q�6/   $
��Wrap=�6B   $��	Fornafn: ��6V   $	��Top=�6g   �� 5   
   $
��Left=�6   $��
81,123,0,0q�6/   $
��Wrap=�6C   $��
Eftirnafn:��6W   $	��Top=�6i   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6:   $��150,150,0,0q�6U   $	��Top=�6j    J� RenderTransformOrigin$ 0.496,-0.907&�6�   $	��120��6�      SelectedDate 6   �� *DateOfBirth+6�   �� 5   
   $
��Left=�6   $��
68,154,0,0q�6/   $
��Wrap=�6C   $��Afmælisdagur:��6W   $	��Top=�6l   �� 5   
   -   5        $��Skrá��5      $
��Left=�6    $��197,234,0,0q�6;   $	��Top=�6P   $��75��6h   6s   �� 5   
   -   5         ��Name$ 	lbCourses��5       �� DisplayMemberPath$
 Name��6E   $
��Left=�6^   $	��144��6y   $��
334,88,0,0q�6�   $	��Top=�6�   $	��156��6�   ��6%   �� *	Courses+ � ContextMenu 5      �� 5      .@�5      m� -   5        $��
Fjarlægja��5      62   5      5      �� 5   
   $
��Left=�6   $��
326,67,0,0q�6/   $
��Wrap=�6C   $+��%Skráður í eftirfarandi námskeið:��6W   $	��Top=�6   �� 5   
   -   5        $ lbAllCourses��5      $
 Name��6@   $
��Left=�6Y   $	��144��6t   $��
561,88,0,0q�6�   $	��Top=�6�   $	��174��6�   ��6(   �� 6�   �� 5   
   $
��Left=�6   $��
572,67,0,0q�6/   $
��Wrap=�6C   $��Námskeið í boði��6W   $	��Top=�6n   5      5      