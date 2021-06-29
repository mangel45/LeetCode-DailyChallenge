public class Solution {
    public string RemoveDuplicates(string s) {
       List<int> removeIndices = new List<int>();
        
        do {                 
            removeIndices.Clear();
            for(int i=0; i<s.Length-1; ) {
                if(s[i] == s[i+1]) {
                    removeIndices.Add(i);
                    removeIndices.Add(i+1);
                    i+=2;
                } else {
                    i++;
                }            
            }

            for(int i=0; i<removeIndices.Count; i++) {
                s = s.Remove(removeIndices[i]-i,1);
            }
            
        } while(removeIndices.Count > 0);
        
        return s;
    }
}