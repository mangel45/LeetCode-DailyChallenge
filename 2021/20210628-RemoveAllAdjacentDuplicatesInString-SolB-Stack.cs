public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> result = new Stack<char>();
        
        foreach(char c in s) {
            if(result.Count <= 0) 
                result.Push(c);                                
            else if(result.Peek() != c) 
                result.Push(c);
            else
                result.Pop();                
        }
        
        return new String(result.Reverse().ToArray());
    }
}