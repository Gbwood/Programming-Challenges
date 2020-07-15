//Given an array of positive integers, find the largest h at which there are at least h entries in the array that are greater than or equal


//[0, 1, 2, 3, 4, 4, 5]

//[1, 4, 1,4 ,2,1,3,5,6]

//[1,1,1,2,3,4,4,5,6]



//	1. Order list
//	2. Start at the beginning of array
//	3. If there are atleast h entries to the right, save H
//	4. Continue process until h > remaining digits




public int findH(int a[])
{
	Int h;
	Int n = a.Length;
	Int index = 0;

	a = array.sort(a);

	while(n - index >= 0 && a[index] <= n - index) {
		H = a[index];
		Index++;
	}

	return h;

}

