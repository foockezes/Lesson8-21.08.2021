using System;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] StrArr = {"One", "Two", "Three"};
            int[] IntArr = { 1, 2, 3, 4 };
            double[] DobArr = { 10.5, 11.5, 12.5, 13.5 };
            decimal[] DecArr = { 12m, 11m, 10m, 9m };
            float[] FloatArr = new float[0];
            Console.WriteLine($"было удалено: {ArrayHelper.Pop(ref StrArr)}");
            Console.WriteLine($"обновленная длина массива: {ArrayHelper.Push(ref IntArr, -5)}");
            Console.WriteLine($"было удалено: {ArrayHelper.Shift(ref DobArr)}");
            Console.WriteLine($"обновленная длина массива: {ArrayHelper.UnShift(ref DecArr, 5m)}");
            Console.WriteLine($"было удалено: {ArrayHelper.Pop(ref FloatArr)}");

        }
        static class ArrayHelper
        {
            public static string Pop(ref string[] array)
            {
                if (array.Length == 0) return null;
                string[] NewArray = new string[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                string del = array[array.Length - 1];
                array = NewArray;
                return del;

            }
            public static int Pop(ref int[] array)
            {
                if (array.Length == 0) return 0;
                int[] NewArray = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                int del = array[array.Length - 1];
                array = NewArray;
                return del;
            }
            public static double Pop(ref double[] array)
            {
                if (array.Length == 0) return 0;
                double[] NewArray = new double[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                double del = array[array.Length - 1];
                array = NewArray;
                return del;
            }
            public static decimal Pop(ref decimal[] array)
            {
                if (array.Length == 0) return 0;
                decimal[] NewArray = new decimal[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                decimal del = array[array.Length - 1];
                array = NewArray;
                return del;
            }
            public static float Pop(ref float[] array)
            {
                if (array.Length == 0) return 0;
                float[] NewArray = new float[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                float del = array[array.Length - 1];
                array = NewArray;
                return del;
            }
            public static int Push(ref string[] array, string value)
            {
                if (array.Length == 0) return 0;
                string[] NewArray = new string[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int Push(ref int[] array, int value)
            {
                if (array.Length == 0) return 0;
                int[] NewArray = new int[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int Push(ref double[] array, double value)
            {
                if (array.Length == 0) return 0;
                double[] NewArray = new double[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int Push(ref decimal[] array, decimal value)
            {
                if (array.Length == 0) return 0;
                decimal[] NewArray = new decimal[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int Push(ref float[] array, float value)
            {
                if (array.Length == 0) return 0;
                float[] NewArray = new float[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static string Shift(ref string[] array)
            {
                if (array.Length == 0) return null;
                string[] NewArray = new string[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                string del = array[0];
                array = NewArray;
                return del;
            }
            public static int Shift(ref int[] array)
            {
                if (array.Length == 0) return 0;
                int[] NewArray = new int[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                int del = array[0];
                array = NewArray;
                return del;
            }
            public static double Shift(ref double[] array)
            {
                if (array.Length == 0) return 0;
                double[] NewArray = new double[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                double del = array[0];
                array = NewArray;
                return del;
            }
            public static decimal Shift(ref decimal[] array)
            {
                if (array.Length == 0) return 0;
                decimal[] NewArray = new decimal[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                decimal del = array[0];
                array = NewArray;
                return del;
            }
            public static float Shift(ref float[] array)
            {
                if (array.Length == 0) return 0;
                float[] NewArray = new float[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                float del = array[0];
                array = NewArray;
                return del;
            }
            public static int UnShift(ref string[] array, string value)
            {
                if (array.Length == 0) return 0;
                string[] NewArray = new string[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int UnShift(ref int[] array, int value)
            {
                if (array.Length == 0) return 0;
                int[] NewArray = new int[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int UnShift(ref double[] array, double value)
            {
                if (array.Length == 0) return 0;
                double[] NewArray = new double[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int UnShift(ref decimal[] array, decimal value)
            {
                if (array.Length == 0) return 0;
                decimal[] NewArray = new decimal[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int UnShift(ref float[] array, float value)
            {
                if (array.Length == 0) return 0;
                float[] NewArray = new float[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }
        }
    }
}

