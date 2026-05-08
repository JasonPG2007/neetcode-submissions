public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 0 || s == " ") {
            return true;
        }

        int right = s.Length - 1;
        int left = 0;


        while (left < right) {
            if (!char.IsLetterOrDigit(s[left])) {
                left++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[right])) {
                right--;
                continue;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                return false;
            }

            right--;
            left++;
        }


        return true;
    }
}