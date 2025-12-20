public class ContainerWithMostWater {
    public int MaxArea(int[] arr) {
        int maximum =0;
		
        
		int s =0;
        
		int e = arr.Length-1;
        while (s<e){
        
		int h = Math.Min(arr[s],arr[e]);

            int w =e - s;

            int area = h*w;

            max = Math.Max(maximum,area);

            if(arr[s]<arr[e]){

                s++;



            }else

            {

                e--;

            }

        }
       
      return maximum;
        
    }
}