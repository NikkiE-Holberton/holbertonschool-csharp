﻿using System;

///<summary>Creating an abstarct class.</summary>
public abstract class Base
{
    ///<summary>Creates property obj named "name".</summary>
    public string name;

    ///<summary>Method that prints obj and obj type.</summary>
    public override string ToString()
    {
        return (name + " is a " + this.GetType().ToString());
    }
    
    ///<summary>Creating interface named Interactive.</summary>
    interface IInteractive
    {
        ///<summary>Creates method for interface.</summary>
        void Interact();
    }
    ///<summary>Creating interface named Breakable.</summary>
    interface IBreakable
    {
        ///<summary>Creates method for interface.</summary>
        void Break();

        ///<summary>Creates an int property for interface.</summary>
        int durability { get; set; }
    }
    ///<summary>Creating interface named Collectable.</summary>
    interface ICollectable
    {
        ///<summary>Creates method for interface.</summary>
        void Collect();

        ///<summary>Creates an int property for interface.</summary>
        bool isCollected { get; set; }
    }

    ///<summary>Creating an class that inherits from Base class and the interfaces.</summary>
    class TestObject : Base, IInteractive, IBreakable, ICollectable
    {
        public void Interact()
        {}
        public void Break()
        {}
        public int durability { get; set; }
        public void Collect()
        {}
        public bool isCollected { get; set; }
    }
}