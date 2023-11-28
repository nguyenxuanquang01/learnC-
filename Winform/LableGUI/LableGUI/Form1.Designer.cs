namespace LableGUI
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
            ListViewItem listViewItem1 = new ListViewItem("item 1");
            ListViewItem listViewItem2 = new ListViewItem("item 2");
            ListViewItem listViewItem3 = new ListViewItem("item 3");
            listView2 = new ListView();
            SuspendLayout();
            // 
            // listView2
            // 
            listView2.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView2.Location = new Point(12, 12);
            listView2.Name = "listView2";
            listView2.Size = new Size(548, 375);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            ClientSize = new Size(798, 469);
            Controls.Add(listView2);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView2;
    }
}
