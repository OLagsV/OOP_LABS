namespace ArrLib
{
    public class ArrOperations
    {
        private int[] arrToOperate;
        public ArrOperations(int[] arrToOperate)
        {
            this.arrToOperate = arrToOperate;
        }
        public int[] Subtractuion(int[] arrToSubtr)
        {
            /*if (arrToSubtr.Length != 0)
            {
                throw new ArrException("Не передан массив для вычитания");
            }
            else
            {*/
                Console.Write(arrToSubtr.Length);
                IEnumerable<int> resultArr = this.arrToOperate.Except(arrToSubtr);
                return resultArr.ToArray();
            /*}*/

        }
        public int[] Summ(int[] arrToAdd)
        {
            if (arrToAdd.Length == 0)
            {
                throw new ArrException("Не передан массив для добавления");
            }
            else
            {
                IEnumerable<int> resultArr = this.arrToOperate.Union(arrToAdd);
                return resultArr.ToArray();
            }
        }
    }
}