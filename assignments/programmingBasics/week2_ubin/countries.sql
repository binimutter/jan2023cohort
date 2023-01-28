USE world;
select * from cities;
select * from countries;
select * from languages;
select name, language, percentage from countries left join languages on languages.country_id = countries.id where language = 'Slovene' order by percentage desc;
select countries.name, count(country_id) as cities
from countries
left join cities on cities.country_id = countries.id
group by countries.id
order by cities desc;
select name, population, country_id
from cities
where population > 500000 AND country_id = 136
order by population desc;
select name, language, percentage
from countries
left join languages on languages.country_id = countries.id
where percentage > 89
order by percentage desc;
select name, surface_area, population
from countries
where surface_area < 501 AND population > 100000;
select name, government_form, life_expectancy
from countries
where government_form = 'Constitutional Monarchy' AND capital > 200 AND life_expectancy > 75;
select countries.name as country_name, cities.name as city_name, cities.district, cities.population
from cities
left join countries on countries.id = cities.country_id
where countries.name = 'Argentina' AND cities.district = 'Buenos Aires' AND cities.population > 500000;
select region, count(region) as countries
from countries
group by countries.region
order by countries desc;