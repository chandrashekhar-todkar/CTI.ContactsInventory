# CTI(CT Inc) ContactInverory
The application preservs Contact information in system, allows users to manipulate it.

## Project Hirarchy

CTI.ContactsInvetory   
------>	CTI.ContactsInvetcry.API  
-------------->	Controllers  
------>	CTI.ContactsInvetory.BusinessLayer  
-------------->	Interfaces  
-------------->	Implementation  
------>	CTI.ContactsInvetory.DataAccess  
-------------->	Interfaces  
-------------->	Implementation  
------>	CTI.ContactsInvetory.Dto   
------>	CTI.ContactsInvetory.Tests   
------>	CTI.ContactsInvetory.Web  
-------------->	Controllers  
-------------->	Views  
-------------->	Models  

## Deployment

1. Give appropriate database connection string in CTI.ContactsInvetcry.API project appConfig.json file  
2. While publish, ensure Execute Code First Migrations is checked  

## WIP

1. Authentication and Authorization 
2. 100% Unit test coverage  

## Authors

* **Chandrashekhar Todkar** - *Initial work* 