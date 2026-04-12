public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> list = nums.ToList();
        list.Sort();
        for(int i=0;i<list.Count-1;i++){
            if(list[i] == list[i+1])
            {
                return true;
            }
        }
        return false;
    }
}