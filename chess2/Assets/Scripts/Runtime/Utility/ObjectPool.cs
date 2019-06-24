using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public class ObjectPool<T> where T : new() {
        private readonly List<T> mUsed = new List<T>();
        private readonly List<T> mUnused = new List<T>();

        public List<T> usingObjects {
            get { return mUsed; }
        }

        //public List<T> unusingObjects {
        //    get { return mUnused; }
        //}


        public T Spawn()
        {
            if (mUnused.Count > 0) {
                T item = mUnused[0];
                mUsed.Add(item);
                mUnused.RemoveAt(0);
                return item;
            }
            else {
                T item = new T();
                mUsed.Add(item);
                return item;
            }
        }

        public bool Recycle(T item)
        {
            if (mUsed.Remove(item))
            {
                
            }
            mUnused.Add(item);
            return true;
        }
    }


    //internal class ObjectPool<T> where T : new()
    //{
    //    private readonly Stack<T> m_Stack = new Stack<T>();
    //    private readonly UnityAction<T> m_ActionOnGet;
    //    private readonly UnityAction<T> m_ActionOnRelease;

    //    public int countAll { get; private set; }
    //    public int countActive { get { return countAll - countInactive; } }
    //    public int countInactive { get { return m_Stack.Count; } }

    //    public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) {
    //        m_ActionOnGet = actionOnGet;
    //        m_ActionOnRelease = actionOnRelease;
    //    }

    //    public T Get() {
    //        T element;
    //        if (m_Stack.Count == 0) {
    //            element = new T();
    //            countAll++;
    //        } else {
    //            element = m_Stack.Pop();
    //        }
    //        //if (m_ActionOnGet != null)
    //        //    m_ActionOnGet(element);
    //        return element;
    //    }

    //    public void Release(T element) {
    //        //if (m_Stack.Count > 0 && ReferenceEquals(m_Stack.Peek(), element))
    //        //    Debug.LogError("Internal error. Trying to destroy object that is already released to pool.");
    //        //if (m_ActionOnRelease != null)
    //        //    m_ActionOnRelease(element);
    //        //m_Stack.Push(element);
    //    }
    //}
}