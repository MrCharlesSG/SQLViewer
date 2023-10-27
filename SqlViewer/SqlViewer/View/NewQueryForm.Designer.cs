namespace SqlViewer.View
{
    partial class NewQueryForm
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
            btn_run = new Button();
            tb_query = new TextBox();
            tb_message = new TextBox();
            btn_clear = new Button();
            lb_message = new Label();
            lb_query = new Label();
            SuspendLayout();
            // 
            // btn_run
            // 
            btn_run.BackColor = SystemColors.GradientActiveCaption;
            btn_run.Location = new Point(12, 499);
            btn_run.Name = "btn_run";
            btn_run.Size = new Size(195, 57);
            btn_run.TabIndex = 0;
            btn_run.Text = "Run";
            btn_run.UseVisualStyleBackColor = false;
            btn_run.Click += Tsb_Run_Click;
            // 
            // tb_query
            // 
            tb_query.Location = new Point(12, 34);
            tb_query.Multiline = true;
            tb_query.Name = "tb_query";
            tb_query.Size = new Size(1097, 404);
            tb_query.TabIndex = 2;
            // 
            // tb_message
            // 
            tb_message.Location = new Point(447, 444);
            tb_message.Multiline = true;
            tb_message.Name = "tb_message";
            tb_message.ReadOnly = true;
            tb_message.Size = new Size(662, 152);
            tb_message.TabIndex = 3;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.AppWorkspace;
            btn_clear.Location = new Point(213, 499);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(113, 57);
            btn_clear.TabIndex = 4;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += Tsb_Clear_Click;
            // 
            // lb_message
            // 
            lb_message.AutoSize = true;
            lb_message.Location = new Point(355, 447);
            lb_message.Name = "lb_message";
            lb_message.Size = new Size(86, 25);
            lb_message.TabIndex = 5;
            lb_message.Text = "Message:";
            // 
            // lb_query
            // 
            lb_query.AutoSize = true;
            lb_query.Location = new Point(12, 6);
            lb_query.Name = "lb_query";
            lb_query.Size = new Size(64, 25);
            lb_query.TabIndex = 6;
            lb_query.Text = "Query:";
            // 
            // NewQueryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1121, 608);
            Controls.Add(lb_query);
            Controls.Add(lb_message);
            Controls.Add(btn_clear);
            Controls.Add(tb_message);
            Controls.Add(tb_query);
            Controls.Add(btn_run);
            Name = "NewQueryForm";
            Text = "New Query";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_run;
        private TextBox tb_query;
        private TextBox tb_message;
        private Button btn_clear;
        private Label lb_message;
        private Label lb_query;
    }
}