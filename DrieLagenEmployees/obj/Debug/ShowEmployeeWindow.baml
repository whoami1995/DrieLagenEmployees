   M S B A M L   `   `   `  ����M  IDrieLagenEmployees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DrieLagenEmployeesDrieLagenEmployees  5   	   +    %DrieLagenEmployees.ShowEmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DrieLagenEmployees     5   	     � Title$  	Employees��5   	   $��332.915��6   $��658.307��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ employeeNumberLabel��5
      $��Employee ID��6-   $
��Left=�6C   $��	25,30,0,0q�6^   $	��Top=�6q   $	��138��6�   �� 5   
   -   5        $ employeeFirstNameLabel��5      $��Employee First Name��60   $
��Left=�6N   $��	25,82,0,0q�6i   $	��Top=�6|   $	��138��6�   �� 5   
   -   5        $ employeeLastNameLabel��5      $��Employee Last Name��6/   $
��Left=�6L   $��
25,134,0,0q�6g   $	��Top=�6{   $	��138��6�   �� 5   
   -   5        $ employeeGenderLabel��5      $��Employee Gender��6-   $
��Left=�6G   $��
25,200,0,0q�6b   $	��Top=�6v   $	��138��6�   �� 5   
   -   5        $ employeeBirthdayLabel��5      $��Employee Birthday��6/   $
��Left=�6K   $��
379,25,0,0q�6f   $	��Top=�6z   $	��138��6�   �� 5   
   -   5        $ employeeHireDate��5      $��Employee Hire Date��6*   $
��Left=�6G   $��379,134,0,0q�6b   $	��Top=�6w   $	��138��6�   �� 5   
   -   5         ��Name$ employeeIdTextBlock��5      $
��Left=�62   $��
203,30,0,0q�6M   $
��Wrap=�6a   $	��Top=�6�   $	��117��6�   $��21��6�   ��6u   ��  �� Path$ emp_no�6�   �� 5   
   -   5        $  employeeFirstNameTextBlock��5      $
��Left=�68   $��
203,82,0,0q�6S   $
��Wrap=�6g   $	��Top=�6�   $	��117��6�   $��21��6�   ��6{   �� $ 
first_name�6�   �� 5   
   -	   5        $ employeeLastNameTextBlock��5      $
��Left=�67   $��203,134,0,0q�6R   $
��Wrap=�6g   $	��Top=�6�   $	��117��6�   $��21��6�   ��6{   �� $ 	last_name�6�   �� 5   
   -
   5         ��Name$ employeeGenderCombobox��5      $
��Left=�63   $��203,200,0,0q�6N   $	��Top=�6c   $	��101��6{   .@�5      �� -   5        $��maleComboBoxItem��5      $
��Male��63   �� 5      -   5        $��femaleComboBoxItem��5      $��Female��65   5      (  "System.Windows.Controls.DatePicker  5   
   -   5        $ ��employeeBirthdayDatePicker��5      $
��Left=�67   $��
379,56,0,0q�6R   $	��Top=�6f   $	��222��6~      SelectedDate 6�   �� $ 
birth_date�  5   
   -   5        $��employeeHiredayDatePicker��5      $
��Left=�66   $��379,165,0,0q�6Q   $	��Top=�6f   $	��222��6~    6�   �� $ 	hire_date��� 5   
   -   5         ��Name$ PreviousButton��5      $��Previous��6)   $
��Left=�6<   $��
25,272,0,0q�6W   $	��Top=�6k   $	��147��6�   6�   �� 5   
   -   5        $ 
NextButton��5      $
��Next��6%   $
��Left=�64   $��191,272,0,0q�6O   $	��Top=�6d   $	��147��6|   6�   �� 5   
   -   5        $ 
EditButton��5      $
��Edit��6%   $
��Left=�64   $��352,272,0,0q�6O   $	��Top=�6d   $	��147��6|   6�   �� 5   
   -   5        $ DeleteButton��5      $��Delete��6'   $
��Left=�68   $��515,272,0,0q�6S   $	��Top=�6h   $	��125��6�   6�   5      5      