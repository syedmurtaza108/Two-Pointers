using System;

namespace Two_Pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node() { Val = 1 };
            root.Next = new Node() { Val = 2 };
            root.Next.Next = new Node() { Val = 3 };
            root.Next.Next.Next = new Node() { Val = 4 };
            root.Next.Next.Next.Next = root.Next.Next.Next;
            Console.WriteLine(HasACycleInLinkedList(root));
            //Console.WriteLine(HasTwoPairsEqualsTarget(new int[] { 1, 2, 3, 4, 5, 6 }, 6));
        }

        static bool HasACycleInLinkedList(Node root)
        {
            Node fast = root, slow = root;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast) return true;
            }
            return false;
        }
        static bool HasTwoPairsEqualsTarget(int[] array, int target)
        {
            Array.Sort(array);
            int pointer1 = 0, pointer2 = array.Length - 1;
            while (pointer1 < pointer2)
            {
                var sum = array[pointer1] + array[pointer2];
                if (sum == target) return true;

                if (sum < target)
                    pointer1++;
                else
                    pointer2--;
            }

            return false;
        }
    }

    class Node
    {
        public int Val { get; set; }

        public Node Next { get; set; }
    }
}
