// Create an empty list to store tasks
List<string> tasks = new List<string>();

// Control the program loop
bool running = true;

while (running)
{
    Console.WriteLine("\n===== TO-DO LIST MANAGER =====");
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. Remove Task");
    Console.WriteLine("3. List Tasks");
    Console.WriteLine("4. Quit");
    Console.Write("Choose an option (1-4): ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // ADD TASK
            Console.Write("Enter a new task: ");
            string? newTask = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newTask))
            {
                tasks.Add(newTask);
                Console.WriteLine("Task added successfully!");
            }
            else
            {
                Console.WriteLine("Task cannot be empty!");
            }
            break;

        case "2":
            // REMOVE TASK
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available to remove.");
                break;
            }

            Console.WriteLine("\nYour Tasks:");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }

            Console.Write("Enter task number to remove: ");

            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber >= 1 && taskNumber <= tasks.Count)
                {
                    tasks.RemoveAt(taskNumber - 1);
                    Console.WriteLine("Task removed successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid task number!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
            break;

        case "3":
            // LIST TASKS
            if (tasks.Count == 0)
            {
                Console.WriteLine("Your to-do list is empty.");
            }
            else
            {
                Console.WriteLine("\n===== YOUR TASKS =====");

                int index = 1;

                foreach (string task in tasks)
                {
                    Console.WriteLine($"{index}. {task}");
                    index++;
                }
            }
            break;

        case "4":
            // QUIT PROGRAM
            Console.WriteLine("Goodbye! Have a productive day!");
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option! Please choose 1-4.");
            break;
    }
}