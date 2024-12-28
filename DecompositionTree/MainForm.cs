using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DecompositionTree.Classification;
using DecompositionTree.Tree;

namespace DecompositionTree
{
    public partial class MainForm : Form
    {
        private readonly Classifier tree = new Classifier();
        public MainForm()
        {
            InitializeComponent();
        }

        //Построение дерева
        private void ButtonBuildTree_Click(object sender, EventArgs e)
        {
            tree.ClearClasses();
            TreeNode ClassificationTree = new TreeNode();
            List<double> ClassificationValues = new List<double>();

            //Получение объектов классификации
            for (int i = 0; i < ClassificationObjects.Rows.Count; i++)
            {
                List<double> Features = new List<double>();
                for (int j = 1; j < ClassificationObjects.ColumnCount; j++)
                    Features.Add(double.Parse(ClassificationObjects.Rows[i].Cells[j].Value.ToString()));

                tree.AddObject(new Classification.Object(ClassificationObjects.Rows[i].Cells[0].Value.ToString(), Features.ToArray()));
            }
            TreeBuilder.AddLevel(ClassificationTree, tree.ClassesOfClassification, 0);

            //Получение пороговых значений классификации
            if (IsStaticValue.Checked)
            {
                foreach (string StringValue in StaticClassificationValue.Text.Split())
                    ClassificationValues.Add(double.Parse(StringValue.Trim(' ', ',')));
            }
            else
            {
                double StartValue = double.TryParse(StartClassificationValue.Text, out StartValue) == true ? StartValue : -1;
                double EndValue = double.TryParse(EndClassificationValue.Text, out EndValue) == true ? EndValue : -1;
                double StepValue = double.TryParse(StepClassificationValue.Text, out StepValue) == true ? StepValue : -1;

                for (; StartValue <= EndValue; StartValue += StepValue)
                    ClassificationValues.Add(StartValue);
            }

            //Классификация
            foreach (double ClassifacationValue in ClassificationValues)
            {
                tree.Classify(ClassifacationValue);
                TreeBuilder.AddLevel(ClassificationTree, tree.ClassesOfClassification, ClassifacationValue);
            }
            PictureTree.Image = TreeBuilder.DrawTree(ClassificationTree);
            PictureTree.Refresh();
        }

        #region Объекты классификации
        //Добавление объекта классификации
        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            ClassificationObjects.Rows.Add();
        }

        //Очистка объектов
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClassificationObjects.Rows.Clear();
            tree.ClearClasses();
        }

        //Двойной клик - случайное заполнение
        private void ClassificationObjects_DoubleClick(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int CountRows = rdm.Next(5, 20);

            for (int i = 0; i < CountRows; i++)
            {
                ClassificationObjects.Rows.Add();
                ClassificationObjects.Rows[i].Cells[0].Value = (i + 1).ToString();
                ClassificationObjects.Rows[i].Cells[1].Value = rdm.NextDouble().ToString();
                ClassificationObjects.Rows[i].Cells[2].Value = rdm.NextDouble().ToString();
            }
        }
        #endregion

        //Выбор способа ввода порогов классификации
        private void IsStaticValue_CheckedChanged(object sender, EventArgs e)
        {
            if (IsStaticValue.Checked)
            {
                StartClassificationValue.Enabled = false;
                EndClassificationValue.Enabled = false;
                StepClassificationValue.Enabled = false;

                StaticClassificationValue.Enabled = true;
            }
            else
            {
                StartClassificationValue.Enabled = true;
                EndClassificationValue.Enabled = true;
                StepClassificationValue.Enabled = true;

                StaticClassificationValue.Enabled = false;
            }
        }
    }
}
