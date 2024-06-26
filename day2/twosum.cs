public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length < 2) return new int[0];

        int n = nums.Length;
        for(int i=0; i< n-1 ;i++ ){
            for(int j = i+1; j < n; j++){
                if(nums[i] + nums[j] == target) 
                    return new int[]{i, j};                 
            }
        }

        return null;
    }
}