public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            var comp = target - nums[i];
            if(dict.ContainsKey(comp)){
                return [dict[comp],i];
            }
            else{
                dict[nums[i]] = i;
            }
        }
        return [];
    }
}
