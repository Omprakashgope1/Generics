namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the count of operation you want to perform");
            int val = Convert.ToInt32(Console.ReadLine());
            switch(val)
            {
                case 1:
                    Console.WriteLine("size of array you want to create : ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    Random rn = new Random();
                    int[] arr1 = new int[size];
                    for (int i = 0; i < size; i++)
                        arr1[i] = rn.Next();
                    double[] arr2 = new double[size];
                    for (int i = 0; i < size; i++)
                        arr2[i] = rn.NextDouble() * 100;
                    char[] arr3 = new char[size];
                    for (int i = 0; i < size; i++)
                        arr3[i] = (char)('a' + rn.Next());
                    DeleteArray da = new DeleteArray();
                    Console.WriteLine("Please enter the int value you want to delete");
                    int el = Convert.ToInt32(Console.ReadLine());
                    da.DeleteMethod(arr1,el);
                    Console.WriteLine("Please enter the double value you want to delete");
                    double el2 = Convert.ToDouble(Console.ReadLine());  
                    da.DeleteMethod(arr2, el2);
                    Console.WriteLine("Please enter the char value you want to delete");
                    char ch = Convert.ToChar(Console.ReadLine());
                    da.DeleteMethod(arr3, ch);
                    break;
                case 2:
                    Console.WriteLine("size of array you want to create : ");
                    size = Convert.ToInt32(Console.ReadLine());
                    arr1 = new int[] {1,2,3,4,4,5,5,6,6};
                    arr2 = new double[] {1,2,3,4,5,6};
                    arr3 = new char[] {'a','b','c','d','e','f'};
                    Console.WriteLine("Please enter the int value you want to delete");
                    Console.WriteLine("The array before deleting the value");
                    PrintClass.printArray(arr1);
                    el = Convert.ToInt32(Console.ReadLine());
                    da = new DeleteArray();
                    da.DeleteMethodGen<int>(arr1, el);
                    Console.WriteLine("Array after deleting the element we want to delete");
                    PrintClass.printArray(arr1);
                    Console.WriteLine("The array before deleting the value");
                    PrintClass.printArray(arr2);
                    Console.WriteLine("Please enter the double value you want to delete");
                    el2 = Convert.ToDouble(Console.ReadLine());
                    da.DeleteMethodGen<double>(arr2, el2);
                    Console.WriteLine("Array after deleting the element we want to delete");
                    PrintClass.printArray(arr2);
                    Console.WriteLine("Please enter the char value you want to delete");
                    Console.WriteLine("The array before deleting the value");
                    PrintClass.printArray(arr3);
                    ch = Convert.ToChar(Console.ReadLine());
                    da.DeleteMethodGen<char>(arr3, ch);
                    Console.WriteLine("Array after deleting the element we want to delete");
                    PrintClass.printArray(arr3);
                    break;
                case 3:
                    DeleteArrayGen<int> dlInt = new DeleteArrayGen<int>();
                    DeleteArrayGen<char> dlChar = new DeleteArrayGen<char>();
                    DeleteArrayGen<double> dlDouble = new DeleteArrayGen<double>();
                    arr1 = new int[] { 1, 2, 3, 4, 4, 5, 5, 6, 6 };
                    arr2 = new double[] { 1, 2, 3, 4, 5, 6 };
                    arr3 = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
                    Console.WriteLine("Enter the element you want to delete");
                    el = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The array before deleting the value");
                    PrintClass.printArray(arr1);
                    dlInt.DeleteElement(arr1, el);
                    Console.WriteLine("The array after deleting the value");
                    PrintClass.printArray(arr2);
                    Console.WriteLine("Enter the element you want to delete");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("The array before deleting the value");
                    PrintClass.printArray(arr3);
                    dlChar.DeleteElement(arr3, ch);
                    Console.WriteLine("Array after deleting the element we want to delete");
                    PrintClass.printArray(arr3);
                    Console.WriteLine("Enter the element you want to delete");
                    el2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The array before deleting the value");
                    PrintClass.printArray(arr2);
                    dlDouble.DeleteElement(arr2, el2);
                    Console.WriteLine("Array after deleting the element we want to delete");
                    PrintClass.printArray(arr2);
                    break;
                case 4:
                    arr1 = new int[] { 1, 2, 3, 4, 4, 5, 5, 6, 6 };
                    float[] arr5 = new float[] { 1, 2, 3, 4, 5, 6 };
                    string[] arr4 = new string[] { "scjks","cjbasibd","jkdsck","bsbkcsa","bjsdkc" };
                    MinClass mc = new MinClass();
                    mc.findMinElement(arr1);
                    mc.findMinElement(arr5);
                    mc.findMinElement(arr4);
                    break;
                case 5:
                    arr1 = new int[] { 1, 2, 3, 4, 4, 5, 5, 6, 6 };
                    arr5 = new float[] { 1, 2, 3, 4, 5, 6 };
                    arr4 = new string[] { "scjks", "cjbasibd", "jkdsck", "bsbkcsa", "bjsdkc" };
                    mc = new MinClass();
                    mc.findMinElementGen<int>(arr1);
                    mc.findMinElementGen<string>(arr4);
                    mc.findMinElementGen<float>(arr5);
                    break;
                case 6:
                    arr1 = new int[] { 1, 2, 3, 4, 4, 5, 5, 6, 6 };
                    arr5 = new float[] { 1, 2, 3, 4, 5, 6 };
                    arr4 = new string[] { "scjks", "cjbasibd", "jkdsck", "bsbkcsa", "bjsdkc" };
                    MinClassGen<int>.findMinimum(arr1);
                    MinClassGen<float>.findMinimum(arr5);
                    MinClassGen<string>.findMinimum(arr4);
                    break;
                default:
                    Console.WriteLine("input value out of limit");
                    break;
            }
        }
    }
}
