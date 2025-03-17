namespace COLLECTION;

public class Queues
{
    Queue<int> numbers = new Queue<int>();

    void Enqueue(int number)
    {
        numbers.Enqueue(number);  // Добавляет элемент в конец очереди
    }

    void Peek()
    {
        Console.WriteLine(numbers.Peek()); //Показывает первый элемент в очереди
    }

    void Dequeue()
    {
        int dequedNum = numbers.Dequeue(); //Убирает элемент из очереди. Можно его так же поместить в переменную
        Console.WriteLine(numbers.Count);
        
    }
}