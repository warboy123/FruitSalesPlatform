using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class RandomData
    {
        private static string[] _firstName = { "张", "王", "李", "赵", "陈", "杨", "吴", "刘", 
                                              "黄", "周", "徐", "朱", "林", "孙", "马", "高", 
                                              "胡", "郑", "郭", "萧", "谢", "何", "许", "宋", 
                                              "沈", "罗", "韩", "邓", "梁", "叶" };
        private static string[] _lastName = { "旭诚", "菀茹", "荣廷", "芳", "宏坤", "婉茹", 
                                              "邦原", "思达", "书贤", "卫东", "东辉", "子函", 
                                              "慧", "光洪", "光永", "韬", "向明", "宇峰", "岑", 
                                              "子涵", "玉轩", "婉宛", "茹芸", "菲芸", "娴茹", 
                                              "子茹", "正云", "正荣", "正蓉", "正容", "正芸", 
                                              "影倩", "杰", "小权", "丹", "御宾", "恒易", "书星", 
                                              "木", "牧", "牧森", "恒杳", "檗", "楚一", "楚棣", "棣", 
                                              "棣楚", "楮", "桂林", "德林", "植", "恒一", "杵帆", 
                                              "桢", "楚", "玮珩", "星衍", "炜程", "恒楚", "桥", 
                                              "文娅", "位", "佳", "广民", "连波", "奎", "璐璐", 
                                              "陆", "鹿", "芷茹", "魁", "麓", "萌", "萧", "儒泳", 
                                              "璐", "簏", "露", "辘", "卢", "路路", "潞潞", 
                                              "露露", "玮", "精聪", "路", "彦敏", "文竹", "禄", 
                                              "胜文", "昕", "蓼", "优优", "峰", "也", "皇侗", "梦娇", 
                                              "婧婧", "道光", "道勇", "空次", "卓远", "卓原", "亚伟", 
                                              "琼", "淼", "静", "雅伦", "贶叶", "宇彤", "恺", "怡媛", 
                                              "鸿艳", "在哲", "旭哲", "曦哲", "梓豪", "金超", "丽丽", 
                                              "丽辉", "丽娟", "凤娟", "洁", "学军", "霞", "向辰", "志红",
                                              "曜", "铋舰", "硕", "婧", "硕辰", "硕晨", "连东", "海杰",
                                              "春南", "奥博", "扬东", "明达", "艳霞", "倩雯", "亚轩", "中玲",
                                              "宇阳", "莉", "超", "建红", "慧颖", "青", "利军", "财和",
                                              "培涵", "雪松", "祎", "语", "瑜", "裳", "宁", "弋涵", 
                                              "鑫言", "泽年", "怡淼", "雅茹", "怡渺", "迪", "言丽", 
                                              "星瞳", "跃" };
        public static string GetRandomName()
        {
            int seed=getRandomSeed();
            Random r = new Random(seed);
            int firstIdx = r.Next(0, _firstName.Length);
            int lastIdx = r.Next(0, _lastName.Length);

            return _firstName[firstIdx]+_lastName[lastIdx];
        }
        public static int GetRandomInt(int min,int max)
        {
            int seed = getRandomSeed();
            Random r = new Random(seed);
            return r.Next(min, max);
        }
        public static DateTime GetRadomTime()
        {
            int rYear = GetRandomInt(1980,DateTime.Now.Year);
            int rMonth = GetRandomInt(1, 12);
            int rDay=GetRandomInt(1,DateTime.DaysInMonth(rYear,rMonth));

            return new DateTime(rYear, rMonth, rDay);
        }
        private static int getRandomSeed()
        {
             DateTime begin=new DateTime(1980,9,1);
             DateTime end = DateTime.Now;
             TimeSpan ts = end - begin;
             return (int)ts.TotalSeconds;
        }

    }
}
