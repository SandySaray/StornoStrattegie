using System;
namespace StornoStrategie
{
    public class StandardReise : Reise
    {
        public StandardReise(double grundPreis, DateTime reisebeginn) : base(grundPreis, reisebeginn,new StrengerStornoAlgorithmus())
       
        {
            this.StornoAlgorithmus = new StrengerStornoAlgorithmus(); // Standard Storno Algorithmus
        }
    }
}