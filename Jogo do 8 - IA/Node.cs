using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_do_8
{
    public class Node
    {
        public string Cadeia;
        public Node NodePai;
        public int H1 = 0;

        public Node() { }
        public Node(string cadeia, Node nodePai)
        {
            Cadeia = cadeia;
            NodePai = nodePai;
            
        }

        public void GetH1()
        {
            var arrCadeia = Cadeia.ToCharArray();
            var result = @"123456780".ToCharArray();
            for (int i = 0; i < 9; i++)
            {
                if (arrCadeia[i] != result[i])
                    H1++;
            }


        }


        public List<Node> GetFilhos(Node nodePai, bool h1 = false)
        {
            int posicaoZero = -1;
            for (int i = 0; i < nodePai.Cadeia.Length; i++)
            {
                if (nodePai.Cadeia.Substring(i, 1) == @"0")
                {
                    posicaoZero = i;
                    break;
                }

            }

            var list = new List<Node>();
            char getOldValue;
            Node f1, f2, f3, f4;

            switch (posicaoZero)
            {
                case 0:
                    getOldValue = nodePai.Cadeia.ToCharArray(1, 1).First();
                    f1 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(3, 1).First();
                    f2 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    list.Add(f1);
                    list.Add(f2);
                    break;
                case 1:
                    getOldValue = nodePai.Cadeia.ToCharArray(0, 1).First();
                    f1 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(4, 1).First();
                    f2 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(2, 1).First();
                    f3 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    list.Add(f1);
                    list.Add(f2);
                    list.Add(f3);
                    break;
                case 2:
                    getOldValue = nodePai.Cadeia.ToCharArray(1, 1).First();
                    f1 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(5, 1).First();
                    f2 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    list.Add(f1);
                    list.Add(f2);
                    break;
                case 3:
                    getOldValue = nodePai.Cadeia.ToCharArray(0, 1).First();
                    f1 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(4, 1).First();
                    f2 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(6, 1).First();
                    f3 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    list.Add(f1);
                    list.Add(f2);
                    list.Add(f3);
                    break;
                case 4:
                    getOldValue = nodePai.Cadeia.ToCharArray(1, 1).First();
                    f1 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(5, 1).First();
                    f2 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(7, 1).First();
                    f3 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(3, 1).First();
                    f4 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    list.Add(f1);
                    list.Add(f2);
                    list.Add(f3);
                    list.Add(f4);
                    break;
                case 5:
                    getOldValue = nodePai.Cadeia.ToCharArray(2, 1).First();
                    f1 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(4, 1).First();
                    f2 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(8, 1).First();
                    f3 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    list.Add(f1);
                    list.Add(f2);
                    list.Add(f3);
                    break;
                case 6:
                    getOldValue = nodePai.Cadeia.ToCharArray(3, 1).First();
                    f1 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(7, 1).First();
                    f2 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    list.Add(f1);
                    list.Add(f2);
                    break;
                case 7:
                    getOldValue = nodePai.Cadeia.ToCharArray(6, 1).First();
                    f1 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(4, 1).First();
                    f2 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(8, 1).First();
                    f3 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    list.Add(f1);
                    list.Add(f2);
                    list.Add(f3);
                    break;
                case 8:
                    getOldValue = nodePai.Cadeia.ToCharArray(5, 1).First();
                    f1 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    getOldValue = nodePai.Cadeia.ToCharArray(7, 1).First();
                    f2 = new Node(nodePai.Cadeia.Replace('0', 'X').Replace(getOldValue, '0').Replace('X', getOldValue), nodePai);
                    list.Add(f1);
                    list.Add(f2);
                    break;

            }

            if (h1)
            {
                foreach (var node in list)
                {
                    node.GetH1();
                }
            }


            return list;


        }



    }
}
