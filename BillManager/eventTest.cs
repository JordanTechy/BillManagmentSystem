using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager
{
    



    



}


/*
 
  //--------------------------------------------------------------wicked event when added to list-----------------------------------------   
    using System.Collections;
    
    // A class that works just like ArrayList, but sends event
    // notifications whenever the list changes:
    public class ListWithChangedEvent : ArrayList
    {
        // An event that clients can use to be notified whenever the
        // elements of the list change:
        public event EventHandler Changed;

        // Invoke the Changed event; called whenever list changes:
        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        // Override some of the methods that can change the list;
        // invoke event after each:
       

        public override int Add(object value)
        {
            int i = base.Add(value);
            OnChanged(EventArgs.Empty);
            return i;
        }

        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }



    class EventListener
    {
        private ListWithChangedEvent List;

        public EventListener(ListWithChangedEvent list)
        {
            List = list;
            // Add "ListChanged" to the Changed event on "List":
            List.Changed += new EventHandler(ListChanged);
        }

        // This will be called whenever the list changes:
        private void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is called when the event fires.");
        }

        public void Detach()
        {
            // Detach the event and delete the list:
            List.Changed -= new EventHandler(ListChanged);
            List = null;
        }
    }

    class Test
    {
        // Test the ListWithChangedEvent class:
        public static void Main()
        {
            // Create a new list:
            ListWithChangedEvent list = new ListWithChangedEvent();

            // Create a class that listens to the list's change event:
            EventListener listener = new EventListener(list);

            // Add and remove items from the list:
            list.Add("item 1");

            listener.Detach();
            
           // listener.Detach();
            list.Add("item 2");
            //listener = new EventListener(list);
         
         listener = new EventListener(list);
            list.Add("item 3");    
        
       
            list.Clear();
            //listener.Detach();
        }
    }


}

    -------------------------------------------end-----------------------------------------------------------
    public class Metronome
    {
        public event TickHandler Tick;
        public EventArgs e = null;
        public delegate void TickHandler(Metronome m, EventArgs e);
        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(3000);
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }
    public class Listener
    {
        public void Subscribe(Metronome m)
        {
            m.Tick += new Metronome.TickHandler(HeardIt);
        }
//wtfff
        private void HeardIt(Metronome m, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }




    class Test
    {
        static void Main()
        {
            Metronome m = new Metronome();
            Listener l = new Listener();
            l.Subscribe(m);
            m.Start();

            MyClass myObject = new MyClass();
            myObject.MyEvent += new EventHandler(myObject_MyEvent);
            myObject.Method();

        }

        private static void myObject_MyEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }


    class MyClass
    {
        public event EventHandler MyEvent;

        public void Method()
        {
            OnEvent();
        }

        private void OnEvent()
        {
            if (MyEvent != null)
            {
                MyEvent(this, EventArgs.Empty);
            }
        }
    }
     */
