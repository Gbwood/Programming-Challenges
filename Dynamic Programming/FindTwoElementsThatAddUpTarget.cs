//Suppose you are asked to write a program that takes an array of integers in sorted order. Given a target element, Tell me if there are two elements that add up to that element

public bool FindElement(int[] a, int elem) {
	
	int first = 0;
	int last = a.length - 1;
	int sum;
	
	while (first != last) {
		sum = a[first] + a[last];
		if(sum == target) return true;
		if(sum > target) last--;
		if(sum < target) first++;
	}
	return false;
}
