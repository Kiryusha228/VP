using System.Threading.Channels;

namespace DelegatesLib
{
    public static class ActionDelegate
    {
        static public float Mul() => 4.34f * 4;

        static public void ActionExample(Func<float> operation, bool flag, List<float> list)
        {
            if (flag)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = operation();
                }
            }
        }

        public static Action<Func<float>, bool, List<float>> FirstTask = ActionExample;
    }
}