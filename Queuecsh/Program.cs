// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, to Queue programe!");
using Queuecsh;
Queue<int> qu = new Queue<int>();
qu.Enqueue(1);
qu.Enqueue(2);
qu.Enqueue(3);
while (qu.Count() > 0)
    Console.WriteLine(qu.Dequeue());
