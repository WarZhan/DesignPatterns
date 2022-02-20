# DesignPatterns
# 设计模式
概述：[https://blog.csdn.net/zhanxi1992/article/details/123020040](https://blog.csdn.net/zhanxi1992/article/details/123020040)

## 一、简单工厂模式
源码：[FactoryPattern](https://github.com/WarZhan/DesignPatterns/tree/master/FactoryPattern)  
博文：[https://blog.csdn.net/zhanxi1992/article/details/123022083](https://blog.csdn.net/zhanxi1992/article/details/123022083)
![简单工厂模式](https://github.com/WarZhan/DesignPatterns/blob/master/Image/%E7%AE%80%E5%8D%95%E5%B7%A5%E5%8E%82%E6%A8%A1%E5%BC%8F.png)

## 二、工厂方法模式
源码：[FactoryMethodPattern](https://github.com/WarZhan/DesignPatterns/tree/master/FactoryMethodPattern)  
博文：[https://blog.csdn.net/zhanxi1992/article/details/123022459](https://blog.csdn.net/zhanxi1992/article/details/123022459)
![工厂方法模式](https://github.com/WarZhan/DesignPatterns/blob/master/Image/%E5%B7%A5%E5%8E%82%E6%96%B9%E6%B3%95%E6%A8%A1%E5%BC%8F.png)

## 三、抽象工厂模式
源码：[AbstractFactoryPattern](https://github.com/WarZhan/DesignPatterns/tree/master/AbstractFactoryPattern)  
博文：[https://blog.csdn.net/zhanxi1992/article/details/123029805](https://blog.csdn.net/zhanxi1992/article/details/123029805)
![抽象工厂模式](https://github.com/WarZhan/DesignPatterns/blob/master/Image/%E6%8A%BD%E8%B1%A1%E5%B7%A5%E5%8E%82%E6%A8%A1%E5%BC%8F.png)

## 四、单例模式
源码：[SingletonPattern](https://github.com/WarZhan/DesignPatterns/tree/master/SingletonPattern)  
博文：[https://blog.csdn.net/zhanxi1992/article/details/123030569](https://blog.csdn.net/zhanxi1992/article/details/123030569)
![单例模式](https://github.com/WarZhan/DesignPatterns/blob/master/Image/%E5%8D%95%E4%BE%8B%E6%A8%A1%E5%BC%8F.png)

## 命令模式
![命令模式](https://github.com/WarZhan/DesignPatterns/blob/master/Image/13_01.png)  
将一个请求封装为一个对象，从而可用不同的请求对客户进行参数化，对请求进行排队或记录请求日志，以及支持可撤销的操作。命令模式把请求对象与执行对象分割开
1. 它能较容易设计一个命令队列
2. 在需要的情况下，可以较容易的将命令记入日志
3. 允许接收请求的一方决定是否要执行请求
4. 可以容易的实现对请求的撤销和重做
5. 易拓展新的具体命令不影响其他类

参考代码：**CommandPattern** 和 **CommandPatternExample**