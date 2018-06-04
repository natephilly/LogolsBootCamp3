using System;
using System.cogsllections.Generic

namespace Zombie
{
    Class Program
    {
        Static Void Main(String[] args)
    }
}
{
    List<Iperson> people= new List<Iperson>();
    people.Add(new Human())
    people.Add(new Zombie())
    People.Add(new Human())

    foreach (Iperson person in people)
    {
        person.Walk(5);
        Console.WriteLine(person.DistanceTraveled);
    }
    /*
    Human bob = new Human();
    Zombie Jum = new Zombie();
    bob.Run(3.0M);
    Jim.Walk(3.0M);
     */
        
    }

}


static void Main