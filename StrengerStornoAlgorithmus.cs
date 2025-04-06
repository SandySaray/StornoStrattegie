namespace StornoStrategie
{
    public class StrengerStornoAlgorithmus : IstornoAlgorehmus
    {
       public double StornoBerechnen(Reise reise)
       {
        return reise.GrundPreis * 0.1; // 10% Stornogebühr
       }
    }
    
}