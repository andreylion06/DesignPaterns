using System;
using Singleton;

Thread t1 = new Thread(() =>
{
    DatabaseRepository.Instance(1);
});

Thread t2 = new Thread(() =>
{
    DatabaseRepository.Instance(2);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine(DatabaseRepository.Instance(0).Id);

// Both threads are creating an instance with different Ids.
// After that I join both threads. Id is equal to 1
// So, I did not created two instances and Design Patern is
// implemented correctly.