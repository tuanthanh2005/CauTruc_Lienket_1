using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt1_LienKetCauTruc
{
    class Node
    {
        private int info;
        private Node next;



        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int InFo
        {
            set { info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { next = value; }
            get { return next; }
        }


        class DSLienKetDon
        {
            private Node Head;

            public DSLienKetDon()
            {
                Head = null;
            }
            public void ThemDau(int x)
            {
                Node q = new Node(x);

                q.Next = Head;
                Head = q;
            }
            public void ThemCui(int x)
            {
                Node p = new Node(x);
                if (Head == null)
                {
                    Head = p;
                }
                else
                {
                    Node q = Head;
                    while (q.Next != null)
                    {
                        q = q.Next;
                    }

                    q.Next = p;

                }
            }
            public void XoaDau()
            {
                if (Head != null)
                {
                    Node p = Head;
                    Head = Head.next;
                    p.next = null;
                }
            }
            public void XoaCui()
            {
                Node p = Head;
                Node q = null;

                while (p.next != null)
                {
                    q = p;
                    p = p.next;
                }
                q.next = null;
            }
            public void Xuat()
            {
                Node p = Head;
                while (p != null)
                {
                    Console.WriteLine($"{p.info}\t");
                    p = p.Next;
                }

            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                DSLienKetDon ds = new DSLienKetDon();
                Console.WriteLine("Xuat Danh sach\n");
                ds.ThemDau(8);
                ds.ThemDau(5);
                ds.ThemDau(7);
                ds.ThemCui(9);
                ds.Xuat();
                Console.WriteLine("xoa Dau\n");
                ds.XoaDau();
                ds.Xuat();
                Console.WriteLine("Xoa Cui\n");
                ds.XoaCui();
                ds.Xuat();
                Console.ReadLine();
            }
        }
    }
}

