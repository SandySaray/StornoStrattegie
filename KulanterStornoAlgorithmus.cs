namespace StornoStrategie
{
    public class KulanterStornoAlgorithmus : IstornoAlgorehmus
    {
        public double StornoBerechnen(Reise reise)
        {
            return reise.GrundPreis * 0.9; // 90% Rückerstattung
        }
    }
}