//given two strings, write a method to mdecide if one is a permutation of the other


public bool checkPermutation(string a, string b)
{
    int[] words = new int[26];

    if (a.Length != b.Length) return false;

    foreach (char c in a)
    {
        words[c - 97]++;
    }

    foreach (char c in b)
    {
        if(words[c - 97] > 0)
        {
            words[c - 97]--;
        }
        else
        {
            return false;
        }
    }
    return true;
}


//solution #2
public bool checkPermutation(string a, string b)
{
    if (a.Length != b.Length) return false;
    int aCount = 0;
    int bCount = 0;


    for (int i = 0; i < a.Length; i++)
    {
        aCount += a[i];
        bCount += b[i];
    }

    if (aCount == bCount) return true;
    return false;
}
