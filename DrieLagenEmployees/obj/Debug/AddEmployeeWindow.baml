   M S B A M L   `   `   `  ����M  IDrieLagenEmployees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DrieLagenEmployeesDrieLagenEmployees  5   	   *    $DrieLagenEmployees.AddEmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DrieLagenEmployees     5   	     � Title$  Add Employee��5   	   $��348.903��6   $��732.602��6/   .��5	      � .+�5
   
   �� -   5         ��Name$ employeeFirstNameLabel��5
      $��Employee First Name��60   $
��Left=�6N   $��	27,80,0,0q�6i   $	��Top=�6|   $	��138��6�   �� 5   
   -   5        $ employeeLastNameLabel��5      $��Employee Last Name��6/   $
��Left=�6L   $��
27,119,0,0q�6g   $	��Top=�6{   $	��138��6�   �� 5   
   -   5        $ employeeGenderLabel��5      $��Employee Gender��6-   $
��Left=�6G   $��
27,171,0,0q�6b   $	��Top=�6v   $	��138��6�   �� 5   
   -   5        $ employeeBirthdayLabel��5      $��Employee Birthday��6/   $
��Left=�6K   $��
427,41,0,0q�6f   $	��Top=�6z   $	��138��6�   �� 5   
   -   5        $ employeeHireDateLabel��5      $��Employee Hire Date��6/   $
��Left=�6L   $��427,173,0,0q�6g   $	��Top=�6|   $	��138��6�   �� 5   
   -   5         ��Name$ employeeFirstNameTextBox��5      $
��Left=�64   $��23��6O   $��
248,80,0,0q�6[    �� TextWrapping$
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ employeeLastNameTextBox��5      $
��Left=�63   $��23��6N   $��248,119,0,0q�6Z   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ employeeGenderComboBox��5      $
��Left=�63   $��248,171,0,0q�6N   $	��Top=�6c   $	��120��6{   .@�5      �� -	   5        $��maleComboBoxItem��5      $
��Male��63   �� 5      -
   5        $��femaleComboBoxItem��5      $��Female��65   5      (  "System.Windows.Controls.DatePicker  5   
   -   5        $ ��employeeBirthdayDatePicker��5      $
��Left=�67   $��
427,72,0,0q�6R   $	��Top=�6f   $	��205��6~     5   
   -   5        $ ��employeeHireDateDatePicker��5      $
��Left=�67   $��427,199,0,0q�6R   $	��Top=�6g   $	��205��6   �� 5   
   -   5         ��Name$ addEmployeeButton��5      $��Add Employee��6,   $
��Left=�6C   $��
36,288,0,0q�6^   $	��Top=�6r   $	��103��6�   6�   �� 5   
   -   5        $ clearBoxesButton��5      $��Clear Content��6+   $
��Left=�6C   $��162,288,0,0q�6^   $	��Top=�6s   $	��103��6�   6�   �� 5   
   -   5        $ 
exitButton��5      $
��Exit��6%   $
��Left=�64   $��612,288,0,0q�6O   $	��Top=�6d   $	��103��6|   6�   5      5      