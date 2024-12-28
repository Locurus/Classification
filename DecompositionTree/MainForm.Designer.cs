namespace DecompositionTree
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonBuildTree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StepClassificationValue = new System.Windows.Forms.TextBox();
            this.EndClassificationValue = new System.Windows.Forms.TextBox();
            this.StartClassificationValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Feature2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.Feature1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassificationObjects = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            this.IsStaticValue = new System.Windows.Forms.CheckBox();
            this.StaticClassificationValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ControlClassificationPanel = new System.Windows.Forms.Panel();
            this.PanelControl = new System.Windows.Forms.Panel();
            this.PictureTree = new DecompositionTree.TreeViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ClassificationObjects)).BeginInit();
            this.ControlClassificationPanel.SuspendLayout();
            this.PanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTree)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBuildTree
            // 
            this.ButtonBuildTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(110)))), ((int)(((byte)(31)))));
            this.ButtonBuildTree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonBuildTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBuildTree.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBuildTree.ForeColor = System.Drawing.Color.Black;
            this.ButtonBuildTree.Location = new System.Drawing.Point(0, 410);
            this.ButtonBuildTree.Name = "ButtonBuildTree";
            this.ButtonBuildTree.Size = new System.Drawing.Size(302, 38);
            this.ButtonBuildTree.TabIndex = 9;
            this.ButtonBuildTree.TabStop = false;
            this.ButtonBuildTree.Text = "Построить декомпозиционное дерево";
            this.ButtonBuildTree.UseVisualStyleBackColor = false;
            this.ButtonBuildTree.Click += new System.EventHandler(this.ButtonBuildTree_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Jost", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "ОБЪЕКТЫ КЛАССИФИКАЦИИ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StepClassificationValue
            // 
            this.StepClassificationValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepClassificationValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            this.StepClassificationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StepClassificationValue.Font = new System.Drawing.Font("Jost", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepClassificationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.StepClassificationValue.Location = new System.Drawing.Point(149, 300);
            this.StepClassificationValue.Name = "StepClassificationValue";
            this.StepClassificationValue.Size = new System.Drawing.Size(149, 26);
            this.StepClassificationValue.TabIndex = 8;
            this.StepClassificationValue.TabStop = false;
            // 
            // EndClassificationValue
            // 
            this.EndClassificationValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndClassificationValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            this.EndClassificationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndClassificationValue.Font = new System.Drawing.Font("Jost", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndClassificationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.EndClassificationValue.Location = new System.Drawing.Point(149, 268);
            this.EndClassificationValue.Name = "EndClassificationValue";
            this.EndClassificationValue.Size = new System.Drawing.Size(149, 26);
            this.EndClassificationValue.TabIndex = 7;
            this.EndClassificationValue.TabStop = false;
            // 
            // StartClassificationValue
            // 
            this.StartClassificationValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartClassificationValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            this.StartClassificationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartClassificationValue.Font = new System.Drawing.Font("Jost", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartClassificationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.StartClassificationValue.Location = new System.Drawing.Point(149, 236);
            this.StartClassificationValue.Name = "StartClassificationValue";
            this.StartClassificationValue.Size = new System.Drawing.Size(149, 26);
            this.StartClassificationValue.TabIndex = 6;
            this.StartClassificationValue.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jost Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Шаг порога:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jost Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начальный порог:";
            // 
            // Feature2
            // 
            this.Feature2.HeaderText = "Признак 2";
            this.Feature2.Name = "Feature2";
            this.Feature2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jost Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Конечный порог:";
            // 
            // Feature1
            // 
            this.Feature1.HeaderText = "Признак 1";
            this.Feature1.Name = "Feature1";
            this.Feature1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClassificationObjects
            // 
            this.ClassificationObjects.AllowUserToAddRows = false;
            this.ClassificationObjects.AllowUserToResizeRows = false;
            this.ClassificationObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassificationObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassificationObjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Jost", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassificationObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassificationObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassificationObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Feature1,
            this.Feature2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Jost", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassificationObjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClassificationObjects.EnableHeadersVisualStyles = false;
            this.ClassificationObjects.GridColor = System.Drawing.SystemColors.Window;
            this.ClassificationObjects.Location = new System.Drawing.Point(0, 30);
            this.ClassificationObjects.MultiSelect = false;
            this.ClassificationObjects.Name = "ClassificationObjects";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassificationObjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ClassificationObjects.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.ClassificationObjects.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ClassificationObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassificationObjects.Size = new System.Drawing.Size(302, 142);
            this.ClassificationObjects.TabIndex = 11;
            this.ClassificationObjects.DoubleClick += new System.EventHandler(this.ClassificationObjects_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 1F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("Jost Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.ButtonClear.Location = new System.Drawing.Point(0, 7);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(108, 26);
            this.ButtonClear.TabIndex = 3;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(110)))), ((int)(((byte)(31)))));
            this.ButtonAddObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddObject.Font = new System.Drawing.Font("Jost Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddObject.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddObject.Location = new System.Drawing.Point(198, 7);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(102, 26);
            this.ButtonAddObject.TabIndex = 1;
            this.ButtonAddObject.Text = "Добавить";
            this.ButtonAddObject.UseVisualStyleBackColor = false;
            this.ButtonAddObject.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // IsStaticValue
            // 
            this.IsStaticValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsStaticValue.AutoSize = true;
            this.IsStaticValue.Font = new System.Drawing.Font("Jost", 11.25F);
            this.IsStaticValue.Location = new System.Drawing.Point(3, 334);
            this.IsStaticValue.Name = "IsStaticValue";
            this.IsStaticValue.Size = new System.Drawing.Size(248, 26);
            this.IsStaticValue.TabIndex = 16;
            this.IsStaticValue.Text = "Использовать статические пороги";
            this.IsStaticValue.UseVisualStyleBackColor = true;
            this.IsStaticValue.CheckedChanged += new System.EventHandler(this.IsStaticValue_CheckedChanged);
            // 
            // StaticClassificationValue
            // 
            this.StaticClassificationValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaticClassificationValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            this.StaticClassificationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaticClassificationValue.Enabled = false;
            this.StaticClassificationValue.Font = new System.Drawing.Font("Jost", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaticClassificationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.StaticClassificationValue.Location = new System.Drawing.Point(74, 360);
            this.StaticClassificationValue.Name = "StaticClassificationValue";
            this.StaticClassificationValue.Size = new System.Drawing.Size(224, 26);
            this.StaticClassificationValue.TabIndex = 15;
            this.StaticClassificationValue.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jost Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Пороги:";
            // 
            // ControlClassificationPanel
            // 
            this.ControlClassificationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlClassificationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlClassificationPanel.Controls.Add(this.ButtonClear);
            this.ControlClassificationPanel.Controls.Add(this.ButtonAddObject);
            this.ControlClassificationPanel.Location = new System.Drawing.Point(0, 174);
            this.ControlClassificationPanel.Name = "ControlClassificationPanel";
            this.ControlClassificationPanel.Size = new System.Drawing.Size(302, 40);
            this.ControlClassificationPanel.TabIndex = 12;
            // 
            // PanelControl
            // 
            this.PanelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            this.PanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelControl.Controls.Add(this.IsStaticValue);
            this.PanelControl.Controls.Add(this.StaticClassificationValue);
            this.PanelControl.Controls.Add(this.label6);
            this.PanelControl.Controls.Add(this.ControlClassificationPanel);
            this.PanelControl.Controls.Add(this.ClassificationObjects);
            this.PanelControl.Controls.Add(this.ButtonBuildTree);
            this.PanelControl.Controls.Add(this.label1);
            this.PanelControl.Controls.Add(this.StepClassificationValue);
            this.PanelControl.Controls.Add(this.EndClassificationValue);
            this.PanelControl.Controls.Add(this.StartClassificationValue);
            this.PanelControl.Controls.Add(this.label4);
            this.PanelControl.Controls.Add(this.label3);
            this.PanelControl.Controls.Add(this.label2);
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(228)))), ((int)(((byte)(201)))));
            this.PanelControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(304, 450);
            this.PanelControl.TabIndex = 1;
            // 
            // PictureTree
            // 
            this.PictureTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureTree.Location = new System.Drawing.Point(304, 0);
            this.PictureTree.Name = "PictureTree";
            this.PictureTree.Size = new System.Drawing.Size(496, 450);
            this.PictureTree.TabIndex = 2;
            this.PictureTree.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureTree);
            this.Controls.Add(this.PanelControl);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClassificationObjects)).EndInit();
            this.ControlClassificationPanel.ResumeLayout(false);
            this.PanelControl.ResumeLayout(false);
            this.PanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonBuildTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StepClassificationValue;
        private System.Windows.Forms.TextBox EndClassificationValue;
        private System.Windows.Forms.TextBox StartClassificationValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feature2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feature1;
        private System.Windows.Forms.DataGridView ClassificationObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonAddObject;
        private System.Windows.Forms.CheckBox IsStaticValue;
        private System.Windows.Forms.TextBox StaticClassificationValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel ControlClassificationPanel;
        private System.Windows.Forms.Panel PanelControl;
        private TreeViewer PictureTree;
    }
}

