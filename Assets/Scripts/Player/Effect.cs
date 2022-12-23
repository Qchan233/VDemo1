using System.Runtime.InteropServices;

namespace Player
{
    public class Effect
    {
        public enum DataType {
            intType,
            floatType,
            boolType
        }
        public string name; //name of the property to change
        public DataType dataType;
    }
}