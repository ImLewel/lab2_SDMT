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
          //result += $"{node.Data} {node.Next.Data} Index:{List.IndexOf(node)}\n";
          result += $"{node.Data} {node.Next.Data}\n";
        else
          //result += $"{node.Data} null Index:{List.IndexOf(node)}";
          result += $"{node.Data} null";
      }
      return result;
    }

    public void Insert(int index, string data) {
      if (index < 0 || index > List.Count)
        throw (new IndexOutOfRangeException());
      Node node = new Node(data);
      List.Insert(index, node);
      if (index == 0) {
        Head = node;
        List[index].Next = List[++index];
      }
      else if (index < List.Count) {
        List[index].Next = List[index + 1];
        List[index - 1].Next = List[index];
      }
    }

    public void Clear() {
      List.Clear();
      Head = null;
      Tail = null;
      current = null;
    }

    public LinkedList Clone() => this;

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
