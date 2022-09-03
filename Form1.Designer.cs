
using System.Drawing;
using MaterialSkin2DotNet;

namespace InstBlend
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin2DotNet.Controls.MaterialTabControl();
            this.interuse = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editors = new System.Windows.Forms.TabPage();
            this.objects = new System.Windows.Forms.TabPage();
            this.modeling = new System.Windows.Forms.TabPage();
            this.sculpting = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.interuse.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.interuse);
            this.materialTabControl1.Controls.Add(this.editors);
            this.materialTabControl1.Controls.Add(this.objects);
            this.materialTabControl1.Controls.Add(this.modeling);
            this.materialTabControl1.Controls.Add(this.sculpting);
            this.materialTabControl1.Depth = 0;
            resources.ApplyResources(this.materialTabControl1, "materialTabControl1");
            this.materialTabControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            // 
            // interuse
            // 
            this.interuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.interuse.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.interuse, "interuse");
            this.interuse.Name = "interuse";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // editors
            // 
            this.editors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.editors, "editors");
            this.editors.Name = "editors";
            // 
            // objects
            // 
            this.objects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.objects, "objects");
            this.objects.Name = "objects";
            // 
            // modeling
            // 
            this.modeling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.modeling, "modeling");
            this.modeling.Name = "modeling";
            // 
            // sculpting
            // 
            this.sculpting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.sculpting, "sculpting");
            this.sculpting.Name = "sculpting";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "editors.png");
            this.imageList1.Images.SetKeyName(1, "Interface.png");
            this.imageList1.Images.SetKeyName(2, "modeling.png");
            this.imageList1.Images.SetKeyName(3, "Objects.png");
            this.imageList1.Images.SetKeyName(4, "sculpting.png");
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            resources.ApplyResources(this.tabPage8, "tabPage8");
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AccentColor = MaterialSkin2DotNet.Accent.Cyan400;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormToManage = this;
            this.Name = "MainForm";
            this.PrimaryColor = MaterialSkin2DotNet.Primary.Orange800;
            this.PrimaryDarkColor = MaterialSkin2DotNet.Primary.Brown900;
            this.PrimaryLightColor = MaterialSkin2DotNet.Primary.Lime700;
            this.Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            this.materialTabControl1.ResumeLayout(false);
            this.interuse.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage editors;
        private System.Windows.Forms.TabPage objects;
        private System.Windows.Forms.TabPage modeling;
        private System.Windows.Forms.TabPage sculpting;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage interuse;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
    }
}

