public class Solution {
    public int LongestPalindrome(string s) {
        char[] lst = new char[123];

        for(int i=0; i< s.Length; i++){
            if(lst[s[i]] is not null)
                lst[s[i]] += 1
            else 
                lst[s[i]] = 1
        }

        int ans=0;
        for(int j=65; j<=122; j++){
            if(lst[j] is not null){
                ans += lst[j]/2 * 2;
            }
        }

        return ans < s.Length ? ans : ans+1;
        
    }
}

public class Program{
    static void Main(string[] args){
        Solution sol = new Solution();
        Console.WriteLine(sol.LongestPalindrome("abccccdd"));
    }
}