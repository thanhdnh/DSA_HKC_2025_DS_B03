public class Node{
    public object data;
    public Node next;
}
public class MyStack{
    public Node top;
    public bool IsEmpty(){
        return top == null;
    }
    public void Push(object newele){
        Node newnode = new Node();
        newnode.data = newele;
        newnode.next = top;
        top = newnode;
    }
    public object Pop(){
        if (IsEmpty())
            return null;
        else
        {
            Node result = top;
            top = top.next;
            return result.data;
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        MyStack stack = new MyStack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        /*Console.WriteLine(stack.IsEmpty());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.IsEmpty());*/
    }
}