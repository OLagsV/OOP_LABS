namespace ArrLib
{
    public class ArrayOperations
    {
        private int[] arrToOperate;
        public ArrayOperations(int[] arrToOperate)
        {
            this.arrToOperate = arrToOperate;
        }
        public int[] Subtractuion(int[] arrToSubtr)
        {
            IEnumerable<int> resultArr = this.arrToOperate.Except(arrToSubtr);
            return resultArr.ToArray();
        }
        public int[] Summ(int[] arrToAdd)
        {
            IEnumerable<int> resultArr = this.arrToOperate.Union(arrToAdd);
            return resultArr.ToArray();
        }
    }
}