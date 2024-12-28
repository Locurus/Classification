using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DecompositionTree.Classification;

namespace DecompositionTree.Tree
{
    class TreeBuilder
    {
        private static Bitmap treeImage = new Bitmap(100, 100);
        private static Graphics graphicsTree = Graphics.FromImage(treeImage);

        private static readonly int marginX = 20; //Отступы узлов друг от друга
        private static readonly int nodeHeight = 20; //Высота узла
        private static readonly int verticalSpacing = 50; //Отступ между уровнями
        private static readonly Font nodeFont = new Font("Times New Roman", 16); //Шрифт названий узлов
        private static readonly Font levelFont = new Font("Arial", 12); //Шрифт для подписей уровней
        public static Dictionary<int, double> ClassificationValues = new Dictionary<int, double>(); //Пороги классификации

        public static Bitmap DrawTree(TreeNode root)
        {
            graphicsTree = Graphics.FromImage(treeImage);

            int treeWidth = GetTotalWidth(root);
            int treeHeight = GetMaxDepth(root) * (nodeHeight + verticalSpacing);

            treeImage = new Bitmap(treeWidth + 150, treeHeight + 5);
            graphicsTree = Graphics.FromImage(treeImage);
            graphicsTree.CompositingQuality = CompositingQuality.HighQuality;
            graphicsTree.SmoothingMode = SmoothingMode.AntiAlias;
            graphicsTree.Clear(Color.FromArgb(73, 73, 75));

            DrawNode(root, treeWidth / 2, treeHeight - verticalSpacing, 1);

            DrawLevelLabels(treeHeight);

            graphicsTree.Dispose();
            return treeImage;
        }

        private static void DrawNode(TreeNode node, int x, int y, int level)
        {
            string formattedText = FormatNodeText(node.Text);
            SizeF textSize = graphicsTree.MeasureString(formattedText, nodeFont);
            int nodeWidth = (int)textSize.Width + 10;

            //Отрисовка текущего узла
            Rectangle rect = new Rectangle(x - nodeWidth / 2, y - nodeHeight, nodeWidth, nodeHeight);
            graphicsTree.FillRectangle(new SolidBrush(Color.FromArgb(245, 228, 201)), rect);
            graphicsTree.DrawRectangle(Pens.Black, rect);
            graphicsTree.DrawString(formattedText, nodeFont, Brushes.Black, rect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            //Отрисовка дочерних узлов
            if (node.Nodes.Count > 0)
            {
                int totalChildrenWidth = GetTotalWidth(node);
                int childXStart = x - totalChildrenWidth / 2;
                int currentX = childXStart;

                foreach (TreeNode child in node.Nodes)
                {
                    int childWidth = GetTotalWidth(child);
                    int childX = currentX + childWidth / 2;

                    graphicsTree.DrawLine(new Pen(Color.Black, 2), x, y - nodeHeight, childX, y - nodeHeight - verticalSpacing);
                    DrawNode(child, childX, y - nodeHeight - verticalSpacing, level + 1);

                    currentX += childWidth + marginX;
                }
            }
        }

        private static int GetTotalWidth(TreeNode node)
        {
            SizeF textSize = graphicsTree.MeasureString(FormatNodeText(node.Text), nodeFont);
            int nodeWidth = (int)textSize.Width + 10;

            if (node.Nodes.Count == 0)
                return nodeWidth;

            int totalWidth = 0;
            foreach (TreeNode child in node.Nodes)
                totalWidth += GetTotalWidth(child) + marginX;

            return Math.Max(totalWidth - marginX, nodeWidth);
        }

        private static int GetMaxDepth(TreeNode node)
        {
            if (node == null)
                return 0;

            int maxDepth = 1;
            foreach (TreeNode child in node.Nodes)
                maxDepth = Math.Max(maxDepth, GetMaxDepth(child) + 1);

            return maxDepth;
        }

        private static string FormatNodeText(string text)
        {
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" | ", words);
        }

        private static void DrawLevelLabels(int treeHeight)
        {
            int level = 0;
            int y = treeHeight - verticalSpacing;

            while (y >= 0)
            {
                if (y != treeHeight - verticalSpacing)
                    graphicsTree.DrawString($"{ClassificationValues[level]}", levelFont, Brushes.White, new PointF(treeImage.Width - 140, y - nodeHeight));
                y -= (nodeHeight + verticalSpacing);
                level++;
            }
        }


        //Добавление уровня дерева
        public static void AddLevel(TreeNode root, List<Class> LevelClasses, double ClassificationValue)
        {
            if (root.Tag == null)
            {
                ClassificationValues.Clear();
                root.Text = LevelClasses[0].GetName();
                root.Tag = LevelClasses[0];
                return;
            }

            foreach (Class CurrentClass in LevelClasses)
                if (root.Tag == CurrentClass.Parent)
                {
                    TreeNode NewChild = new TreeNode(CurrentClass.GetName());
                    NewChild.Tag = CurrentClass;
                    root.Nodes.Add(NewChild);

                    if (!ClassificationValues.ContainsKey(NewChild.Level))
                        ClassificationValues.Add(NewChild.Level, ClassificationValue);
                }

            foreach (TreeNode ChildNode in root.Nodes)
                AddLevel(ChildNode, LevelClasses, ClassificationValue);
        }
    }
}
