namespace Quizmaster
{
    partial class Form4
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
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.txtlong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, -2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(679, 612);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // txtlong
            // 
            this.txtlong.Location = new System.Drawing.Point(685, 128);
            this.txtlong.Name = "txtlong";
            this.txtlong.Size = new System.Drawing.Size(125, 27);
            this.txtlong.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Longitude";
            // 
            // txtlat
            // 
            this.txtlat.Location = new System.Drawing.Point(685, 49);
            this.txtlat.Name = "txtlat";
            this.txtlat.Size = new System.Drawing.Size(125, 27);
            this.txtlat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Latitude";
            // 
            // btnmap
            // 
            this.btnmap.Location = new System.Drawing.Point(685, 189);
            this.btnmap.Name = "btnmap";
            this.btnmap.Size = new System.Drawing.Size(164, 73);
            this.btnmap.TabIndex = 10;
            this.btnmap.Text = "Load";
            this.btnmap.UseVisualStyleBackColor = true;
            this.btnmap.Click += new System.EventHandler(this.btnmap_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 607);
            this.Controls.Add(this.btnmap);
            this.Controls.Add(this.txtlong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.TextBox txtlong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmap;
    }
}