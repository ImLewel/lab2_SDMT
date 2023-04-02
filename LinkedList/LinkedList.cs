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

    public void Insert(int index, string data) {
      if (index < 0 || index > length - 1)
        throw (new IndexOutOfRangeException());
      Node ToInsert = new Node(data);
      Node curr = Head;
      for (int i = 0; i < length; i++) {
        if (i + 1 == index) {
          ToInsert.Next = curr.Next;
          curr.Next = ToInsert;
          ++length;
          break;
        }
        else if (index == 0) {
          ToInsert.Next = Head;
          Head = ToInsert;
          ++length;
          break;
        }
        curr = curr.Next;
      }
    }
    public string Delete(int index) {
      if (index < 0 || index > length - 1)
        throw (new IndexOutOfRangeException());
      Node curr = Head;
      string res = String.Empty;
      for (int i = 0; i < length; i++) {
        if (i + 1 == index) {
          res = curr.Next.Data;
          curr.Next = curr.Next.Next;
          if (index == length - 1) {
            Tail = curr;
          }
          --length;
          break;
        }
        else if (index == 0) {
          res = Head.Data;
          Head = Head.Next;
          --length;
          break;
        }
        curr = curr.Next;
      }
      return res;
    }

    public void DeleteAll(string toFind) {
      for (int j = 0; j < length; j++) {
        Node curr = Head;
        for (int i = 0; i < length; i++) {
          if (Head.Data == toFind) {
            Head = Head.Next;
            --length;
          }
          else if (curr.Next == Tail && Tail.Data == toFind) {
            curr.Next = null;
            Tail = curr;
            --length;
          }
          else if (curr.Next != null && curr.Next.Data == toFind) {
            curr.Next = curr.Next.Next;
            --length;
          }
          curr = curr.Next;
        }
      }
    }

    public string Get(int index) {
      Node curr = Head;
      for (int i = 0; i < length; i++) {
        if (i == index)
          break;
        curr = curr.Next;
      }
      return curr.Data;
    }

    public LinkedList Clone() {
      LinkedList res = new LinkedList();
      Node current = Head;
      while (current != null) {
        res.Append(current.Data);
        current = current.Next;
      }
      return res;
    }

    public LinkedList Reverse() {
      LinkedList tmp = new();
      Node current = Head;
      tmp.Append(current.Data);
      current = current.Next;
      while (current != null) {
        tmp.Insert(0, current.Data);
        current = current.Next;
      }
      return tmp;
    }

    public int FindFirst(string toFind) {
      Node curr = Head;
      int res = -1;
      for (int i = 0; i < length; i++) {
        if (curr.Data == toFind) {
          res = i;
          break;
        }
        curr = curr.Next;
      }
      return res;
    }

    public int FindLast(string toFind) {
      LinkedList tmp = this.Reverse();
      Node curr = tmp.Head;
      int res = -1;
      for (int i = 0; i < length; i++) {
        if (curr.Data == toFind) {
          res = i;
          break;
        }
        curr = curr.Next;
      }
      return res;
    }

    public LinkedList Clear() => new();

    public void ClearInCurrent() {
      while (length != 0) {
        Delete(0);
      }
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
