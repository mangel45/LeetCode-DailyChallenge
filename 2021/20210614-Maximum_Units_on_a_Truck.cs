public class Solution {
  public int MaximumUnits(int[][] boxTypes, int truckSize) {
    int maxUnits = 0;
    int currentIndex = 0;
    
    boxTypes = boxTypes.OrderByDescending(inner => inner[1]).ToArray();
    
    while(truckSize > 0 && currentIndex < boxTypes.Length) {               
      maxUnits += boxTypes[currentIndex][1];
      boxTypes[currentIndex][0]--;
      truckSize--;            
      if(boxTypes[currentIndex][0] == 0) currentIndex++;
    }
        
    return maxUnits;
  }
}