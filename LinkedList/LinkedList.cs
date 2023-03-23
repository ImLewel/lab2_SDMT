using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
  public class LinkedList {
    List<Node> List;
    Node Head;
    Node Tail;
    Node current;
    public LinkedList() {
      List = new();
    }
    public void Append(string data) {
      current = new Node(data);
      List.Add(current);
      if (Head == null)
        Head = current;
      if (Tail == null)
        Tail = current;
      else {
        Tail.Next = current;
        Tail = current;
        current.Next = null;
      }
    }

    public int Length => List.Count;

    public string Show() {
      string result = String.Empty;
      foreach (Node node in List) {
        if (node.Next != null)
          result += $"{node.Data} {node.Next.Data}\n";
        else
          result += $"{node.Data} null";
      }
      return result;
    }

    public class Node {
      public Node? Next;
      public string Data;
      public Node(string _data) {
        Data = _data;
        Next = null;
      }
    }
  }
}
