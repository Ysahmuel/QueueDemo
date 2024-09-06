using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        // Initialize the queue with some elements
        queue.Enqueue("Josh");
        queue.Enqueue("Khian");
        queue.Enqueue("Prince");

        Console.WriteLine("Initial Queue: ");
        DisplayQueue(queue);

        while (true)
        {
            Console.WriteLine("\nChoose an action: ");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Check if an item exists");
            Console.WriteLine("5. Display Queue");
            Console.WriteLine("6. Convert Queue to Array");
            Console.WriteLine("7. Clear Queue");
            Console.WriteLine("8. Exit");

            Console.Write("\nEnter your choice (1-8): ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 8)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a name to enqueue: ");
                    string name = Console.ReadLine();
                    queue.Enqueue(name);
                    Console.WriteLine($"'{name}' has been added to the queue.");
                    break;

                case 2:
                    if (queue.Count > 0)
                    {
                        string dequeuedItem = queue.Dequeue();
                        Console.WriteLine($"Dequeued Item: {dequeuedItem}");
                    }
                    else
                    {
                        Console.WriteLine("Queue is empty. Nothing to dequeue.");
                    }
                    break;

                case 3:
                    if (queue.Count > 0)
                    {
                        string nextItem = queue.Peek();
                        Console.WriteLine($"Next Item to be dequeued: {nextItem}");
                    }
                    else
                    {
                        Console.WriteLine("Queue is empty. No items to peek at.");
                    }
                    break;

                case 4:
                    Console.Write("Enter the name to check if it exists: ");
                    string searchItem = Console.ReadLine();
                    if (queue.Contains(searchItem))
                    {
                        Console.WriteLine($"'{searchItem}' exists in the queue.");
                    }
                    else
                    {
                        Console.WriteLine($"'{searchItem}' is not in the queue.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Current Queue:");
                    DisplayQueue(queue);
                    break;

                case 6:
                    string[] queueArray = queue.ToArray();
                    Console.WriteLine("Queue converted to array:");
                    for (int i = 0; i < queueArray.Length; i++)
                    {
                        Console.WriteLine($"Element {i + 1}: {queueArray[i]}");
                    }
                    break;

                case 7:
                    queue.Clear();
                    Console.WriteLine("Queue has been cleared.");
                    break;

                case 8:
                    Console.WriteLine("Exiting the program.");
                    return;
            }

            // Display the queue after each action
            Console.WriteLine("\nUpdated Queue:");
            DisplayQueue(queue);
        }
    }

    static void DisplayQueue(Queue<string> queue)
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}