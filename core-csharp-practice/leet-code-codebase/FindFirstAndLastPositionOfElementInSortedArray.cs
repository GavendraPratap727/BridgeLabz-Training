public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] res=new int[]{-1,-1};
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==target){
                res[0]=i;
                break;
            }

        }
        for(int i=nums.Length-1;i>=0;i--){
            if(nums[i]==target){
                res[1]=i;
                break;
            }

        }
        return res;
    }
}