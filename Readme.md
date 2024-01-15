new is allocated in heap

In another language, there is delete
	- memory leak
	- memory corruption
	- memory error
So .NET have GC
but GC itself have 
	- too convenient
	- lose sight memory footprint
	- allocates more memory than it actually needs

---
Stack
	Stack Frame = 
	- Local Variables, 
	- Return Address, 
	- MethodParameters
Too much frames : StackOverFlow
---
Heap
	Heap for reference type
	It will still exist even the method caller closed (dereferenced state)
	Thats GC job to clean the Heap
---
Boxing Unboxing
Make the value to reference type
---
GC 
Generation Garbage Collection
Why?
Frequent Gen0
Infrequent Gen1
Very infrequent Gen2
So not frequently check and clean the object

LOH is collected in Gen2
Not compacted
---
Memory Optimization
- Do not use ToString(), even in StringBuilder
- Do not use boxing and unboxing (ArrayList -> List<>)
- Do not create instance that not used for long time
- Do not realocate new List or collection, just use .Clear()
---
Finalizers
	~
	Finalizers queue
	Must only process it owns object, not other referenced object, because maybe already finalized
	Random order finalizers
	Make it in two collection cycle, make it tobe cleaned on Gen1
	Do not inheritance using Finalizers
	Not guaranteed to be called
	If the host exits, all remaining finalisation queue will be discarded in 4 seconds
---
Dispose Pattern
	Why there is dispose pattern?
	To overcome the problem of finalizers
	And immediately release resource
---
Why do not use Dispose()
Why use using()
---