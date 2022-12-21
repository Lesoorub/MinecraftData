using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftData._1_18_2.CodeGenerators;

namespace CodeGenerators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlocksGenerator.ConvertRawDataBlockFormatToBlockFormat(
                inJsonPath: @"blocks.json",
                outputJsonPath: @"blocksData.json");
            BlocksGenerator.GenerateCode(
                jsonInPath: @"blocksData.json",
                outputCodeDir: @"blocks");
            return;

        }
    }
}
