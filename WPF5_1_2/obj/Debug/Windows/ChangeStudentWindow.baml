   M S B A M L   `   `   `  ����C  ?WPF5_1_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF5_1_2.WindowsWPF5_1_2.Windows  5   	   *    $WPF5_1_2.Windows.ChangeStudentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPF5_1_2.Windows     5   	   -   5          � Title$  ChangeStudentWindow��5   	   $	��450��6%   $	��800��62   .��5	      � .+�5
   
   �� -   5         ��Name$ 
cbStudents��5
       �� DisplayMemberPath$ FullName��6?   $
��Left=�6\   $��
127,53,0,0q�6w   $	��Top=�6�   $	��120��6�    �� SelectedIndex$ 0��6�   ��6'   �� 6�   �� 5   
   $
��Left=�6   $��
127,92,0,0q�6/   $
��Wrap=�6C   $	��Top=�6q   $	��120��6�   ��6W   �� *
FullName+6�   �� 5   
   $
��Left=�6   $��23��6-   $��127,113,0,0q�69    �� TextWrapping$
 Wrap=�6N   $	��Top=�6}   $	��120��6�   ��6b   �� *	FirstName+6�   �� 5   
   $
��Left=�6   $��23��6-   $��127,151,0,0q�69   $
 Wrap=�6N   $	��Top=�6|   $	��120��6�   ��6b   �� *
LastName+6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6:   $��127,191,0,0q�6U   $	��Top=�6j   $	��120��6�      SelectedDate 6   �� *DateOfBirth+6�   �� 5   
   -   5         ��Name$ lbCurrentCourses��5      $
 Name��6L   $
��Left=�6e   $	��162��6�   $��307,113,0,0q�6�   $	��Top=�6�   $	��154��6�   ��6,   �� *	Courses+ � ContextMenu 5      �� 5      .@�5      m� -   5        $��Afskrá��5      6/   5      5      �� 5   
   $
��Left=�6   $��
73,114,0,0q�6/   $
��Wrap=�6C   $��	TextBlock��6W   $	��Top=�6h   �� 5   
   $
��Left=�6   $��
73,152,0,0q�6/   $
��Wrap=�6C   $��	TextBlock��6W   $	��Top=�6h   �� 5   
   $
��Left=�6   $��	52,53,0,0q�6/   $
��Wrap=�6B   $��Nemendur��6V   $	��Top=�6f   �� 5   
   -   5        $ lbAllCourses��5      $
 Name��6@   $
��Left=�6Y   $	��160��6t   $��521,115,0,0q�6�   $	��Top=�6�   $	��152��6�   ��6(   �� 6�   �� 5   
   $
��Left=�6   $��
307,92,0,0q�6/   $
��Wrap=�6C   $��Núverandi námkskeið��6W   $	��Top=�6r   �� 5   
   $
��Left=�6   $��
521,92,0,0q�6/   $
��Wrap=�6C   $��Öll námskeið í boði��6W   $	��Top=�6r   �� 5   
   -   5        $��Skrá��5      $
��Left=�6    $��172,260,0,0q�6;   $	��Top=�6P   $��75��6h   6s   5      5      