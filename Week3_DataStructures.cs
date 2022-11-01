using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Week3_DataStructures
    {
        const int amt = 100;
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        /*
         * Arrays are good for most information-storing uses, though a normal array cannot be resized, so ususally a List<type> is used
         * Normal arrays are much faster and take up a small amount of space and can be easily cached
         */
        public static void ArrayExample()
        {
            int[] ids = new int[amt];
            for (int i = 0; i < ids.Length; i++)
            {
                ids[i] = i * 64;
            }
        }

        /*
         * Maps are useful in scenerios where youre associating one value with another
         * I've used this in multiplayer games, where a player's ID is used to get a specific instance of the player running on the server
         */
        public static void DictionaryExample()
        {
            Dictionary<int, string> ids = new Dictionary<int, string>();
            int id;
            string name;
            for (int i = 0; i < amt; i++)
            {
                id = i * 64;
                name = GenerateName(i);
                Utility.Print($"{id}, {name}");
                ids.Add(id, name);
            }
        }

        /*
         * A perfect use case of stacks is with Undo-ing using the command pattern
         */
        public static void StackExample()
        {
            Stack<string> actions = new Stack<string>();
            actions.Push("Move");
            actions.Push("Scale");
            actions.Push("Rotate");
            //Undo rotate
            UndoAction(actions.Pop());
        }
        private static void UndoAction(string action)
        {
            //does nothing
        }


        /*
         * Queues are good for waitlists such as song queues or finding multiplayer lobbys
         */
        public static void QueueExample()
        {
            Queue<string> songs = new Queue<string>();
            for(int i = 0; i < amt; i++)
            {
                songs.Enqueue(GenerateName(i));
            }
            while(songs.Count > 0)
            {
                Utility.Print($"Playing: {songs.Dequeue()}");
            }
        }

        public static string GenerateName(int i)
        {
            return chars[((i + 0) % chars.Length)].ToString() + chars[((i + 66) % chars.Length)].ToString() + chars[((i + 88) % chars.Length)].ToString();
        }
    }
}
