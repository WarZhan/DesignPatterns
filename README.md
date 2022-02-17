# DesignPatterns
# 设计模式
## 一、简单工厂模式
项目：FactoryPattern
## 二、工厂方法模式
项目：FactoryMethodPattern
## 三、抽象工厂模式
项目：AbstractFactoryPattern



## 命令模式
![命令模式](https://github.com/WarZhan/DesignPatterns/blob/master/Image/13_01.png)  
将一个请求封装为一个对象，从而可用不同的请求对客户进行参数化，对请求进行排队或记录请求日志，以及支持可撤销的操作。命令模式把请求对象与执行对象分割开
1. 它能较容易设计一个命令队列
2. 在需要的情况下，可以较容易的将命令记入日志
3. 允许接收请求的一方决定是否要执行请求
4. 可以容易的实现对请求的撤销和重做
5. 易拓展新的具体命令不影响其他类

参考代码：**CommandPattern** 和 **CommandPatternExample**