namespace Base75;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length-1;
        var maxSquere = 0;
        while (left < right)
        {
            var square = (right - left) * Math.Min(height[left], height[right]);
            maxSquere = Math.Max(maxSquere, square);
            if (height[left] < height[right])
            {
                left++;
                continue;
            }
            if (height[right] < height[left])
            {
                right--;
                continue;
            }
            left++;
            right--;
        }
        return maxSquere;
    }
}