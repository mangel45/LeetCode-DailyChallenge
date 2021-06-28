public class Solution {
    public bool ContainsDuplicate(int[] nums) {             
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int i in nums) {
            if(dict.ContainsKey(i)) return true;
            dict.Add(i, 1);                        
        }
                        
        return false;
    }
}