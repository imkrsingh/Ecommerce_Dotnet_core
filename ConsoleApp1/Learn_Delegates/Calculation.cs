
namespace Learn_Delegates
{
    internal class Calculation
    {
        private Action<int, int> addition;

        public Calculation(Action<int, int> addition)
        {
            this.addition = addition;
        }

        internal void Invoke(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}