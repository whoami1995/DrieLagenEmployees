   M S B A M L   `   `   `  ����M  IDrieLagenEmployees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DrieLagenEmployeesDrieLagenEmployees  5   	   +    %DrieLagenEmployees.EditEmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DrieLagenEmployees     5   	     � Title$  EditEmployeeWindow��5   	   $��294.691��6$   $��427.433��65   .��5	      � $��0,0,2,0q�6   .+�5
   
   �� -   5         ��Name$ employeeFirstNameLabel��5
      $��Employee First Name��60   $
��Left=�6N   $��	32,26,0,0q�6i   $	��Top=�6|   $	��138��6�   �� 5   
   -   5        $ employeeLastNameLabel��5      $��Employee Last Name��6/   $
��Left=�6L   $��	32,65,0,0q�6g   $	��Top=�6z   $	��138��6�   �� 5   
   -   5        $ employeeGenderLabel��5      $��Employee Gender��6-   $
��Left=�6G   $��
32,102,0,0q�6b   $	��Top=�6v   $	��138��6�   �� 5   
   -   5        $ employeeBirthdayLabel��5      $��Employee Birthday��6/   $
��Left=�6K   $��
32,151,0,0q�6f   $	��Top=�6z   $	��138��6�   �� 5   
   -   5        $ employeeHireDateLabel��5      $��Employee Hire Date��6/   $
��Left=�6L   $��
32,189,0,0q�6g   $	��Top=�6{   $	��138��6�   �� 5   
   -   5         ��Name$ employeeFirstNameTextBox��5      $
��Left=�64   $��23��6O   $��
269,26,0,0q�6[    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��120��6�   ��6�   ��  �� Path$ 
first_name�6�   �� 5   
   -   5        $ employeeLastNameTextBox��5      $
��Left=�63   $��23��6N   $��
269,65,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   ��6�   �� $ 	last_name�6�   �� 5   
   -   5         ��Name$ employeeGenderComboBox��5      $
��Left=�63   $��269,106,0,0q�6N   $	��Top=�6c   $	��120��6{   .@�5      �� -	   5         ��Name$ maleComboBoxItem��5      $
��Male��65   �� 5      -
   5        $ femaleComboBoxItem��5      $��Female��67   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$  employeeBirthdayDatePicker��5      $
��Left=�69   $��184,151,0,0q�6T   $	��Top=�6i   $	��205��6�      SelectedDate 6�   �� $ 
birth_date�  5   
   -   5        $  employeeHireDateDatePicker��5      $
��Left=�69   $��184,191,0,0q�6T   $	��Top=�6i   $	��205��6�    6�   �� $ 	hire_date��� 5   
   -   5        	 ��Name$	 
saveButton��5      $
��Save��6%   $
��Left=�64   $��161,234,0,0q�6O   $	��Top=�6d   $��75��6|   6�   5      5      