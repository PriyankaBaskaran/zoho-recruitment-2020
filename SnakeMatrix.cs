public class SnakeMatrix
{
 public static void main(string arg[])
{
    int row,col,k=0;
    int n = 4;
    for(row=1;row<=n;row++)
    {
        for(col=1;col<=(2*n)-row;col++) 
        {
			col<=n-row ? Console.Write(" "): row%2==1? k++:  k--; ;
                Console.Write(k);
        }k+=n;                  
        Console.WriteLine();
    }
}
}
