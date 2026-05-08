public class Solution {
   public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }

        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in set) {
            if (!set.Contains(num - 1)) { // means it is start
                int length = 0;
                while (set.Contains(num + length)) { // means it is continue after the num above
                    length++;
                }

                longest = Math.Max(length, longest);
            }
        }

       return longest;
    }
}