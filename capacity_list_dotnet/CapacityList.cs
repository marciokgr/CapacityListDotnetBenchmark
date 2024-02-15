using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;

namespace CapacityListDotnetBenchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [SimpleJob(RuntimeMoniker.Net60, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [SimpleJob(RuntimeMoniker.Net80)]
    public class CapacityList
    {
        //Sem capacity
        [Benchmark(Baseline = true)]
        public void AddItemList()
        {
            List<string> produtos = new List<string>();

            produtos.Add("item1");
            produtos.Add("item2");
            produtos.Add("item3");
            produtos.Add("item4");
            produtos.Add("item5");
            produtos.Add("item6");
            produtos.Add("item7");
            produtos.Add("item8");
            produtos.Add("item9");
            produtos.Add("item10");
            produtos.Add("item11");
            produtos.Add("item12");
            produtos.Add("item13");
            produtos.Add("item14");
            produtos.Add("item15");
            produtos.Add("item16");
            produtos.Add("item17");
            produtos.Add("item18");
            produtos.Add("item19");
            produtos.Add("item20");
        }

        //com capacity
        [Benchmark()]
        public void AddItemListCapacity()
        {
            List<string> produtos = new List<string>(20);

            produtos.Add("item1");
            produtos.Add("item2");
            produtos.Add("item3");
            produtos.Add("item4");
            produtos.Add("item5");
            produtos.Add("item6");
            produtos.Add("item7");
            produtos.Add("item8");
            produtos.Add("item9");
            produtos.Add("item10");
            produtos.Add("item11");
            produtos.Add("item12");
            produtos.Add("item13");
            produtos.Add("item14");
            produtos.Add("item15");
            produtos.Add("item16");
            produtos.Add("item17");
            produtos.Add("item18");
            produtos.Add("item19");
            produtos.Add("item20");
        }

        //com capacity menor
        [Benchmark()]
        public void AddItemListCapacityMenor()
        {
            List<string> produtos = new List<string>(10);

            produtos.Add("item1");
            produtos.Add("item2");
            produtos.Add("item3");
            produtos.Add("item4");
            produtos.Add("item5");
            produtos.Add("item6");
            produtos.Add("item7");
            produtos.Add("item8");
            produtos.Add("item9");
            produtos.Add("item10");
            produtos.Add("item11");
            produtos.Add("item12");
            produtos.Add("item13");
            produtos.Add("item14");
            produtos.Add("item15");
            produtos.Add("item16");
            produtos.Add("item17");
            produtos.Add("item18");
            produtos.Add("item19");
            produtos.Add("item20");
        }
    }
}
