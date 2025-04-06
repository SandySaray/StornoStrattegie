using System;
namespace StornoStrategie
{
    public class Reise
    {
        public double GrundPreis { get; set; }
        public DateTime Reisebeginn { get; set; }
        protected IstornoAlgorehmus StornoAlgorithmus { get; set; }
       public Reise(double grundPreis, DateTime reisebeginn, IstornoAlgorehmus stornoAlgorithmus)
        {
            GrundPreis = grundPreis;
            Reisebeginn = reisebeginn;
            StornoAlgorithmus = stornoAlgorithmus;
        }
        public void SetStornoAlgorithmus(IstornoAlgorehmus stornoAlgorithmus)
        {
            StornoAlgorithmus = stornoAlgorithmus;
        }
        public double ExecuteStornoBerechnen()
        {
            return StornoAlgorithmus.StornoBerechnen(this);
        }
    }
}