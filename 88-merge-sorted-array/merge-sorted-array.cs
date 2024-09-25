public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int n1 =m-1, n2=n-1,Len=n+m-1;

        while(n1>=0 && n2>=0){
            if(nums1[n1]<=nums2[n2]){
                nums1[Len--] = nums2[n2--];
            }
            else {
                nums1[Len--] = nums1[n1--];
            }
        }
        while(n2>=0){
            nums1[Len--] = nums2[n2--];
        }
    }
}