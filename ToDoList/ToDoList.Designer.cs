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
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleAllItemsCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAllItemsIncompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleItemStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.moveCurrentItemUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveCurrentItemDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideUncompletedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listName_txt = new System.Windows.Forms.ToolStripTextBox();
            this.totalItems_txt = new System.Windows.Forms.ToolStripTextBox();
            this.todolist_lst = new System.Windows.Forms.CheckedListBox();
            this.addNewChildItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.addItemToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteCurrentItemToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.listName_txt,
            this.totalItems_txt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 27);
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newToolStripMenuItem.Text = "New List";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openListToolStripMenuItem
            // 
            this.openListToolStripMenuItem.Name = "openListToolStripMenuItem";
            this.openListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openListToolStripMenuItem.Text = "Open List";
            this.openListToolStripMenuItem.Click += new System.EventHandler(this.openListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveListToolStripMenuItem.Text = "Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // saveListAsToolStripMenuItem
            // 
            this.saveListAsToolStripMenuItem.Name = "saveListAsToolStripMenuItem";
            this.saveListAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveListAsToolStripMenuItem.Text = "Save List As";
            this.saveListAsToolStripMenuItem.Click += new System.EventHandler(this.saveListAsToolStripMenuItem_Click);
            // 
            // enableAutoSaveToolStripMenuItem
            // 
            this.enableAutoSaveToolStripMenuItem.Name = "enableAutoSaveToolStripMenuItem";
            this.enableAutoSaveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.enableAutoSaveToolStripMenuItem.Text = "Toggle AutoSave";
            this.enableAutoSaveToolStripMenuItem.Click += new System.EventHandler(this.enableAutoSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            // 
            // closeListToolStripMenuItem
            // 
            this.closeListToolStripMenuItem.Name = "closeListToolStripMenuItem";
            this.closeListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.closeListToolStripMenuItem.Text = "Close List";
            this.closeListToolStripMenuItem.Click += new System.EventHandler(this.closeListToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem,
            this.toolStripSeparator6,
            this.toggleAllItemsCompletedToolStripMenuItem,
            this.markAllItemsIncompleteToolStripMenuItem,
            this.toggleItemStateToolStripMenuItem,
            this.toolStripSeparator7,
            this.moveCurrentItemUpToolStripMenuItem,
            this.moveCurrentItemDownToolStripMenuItem,
            this.toolStripSeparator8,
            this.addNewItemToolStripMenuItem,
            this.editCurrentItemToolStripMenuItem,
            this.deleteCurrentItemToolStripMenuItem1});
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(210, 6);
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(210, 6);
            // 
            // moveCurrentItemUpToolStripMenuItem
            // 
            this.moveCurrentItemUpToolStripMenuItem.Name = "moveCurrentItemUpToolStripMenuItem";
            this.moveCurrentItemUpToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.moveCurrentItemUpToolStripMenuItem.Text = "Move Current Item Up";
            this.moveCurrentItemUpToolStripMenuItem.Click += new System.EventHandler(this.moveCurrentItemUpToolStripMenuItem_Click);
            // 
            // moveCurrentItemDownToolStripMenuItem
            // 
            this.moveCurrentItemDownToolStripMenuItem.Name = "moveCurrentItemDownToolStripMenuItem";
            this.moveCurrentItemDownToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.moveCurrentItemDownToolStripMenuItem.Text = "Move Current Item Down";
            this.moveCurrentItemDownToolStripMenuItem.Click += new System.EventHandler(this.moveCurrentItemDownToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(210, 6);
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addNewItemToolStripMenuItem.Text = "Add New Item";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.addNewItemToolStripMenuItem_Click);
            // 
            // editCurrentItemToolStripMenuItem
            // 
            this.editCurrentItemToolStripMenuItem.Name = "editCurrentItemToolStripMenuItem";
            this.editCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.editCurrentItemToolStripMenuItem.Text = "Edit Current Item";
            this.editCurrentItemToolStripMenuItem.Click += new System.EventHandler(this.editCurrentItemToolStripMenuItem_Click);
            // 
            // deleteCurrentItemToolStripMenuItem1
            // 
            this.deleteCurrentItemToolStripMenuItem1.Name = "deleteCurrentItemToolStripMenuItem1";
            this.deleteCurrentItemToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.deleteCurrentItemToolStripMenuItem1.Text = "Delete Current Item";
            this.deleteCurrentItemToolStripMenuItem1.Click += new System.EventHandler(this.deleteCurrentItemToolStripMenuItem1_Click);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewChildItemToolStripMenuItem});
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.addItemToolStripMenuItem.Text = "Add New Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 23);
            this.toolStripMenuItem1.Text = "Edit Current Item";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // deleteCurrentItemToolStripMenuItem
            // 
            this.deleteCurrentItemToolStripMenuItem.Name = "deleteCurrentItemToolStripMenuItem";
            this.deleteCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.deleteCurrentItemToolStripMenuItem.Text = "Delete Current Item";
            this.deleteCurrentItemToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentItemToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(29, 23);
            this.toolStripMenuItem2.Text = "/\\";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(29, 23);
            this.toolStripMenuItem3.Text = "\\/";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(233, 6);
            // 
            // toggleToolStripMenuItem
            // 
            this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            this.toggleToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.toggleToolStripMenuItem.Text = "Toggle Window on Top ";
            this.toggleToolStripMenuItem.Click += new System.EventHandler(this.toggleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator5,
            this.reportBugToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(231, 6);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.reportBugToolStripMenuItem.Text = "Report Issue/Make Suggestion";
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.reportBugToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
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
            this.todolist_lst.HorizontalScrollbar = true;
            this.todolist_lst.Location = new System.Drawing.Point(0, 27);
            this.todolist_lst.Name = "todolist_lst";
            this.todolist_lst.Size = new System.Drawing.Size(1063, 556);
            this.todolist_lst.TabIndex = 1;
            this.todolist_lst.ThreeDCheckBoxes = true;
            this.todolist_lst.SelectedIndexChanged += new System.EventHandler(this.todolist_lst_SelectedIndexChanged);
            // 
            // addNewChildItemToolStripMenuItem
            // 
            this.addNewChildItemToolStripMenuItem.Name = "addNewChildItemToolStripMenuItem";
            this.addNewChildItemToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addNewChildItemToolStripMenuItem.Text = "Add New Child Item";
            this.addNewChildItemToolStripMenuItem.Click += new System.EventHandler(this.addNewChildItemToolStripMenuItem_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 583);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem moveCurrentItemUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveCurrentItemDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem editCurrentItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentItemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addNewChildItemToolStripMenuItem;
    }
}

