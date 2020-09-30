public static bool isStringPermutationOfPalindrome(string s) {
	s.trim();
	s.toLowerCase();
	
	Bool [] oddChars = new bool[26];
	int oddCount = 0;
	
	for (int i = 0; i < s.Length; i++) {
		int index = s[i] - 'a';
		oddChars[index] = !oddChars[index];
		
		if (oddChars[index]) {
			oddCount++
		}
		else {
			oddCount--;
		}
	}
	return oddCount <= 1;
}