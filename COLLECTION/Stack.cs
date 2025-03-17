namespace COLLECTION;

public class Stack
{
    Stack<int> stack = new Stack<int>();

    void Push(int value)
    {
        stack.Push(value);
        stack.Count();
    }

    void Peek()
    {
        stack.Peek(); // показывает самый верхний элемент
    }

    void Pop()
    {
        int myPoppedItem = stack.Pop(); // Удаляет элемент сверху. Если присвоить - то так же записывает удаленное значение в переменную
        
    }
}