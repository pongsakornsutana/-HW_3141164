// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Queue instructionDataQueue = new Queue(); 
        string intruction;
        string data;
  
        Console.WriteLine("intruction : ");
        while (true)
        { 
        intruction = Console.ReadLine();
            if (intruction == "?")
            {
                break;
            }
            Console.WriteLine("data :");
            data = Console.ReadLine();
            if (data == "?")
            {
                break;
            }
            Node inputQueue = new Node(intruction, data);
                instructionDataQueue.Push(inputQueue);
        }    
    }
}
class Node
{
    public string instruction;
    public string data;
    public Node next;

    public Node(string instructionvalue,string datavalue) 
    {

        instruction = instructionvalue;
        data = datavalue;
    }
}

class Queue
{
    private Node Root;

    private void Push(Node node) 
    {
        if (Root == null)
        {

            Root = node;
        }
        else
        {
            Node ptr = Root;
            while (ptr.next != null)
            {

                ptr = ptr.next;
            }
            ptr.next = node;
        }
    }
    public Node Pop()
    {
        if (Root == null) 
        {
            return null;
        }
        Node node = Root;
        Root = Root.next;
        node.next = null;
        return node;
    }
}