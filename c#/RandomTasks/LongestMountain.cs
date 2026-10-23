namespace RandomTasks;

public static class LongestMountain
{
    public static int FindLongestMountain(int[] arr) {
        if (arr.Length < 3) return 0;
        var res = 0;
        var i = 1;
        var l = i - 1;
        var r = i + 1;
        var current = 3;
        var isRight = false;
        var isLeft = false;

        while (i < arr.Length - 1) {
            current = 1;
            isRight = false;
            isLeft = false;
            while (r < arr.Length && arr[r] < arr[r-1]) {
                r++;
                current++;
                isRight = true;
            }
            while (l >= 0 && arr[l] < arr[l+1]) {
                l--;
                current++;
                isLeft = isRight;
            }
            if (isLeft)
                res = Math.Max(current, res);
            i = r;
            l = i - 1;
            r = i + 1;
        }
        return res;
    }
}