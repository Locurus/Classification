using System.Collections.Generic;
using System.Linq;

namespace DecompositionTree.Classification
{
    public class Classifier
    {
        public List<Class> ClassesOfClassification = new List<Class>();

        //Конструктор класса
        public Classifier()
        {
            ClassesOfClassification.Add(new Class());
        }

        //Добавление объектов классификации
        public void AddObject(Object obj)
        {
            ClassesOfClassification[0].AddObject(obj);
        }

        //Классификация
        public List<Class> Classify(double ClassifyValue)
        {
            List<Class> NewClasses = new List<Class>();

            foreach (Class CurrentClass in ClassesOfClassification)
            {
                List<Object> ObjectsOfClass = CurrentClass.Objects.ToList();
                foreach (Object CurrentObject in ObjectsOfClass)
                {
                    bool IsAdded = false;

                    foreach (Class NewClass in NewClasses)
                    {
                        if (CurrentObject.CalculateSimilarity(NewClass.Objects.First()) >= ClassifyValue && NewClass.Parent.Objects.Contains(CurrentObject))
                        {
                            NewClass.AddObject(CurrentObject);
                            IsAdded = true;
                            break;
                        }
                    }

                    if (!IsAdded)
                    {
                        Class NewClass = new Class();
                        NewClass.AddObject(CurrentObject);
                        NewClasses.Add(NewClass);

                        NewClass.Parent = CurrentClass;
                    }
                }
            }
            ClassesOfClassification = NewClasses;

            return ClassesOfClassification;
        }

        //Очистка классов
        public void ClearClasses()
        {
            ClassesOfClassification.Clear();
            ClassesOfClassification.Add(new Class());
        }
    }
}
