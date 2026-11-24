namespace LinkedList_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1vaGrupa
            MyLinkedList list = new MyLinkedList();
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30); //30  20  10

            list.AddLast(40);//30  20  10  40
            list.AddLast(50);// 30  20  10  40  50
            Console.ReadKey();
            #endregion
        }
    }
}
