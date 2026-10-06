namespace Base75;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var pref = new int[nums.Length];
        var suff = new int[nums.Length];
        var ans = new int[nums.Length];
        var pro = 1;
        var sufpro = 1;
        var sufind = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            pro *= nums[i];
            pref[i] = pro;
            sufind = nums.Length - 1 - i;
            sufpro *= nums[sufind];
            suff[sufind] = sufpro;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                ans[i] = suff[i+1];
                continue;
            }
            if (i == nums.Length - 1)
            {
                ans[i] = pref[i-1];
                continue;
            }
            ans[i] = pref[i-1] * suff[i+1];
        }
        return ans;
    }
}