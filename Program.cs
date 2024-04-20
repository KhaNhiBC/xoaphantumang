internal class Program
{
    private static void Main(string[] args)
    {
        int[] myarry = {1,2,3,4,5,6,7,8,9};
        Console.WriteLine("Nhap gia tri can xoa");
        int x = Convert.ToInt32(Console.ReadLine());
        ClearArry(x,myarry);
    }
    private static void ClearArry(int x, int[] myarry){
        
        int indext = 0;
        // tim phan tu co trong mang
        for (int i = 0;i < myarry.Length;i++){
            if (myarry[i] == x){
                indext = i;
            }
        }
        // chen phan tu da nhap
        for (int i = indext;i < myarry.Length-1;i++){
            myarry[i] = myarry[i+1];
        }
        Array.Resize(ref myarry, myarry.Length-1);
        for (int i = 0;i < myarry.Length;i++){
            Console.Write(myarry[i]+",");
        }
    }
}