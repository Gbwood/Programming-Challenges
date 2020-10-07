public List<String> GeneratePermutations(string s1) {
List<string> result = new List<string>();
Var charMap = GenerateCharacterCount(s1);
GeneratePermutations(s1.Length, charMap, result)
}
 
Public Dictionary<char, int> GenerateCharacterCount(string s1) {
Dictionary<char, int> charCounts = new Dictionary<char,int>();
Foreach(var c in s1) {
If (!charCounts.ContainsKey:copyright:) {
charCounts.Add(c, 0)
}
 
charCounts[c]++;
}
 
Return charCounts;
}
 
Public void GeneratePermutations(int remaining, Dictionary<char, int> charCounts, string prefix, List<String> result) {
If (remaining == 0) {
Result.Add(prefix);
}
 
For (KeyValuePair<char, int> charToCount in charCounts) {
If (charToCount.Value > 0 {
charCounts[charToCount.Key] -= 1;
GeneratePermutations(remaining - 1, charCounts, prefix + charToCount.Key, result);
charCounts[charToCount.Key] += 1;
)
}
}