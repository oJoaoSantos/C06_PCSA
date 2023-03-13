namespace D13_Advanced_DelegateEvent
{

    internal class CalculateClass
    {

        // public delegate int CalculateResult(int v1, int v2);
        
        internal static int Add(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }

        internal static int Subtract(int value1, int value2)
        {
            int result = value1 - value2;
            return result;
        }

    }

}
