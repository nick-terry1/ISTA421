## C# hw ch24b 
#### author: nick terry 
#### date: june 3, 2018 

1. You can use plinq when youre dealing with large data sets with large numbers of elements or if the criteria specified for matching data involve complex computationally expensive operations. 
Using plinq speeds this up by partitioning the data structure and running tasks in parrallel to look for the criteria specified. 

2. Extension methods are methods that are added to the original class. AsParrallel is an extension method because it uses the Linq class but is an added method. 

3. You can cancel it before it finishes by specifying a CancellationToken object from a CancellationTokenSource and use the WithCancellation extension method of the ParrallelQuery. 

4. Its important to synchronize concurrent access to a server because you might try to access data in one thread, have another thread running faster and change the data the first thread needs, 
then when the first thread accesses that data its incorrect. An example is when you are iterating through a loop and two threads access i. If one thread is moving through the loop and changing 
i each time and the first thread is moving slow and still accessing the first i, then the next time the slow thread iterates through the loop i might not be correct. 

5. The lock statement guarantees exclusive access to resources. If an object is being used by another thread it halts the thread trying to access it until the 
accessing thread is finished with it. 

6. A mutex object is a synchronization object whose state is set to signaled when it is not owned by any thread, and nonsignaled when it is owned. 
Semaphore limits the number of threads that can access a resource or pool of resources concurrently. Mutex can be released only by thread that had acquired it, while you can signal semaphore from any other thread. 

7. If a collection is not thread safe that means it can be changed by one thread in the middle of another threads operation that uses that data. 

8. Thread safe collections are thread safe because instead of methods that change the collection it uses methods that <i>try</i> to change the collection. 
For example instead of a Remove() method the ConcurrentDictionary collection uses the TryRemove() method which wont allow the object to be removed if its being used 
by another thread. 

9. Thread safe classes are slower because they need to access whether or not the object attempting to be used is also being used by another thread. This time adds up when you are 
iterating through a collection and need to check that with every object. 

