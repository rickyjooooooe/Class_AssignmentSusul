namespace Class_Assignment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bottomWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tshirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tshirtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paneltraining = new System.Windows.Forms.Panel();
            this.labelsub = new System.Windows.Forms.Label();
            this.labelsubtot = new System.Windows.Forms.Label();
            this.labeltotalll = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.paneljeans = new System.Windows.Forms.Panel();
            this.panelshirt = new System.Windows.Forms.Panel();
            this.paneltshirt = new System.Windows.Forms.Panel();
            this.panelshoes = new System.Windows.Forms.Panel();
            this.panelbag = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottomWearToolStripMenuItem,
            this.tshirtToolStripMenuItem,
            this.accesoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bottomWearToolStripMenuItem
            // 
            this.bottomWearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeansToolStripMenuItem,
            this.trainingToolStripMenuItem});
            this.bottomWearToolStripMenuItem.Name = "bottomWearToolStripMenuItem";
            this.bottomWearToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.bottomWearToolStripMenuItem.Text = "Bottom Wear";
            // 
            // jeansToolStripMenuItem
            // 
            this.jeansToolStripMenuItem.Name = "jeansToolStripMenuItem";
            this.jeansToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.jeansToolStripMenuItem.Text = "Jeans";
            this.jeansToolStripMenuItem.Click += new System.EventHandler(this.jeansToolStripMenuItem_Click);
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.trainingToolStripMenuItem.Text = "Training";
            this.trainingToolStripMenuItem.Click += new System.EventHandler(this.trainingToolStripMenuItem_Click);
            // 
            // tshirtToolStripMenuItem
            // 
            this.tshirtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tshirtToolStripMenuItem1,
            this.shirtToolStripMenuItem});
            this.tshirtToolStripMenuItem.Name = "tshirtToolStripMenuItem";
            this.tshirtToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.tshirtToolStripMenuItem.Text = "Top wear";
            // 
            // tshirtToolStripMenuItem1
            // 
            this.tshirtToolStripMenuItem1.Name = "tshirtToolStripMenuItem1";
            this.tshirtToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.tshirtToolStripMenuItem1.Text = "T-shirt";
            this.tshirtToolStripMenuItem1.Click += new System.EventHandler(this.tshirtToolStripMenuItem1_Click);
            // 
            // shirtToolStripMenuItem
            // 
            this.shirtToolStripMenuItem.Name = "shirtToolStripMenuItem";
            this.shirtToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.shirtToolStripMenuItem.Text = "Shirt";
            this.shirtToolStripMenuItem.Click += new System.EventHandler(this.shirtToolStripMenuItem_Click);
            // 
            // accesoriesToolStripMenuItem
            // 
            this.accesoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shoesToolStripMenuItem,
            this.bagToolStripMenuItem});
            this.accesoriesToolStripMenuItem.Name = "accesoriesToolStripMenuItem";
            this.accesoriesToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.accesoriesToolStripMenuItem.Text = "Accesories";
            // 
            // shoesToolStripMenuItem
            // 
            this.shoesToolStripMenuItem.Name = "shoesToolStripMenuItem";
            this.shoesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.shoesToolStripMenuItem.Text = "Shoes";
            this.shoesToolStripMenuItem.Click += new System.EventHandler(this.shoesToolStripMenuItem_Click);
            // 
            // bagToolStripMenuItem
            // 
            this.bagToolStripMenuItem.Name = "bagToolStripMenuItem";
            this.bagToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bagToolStripMenuItem.Text = "Bag";
            this.bagToolStripMenuItem.Click += new System.EventHandler(this.bagToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(571, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(679, 325);
            this.dataGridView1.TabIndex = 1;
            // 
            // paneltraining
            // 
            this.paneltraining.Location = new System.Drawing.Point(12, 51);
            this.paneltraining.Name = "paneltraining";
            this.paneltraining.Size = new System.Drawing.Size(553, 715);
            this.paneltraining.TabIndex = 2;
            // 
            // labelsub
            // 
            this.labelsub.AutoSize = true;
            this.labelsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsub.Location = new System.Drawing.Point(928, 399);
            this.labelsub.Name = "labelsub";
            this.labelsub.Size = new System.Drawing.Size(118, 29);
            this.labelsub.TabIndex = 3;
            this.labelsub.Text = "Sub-total";
            // 
            // labelsubtot
            // 
            this.labelsubtot.AutoSize = true;
            this.labelsubtot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsubtot.Location = new System.Drawing.Point(1122, 399);
            this.labelsubtot.Name = "labelsubtot";
            this.labelsubtot.Size = new System.Drawing.Size(85, 29);
            this.labelsubtot.TabIndex = 4;
            this.labelsubtot.Text = "label2";
            // 
            // labeltotalll
            // 
            this.labeltotalll.AutoSize = true;
            this.labeltotalll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalll.Location = new System.Drawing.Point(973, 434);
            this.labeltotalll.Name = "labeltotalll";
            this.labeltotalll.Size = new System.Drawing.Size(73, 29);
            this.labeltotalll.TabIndex = 5;
            this.labeltotalll.Text = "Total";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(1122, 434);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(85, 29);
            this.labeltotal.TabIndex = 6;
            this.labeltotal.Text = "label4";
            // 
            // paneljeans
            // 
            this.paneljeans.Location = new System.Drawing.Point(12, 51);
            this.paneljeans.Name = "paneljeans";
            this.paneljeans.Size = new System.Drawing.Size(553, 715);
            this.paneljeans.TabIndex = 3;
            // 
            // panelshirt
            // 
            this.panelshirt.Location = new System.Drawing.Point(12, 51);
            this.panelshirt.Name = "panelshirt";
            this.panelshirt.Size = new System.Drawing.Size(553, 715);
            this.panelshirt.TabIndex = 4;
            // 
            // paneltshirt
            // 
            this.paneltshirt.Location = new System.Drawing.Point(12, 51);
            this.paneltshirt.Name = "paneltshirt";
            this.paneltshirt.Size = new System.Drawing.Size(553, 715);
            this.paneltshirt.TabIndex = 5;
            // 
            // panelshoes
            // 
            this.panelshoes.Location = new System.Drawing.Point(12, 51);
            this.panelshoes.Name = "panelshoes";
            this.panelshoes.Size = new System.Drawing.Size(553, 715);
            this.panelshoes.TabIndex = 6;
            // 
            // panelbag
            // 
            this.panelbag.Location = new System.Drawing.Point(12, 51);
            this.panelbag.Name = "panelbag";
            this.panelbag.Size = new System.Drawing.Size(553, 715);
            this.panelbag.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 778);
            this.Controls.Add(this.panelbag);
            this.Controls.Add(this.panelshoes);
            this.Controls.Add(this.paneltshirt);
            this.Controls.Add(this.panelshirt);
            this.Controls.Add(this.paneljeans);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.labeltotalll);
            this.Controls.Add(this.labelsubtot);
            this.Controls.Add(this.labelsub);
            this.Controls.Add(this.paneltraining);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tshirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomWearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoriesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tshirtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bagToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel paneltraining;
        private System.Windows.Forms.Label labelsub;
        private System.Windows.Forms.Label labelsubtot;
        private System.Windows.Forms.Label labeltotalll;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Panel paneljeans;
        private System.Windows.Forms.Panel panelshirt;
        private System.Windows.Forms.Panel paneltshirt;
        private System.Windows.Forms.Panel panelshoes;
        private System.Windows.Forms.Panel panelbag;
    }
}

