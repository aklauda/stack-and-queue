using System;
using System.Collections;

namespace Stack_and_Queue
{
    public class Stack
    {
        private object obj;
        private static readonly ArrayList list = new ArrayList();

        public object Obj
        {
            get { return obj; }
            set { obj = value; }
        }

        public void Push(object obj)
        {
            string wordobj = (string)obj;
            if (string.IsNullOrEmpty(wordobj))
            {
                Console.WriteLine("Cannot push empty objects on stack.");
            }
            else
            {
                list.Add(obj);
            }
        }

        public void Pop()
        {
            try
            {
                Console.WriteLine("Object popped out: " + list[list.Count - 1]);
                list.Remove(list[list.Count - 1]);
            }
            catch
            {
                Console.WriteLine("Invalid operation: Stack is empty!");
            }
        }

        public void All()
        {
            Console.WriteLine("\nNumber of objects on stack: {0}", list.Count);
        }

        public void Clear()
        {
            list.Clear();
            Console.WriteLine("\nStack has been cleared.");
        }
    }

    public class Queue
    {
        private object obj;
        private static readonly ArrayList list = new ArrayList();

        public object Obj
        {
            get { return obj; }
            set { obj = value; }
        }

        public void Push(object obj)
        {
            string wordobj = (string)obj;
            if (string.IsNullOrEmpty(wordobj))
            {
                Console.WriteLine("Cannot push empty objects to queue.");
            }
            else
            {
                list.Add(obj);
            }
        }

        public void Pop()
        {
            try
            {
                Console.WriteLine("Object popped out: " + list[0]);
                list.Remove(list[0]);
            }
            catch
            {
                Console.WriteLine("Invalid operation: Queue is empty!");
            }
        }

        public void All()
        {
            Console.WriteLine("\nNumber of objects in queue: {0}", list.Count);
        }

        public void Clear()
        {
            list.Clear();
            Console.WriteLine("\nQueue has been cleared.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            var queue = new Queue();
            int memory_selector;
            int input;

            while (true)
            {
                Console.WriteLine("\nWhich memory would you like to use?");
                Console.WriteLine("\n1) Stack (Last In First Out)\n2) Queue (First In First Out)\n3) Exit");
                memory_selector = Convert.ToInt32(Console.ReadLine());

                if (memory_selector == 1)
                {
                    do
                    {
                        Console.WriteLine("\n1) Push an object to stack \n2) Pop an object from the stack \n3) Number of objects on stack \n4) Clear the stack \n5) Exit");
                        input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("\nEnter your objects or enter \"break\" to exit. ");
                                string word;
                                while (true)
                                {
                                    Console.Write("Object:");
                                    stack.Obj = Console.ReadLine();
                                    word = (string)stack.Obj;
                                    if (word == "break") break;
                                    stack.Push(stack.Obj);
                                }
                                break;

                            case 2:
                                Console.WriteLine("\nPress 'enter' to pop an object or enter \"break\" to exit.");
                                while (true)
                                {
                                    word = Console.ReadLine();
                                    if (word == "break") break;
                                    else if (!string.IsNullOrWhiteSpace(word) | word == "break")
                                    {
                                        Console.WriteLine("Invalid operation: Press 'enter' to pop an object!");
                                        continue;
                                    }
                                    else
                                    {
                                        stack.Pop();
                                    }
                                }
                                break;

                            case 3:
                                stack.All();
                                break;

                            case 4:
                                stack.Clear();
                                break;

                            default:
                                if (input == 5) break;
                                Console.WriteLine("Invalid operation: Try again with a valid command!");
                                break;
                        }
                    } while (input != 5);
                }

                else if (memory_selector == 2)
                {
                    do
                    {
                        Console.WriteLine("\n1) Push an object to queue \n2) Pop an object from the queue \n3) Number of objects in queue \n4) Clear the queue \n5) Exit");
                        input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("\nEnter your objects or enter \"break\" to exit. ");
                                string word;
                                while (true)
                                {
                                    Console.Write("Object:");
                                    queue.Obj = Console.ReadLine();
                                    word = (string)queue.Obj;
                                    if (word == "break") break;
                                    queue.Push(queue.Obj);
                                }
                                break;

                            case 2:
                                Console.WriteLine("\nPress 'enter' to pop an object or enter \"break\" to exit.");
                                while (true)
                                {
                                    word = Console.ReadLine();
                                    if (word == "break") break;
                                    else if (!string.IsNullOrWhiteSpace(word) | word == "break")
                                    {
                                        Console.WriteLine("Invalid operation: Press 'enter' to pop an object!");
                                        continue;
                                    }
                                    else
                                    {
                                        queue.Pop();
                                    }
                                }
                                break;

                            case 3:
                                queue.All();
                                break;

                            case 4:
                                queue.Clear();
                                break;

                            default:
                                if (input == 5) break;
                                Console.WriteLine("Invalid operation: Try again with a valid command!");
                                break;
                        }
                    } while (input != 5);
                }

                else if (memory_selector == 3) break;

                else
                {
                    Console.WriteLine("Invalid operation: Try again with a valid memory selection!");
                }
            }

            Console.WriteLine("Exiting application..");
        }
    }
}
