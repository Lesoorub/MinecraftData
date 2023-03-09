using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MinecraftData._1_18_2.shapes;
using Newtonsoft.Json.Linq;

namespace MinecraftData._1_18_2.CodeGenerators
{
    public static class ShapesGenerator
    {
        public static void GenerateAABB(string shapesJsonPath)
        {
            JObject shapes = JObject.Parse(File.ReadAllText(shapesJsonPath));
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"public static AABB[] AABBs = new AABB[]");
            sb.AppendLine("{");
            foreach (var aabb in shapes["aabbs"])
            {
                float[] from = Parse(aabb["from"]);
                float[] to = Parse(aabb["to"]);

                sb.AppendLine($"new AABB() {{ from = {ToString(from)}, to = {ToString(to)} }},");
            }
            sb.AppendLine("};");
            string toString = sb.ToString();
            System.Console.WriteLine(toString);
            return; 
            float[] Parse(JToken value)
            {
                if (value.Type == JTokenType.Float)
                    return new float[3] { (float)value, (float)value, (float)value };
                if (value.Type == JTokenType.Array)
                    return (value as JArray).ToObject<float[]>();
                throw new System.Exception("Неопределенный тип");
            }
            string ToString(float[] arr) => 
                "new float[" + arr.Length + "] { " + string.Join(
                    ", ", 
                arr.Select(x => 
                x.ToString().Replace(",", ".") + "f")) + " }";
        }
        public static void GenerateShapes(string shapesJsonPath)
        {
            JObject shapes = JObject.Parse(File.ReadAllText(shapesJsonPath));
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("public static AABB[][] Shapes = new AABB[][]");
            sb.AppendLine("{");
            foreach (var shape in shapes["shapes"])
            {
                var s = Parse(shape);
                sb.AppendLine($"    new AABB[] {{ {string.Join(", ", s.Select(x => $"AABBs[{x}]"))} }},");
            }
            sb.AppendLine("};");
            var toString = sb.ToString();
            System.Console.WriteLine(toString);
            return;

            int[] Parse(JToken value)
            {
                if (value.Type == JTokenType.Integer)
                    return new int[] { (int)value };
                return value.ToObject<int[]>();
            }
        }
        public static AABB[][] Shapes = new AABB[][]
        {
            new AABB[] { ShapesBacked.AABBs[0] },
        };
    }
}