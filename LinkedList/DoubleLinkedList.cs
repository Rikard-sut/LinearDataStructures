using System;

namespace DynamicList //TODO
{
    public class DoubleLinkedList<T> : System.Collections.Generic.IEnumerable<T>
    {
        // Initialisera ny instans av DoubleLinkedList classen som är tom
        public DoubleLinkedList()
        {

        }

        //Initialisera ny instans av doublelinkedlist klassen som
        //innehåller element kopierade från collectionen man använder.
        public DoubleLinkedList(System.Collections.Generic.IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new NullReferenceException("Collection cannot be null");
            }

            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }
        // Hämtar första elementet i collectionen
        public ListNode<T> First { get; private set; }

        // Hämtar sista elementet i collectionen.
        public ListNode<T> Last { get; private set; }

        //Hämtar antalet element som faktiskt finns i collectionen
        public int Count { get; private set; }


        //Lägger till nytt element med de bestämda värdet i början av collectionen.
        public void AddFirst(T value)
        {
            var linkedListNode = new ListNode<T>(value);

            if (this.First == null)
            {
                this.First = this.Last = linkedListNode;   //??
            }
            else
            {
                linkedListNode.Next = this.First;
                this.First.Previous = linkedListNode;
                this.Last = linkedListNode;
            }
            this.Count++;
        }
        //Lägger till nytt element på sista platsen i collectionen
        public void AddLast(T value)
        {
            var linkedListNode = new ListNode<T>(value);

            if (this.Last == null)
            {
                this.First = this.Last = linkedListNode;
            }
            else
            {
                linkedListNode.Previous = this.Last;
                this.Last.Next = linkedListNode;
                this.Last = linkedListNode;
            }
            this.Count++;
        }
        //Lägg till nytt element med det bestämda värdet före ett specifikt element i collectionen.
        /// <param name="node">The ListNode before which to insert a new ListNode containing value.</param>
        /// <param name="value">The value to add to the collection.</param>
        public void AddBefore(ListNode<T> node, T value)
        {
            if (node == null)
            {
                return;
            }
            var newNode = new ListNode<T>(value);

            if (node.Previous == null)
            {
                node.Previous = newNode;
                newNode.Next = node;
            }
            else
            {
                newNode.Next = node;
                newNode.Previous = node.Previous;
                //??????????????????
                node.Previous.Next = newNode;
                node.Previous = newNode;
            }

            if (node == this.First)
            {
                this.First = newNode;
            }
            this.Count++;


        }
        // tar bort första uppkomsten av specifikt element från collectionen
        public void Remove(T value)
        {
            var node = this.Find(value);
            this.RemoveReference(ref node);
        }

        //Tar bort första elementet.
        public void RemoveFirst()
        {
            var node = this.First;
            this.RemoveReference(ref node);
        }
        //Tar bort sista elementet
        public void RemoveLast()
        {
            var node = this.Last;
            this.RemoveReference(ref node);
        }

        //Hittar första platsen som inhåller specifikt värde
        public ListNode<T> Find(T value)
        {
            var currentNode = this.First;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }
            return null;
        }

        //Tar bort alla element i collectionen
        public void Clear()
        {
            this.First = this.Last = null;
            this.Count = 0;
        }

        //Returnerar en Enumerator som stegar igenom collectionen
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.First;

            while (currentNode != null)
            {
                yield return currentNode.Value;

                currentNode = currentNode.Next;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void RemoveReference(ref ListNode<T> node)
        {
            if (node != null)
            {
                if (node.Previous != null)
                {
                    node.Previous.Next = node.Next;
                }
                if (node.Next != null)
                {
                    node.Next.Previous = node.Previous;
                }
                if (node == this.First)
                {
                    this.First = node.Next;
                }
                if (node == this.Last)
                {
                    this.Last = node.Previous;
                }
                node = null;
                Count--;
            }
        }
    }

}

