
namespace LR1
{
    partial class SearcherPlanet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Диаметр = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Масса = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Радиус = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Период = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Спутники = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Тип = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название планеты";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(732, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchPlanet);
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
            this.listView1.Location = new System.Drawing.Point(15, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(623, 109);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // SearcherPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SearcherPlanet";
            this.Text = "SearchPlanet";
            this.Load += new System.EventHandler(this.SearchPlanet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ColumnHeader Диаметр;
        private System.Windows.Forms.ColumnHeader Масса;
        private System.Windows.Forms.ColumnHeader Радиус;
        private System.Windows.Forms.ColumnHeader Период;
        private System.Windows.Forms.ColumnHeader Спутники;
        private System.Windows.Forms.ColumnHeader Тип;
    }
}