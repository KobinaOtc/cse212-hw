using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue and add 3 people with deferent priorities. Dequeue all of them and check the order. Tim (4),
    // Bob (3), Sue (1)
    // Expected Result: The order should be like this: Tim, Bob, Sue
    // Defect(s) Found: The Dequeue method is not running as expected. It is returing the item with the high priority and not 
    // removing it from the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        var tim = new PriorityItem("Tim", 4);
        var bob = new PriorityItem("Bob", 3);
        var sue = new PriorityItem("Sue", 1);

        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        Assert.AreEqual(tim.Value, priorityQueue.Dequeue());
        Assert.AreEqual(bob.Value, priorityQueue.Dequeue());
        Assert.AreEqual(sue.Value, priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Create a priority list that has people with the same priority. Add 3 people with the same priority.
    // Dequeue all of them and check the order. Tim (4), Bob (4), Sue (4)
    // Expected Result: The Order should be like this: Tim, Bob, Sue
    // Defect(s) Found: The loop skips the beginning items in the queue and pick from the back like a stack.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        var tim = new PriorityItem("Tim", 4);
        var bob = new PriorityItem("Bob", 4);
        var sue = new PriorityItem("Sue", 4);

        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        Assert.AreEqual(tim.Value, priorityQueue.Dequeue());
        Assert.AreEqual(bob.Value, priorityQueue.Dequeue());
        Assert.AreEqual(sue.Value, priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}