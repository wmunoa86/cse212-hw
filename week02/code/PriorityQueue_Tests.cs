using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:
    // Add items with different priorities to the queue.
    // Expected Result:
    // Items should be removed in order from highest priority to lowest priority.
    // Defect(s) Found:
    // Incorrect selection of highest priority item.
    public void TestPriorityQueue_1()
    {
    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("Low", 1);
    priorityQueue.Enqueue("Medium", 5);
    priorityQueue.Enqueue("High", 10);

    Assert.AreEqual("High", priorityQueue.Dequeue());
    Assert.AreEqual("Medium", priorityQueue.Dequeue());
    Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario:
    // Add multiple items that share the same highest priority.
    // Expected Result:
    // Items with the same priority should be removed in FIFO order.
    // Defect(s) Found:
    // Incorrect tie-breaking behavior when priorities are equal.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 10);
    priorityQueue.Enqueue("Tim", 10);
    priorityQueue.Enqueue("Sue", 5);

    Assert.AreEqual("Bob", priorityQueue.Dequeue());
    Assert.AreEqual("Tim", priorityQueue.Dequeue());
    Assert.AreEqual("Sue", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario:
    // Attempt to dequeue from an empty priority queue.
    // Expected Result:
    // An InvalidOperationException should be thrown with the message
    // "The queue is empty.".
    // Defect(s) Found:
    // Missing or incorrect exception handling for an empty queue.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(
        () => priorityQueue.Dequeue());

    Assert.AreEqual("The queue is empty.", ex.Message);
    }
}