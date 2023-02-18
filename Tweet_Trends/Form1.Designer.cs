namespace Tweet_Trends
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gmcMap = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxLatitude = new System.Windows.Forms.TextBox();
            this.txtbxLongitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadIntoMap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmcMap
            // 
            this.gmcMap.Bearing = 0F;
            this.gmcMap.CanDragMap = true;
            this.gmcMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmcMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmcMap.GrayScaleMode = false;
            this.gmcMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmcMap.LevelsKeepInMemmory = 5;
            this.gmcMap.Location = new System.Drawing.Point(0, 0);
            this.gmcMap.MarkersEnabled = true;
            this.gmcMap.MaxZoom = 2;
            this.gmcMap.MinZoom = 2;
            this.gmcMap.MouseWheelZoomEnabled = true;
            this.gmcMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmcMap.Name = "gmcMap";
            this.gmcMap.NegativeMode = false;
            this.gmcMap.PolygonsEnabled = true;
            this.gmcMap.RetryLoadTile = 0;
            this.gmcMap.RoutesEnabled = true;
            this.gmcMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmcMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmcMap.ShowTileGridLines = false;
            this.gmcMap.Size = new System.Drawing.Size(903, 691);
            this.gmcMap.TabIndex = 0;
            this.gmcMap.Zoom = 0D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadIntoMap);
            this.panel1.Controls.Add(this.txtbxLongitude);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbxLatitude);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 691);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 547);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 144);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gmcMap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 691);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Latitude";
            // 
            // txtbxLatitude
            // 
            this.txtbxLatitude.Location = new System.Drawing.Point(12, 54);
            this.txtbxLatitude.Name = "txtbxLatitude";
            this.txtbxLatitude.Size = new System.Drawing.Size(184, 27);
            this.txtbxLatitude.TabIndex = 2;
            // 
            // txtbxLongitude
            // 
            this.txtbxLongitude.Location = new System.Drawing.Point(9, 132);
            this.txtbxLongitude.Name = "txtbxLongitude";
            this.txtbxLongitude.Size = new System.Drawing.Size(184, 27);
            this.txtbxLongitude.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            // 
            // btnLoadIntoMap
            // 
            this.btnLoadIntoMap.Location = new System.Drawing.Point(27, 219);
            this.btnLoadIntoMap.Name = "btnLoadIntoMap";
            this.btnLoadIntoMap.Size = new System.Drawing.Size(136, 37);
            this.btnLoadIntoMap.TabIndex = 5;
            this.btnLoadIntoMap.Text = "Load";
            this.btnLoadIntoMap.UseVisualStyleBackColor = true;
            this.btnLoadIntoMap.Click += new System.EventHandler(this.btnLoadIntoMap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmcMap;
        private Panel panel1;
        private Panel panel2;
        private ListBox listBox1;
        private Button btnLoadIntoMap;
        private TextBox txtbxLongitude;
        private Label label2;
        private TextBox txtbxLatitude;
        private Label label1;
    }
}