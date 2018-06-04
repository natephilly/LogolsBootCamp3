namespace Zombie
{
    public class Human : Person
    {
        public void Run(decimal minutes)
        {
            DistanceTraveled = DistanceTraveled + (minutes * 3.0)
            
        }
    }
}