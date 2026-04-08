public class Palindrome {
    public bool IsPalindrome(int x) {
      int temp=x;
      int rev=0;
      if(x<0) {
        return false;
      }
      while(x!=0){
        int d=x%10;
        rev=rev*10+d;
        x=x/10;
      }  
      if(temp==rev) return true;
      else return false;
    }
}