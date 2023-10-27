namespace SqlViewer.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            twServer = new TreeView();
            toolStrip1 = new ToolStrip();
            tsbSelect = new ToolStripButton();
            tsbXML = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            tbContent = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // twServer
            // 
            twServer.Location = new Point(10, 91);
            twServer.Margin = new Padding(1);
            twServer.Name = "twServer";
            twServer.Size = new Size(494, 917);
            twServer.TabIndex = 0;
            twServer.AfterCollapse += TwServer_AfterCollapse;
            twServer.BeforeExpand += TwServer_BeforeExpand;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbSelect, tsbXML, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(1392, 49);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbSelect
            // 
            tsbSelect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSelect.Image = (Image)resources.GetObject("tsbSelect.Image");
            tsbSelect.ImageTransparentColor = Color.Magenta;
            tsbSelect.Name = "tsbSelect";
            tsbSelect.Size = new Size(44, 44);
            tsbSelect.Text = "Select";
            tsbSelect.Click += TsbSelect_Click;
            // 
            // tsbXML
            // 
            tsbXML.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbXML.Image = (Image)resources.GetObject("tsbXML.Image");
            tsbXML.ImageTransparentColor = Color.Magenta;
            tsbXML.Name = "tsbXML";
            tsbXML.Size = new Size(44, 44);
            tsbXML.Text = "XML";
            tsbXML.Click += TsbXML_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.new_query;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(44, 44);
            toolStripButton1.Text = "New Query";
            toolStripButton1.Click += TsbNewQuery_Click;
            // 
            // tbContent
            // 
            tbContent.Location = new Point(552, 91);
            tbContent.Margin = new Padding(1);
            tbContent.Multiline = true;
            tbContent.Name = "tbContent";
            tbContent.Size = new Size(824, 710);
            tbContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 1050);
            Controls.Add(tbContent);
            Controls.Add(toolStrip1);
            Controls.Add(twServer);
            Margin = new Padding(1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSMS";
            FormClosed += MainForm_FormClosed;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView twServer;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbSelect;
        private ToolStripButton tsbXML;
        private TextBox tbContent;
        private ToolStripButton toolStripButton1;
    }
}