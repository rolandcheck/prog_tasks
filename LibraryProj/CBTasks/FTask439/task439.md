## russian:
Ни для кого не секрет, что в основе реляционной базы данных лежит таблица, которую можно рассматривать как одномерный массив записей. 
Известно, что при поиске все записи таблицы просматриваются последовательно, начиная с самой первой и заканчивая найденной.

Технический отдел компании установил, что часто бывает так, что поиск одной и той же записи в таблице производится несколько раз. 
Основываясь на этом, программисты решили после каждого нового поискового запроса менять порядок следования записей в таблице. 
Другими словами, после поиска найденная запись перемещается на первое место в таблице.
Очевидно, что чем чаще осуществляется поиск определенной записи, тем ближе она будет к началу таблицы и тем быстрее будет поиск этой записи.

Вашей задачей является написать программу, которая для каждого из M последовательно заданных поисковых запросов будет определять количество просмотренных записей при поиске заданной. 
простоты обозначения будем считать, что имеется таблица с N записями, где запись – это число от 1 до N. 
В начале все записи в таблице расположены в порядке возрастания, то есть на i-м месте в таблице находится число i. 
Для приведенного ниже примера при M = 2, N = 6 и запросах на поиск чисел «5» и «3» потребуется 5 и 4 просмотра записей соответственно.

//
1, 2, 3, 4, 5, 6
// 5 comparisons 
5, 1, 2, 3, 4, 6
// 4 comparisons 
3, 5, 1, 2, 4, 6


## english (automatic translation):
It's no secret that a relational database is based on a table that can be viewed as a one-dimensional array of records.
It is known that when searching, all the table entries are viewed sequentially, starting with the first one and ending with the one found.

The company's technical Department found that it often happens that the same entry in the table is searched several times.
Based on this, the programmers decided to change the order of entries in the table after each new search query.
In other words, after the search, the found record is moved to the first place in the table.
Obviously, the more frequently a particular record is searched, the closer it will be to the top of the table and the faster the search for this record will be.

Your task is to write a program that for each of the M consecutive search queries will determine the number of viewed records when searching for the specified one.
for simplicity of notation, we assume that there is a table with N entries, where the entry is a number from 1 to N.
At the beginning, all entries in the table are arranged in ascending order, that is, the I-th place in the table is the number i.
For the example below, for M = 2, N = 6, and queries to search for the numbers "5" and "3", you will need 5 and 4 record views, respectively.