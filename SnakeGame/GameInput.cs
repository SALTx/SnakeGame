using System.Collections;
using System.Windows.Forms;

namespace SnakeGame
{
    public class GameInput
    {
        /*
        This solution is an implementation of what I use on khanacademy
        but instead of an array im using a hashtable for keys
        */
        private static Hashtable KeyTable = new Hashtable();

        public static void ChangeState(Keys key, bool state) 
{
            KeyTable[key] = state;
        }

        public static bool PressedKey(Keys key)
        {
            return (KeyTable[key] == null) ? false : (bool)KeyTable[key] ;
        }

        public static bool DepressedKey(Keys key)
        {
            return (KeyTable[key] != null) ? true : (bool)KeyTable[key];
        }
        /*
         This is what a bad idea looks like
         for future reference i was trying to see if i could use a value from the hashtable to either be
         truthy or falsy but i guess not
         */
    }
}
