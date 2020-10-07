using System;
using System.Collections.Generic;
using DataStructures.HashTable;
using Xunit;

namespace DataStructures.Tests.HashTests
{
    public class LeftJoinTests
    {
        [Fact]
        public void Test()
        {
            var table1 = new Dictionary<string, string>();
            table1.Add("fond", "enamored");
            table1.Add("wrath", "anger");
            table1.Add("diligent", "employed");
            table1.Add("outfit", "garb");
            table1.Add("guide", "usher");
            var table2 = new Dictionary<string, string>();
            table2.Add("fond", "averse");
            table2.Add("wrath", "delight");
            table2.Add("diligent", "idle");
            table2.Add("guide", "follow");
            table2.Add("flow", "jam");

            var result1 = LeftJoinDsa.LeftJoinList(table1, table2);
            List<string[]> expect = new List<string[]>();

            expect.Add(new string[3] { "fond", "enamored", "averse" });
            expect.Add(new string[3] { "wrath", "anger", "delight" });
            expect.Add(new string[3] { "diligent", "employed", "idle" });
            expect.Add(new string[3] { "outfit", "garb", null });
            expect.Add(new string[3] { "guide", "usher", "follow" });
            Assert.Equal(expect, result1);
        }
    }
}
