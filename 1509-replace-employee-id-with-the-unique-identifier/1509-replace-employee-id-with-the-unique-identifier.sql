/* Write your T-SQL query statement below */
select e.unique_id,es.name 
from EmployeeUNI e
right join Employees es
on e.id =es.id