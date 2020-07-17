
// A magic index in an array is an index such that an index into that array is the same as the value. Sorted Array, distinct, increasing
// Find magic index

public int FindMagicIndex(int[] array) {
	int index;
	int lo = 0;
	int high = array.Length;
	
	while (lo > 0 || hi < array.length) {
		index = (lo + high)/2;
	
		if (array[index] == index) return index;
		
		if (array[index] > index) {
			if (array[index] > index) return -1;
			lo = index + 1;
		}
		else if (array[index] < index) {

			high = index - 1;
		}
	}
	
	Return -1;
	
}
