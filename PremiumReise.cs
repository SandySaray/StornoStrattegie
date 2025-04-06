using System;
namespace StornoStrategie
{
    public class PremiumReise : Reise
    {
        public PremiumReise(double grundPreis, DateTime reisebeginn) : base(grundPreis, reisebeginn, new KulanterStornoAlgorithmus())
       
        {
            this.StornoAlgorithmus = new KulanterStornoAlgorithmus(); // Kulanter Storno Algorithmus
        }
    }
}