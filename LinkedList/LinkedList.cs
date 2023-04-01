using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImLewel_LinkedList {
  public class LinkedList {
    Node Head;
    Node Tail;
    Node current;
    private int length = 0;
    public int Length() => length;


    private class Node {
      Node? next;
      string data;
      public Node(string _data) {
        data = _data;
      }
    }
  }
}
