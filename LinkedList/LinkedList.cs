using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImLewel_LinkedList {
  public class LinkedList {
    Node Head;
    Node Tail;
    Node Current;
    private int length = 0;
    public int Length() => length;

    public void Append(string data) {
      Current = new Node(data);
      if (Head == null) {
        Head = Current;
        Tail = Current;
        Tail.Next = null;
        ++length;
      }
      else {
        Tail.Next = Current;
        Tail = Current;
        Tail.Next = null;
        ++length;
      }
    }

    public string Show() {
      Node curr = Head;
      string res = String.Empty;
      for (int i = 0; i < length; i++) {
        if (curr.Next is not null) {
          res += $"{curr.Data} {curr.Next.Data}\n";
          curr = curr.Next;
        }
        else
          res += $"{curr.Data} null";
      }
      return res;
    }

    private class Node {
      public Node? Next;
      public string Data;
      public Node(string _data) {
        Data = _data;
      }
    }
  }
}
