//Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?

//Dictionary Set first instinct. But without a data structure?

//I could order the array and check for duplicates? to do it without a data structure.


//Implementation 1. Dictionary Set


public bool IsUnique(string value)
{
	//if there are more than 128 characters you know one has to repeat. #PigeonHolePrinciple
	if (value.Length > 128) return false;
		
	bool[] list = new bool[128];
	for (int i = 0; i < value.Length; i++)
    {
		char character = value[i];

		if (list[character] == true) return false;
		list[character] = true;
    }
	return true;


}



//Implementation 2. No data structures
//Order array and then compare
public bool IsUnique2(string value)
{
	char[] values = value.ToCharArray();
	Array.Sort(values);

	for(int i = 0; i < values.Length; i++) {
		if(i < values.Length - 1)
        {
			if (values[i] == values[i + 1]) return false;
        }
    }
	return true;
}


