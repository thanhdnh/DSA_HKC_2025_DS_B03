public class Node
{
    public object data;
    public Node next;
}
public class MyStack
{
    public Node top;
    public bool IsEmpty()
    {
        return top == null;
    }
    public void Push(object newele)
    {
        Node newnode = new Node();
        newnode.data = newele;
        newnode.next = top;
        top = newnode;
    }
    public object Pop()
    {
        if (IsEmpty())
            return null;
        else
        {
            Node result = top;
            top = top.next;
            return result.data;
        }
    }
    public object Peek()
    {
        if (IsEmpty())
            return null;
        else
            return top.data;
    }
    public bool IsExist(object data)
    {
        if (this.IsEmpty())
            return false;
        MyStack tempStack = new MyStack();
        bool found = false;
        while (this.IsEmpty() == false)
        {
            object temp = this.Pop();
            tempStack.Push(temp);
            if (temp.Equals(data))
            {
                found = true; break;
            }
        }
        while (tempStack.IsEmpty() == false)
            this.Push(tempStack.Pop());
        return found;
    }
    public void Swap(object a, object b)
    {
        bool foundA = this.IsExist(a);
        bool foundB = this.IsExist(b);
        if (foundA == false || foundB == false)
            return;
        MyStack tempStack = new MyStack();
        //while (this.IsEmpty() == false)
        object t;
        do
        {
            t = this.Pop();
            tempStack.Push(t);
        } while (t.Equals(b) == false);

        while (tempStack.IsEmpty() == false)
        {
            object temp = tempStack.Pop();
            if (temp.Equals(a))
                this.Push(b);
            else if (temp.Equals(b))
                this.Push(a);
            else
                this.Push(temp);
        }

    }
}
public class Node2
{
    public Node2 prev, next;
    public object data;
}
public class MyQueue
{
    Node2 rear, front; public bool IsEmpty()
    {
        return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
        Node2 n = new Node2();
        n.data = ele;
        if (rear == null)
        {
            rear = n; front = n;
        }
        else
        {
            rear.prev = n;
            n.next = rear; rear = n;
        }
    }
    public Node2 Dequeue()
    {
        if (front == null) return null;
        Node2 d = front;
        front = front.prev;
        if (front == null)
            rear = null;
        else
            front.next = null;
        return d;
    }
    public object Peek()
    {

    }
    public bool IsExist(object data)
    {

    }
    public void Swap(object a, object b)
    {

    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        /*MyStack stack = new MyStack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        stack.Swap(20, 40);*/
        /*Console.WriteLine(stack.IsEmpty());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.IsEmpty());*/

        MyQueue queue = new MyQueue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
    }
}