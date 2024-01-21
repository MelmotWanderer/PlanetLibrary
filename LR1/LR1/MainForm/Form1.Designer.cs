
namespace LR1
{
    partial class Form1
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
            this.createPlanet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Диаметр = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Масса = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Радиус = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Период = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Спутники = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Тип = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPlanet
            // 
            this.createPlanet.Location = new System.Drawing.Point(12, 12);
            this.createPlanet.Name = "createPlanet";
            this.createPlanet.Size = new System.Drawing.Size(114, 36);
            this.createPlanet.TabIndex = 0;
            this.createPlanet.Text = "Добавить планету";
            this.createPlanet.UseVisualStyleBackColor = true;
            this.createPlanet.Click += new System.EventHandler(this.OpenCreatorPlanet);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Поиск планеты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OpenSearchPlanet);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Фильтр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OpenFilterPlanet);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Имя,
            this.Диаметр,
            this.Масса,
            this.Радиус,
            this.Период,
            this.Спутники,
            this.Тип});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 362);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.RemovePlanet);
            // 
            // Имя
            // 
            this.Имя.Text = "Имя";
            this.Имя.Width = 66;
            // 
            // Диаметр
            // 
            this.Диаметр.Text = "Экваториальный диаметр";
            this.Диаметр.Width = 150;
            // 
            // Масса
            // 
            this.Масса.Text = "Масса";
            this.Масса.Width = 80;
            // 
            // Радиус
            // 
            this.Радиус.Text = "Радиус";
            this.Радиус.Width = 80;
            // 
            // Период
            // 
            this.Период.Text = "Период";
            this.Период.Width = 80;
            // 
            // Спутники
            // 
            this.Спутники.Text = "Спутники";
            this.Спутники.Width = 80;
            // 
            // Тип
            // 
            this.Тип.Text = "Тип";
            this.Тип.Width = 80;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(372, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отключить фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearFilter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createPlanet);
            this.Name = "Form1";
            this.Text = "Planets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createPlanet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ColumnHeader Диаметр;
        private System.Windows.Forms.ColumnHeader Масса;
        private System.Windows.Forms.ColumnHeader Радиус;
        private System.Windows.Forms.ColumnHeader Период;
        private System.Windows.Forms.ColumnHeader Спутники;
        private System.Windows.Forms.ColumnHeader Тип;
        private System.Windows.Forms.Button button1;
    }
}

