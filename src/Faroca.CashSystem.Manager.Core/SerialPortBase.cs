using System.Reflection.Emit;

namespace Faroca.CashSystem.Manager.Core
{
    public abstract class SerialPortBase
    {

        public abstract bool IsCompleted(byte[] buffer);

        public abstract int GetExpectedLength(byte[] buffer);
    }
}
