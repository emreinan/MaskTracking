
using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Emre";
person1.LastName = "İnan";
person1.DateOfBirthYear = 1993;
person1.NationalIdentity = 21713422484;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);



//resharper



