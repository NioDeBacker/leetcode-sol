public class Solution {
    public double New21Game(int n, int k, int maxPts) {
        if(k==0||n>=k+maxPts){
            return 1.0;
        }
        double[] arr=new double[n+1];
        double Sum=1.0, result=0.0;
        arr[0]=1;
        for(int i =1;i<arr.Length;i++){
            arr[i]=Sum/maxPts;
            if(i<k){
                Sum+=arr[i];
            }
            else{
               result+=arr[i]; 
            }
            if(i-maxPts>=0){
                Sum=Sum-arr[i-maxPts];
            }
        }
        return result;
    }
}
