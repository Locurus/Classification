using System;

namespace DecompositionTree.Classification
{
    public class Object
    {
        public string Name;
        public double[] Features;

        //Конструктор класса
        public Object(string Name, double[] Features)
        {
            this.Name = Name;
            this.Features = Features;
        }

        //Функция вычисления оценки между объектами
        public double CalculateSimilarity(Object other)
        {
            if (other is Object obj)
            {
                double sum = 0;
                for (int i = 0; i < Features.Length; i++)
                    sum += Math.Pow(Features[i] - obj.Features[i], 2);
                return 1 / (1 + Math.Sqrt(sum));
            }
            return 0;
        }
    }
}
