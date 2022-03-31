Select Email from
(
Select Email, count(1) as num from Person
group by Email

) as t
where num>1;