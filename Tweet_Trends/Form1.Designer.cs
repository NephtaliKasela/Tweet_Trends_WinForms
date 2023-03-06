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
            this.btnInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.gmcMap.Size = new System.Drawing.Size(1058, 691);
            this.gmcMap.TabIndex = 0;
            this.gmcMap.Zoom = 0D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 691);
            this.panel1.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(47, 37);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.Text = "Test";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 487);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(47, 204);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gmcMap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(47, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 691);
            this.panel2.TabIndex = 2;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmcMap;
        private Panel panel1;
        private Panel panel2;
        private ListBox listBox1;
        private Button btnInfo;
    }
}