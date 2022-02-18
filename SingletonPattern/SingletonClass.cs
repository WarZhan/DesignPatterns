using System;

namespace SingletonPattern
{
    public class SingletonClass
    {
        #region 懒汉式，线程不安全
        // 懒汉式：使用 Lazy 初始化，在第一次调用时实例化
        // 最基本的实现方式，适用于 单线程
        //private static SingletonClass _instance = null;
        //public static SingletonClass Instance 
        //{
        //    get 
        //    {
        //        if (null == _instance)
        //        {
        //            _instance = new SingletonClass();
        //        }

        //        return _instance;
        //    }
        //}
        #endregion

        #region 饿汉式，线程安全
        // 饿汉式：它基于 classloader 机制避免了多线程的同步问题，_instance 在类装载时就实例化
        //private static SingletonClass _instance = new SingletonClass();
        //public static SingletonClass Instance
        //{
        //    get 
        //    { 
        //        return _instance;
        //    }
        //}
        #endregion

        #region 懒汉式：双检锁/双重校验锁（DCL，即 double-checked locking）
        // 使用 Lazy 初始化，并且线程安全 推荐使用
        //private static volatile SingletonClass _instance = null;
        //private static readonly object _lockObject = new Object();

        //public static SingletonClass Instance
        //{
        //    get
        //    {
        //        if (null == _instance)
        //        {
        //            lock (_lockObject)
        //            {
        //                if (null == _instance)
        //                {
        //                    _instance = new SingletonClass();
        //                }
        //            }
        //        }

        //        return _instance;
        //    }
        //}
        #endregion

        #region 使用 Lazy<T> 实现，.net3.5 后推荐使用
        // 使用 Lazy<T> 可以使对象的实例化延迟到第一次被调用的时候执行，
        // 通过访问它的 Value 属性来创建并获取实例，
        // 并且读取一个 Lazy<T> 实例的 Value 属性只会执行一次实例化代码，确保了线程安全。
        private static readonly Lazy<SingletonClass> _instance =
                new Lazy<SingletonClass>(() => new SingletonClass());

        public static SingletonClass Instance
        {
            get { return _instance.Value; }
        }
        #endregion

        /// <summary>
        /// 构造函数私有化 不允许外部调用
        /// </summary>
        private SingletonClass() { }

        public void ShowName()
        {
            Console.WriteLine("Call SingletonClass.ShowName()！");
        }
    }
}
