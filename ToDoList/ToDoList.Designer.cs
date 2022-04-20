using System.Windows.Forms;
using SIL.FieldWorks.Common.Controls;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputText_txt = new System.Windows.Forms.ToolStripTextBox();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewChildItemMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentItemMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemUpMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemDownMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleExpandAllItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status_str = new System.Windows.Forms.StatusStrip();
            this.listName_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalItems_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentSelectionStats_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openListInCurrentWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.addNewChildItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleExpandAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.unselectCurrentSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todolist_lst = new SIL.FieldWorks.Common.Controls.TriStateTreeView();
            this.copyCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCurrentItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.status_str.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputText_txt,
            this.addItemToolStripMenuItem,
            this.addNewChildItemMainStrip,
            this.editCurrentItemMainStrip,
            this.deleteCurrentItemToolStripMenuItem,
            this.moveItemUpMainStrip,
            this.moveItemDownMainStrip,
            this.copyCurrentItemToolStripMenuItem,
            this.unselectCurrentItemToolStripMenuItem,
            this.toggleExpandAllItemsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputText_txt
            // 
            this.inputText_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputText_txt.Name = "inputText_txt";
            this.inputText_txt.Size = new System.Drawing.Size(200, 23);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.addItemToolStripMenuItem.Text = "Add New Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // addNewChildItemMainStrip
            // 
            this.addNewChildItemMainStrip.Name = "addNewChildItemMainStrip";
            this.addNewChildItemMainStrip.Size = new System.Drawing.Size(126, 23);
            this.addNewChildItemMainStrip.Text = "Add New Child Item";
            this.addNewChildItemMainStrip.Click += new System.EventHandler(this.addNewChildItemMainStrip_Click);
            // 
            // editCurrentItemMainStrip
            // 
            this.editCurrentItemMainStrip.Name = "editCurrentItemMainStrip";
            this.editCurrentItemMainStrip.Size = new System.Drawing.Size(109, 23);
            this.editCurrentItemMainStrip.Text = "Edit Current Item";
            this.editCurrentItemMainStrip.Click += new System.EventHandler(this.editCurrentItemMainStrip_Click);
            // 
            // deleteCurrentItemToolStripMenuItem
            // 
            this.deleteCurrentItemToolStripMenuItem.Name = "deleteCurrentItemToolStripMenuItem";
            this.deleteCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.deleteCurrentItemToolStripMenuItem.Text = "Delete Current Item";
            this.deleteCurrentItemToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentItemToolStripMenuItem_Click);
            // 
            // moveItemUpMainStrip
            // 
            this.moveItemUpMainStrip.Name = "moveItemUpMainStrip";
            this.moveItemUpMainStrip.Size = new System.Drawing.Size(29, 23);
            this.moveItemUpMainStrip.Text = "/\\";
            this.moveItemUpMainStrip.Click += new System.EventHandler(this.moveItemUpMainStrip_Click);
            // 
            // moveItemDownMainStrip
            // 
            this.moveItemDownMainStrip.Name = "moveItemDownMainStrip";
            this.moveItemDownMainStrip.Size = new System.Drawing.Size(29, 23);
            this.moveItemDownMainStrip.Text = "\\/";
            this.moveItemDownMainStrip.Click += new System.EventHandler(this.moveItemDownMainStrip_Click);
            // 
            // toggleExpandAllItemsToolStripMenuItem1
            // 
            this.toggleExpandAllItemsToolStripMenuItem1.Name = "toggleExpandAllItemsToolStripMenuItem1";
            this.toggleExpandAllItemsToolStripMenuItem1.Size = new System.Drawing.Size(145, 23);
            this.toggleExpandAllItemsToolStripMenuItem1.Text = "Toggle Expand All Items";
            this.toggleExpandAllItemsToolStripMenuItem1.Click += new System.EventHandler(this.toggleExpandAllItemsToolStripMenuItem1_Click);
            // 
            // unselectCurrentItemToolStripMenuItem
            // 
            this.unselectCurrentItemToolStripMenuItem.Name = "unselectCurrentItemToolStripMenuItem";
            this.unselectCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(134, 23);
            this.unselectCurrentItemToolStripMenuItem.Text = "Unselect Current Item";
            this.unselectCurrentItemToolStripMenuItem.Click += new System.EventHandler(this.unselectCurrentItemToolStripMenuItem_Click);
            // 
            // status_str
            // 
            this.status_str.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listName_txt,
            this.totalItems_txt,
            this.currentSelectionStats_txt});
            this.status_str.Location = new System.Drawing.Point(0, 524);
            this.status_str.Name = "status_str";
            this.status_str.Size = new System.Drawing.Size(1271, 24);
            this.status_str.TabIndex = 2;
            this.status_str.Text = "statusStrip1";
            // 
            // listName_txt
            // 
            this.listName_txt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.listName_txt.Name = "listName_txt";
            this.listName_txt.Size = new System.Drawing.Size(56, 19);
            this.listName_txt.Text = "New List";
            // 
            // totalItems_txt
            // 
            this.totalItems_txt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.totalItems_txt.Name = "totalItems_txt";
            this.totalItems_txt.Size = new System.Drawing.Size(49, 19);
            this.totalItems_txt.Text = "0 items";
            // 
            // currentSelectionStats_txt
            // 
            this.currentSelectionStats_txt.Name = "currentSelectionStats_txt";
            this.currentSelectionStats_txt.Size = new System.Drawing.Size(45, 19);
            this.currentSelectionStats_txt.Text = "0 items";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1271, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openListToolStripMenuItem,
            this.openListInCurrentWindowToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveListToolStripMenuItem,
            this.saveListAsToolStripMenuItem,
            this.enableAutoSaveToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeListToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.newToolStripMenuItem.Text = "New List";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openListToolStripMenuItem
            // 
            this.openListToolStripMenuItem.Name = "openListToolStripMenuItem";
            this.openListToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openListToolStripMenuItem.Text = "Open List";
            this.openListToolStripMenuItem.Click += new System.EventHandler(this.openListToolStripMenuItem_Click);
            // 
            // openListInCurrentWindowToolStripMenuItem
            // 
            this.openListInCurrentWindowToolStripMenuItem.Name = "openListInCurrentWindowToolStripMenuItem";
            this.openListInCurrentWindowToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openListInCurrentWindowToolStripMenuItem.Text = "Open List in Current Window";
            this.openListInCurrentWindowToolStripMenuItem.Click += new System.EventHandler(this.openListInCurrentWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.saveListToolStripMenuItem.Text = "Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // saveListAsToolStripMenuItem
            // 
            this.saveListAsToolStripMenuItem.Name = "saveListAsToolStripMenuItem";
            this.saveListAsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.saveListAsToolStripMenuItem.Text = "Save List As";
            this.saveListAsToolStripMenuItem.Click += new System.EventHandler(this.saveListAsToolStripMenuItem_Click);
            // 
            // enableAutoSaveToolStripMenuItem
            // 
            this.enableAutoSaveToolStripMenuItem.Name = "enableAutoSaveToolStripMenuItem";
            this.enableAutoSaveToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.enableAutoSaveToolStripMenuItem.Text = "Toggle AutoSave";
            this.enableAutoSaveToolStripMenuItem.Click += new System.EventHandler(this.enableAutoSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
            // 
            // closeListToolStripMenuItem
            // 
            this.closeListToolStripMenuItem.Name = "closeListToolStripMenuItem";
            this.closeListToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.closeListToolStripMenuItem.Text = "Exit";
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
            this.addNewChildItemToolStripMenuItem1,
            this.editCurrentItemToolStripMenuItem,
            this.deleteCurrentItemToolStripMenuItem1,
            this.copyCurrentItemToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
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
            this.toggleItemStateToolStripMenuItem.Text = "Toggle All Items State";
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
            // addNewChildItemToolStripMenuItem1
            // 
            this.addNewChildItemToolStripMenuItem1.Name = "addNewChildItemToolStripMenuItem1";
            this.addNewChildItemToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.addNewChildItemToolStripMenuItem1.Text = "Add New Child Item";
            this.addNewChildItemToolStripMenuItem1.Click += new System.EventHandler(this.addNewChildItemToolStripMenuItem1_Click);
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
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleToolStripMenuItem,
            this.toolStripSeparator2,
            this.toggleExpandAllItemsToolStripMenuItem,
            this.toolStripSeparator4,
            this.unselectCurrentSelectedItemToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
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
            // toggleExpandAllItemsToolStripMenuItem
            // 
            this.toggleExpandAllItemsToolStripMenuItem.Name = "toggleExpandAllItemsToolStripMenuItem";
            this.toggleExpandAllItemsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.toggleExpandAllItemsToolStripMenuItem.Text = "Toggle Expand All Items";
            this.toggleExpandAllItemsToolStripMenuItem.Click += new System.EventHandler(this.toggleExpandAllItemsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(233, 6);
            // 
            // unselectCurrentSelectedItemToolStripMenuItem
            // 
            this.unselectCurrentSelectedItemToolStripMenuItem.Name = "unselectCurrentSelectedItemToolStripMenuItem";
            this.unselectCurrentSelectedItemToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.unselectCurrentSelectedItemToolStripMenuItem.Text = "Unselect Current Selected Item";
            this.unselectCurrentSelectedItemToolStripMenuItem.Click += new System.EventHandler(this.unselectCurrentSelectedItemToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator5,
            this.reportBugToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
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
            // todolist_lst
            // 
            this.todolist_lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todolist_lst.ImageIndex = 1;
            this.todolist_lst.Location = new System.Drawing.Point(0, 51);
            this.todolist_lst.Name = "todolist_lst";
            this.todolist_lst.SelectedImageIndex = 1;
            this.todolist_lst.ShowRootLines = false;
            this.todolist_lst.Size = new System.Drawing.Size(1271, 497);
            this.todolist_lst.TabIndex = 1;
            this.todolist_lst.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.itemChecked_AfterCheck);
            // 
            // copyCurrentItemToolStripMenuItem
            // 
            this.copyCurrentItemToolStripMenuItem.Name = "copyCurrentItemToolStripMenuItem";
            this.copyCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(117, 23);
            this.copyCurrentItemToolStripMenuItem.Text = "Copy Current Item";
            this.copyCurrentItemToolStripMenuItem.Click += new System.EventHandler(this.copyCurrentItemToolStripMenuItem_Click);
            // 
            // copyCurrentItemToolStripMenuItem1
            // 
            this.copyCurrentItemToolStripMenuItem1.Name = "copyCurrentItemToolStripMenuItem1";
            this.copyCurrentItemToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.copyCurrentItemToolStripMenuItem1.Text = "Copy Current Item";
            this.copyCurrentItemToolStripMenuItem1.Click += new System.EventHandler(this.copyCurrentItemToolStripMenuItem1_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 548);
            this.Controls.Add(this.status_str);
            this.Controls.Add(this.todolist_lst);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.status_str.ResumeLayout(false);
            this.status_str.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCurrentItemMainStrip;
        private System.Windows.Forms.ToolStripMenuItem moveItemUpMainStrip;
        private System.Windows.Forms.ToolStripMenuItem moveItemDownMainStrip;
        private System.Windows.Forms.StatusStrip status_str;
        private System.Windows.Forms.ToolStripStatusLabel listName_txt;
        private System.Windows.Forms.ToolStripStatusLabel totalItems_txt;
        private System.Windows.Forms.ToolStripMenuItem addNewChildItemMainStrip;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableAutoSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toggleAllItemsCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAllItemsIncompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleItemStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem moveCurrentItemUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveCurrentItemDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewChildItemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editCurrentItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentItemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private TriStateTreeView todolist_lst;
        private System.Windows.Forms.ToolStripTextBox inputText_txt;
        private System.Windows.Forms.ToolStripMenuItem toggleExpandAllItemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toggleExpandAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openListInCurrentWindowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem unselectCurrentSelectedItemToolStripMenuItem;
        private ToolStripMenuItem unselectCurrentItemToolStripMenuItem;
        private ToolStripStatusLabel currentSelectionStats_txt;
        private ToolStripMenuItem copyCurrentItemToolStripMenuItem;
        private ToolStripMenuItem copyCurrentItemToolStripMenuItem1;
    }
}

