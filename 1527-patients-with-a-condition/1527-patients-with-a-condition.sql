/* Write your T-SQL query statement below */
select patient_id ,patient_name,conditions 
from Patients  
WHERE ' ' + conditions + ' ' LIKE '% DIAB1%';