

// #Emplement a Queue using only two stacks

public class Queue {
	Stack EnqueueStack;
	Stack DequeueStack;
	
	
	public Queue() {
		EnqueueStack = new Stack();
		DequeueStack = new Stack();
	}
	
	
	public void Enqueue(int value) {
		if (EnqueueStack.Peek() == null) {
			shiftStack();
		}
		EnqueueStack.push(value);
	}
	
	public void Pop() {
		if (DequeueStack.peek() == null) {
			shiftStack();
		}
		return DequeueStack.Pop();
	}

	//axilary
	public void ShiftStack() {
		if (Enqueue.Peek == null) {
			while(DequeueStack.Peek() != null) {
				EnqueueStack.push(DequeueStack.pop());
			}
		}
		else {
			while(EnqueueStack.Peek() != null) {
				DequeueStack.push(EnqueueStack.pop());
			}	
		}
	}
}