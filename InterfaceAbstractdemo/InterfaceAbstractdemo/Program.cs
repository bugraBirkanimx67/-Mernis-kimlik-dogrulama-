// See https://aka.ms/new-console-template for more information
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concreate;
using InterfaceAbstractDemo.Entities.Adapters;

BaseCustomerManager customerManager=new StarbucksCustomerManager(new MernisServiceAdapter() );
customerManager.Save(new InterfaceAbstractDemo.Entities.Customer { DateOfBirth=new DateTime(2000,04,30),FirstName="Buğra",Lastname="Birkanım",NationalityId="44134995818"});
Console.ReadLine();
