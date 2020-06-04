# C---Logic-Programming

Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.
(exemplo na próxima página)
<hr>
<br>
Exemplo 1:
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
<p>Exemplo 2:</p>
How many employees will be registered? 2
Emplyoee #1:
Id: 333
Name: Maria Brown
Salary: 4000.00
Emplyoee #2:
Id: 536
Name: Alex Grey
Salary: 3000.00
Enter the employee id that will have salary increase: 776
This id does not exist!
Updated list of employees:
333, Maria Brown, 4000.00
536, Alex Grey, 3000.00
