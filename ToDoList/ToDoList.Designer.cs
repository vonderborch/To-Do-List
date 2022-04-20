namespace ToDoList
{
    partial class ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableAutoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleAllItemsCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAllItemsIncompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleItemStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideUncompletedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listName_txt = new System.Windows.Forms.ToolStripTextBox();
            this.totalItems_txt = new System.Windows.Forms.ToolStripTextBox();
            this.todolist_lst = new System.Windows.Forms.CheckedListBox();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.addItemToolStripMenuItem,
            this.deleteCurrentItemToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.listName_txt,
            this.totalItems_txt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openListToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveListToolStripMenuItem,
            this.saveListAsToolStripMenuItem,
            this.enableAutoSaveToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeListToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New List";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openListToolStripMenuItem
            // 
            this.openListToolStripMenuItem.Name = "openListToolStripMenuItem";
            this.openListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openListToolStripMenuItem.Text = "Open List";
            this.openListToolStripMenuItem.Click += new System.EventHandler(this.openListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveListToolStripMenuItem.Text = "Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // saveListAsToolStripMenuItem
            // 
            this.saveListAsToolStripMenuItem.Name = "saveListAsToolStripMenuItem";
            this.saveListAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveListAsToolStripMenuItem.Text = "Save List As";
            this.saveListAsToolStripMenuItem.Click += new System.EventHandler(this.saveListAsToolStripMenuItem_Click);
            // 
            // enableAutoSaveToolStripMenuItem
            // 
            this.enableAutoSaveToolStripMenuItem.Name = "enableAutoSaveToolStripMenuItem";
            this.enableAutoSaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enableAutoSaveToolStripMenuItem.Text = "Toggle AutoSave";
            this.enableAutoSaveToolStripMenuItem.Click += new System.EventHandler(this.enableAutoSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // closeListToolStripMenuItem
            // 
            this.closeListToolStripMenuItem.Name = "closeListToolStripMenuItem";
            this.closeListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeListToolStripMenuItem.Text = "Close List";
            this.closeListToolStripMenuItem.Click += new System.EventHandler(this.closeListToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem,
            this.toggleAllItemsCompletedToolStripMenuItem,
            this.markAllItemsIncompleteToolStripMenuItem,
            this.toggleItemStateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // toggleAllItemsCompletedToolStripMenuItem
            // 
            this.toggleAllItemsCompletedToolStripMenuItem.Name = "toggleAllItemsCompletedToolStripMenuItem";
            this.toggleAllItemsCompletedToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.toggleAllItemsCompletedToolStripMenuItem.Text = "Mark All Items Completed";
            this.toggleAllItemsCompletedToolStripMenuItem.Click += new System.EventHandler(this.toggleAllItemsCompletedToolStripMenuItem_Click);
            // 
            // markAllItemsIncompleteToolStripMenuItem
            // 
            this.markAllItemsIncompleteToolStripMenuItem.Name = "markAllItemsIncompleteToolStripMenuItem";
            this.markAllItemsIncompleteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.markAllItemsIncompleteToolStripMenuItem.Text = "Mark All Items Incomplete";
            this.markAllItemsIncompleteToolStripMenuItem.Click += new System.EventHandler(this.markAllItemsIncompleteToolStripMenuItem_Click);
            // 
            // toggleItemStateToolStripMenuItem
            // 
            this.toggleItemStateToolStripMenuItem.Name = "toggleItemStateToolStripMenuItem";
            this.toggleItemStateToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.toggleItemStateToolStripMenuItem.Text = "Toggle Item State";
            this.toggleItemStateToolStripMenuItem.Click += new System.EventHandler(this.toggleItemStateToolStripMenuItem_Click);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.addItemToolStripMenuItem.Text = "Add New Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // deleteCurrentItemToolStripMenuItem
            // 
            this.deleteCurrentItemToolStripMenuItem.Name = "deleteCurrentItemToolStripMenuItem";
            this.deleteCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.deleteCurrentItemToolStripMenuItem.Text = "Delete Current Item";
            this.deleteCurrentItemToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentItemToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllItemsToolStripMenuItem,
            this.hideUncompletedItemsToolStripMenuItem,
            this.toolStripSeparator4,
            this.toggleToolStripMenuItem,
            this.toolStripSeparator2,
            this.statsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showAllItemsToolStripMenuItem
            // 
            this.showAllItemsToolStripMenuItem.Name = "showAllItemsToolStripMenuItem";
            this.showAllItemsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.showAllItemsToolStripMenuItem.Text = "Toggle Show Completed Items";
            this.showAllItemsToolStripMenuItem.Click += new System.EventHandler(this.showAllItemsToolStripMenuItem_Click);
            // 
            // hideUncompletedItemsToolStripMenuItem
            // 
            this.hideUncompletedItemsToolStripMenuItem.Name = "hideUncompletedItemsToolStripMenuItem";
            this.hideUncompletedItemsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.hideUncompletedItemsToolStripMenuItem.Text = "Toggle Show Incomplete Items";
            this.hideUncompletedItemsToolStripMenuItem.Click += new System.EventHandler(this.hideUncompletedItemsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listName_txt
            // 
            this.listName_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listName_txt.Name = "listName_txt";
            this.listName_txt.ReadOnly = true;
            this.listName_txt.Size = new System.Drawing.Size(200, 23);
            // 
            // totalItems_txt
            // 
            this.totalItems_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalItems_txt.Name = "totalItems_txt";
            this.totalItems_txt.ReadOnly = true;
            this.totalItems_txt.Size = new System.Drawing.Size(300, 23);
            // 
            // todolist_lst
            // 
            this.todolist_lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todolist_lst.FormattingEnabled = true;
            this.todolist_lst.Location = new System.Drawing.Point(0, 27);
            this.todolist_lst.Name = "todolist_lst";
            this.todolist_lst.Size = new System.Drawing.Size(918, 556);
            this.todolist_lst.TabIndex = 1;
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // toggleToolStripMenuItem
            // 
            this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            this.toggleToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.toggleToolStripMenuItem.Text = "Toggle Window on Top ";
            this.toggleToolStripMenuItem.Click += new System.EventHandler(this.toggleToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(233, 6);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 583);
            this.Controls.Add(this.todolist_lst);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleAllItemsCompletedToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox todolist_lst;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideUncompletedItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox listName_txt;
        private System.Windows.Forms.ToolStripTextBox totalItems_txt;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem enableAutoSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAllItemsIncompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleItemStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toggleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

