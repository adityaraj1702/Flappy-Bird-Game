#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() 
{

    int n;
    int a =0;
    scanf("%d", &n);
  	// Complete the code to print the pattern.
    // for (int i=0; i<n; i++) {
    //     printf("%d ", n);
    // }
    for(int i=0;i<n;i++){
        for(int j=0;j<n;j++){
            int t=n-i;
            if(i==0 ||i==n){
                scanf("%d",&n);
                
            }
            
            else if(j>=i && j<=n-1){
                scanf("%d",&t);
            }
            else{
                scanf("%d",&n);
            }
            
            
        }
    }
    
    return 0;
}