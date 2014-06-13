using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnionFind
{
    class QuickFind
    {
       private int[] id;

        public QuickFind(int N)
        {
            id = new int[N];
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                
            }
                    
        }


        public Boolean connected(int p, int q)
        {
            return id[p]==id[q]?true:false;
        }

        public void Union(int p, int q)
        {
            int qid = id[q];
            int pid = id[p];
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == qid)
                {
                    id[i] = pid;
                }
            }
        }



    }
}
