#Static关键字的作用

- The compiler will prevent you from creating an instance of that class.
	编译器会阻止你创建类的实例

- Why would you possibly do that? Why would you create a class and only not to instantiate it?
	为什么要这样做？为什么创建一个类，仅仅不允许实例化这个类？
	
	Because you can expose some static methods of that class and you can directly interact with these things.
	因为你可以暴露出这个类的某些静态方法，你可以直接与这些方法进行交互。
	
	Key things is there is no state being managed within a static class.
	It is effectively stateless.It just provides you with a sries of behaviours.
	关键的一点是静态类中没有需要管理的状态。它是没有状态的，它仅仅给你提供了一系列行为。

- Almost like a library of interactions and activities that it can do without the cost of instantiation
	静态类类似于一个交互库，你可以在不需要创建实例化的前提下使用这些方法。