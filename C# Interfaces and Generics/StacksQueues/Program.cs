// Create new stack to hold the names of sports
Stack<string> sportsStack = new Stack<string>();

// Push some initial items on to the stack
sportsStack.Push("Baseball");
sportsStack.Push("Basketball");
sportsStack.Push("Football");
sportsStack.Push("Cricket");
sportsStack.Push("Hockey");
sportsStack.Push("Rugby");

// TODO: Let's see how many items are on the stack
Console.WriteLine($"There are {sportsStack.Count()} items in sportsStack.");

// TODO: Peek at the top item
Console.WriteLine($"A peek in the sportsStack returns {sportsStack.Peek()}");

// TODO: Pop 2 items, then try the Contains method
sportsStack.Pop();
sportsStack.Pop();
Console.WriteLine(sportsStack.Contains("Rugby")); // false because I popped both rugby and hockey with the pop method prior
Console.WriteLine(sportsStack.Contains("Cricket")); // true and cricket is at the top of the stack currently

// we can confirm that cricket is at top by peeking
Console.WriteLine($"A peek in the sportsStack now returns {sportsStack.Peek()}");

// ---------------------->

// Create new queue to hold the names of sports
Queue<string> sportsQueue = new Queue<string>();

// Enqueue some initial items onto the queue
sportsQueue.Enqueue("Baseball");
sportsQueue.Enqueue("Basketball");
sportsQueue.Enqueue("Football");
sportsQueue.Enqueue("Cricket");
sportsQueue.Enqueue("Hockey");
sportsQueue.Enqueue("Rugby");

// TODO: Lets see how many items are in the queue
Console.WriteLine($"There are {sportsQueue.Count()} items in sportsQueue.");

// TODO: Peek at the front item
Console.WriteLine($"A peek in the sportsQueue returns {sportsQueue.Peek()}");

// TODO: Dequeue 2 items, then try the Contains method
sportsQueue.Dequeue();
sportsQueue.Dequeue();
Console.WriteLine(sportsQueue.Contains("Rugby")); // true
Console.WriteLine(sportsQueue.Contains("Baseball")); // false



