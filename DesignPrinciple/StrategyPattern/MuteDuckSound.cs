using DesignPrinciple.Interfaces;

namespace BasicDesignPrinciple
{
    public class MuteDuckSound : IDuckSound
        {
            public void DuckSound()
            {
                Console.WriteLine("no sound ...");
            }
        }
}