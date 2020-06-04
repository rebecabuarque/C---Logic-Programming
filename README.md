# C# / First List Exercise / Object-Oriented Programming 

<h3> Make a program to read an integer N and then the data (id, name and salary) of N employees. There should be no repetition of id. Then, increase the salary by X percent for a specific employee. To do this, the program must read an ID and the value X. If the provided ID does not exist, show a message and stop the operation. At the end, show the updated list of employees, as examples.
Remember to apply the encapsulation technique to not allow the salary be changed freely. A salary can only be increased based on increase by a given percentage. </h3>

<hr>
<h4> Exemplo 1: </h4>
<br> How many employees will be registered? 3 
<br> Emplyoee #1:
<br> Id: 333
<br> Name: Maria Brown
<br> Salary: 4000.00
<br> Emplyoee #2:
<br> Id: 536
<br> Name: Alex Grey
<br> Salary: 3000.00
<br> Emplyoee #3:
<br> Id: 772

<br> Name: Bob Green
<br> Salary: 5000.00
<br> Enter the employee id that will have salary increase : 536
<br> Enter the percentage: 10.0
<br> Updated list of employees:
<br> 333, Maria Brown, 4000.00
<br> 536, Alex Grey, 3300.00
<br> 772, Bob Green, 5000.00
<hr>
<h4>Exemplo 2:</h4>
<br> How many employees will be registered? 2
<br> Emplyoee #1:
<br> Id: 333
<br> Name: Maria Brown
<br> Salary: 4000.00
<br> Emplyoee #2:
<br> Id: 536
<br> Name: Alex Grey
<br> Salary: 3000.00
<br> Enter the employee id that will have salary increase: 776
<br> This id does not exist!
<br> Updated list of employees:
<br> 333, Maria Brown, 4000.00
<br> 536, Alex Grey, 3000.00
