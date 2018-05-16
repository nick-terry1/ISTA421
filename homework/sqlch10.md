## CH 10 sql hw 
#### author: nick terry 
#### date: may 14, 2018 

1. The purpose of transactions group work together similar queries and data modifiers that can be put into one unit. It makes things easier than writing them all out each time.

2. Atomicity is the smallest unit of work, Consistency gives you the same state of the data the entire time you modify it, Isolation makes sure your 
transactions only access consistent data, Durability means data changes are always written to the databases transaction log on the disk before theyre written to the data portion of the database. 

3. Granularity is having locks on higher levels that access the information you are modifying. 

4. Modes of locks are exclusive and shared and refer to whether someone else can access the data while you have it locked. 

5. Blocking is where someone is trying to access data that someone else has locked. 

6. sid, restype, dbid, dbname, res, resid, mode, status. requestsessionid, resourcetype, resourcedatabaseid, dbname, resource description, resource associated entity id, request mode, request status.

7. sid, connect time, last read, last write, most recent sql handle 

8. session id, blocking session id, command, sql handle, database id, wait type, wait time, wait resource. 

9. Isolation levels determine the level of consistency you get when you interact with data. Like shared locks are used on readers and exclusive are used on writers. 

10. Serialization is turning an object into a series of ones and zeros. It reads with a shared lock and keeps it until the end of the transaction.

11. A deadlock is where one has a lock on data trying to access another set of data thats locked and another is trying to do the same.