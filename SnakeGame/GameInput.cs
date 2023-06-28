using System.Collections;
using System.Windows.Forms;

namespace SnakeGame
{
    public static class GameInput
    {
        private static Hashtable KeyTable = new Hashtable();

        public static void ChangeState(Keys key, bool state)
        {
            KeyTable[key] = state;
        }

        public static bool PressedKey(Keys key)
        {
            return (KeyTable[key] == null) ? false : (bool)KeyTable[key];
        }
    }
}
