using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MinecraftData._1_18_2.blocks.minecraft;
using MinecraftData._1_18_2.CodeGenerators;

namespace CodeGenerators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapesGenerator.GenerateShapes("shapes.json");
            return;
            BlocksGenerator.ConvertRawDataBlockFormatToBlockFormat(
                inJsonPath: @"blocks.json",
                outputJsonPath: @"blocksData.json");
            BlocksGenerator.GenerateCode(
                jsonInPath: @"blocksData.json",
                outputCodeDir: @"blocks");
            return;

        }
        static StringBuilder sb = new StringBuilder();
    }
}
