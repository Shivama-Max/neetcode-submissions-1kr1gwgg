public class Node
{
    public int data {get; set;}
    public Node next {get; set;}
    public Node(int data){
        this.data = data;
        this.next = null;
    }
}
public class LinkedList {
    int count;
    public Node head;
    public LinkedList() {
        head = null;
        count = 0;
    }

    public int Get(int index) {
        if(index >= count || head == null) return -1;
        Node runner = head;
        for(int i=0;i<index;i++){
            runner = runner.next;
        }
        return runner.data;
    }

    public void InsertHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
        count++;
    }

    public void InsertTail(int val) {
        if (head == null) { InsertHead(val); return; }
        Node newNode = new Node(val);
        Node runner = head;
        while(runner.next != null){
            runner = runner.next;
        }
        runner.next = newNode;
        count++;
    }

    public bool Remove(int index) {
        if(index >= count || head == null) return false;
        if(index == 0) {
            head = head.next;
        } else {
            Node runner = head;
            for(int i=0;i<index-1;i++){
                runner = runner.next;
            }
            runner.next = runner.next.next;
        }
        count--;
        return true;
    }

    public List<int> GetValues() {
        Node runner = head;
        List<int> values = new List<int>();
        while(runner != null){
            values.Add(runner.data);
            runner = runner.next;
        }
        return values;
    }
}