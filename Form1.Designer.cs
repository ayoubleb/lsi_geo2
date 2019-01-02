namespace ExShMap
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
            this.mpBx = new SharpMap.Forms.MapBox();
            this.mapZoomToolStrip1 = new SharpMap.Forms.ToolBar.MapZoomToolStrip(this.components);
            this.grd = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // mpBx
            // 
            this.mpBx.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.mpBx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mpBx.Cursor = System.Windows.Forms.Cursors.Default;
            this.mpBx.FineZoomFactor = 10D;
            this.mpBx.Location = new System.Drawing.Point(0, 43);
            this.mpBx.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.mpBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mpBx.Name = "mpBx";
            this.mpBx.QueryGrowFactor = 5F;
            this.mpBx.QueryLayerIndex = 0;
            this.mpBx.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mpBx.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mpBx.ShowProgressUpdate = false;
            this.mpBx.Size = new System.Drawing.Size(584, 631);
            this.mpBx.TabIndex = 0;
            this.mpBx.Text = "mapBox1";
            this.mpBx.WheelZoomMagnitude = -2D;
            this.mpBx.MouseMove += new SharpMap.Forms.MapBox.MouseEventHandler(this.mpBx_MouseMove);
            this.mpBx.Click += new System.EventHandler(this.mpBx_Click);
            // 
            // mapZoomToolStrip1
            // 
            this.mapZoomToolStrip1.Enabled = false;
            this.mapZoomToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mapZoomToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.mapZoomToolStrip1.MapControl = this.mpBx;
            this.mapZoomToolStrip1.Name = "mapZoomToolStrip1";
            this.mapZoomToolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.mapZoomToolStrip1.Size = new System.Drawing.Size(1200, 31);
            this.mapZoomToolStrip1.TabIndex = 1;
            this.mapZoomToolStrip1.Text = "mapZoomToolStrip1";
            this.mapZoomToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mapZoomToolStrip1_ItemClicked);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(618, 43);
            this.grd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(450, 300);
            this.grd.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.mapZoomToolStrip1);
            this.Controls.Add(this.mpBx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpMap.Forms.MapBox mpBx;
        private SharpMap.Forms.ToolBar.MapZoomToolStrip mapZoomToolStrip1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button button1;
    }
}

