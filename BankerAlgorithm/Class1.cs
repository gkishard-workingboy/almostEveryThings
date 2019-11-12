using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankerAlgorithm
{
    public class M 
    {
        public static Random r  = new Random((int) DateTime.Now.Ticks);
        public List<int> m;

        public M(List<int > r)
        {
            m = new List<int>(r);
        }

        public M(int num)
        {
            m = new List<int>();
            for (var i = 0; i < num; i++)
            {
                m.Add(0);
            }
        }
        public M(int num,int min,int max)
        {
            m = new List<int>();
            for (var i = 0; i < num; i++)
            {
                
                m.Add(r.Next(min, max));
            }
        }
        public M(string s)
        {
            m = new List<int>();            
            string[] ss = s.Trim().Split(" ".ToCharArray());
            foreach(var i in ss)
            {
                m.Add(int.Parse(i));
            }
        }

        public M()
        {
            m = new List<int>();
            
        }
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var s in m)
            {
                sb.Append(s.ToString() + " ");             
            }
            return sb.ToString();
        }

        public void addNum(int min, int max)
        {           
            m.Add(r.Next(min, max));
            
        }

        public int sum()
        {
            int sum = 0;
            foreach( var c in m )
            {
                sum += c;
            }
            return sum;
        }

        public int max()
        {
            return m.Max();
        }

        public M Copy()
        {
            return new M(m.ToList<int>());
        }
    }

    public class MUtil { 
        public static M AddM(M ope1,M ope2)
        {
            if(ope1.m.Count == ope2.m.Count)
            {
                List<int> m = new List<int>();
                for (var i = 0; i < ope1.m.Count; i++)
                    m.Add(ope1.m[i] + ope2.m[i]);
                return new M(m);
            }
            else
            {
                Console.WriteLine("矩阵加错误： 相加矩阵维度不匹配");
                return null;
            }
         }

        public static M SubM(M ope1, M ope2)
        {
            if (ope1.m.Count == ope2.m.Count)
            {
                List<int> m = new List<int>();
                for (var i = 0; i < ope1.m.Count; i++)
                    m.Add(ope1.m[i] - ope2.m[i]);

                return new M(m);
            }
            else
            {
                Console.WriteLine("矩阵减错误 ： 相减矩阵维度不匹配");
                return null;
            }
        }

        public static bool isPositive(M ope)
        {
            foreach (var v in ope.m)
            {
                if(v < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int sum_of_column(int column,List<M> mat)
        {
            int sum = 0;
            foreach(var c in mat)
            {
                sum += c.m[column];
            }
            return sum;
        }

        public static int max_of_column(int column, List<M> mat)
        {
            int max = 0;
            foreach (var c in mat)
            {
                max = max < c.m[column] ? c.m[column]:max ;
            }
            return max;
        }
        
        public static bool compare(M p1,M p2)
        {
            return isPositive(SubM(p1, p2));
        }
    }

    public class Processes
    {
        public List<M> need;                            //尚需的各项资源数 n*m  need = max - allocation
        public M available;                             //可利用资源向量 1*m
        public List<M> max;                             //最大需求矩阵 n*m
        public List<M> allocation;                      //已分配矩阵 N*M
        public M request;                               //请求向量 1*m
        public M work;                                  //工作向量 1*m
        public M tempAlloc;                             //暂时分配矩阵 1*m
        List<bool> finish;
        public string p;                                 //安全序列
        public string status;                            //状态信息

        public Processes(int num_p,int num_r)
        {
            max = new List<M>();
            for (var i = 0; i < num_p; i++)
            {
                max.Add(new M(num_r, 0, 20));
            }
            need = new List<M>(max);

            
            available = new M();

            for(var i = 0; i<num_r; i++)
            {
                if((int)Math.Floor(1.3 * MUtil.max_of_column(i, max))< MUtil.sum_of_column(i, max))
                    available.addNum((int)Math.Floor(1.3 * MUtil.max_of_column(i, max)), MUtil.sum_of_column(i, max));
                else
                {
                    available.addNum((int)Math.Floor(1.1 * MUtil.max_of_column(i, max)), MUtil.sum_of_column(i, max));
                }
            }

            request = new M(num_r);
            allocation = new List<M>();

            for( var i = 0; i < num_p; i++)
            {
                allocation.Add(new M(num_r));
            }

            work = available.Copy();
            tempAlloc = new M(num_r);
            finish = new List<bool>();

            for(int i = 0; i< num_p;i++)
            {
                finish.Add(false);
            }
        }

        public bool saftyCheckOut()
        {                       
            for(var i = 0; i< finish.Count; i++)
            {
                if(finish[i] == false && MUtil.compare(work, need[i]))
                {
                    work = MUtil.AddM(work , tempAlloc);
                    finish[i] = true;
                    p += ("P" + i+ " ");
                    saftyCheckOut();
                    break;
                }                
            }

            return checkFinish() ? true : false;
                
        }

        public bool checkFinish()
        {
            foreach(var i in finish)
            {
                if (i == false)
                    return false;
            }
            return true;
        }
       

        public bool bankerAlgorithm(int column)
        {
            if (MUtil.compare(need[column], request)){
                if (MUtil.compare(work, request))
                {
                    work = MUtil.SubM(available, request);
                    tempAlloc = MUtil.AddM(allocation[column], request);
                    need[column] = MUtil.SubM(need[column], request);

                    for(var c = 0;c < finish.Count;c++)
                    {
                        finish[c] = false;
                    }
                    p = "";
                    status = "";
                    if (saftyCheckOut()) {
                        available = MUtil.SubM(available, request);
                        allocation[column] = MUtil.AddM(allocation[column], request);
                        status = "是安全状态";
                        return true;
                    }
                    else
                    {
                        need[column] = MUtil.AddM(need[column], request);
                        status = "不是安全状态";
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("尚无足够资源");
                    status = "尚无足够资源";
                    return false;
                }
            }
            else
            {
                Console.WriteLine("所需要资源数已超过他所宣布的最大值");
                status = "所需要资源数已超过他所宣布的最大值";
                return false;
            }
        }

    }
}
