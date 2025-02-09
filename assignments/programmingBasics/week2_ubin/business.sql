use lead_gen_business;
select * from billing;
select * from clients;
select * from leads;
select * from sites;

select date_format(charged_datetime,'%M') as month, sum(amount) as revenue
from billing
where month(charged_datetime) = 3 AND year(charged_datetime) = 2012;

select client_id, sum(amount) as total_revenue
from billing
where client_id = 2;

select domain_name as website, client_id
from sites
where client_id = 10;

select client_id, count(domain_name) as number_of_websites, date_format(created_datetime,'%M') as month_created, year(created_datetime)
from sites
where client_id = 20
group by month(created_datetime), year(created_datetime);

select sites.domain_name as website, count(leads.site_id) as number_of_leads
from leads
left join sites on sites.site_id = leads.site_id
where registered_datetime >= '2011-01-01' AND registered_datetime <= '2011-02-15'
group by sites.domain_name;

select CONCAT(clients.first_name , ' ' , clients.last_name) as client, count(leads.site_id) as number_of_leads
from clients
left join sites on sites.client_id = clients.client_id
left join leads on leads.site_id = sites.site_id
where registered_datetime >= '2011-01-01' AND registered_datetime <= '2011-12-31'
group by CONCAT(clients.first_name , ' ' , clients.last_name);

select CONCAT(clients.first_name , ' ' , clients.last_name) as client, count(leads.site_id) as number_of_leads, date_format(registered_datetime,'%M') as month_generated
from clients
left join sites on sites.client_id = clients.client_id
left join leads on leads.site_id = sites.site_id
where year(registered_datetime) = 2011 AND month(registered_datetime) >= 1 AND month(registered_datetime) <= 6
group by CONCAT(clients.first_name , ' ' , clients.last_name), month(leads.registered_datetime);

select CONCAT(clients.first_name , ' ' , clients.last_name) as client, sites.domain_name as website, count(leads.site_id) as number_of_leads
from clients
left join sites on sites.client_id = clients.client_id
left join leads on leads.site_id = sites.site_id
group by sites.domain_name
order by sites.client_id, sites.domain_name;

select CONCAT(clients.first_name , ' ' , clients.last_name) as client_name, sum(billing.amount) as total_revenue, date_format(charged_datetime,'%M') as month_charged, year(charged_datetime) as year_charged
from clients
left join billing on clients.client_id = billing.client_id
group by CONCAT(clients.first_name , ' ' , clients.last_name), month(billing.charged_datetime), year(billing.charged_datetime)
order by billing.client_id, month(billing.charged_datetime);

select concat(clients.first_name , ' ' , clients.last_name) as client_name, group_concat(sites.domain_name separator ' / ') as sites
from clients
left join sites on sites.client_id = clients.client_id
group by sites.client_id;
