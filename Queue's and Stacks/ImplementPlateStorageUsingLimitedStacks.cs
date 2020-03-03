
// Stack of plates

// Set of stacks
// Composed of several stacks and create a new one once a previous one reaches a certain capacity



struct SetofPlates{
	int max;
	struct Stack * StackOfPlates;
	}
struct StackOfPlates{
	int max;
	struct Stack * Plates;
}

public void PushPlate(struct * StacksOfPlates s1, int plate)  {
	if (s1->Plates.Size == s1.max) { 
		Struct * StacksOfPlates s2 = new Stuct StacksOfPlates();
		S2.max = s1.max;
		S2->Plates = Struct * Stack;
		S2-> previous = s1;
		S1->next = s2;
		PushPlate(s2, plate);}
	else {
		S1.Plates.push(plate);
	}
}