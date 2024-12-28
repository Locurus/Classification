using System.Collections.Generic;

namespace DecompositionTree.Classification
{
    public class Class
    {
        public Class Parent;
        public List<Object> Objects { get; } = new List<Object>();

        //Добавить объект в класс
        public void AddObject(Object obj)
        {
            Objects.Add(obj);
        }

        //Имя класса
        public string GetName()
        {
            string Name = "";

            for (int i = 0; i < Objects.Count; i++)
                Name += i != Objects.Count - 1 ? Objects[i].Name + " " : Objects[i].Name;

            return Name;
        }
    }
}
