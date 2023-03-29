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
      Relink();
    }

    public void Clear() {
      List.Clear();
      Head = null;
      Tail = null;
      current = null;
    }

    public LinkedList Clone() => this;

    public void deleteAll(string value) {
      List.RemoveAll(node => node.Data == value);
      Relink();
    }

    private void Relink() {
      for (int i = 0; i < List.Count; i++) {
        if (i < List.Count - 1) {
          if (i == 0)
            Head = List[i];
          List[i].Next = List[i + 1];
        }
        if (i == List.Count - 1) {
          Tail = List[i];
          List[i].Next = null;
        }
      }
    }

    public void Reverse() {
      List.Reverse();
      Relink();
    }

    public Node Get(int index) => List[index];

    public void Extend(LinkedList list) {
      foreach (Node node in list.List) {
        List.Add(node);
      }
      Relink();
    }

    public void Delete(int index) {
      List.RemoveAt(index);
      Relink();
    }
    
    public int findFirst(string value) {
      return List.IndexOf(List.Find(node => node.Data == value));
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
