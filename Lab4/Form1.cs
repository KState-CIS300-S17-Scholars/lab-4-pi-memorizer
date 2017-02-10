using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class uxForm : Form
    {
        public uxForm()
        {
            InitializeComponent();
        }

        private void uxFindPrimes_Click(object sender, EventArgs e)
        {
            int bound = 0;
            try
            {
                bound = Convert.ToInt32(uxNumberBound.Text);
            } catch(FormatException)
            {
                MessageBox.Show("Invalid bound");
                return;
            }
            SieveList list = new SieveList();
            list.BuildList(bound);
            list.FindPrimes();
            StringBuilder s = new StringBuilder();
            foreach(int i in list)
            {
                s.Append(i);
                s.Append(' ');
            }
            uxPrimes.Text = s.ToString();
        }
    }

    class SieveList : IEnumerable<int>
    {
        Node _head;
        int _bound;

        public void BuildList(int bound)
        {
            _bound = bound;
            _head = new Node(2);
            Node _temp = _head;
            for (int i = 3; i <= bound; i++)
            {
                _temp.Next = new Node(i);
                _temp = _temp.Next;
            }
        }

        public void FindPrimes()
        {
            if(_head==null)
            {
                return;
            }
            int nsqrt = (int)Math.Sqrt(_bound);
            Node temp = _head;
            while(temp.Data <= nsqrt)
            {
                int d = temp.Data;
                Node t = temp;
                while(t.Next!=null)
                {
                    if (t.Next.Data % d == 0)
                    {
                        t.Next = t.Next.Next;
                    }
                    else
                    {
                        t = t.Next;
                    }
                }
                temp = temp.Next;
            }
        }

        private class SieveEnumerator : IEnumerator<int>
        {
            Node _current;

            public SieveEnumerator(Node head)
            {
                Node dummy = new Node(0);
                dummy.Next = head;
                _current = dummy;
            }

            public int Current
            {
                get
                {
                    return _current.Data;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public void Dispose() { }

            public bool MoveNext() {
                if (_current == null || _current.Next == null) return false;
                _current = _current.Next;
                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SieveEnumerator(_head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class Node
        {
            int _data;
            Node _next;

            public Node(int data)
            {
                _data = data;
            }

            public int Data
            {
                get
                {
                    return _data;
                }
                set
                {
                    _data = value;
                }
            }

            public Node Next
            {
                get
                {
                    return _next;
                }
                set
                {
                    _next = value;
                }
            }
        }
    }
}
