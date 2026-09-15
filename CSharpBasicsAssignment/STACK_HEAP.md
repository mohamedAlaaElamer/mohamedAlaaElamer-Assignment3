# Part E: Memory Model (Stack vs. Heap)

## Diagram 1: After `Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };`

```text
       STACK                               HEAP
+------------------+             +-----------------------+
|  o1: [ 0x004F ]  | ----------> |  Order Instance       |
+------------------+             |  OrderId: 1           |
                                 |  CustomerName: "Ali"  |
                                 |  IsPaid: false        |
                                 +-----------------------+
Explanation: A reference o1 is allocated on the Stack holding the memory address (0x004F), which points to the actual Order object allocated on the Heap.


STACK                               HEAP
+------------------+             +-----------------------+
|  o1: [ 0x004F ]  | ----------> |  Order Instance       |
+------------------+   +-------> |  OrderId: 1           |
|  o2: [ 0x004F ]  | --+         |  CustomerName: "Ali"  |
+------------------+             |  IsPaid: false        |
                                 +-----------------------+
Explanation: The address held by o1 is copied into o2 on the Stack; no new object is created on the Heap, so both point to the exact same instance.



STACK                               HEAP
+------------------+             +-----------------------+
|  o1: [ 0x004F ]  | ----------> |  Order Instance       |
+------------------+   +-------> |  OrderId: 1           |
|  o2: [ 0x004F ]  | --+         |  CustomerName: "Ali"  |
+------------------+             |  IsPaid: true         |
                                 +-----------------------+
Explanation: Modifying IsPaid via o2 updates the shared object on the Heap, which means reading o1.IsPaid will also reflect true.


What would be different with structs?
If Order were a struct (like Point in Part C):

No Heap allocation: Both o1 and o2 would live entirely on the Stack containing their actual values.

Independent Copies: Executing o2 = o1 would perform a byte-by-byte copy of all fields into a separate memory slot on the Stack.

No Shared Mutation: Modifying o2.IsPaid = true would only change o2; o1.IsPaid would remain unchanged.
