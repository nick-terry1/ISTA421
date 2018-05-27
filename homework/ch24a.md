## c# hw ch24 
#### author: nick terry 
#### date: may 27, 2018 

1. An asyncronous method is a method that doesnt block the thread that called it. 

2. The problem is that all the tasks would run at the same time and you might want them to run in a specific order. 

. The problem is that you may want to run more code specifically after the async thread completes but using a wait() method would defeat the purpose of using 
multithreading in the first place. 

4. The problem is only the user interface thread can manipulate user interface controls. 

5. The problem is you have to use a dispatcher object and using those are messy and difficult to maintain. 

6. The async modifier indicates that a method contains functionality that can be run asynchronously. The await operator specifies the points at which this async functionality should be performed. 

7. An awaitable object is a type that provides the GetAwaiter method, which returns an object that in turn provides methods for running code and waiting for it to complete. 

8. You instantiate a task with the code it will run and return the task. 

9. Syntax is to instantiate the task, run it with the code it operates, and await it as the last thing in the method. 

10. The difference is the TResult generic type class where the TResult is the return type. The result property returns a result when it has one and blocks the rest of the 
code until it has one therefore theres no need for an await keyword. 

11. Difference between await and Wait() is Wait() blocks the current thread until the task completes and await releases the calling code thread to be used while the task runs. 