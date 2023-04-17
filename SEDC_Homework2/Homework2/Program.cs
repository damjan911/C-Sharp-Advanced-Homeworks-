#region  

using Homework2.Entities;

Dog dog1 = new Dog (1,"Max","brown" );
Dog dog2 = new Dog (2,"Buddy","black");
Dog dog3 = new Dog (3,"Charlie","white");

if (Dog.Validate(dog1))
{
    DogShelter.Dogs.Add(dog1);
}
if (Dog.Validate(dog2))
{
    DogShelter.Dogs.Add(dog2);
}
if (Dog.Validate(dog3))
{
    DogShelter.Dogs.Add(dog3);
}

DogShelter.PrintAll();


#endregion
