using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
  public class LinkedList {
    Node[] List;
    Node Head;
    Node Tail;
    Node last;
    public LinkedList(int size) {
      List = new Node[size];
    }
    public void Append(string data) {
      for (int i = 0; i < List.Length; ++i) {
        if (List[i] == null) {
          List[i] = new Node(data);
          if (Head == null) {
            Head = List[i];
          }
          if (Tail == null) {
            Tail = List[i];
            List[i].Next = null;
          }
          else {
            List[i] = new Node(data);
            Tail.Next = List[i];
            Tail = List[i];
            List[i].Next = null;
          }
          return;
        }
      }
    }

    public string Show() {
      string result = String.Empty;
      foreach (Node node in List) {
        if (node != null)
          if (node.Next == null)
            result += $"{node.Data} null\n";
          else
            result += $"{node.Data} {node.Next.Data}\n";
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
