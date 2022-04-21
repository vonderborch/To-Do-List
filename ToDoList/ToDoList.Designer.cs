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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.listName_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalItems_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentSelectionStats_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.todolist_lst = new SIL.FieldWorks.Common.Controls.TriStateTreeView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addChildItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
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
            this.copyCurrentItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleExpandAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.unselectCurrentSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.inputText_txt = new System.Windows.Forms.ToolStripTextBox();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewChildItemMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentItemMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemUpMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemDownMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleExpandAllItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.todolist_lst);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1271, 702);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1271, 778);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip4);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip3);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listName_txt,
            this.totalItems_txt,
            this.currentSelectionStats_txt});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(162, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // listName_txt
            // 
            this.listName_txt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.listName_txt.Name = "listName_txt";
            this.listName_txt.Size = new System.Drawing.Size(56, 20);
            this.listName_txt.Text = "New List";
            // 
            // totalItems_txt
            // 
            this.totalItems_txt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.totalItems_txt.Name = "totalItems_txt";
            this.totalItems_txt.Size = new System.Drawing.Size(49, 20);
            this.totalItems_txt.Text = "0 items";
            // 
            // currentSelectionStats_txt
            // 
            this.currentSelectionStats_txt.Name = "currentSelectionStats_txt";
            this.currentSelectionStats_txt.Size = new System.Drawing.Size(45, 20);
            this.currentSelectionStats_txt.Text = "0 items";
            // 
            // todolist_lst
            // 
            this.todolist_lst.ContextMenuStrip = this.contextMenu;
            this.todolist_lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todolist_lst.ImageIndex = 1;
            this.todolist_lst.Location = new System.Drawing.Point(0, 0);
            this.todolist_lst.Name = "todolist_lst";
            this.todolist_lst.SelectedImageIndex = 1;
            this.todolist_lst.ShowRootLines = false;
            this.todolist_lst.Size = new System.Drawing.Size(1271, 702);
            this.todolist_lst.TabIndex = 2;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChildItemToolStripMenuItem,
            this.copyItemToolStripMenuItem,
            this.editItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.moveItemUpToolStripMenuItem,
            this.moveItemDownToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(181, 158);
            // 
            // addChildItemToolStripMenuItem
            // 
            this.addChildItemToolStripMenuItem.Name = "addChildItemToolStripMenuItem";
            this.addChildItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addChildItemToolStripMenuItem.Text = "Add Child Item";
            // 
            // copyItemToolStripMenuItem
            // 
            this.copyItemToolStripMenuItem.Name = "copyItemToolStripMenuItem";
            this.copyItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyItemToolStripMenuItem.Text = "Copy Item";
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            // 
            // moveItemUpToolStripMenuItem
            // 
            this.moveItemUpToolStripMenuItem.Name = "moveItemUpToolStripMenuItem";
            this.moveItemUpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moveItemUpToolStripMenuItem.Text = "Move Item Up";
            // 
            // moveItemDownToolStripMenuItem
            // 
            this.moveItemDownToolStripMenuItem.Name = "moveItemDownToolStripMenuItem";
            this.moveItemDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moveItemDownToolStripMenuItem.Text = "Move Item Down";
            // 
            // menuStrip4
            // 
            this.menuStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(1271, 24);
            this.menuStrip4.TabIndex = 1;
            this.menuStrip4.Text = "menuStrip4";
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
            // 
            // openListToolStripMenuItem
            // 
            this.openListToolStripMenuItem.Name = "openListToolStripMenuItem";
            this.openListToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openListToolStripMenuItem.Text = "Open List";
            // 
            // openListInCurrentWindowToolStripMenuItem
            // 
            this.openListInCurrentWindowToolStripMenuItem.Name = "openListInCurrentWindowToolStripMenuItem";
            this.openListInCurrentWindowToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openListInCurrentWindowToolStripMenuItem.Text = "Open List in Current Window";
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
            // 
            // saveListAsToolStripMenuItem
            // 
            this.saveListAsToolStripMenuItem.Name = "saveListAsToolStripMenuItem";
            this.saveListAsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.saveListAsToolStripMenuItem.Text = "Save List As";
            // 
            // enableAutoSaveToolStripMenuItem
            // 
            this.enableAutoSaveToolStripMenuItem.Name = "enableAutoSaveToolStripMenuItem";
            this.enableAutoSaveToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.enableAutoSaveToolStripMenuItem.Text = "Toggle AutoSave";
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
            // 
            // markAllItemsIncompleteToolStripMenuItem
            // 
            this.markAllItemsIncompleteToolStripMenuItem.Name = "markAllItemsIncompleteToolStripMenuItem";
            this.markAllItemsIncompleteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.markAllItemsIncompleteToolStripMenuItem.Text = "Mark All Items Incomplete";
            // 
            // toggleItemStateToolStripMenuItem
            // 
            this.toggleItemStateToolStripMenuItem.Name = "toggleItemStateToolStripMenuItem";
            this.toggleItemStateToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.toggleItemStateToolStripMenuItem.Text = "Toggle All Items State";
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
            // 
            // moveCurrentItemDownToolStripMenuItem
            // 
            this.moveCurrentItemDownToolStripMenuItem.Name = "moveCurrentItemDownToolStripMenuItem";
            this.moveCurrentItemDownToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.moveCurrentItemDownToolStripMenuItem.Text = "Move Current Item Down";
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
            // 
            // addNewChildItemToolStripMenuItem1
            // 
            this.addNewChildItemToolStripMenuItem1.Name = "addNewChildItemToolStripMenuItem1";
            this.addNewChildItemToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.addNewChildItemToolStripMenuItem1.Text = "Add New Child Item";
            // 
            // editCurrentItemToolStripMenuItem
            // 
            this.editCurrentItemToolStripMenuItem.Name = "editCurrentItemToolStripMenuItem";
            this.editCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.editCurrentItemToolStripMenuItem.Text = "Edit Current Item";
            // 
            // deleteCurrentItemToolStripMenuItem1
            // 
            this.deleteCurrentItemToolStripMenuItem1.Name = "deleteCurrentItemToolStripMenuItem1";
            this.deleteCurrentItemToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.deleteCurrentItemToolStripMenuItem1.Text = "Delete Current Item";
            // 
            // copyCurrentItemToolStripMenuItem1
            // 
            this.copyCurrentItemToolStripMenuItem1.Name = "copyCurrentItemToolStripMenuItem1";
            this.copyCurrentItemToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.copyCurrentItemToolStripMenuItem1.Text = "Copy Current Item";
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
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator9,
            this.reportBugToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(231, 6);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.reportBugToolStripMenuItem.Text = "Report Issue/Make Suggestion";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.menuStrip3.Location = new System.Drawing.Point(0, 24);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1271, 27);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
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
            // 
            // addNewChildItemMainStrip
            // 
            this.addNewChildItemMainStrip.Name = "addNewChildItemMainStrip";
            this.addNewChildItemMainStrip.Size = new System.Drawing.Size(126, 23);
            this.addNewChildItemMainStrip.Text = "Add New Child Item";
            // 
            // editCurrentItemMainStrip
            // 
            this.editCurrentItemMainStrip.Name = "editCurrentItemMainStrip";
            this.editCurrentItemMainStrip.Size = new System.Drawing.Size(109, 23);
            this.editCurrentItemMainStrip.Text = "Edit Current Item";
            // 
            // deleteCurrentItemToolStripMenuItem
            // 
            this.deleteCurrentItemToolStripMenuItem.Name = "deleteCurrentItemToolStripMenuItem";
            this.deleteCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.deleteCurrentItemToolStripMenuItem.Text = "Delete Current Item";
            // 
            // moveItemUpMainStrip
            // 
            this.moveItemUpMainStrip.Name = "moveItemUpMainStrip";
            this.moveItemUpMainStrip.Size = new System.Drawing.Size(29, 23);
            this.moveItemUpMainStrip.Text = "/\\";
            // 
            // moveItemDownMainStrip
            // 
            this.moveItemDownMainStrip.Name = "moveItemDownMainStrip";
            this.moveItemDownMainStrip.Size = new System.Drawing.Size(29, 23);
            this.moveItemDownMainStrip.Text = "\\/";
            // 
            // copyCurrentItemToolStripMenuItem
            // 
            this.copyCurrentItemToolStripMenuItem.Name = "copyCurrentItemToolStripMenuItem";
            this.copyCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(117, 23);
            this.copyCurrentItemToolStripMenuItem.Text = "Copy Current Item";
            // 
            // unselectCurrentItemToolStripMenuItem
            // 
            this.unselectCurrentItemToolStripMenuItem.Name = "unselectCurrentItemToolStripMenuItem";
            this.unselectCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(134, 23);
            this.unselectCurrentItemToolStripMenuItem.Text = "Unselect Current Item";
            // 
            // toggleExpandAllItemsToolStripMenuItem1
            // 
            this.toggleExpandAllItemsToolStripMenuItem1.Name = "toggleExpandAllItemsToolStripMenuItem1";
            this.toggleExpandAllItemsToolStripMenuItem1.Size = new System.Drawing.Size(145, 23);
            this.toggleExpandAllItemsToolStripMenuItem1.Text = "Toggle Expand All Items";
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 778);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripStatusLabel listName_txt;
        private ToolStripStatusLabel totalItems_txt;
        private ToolStripStatusLabel currentSelectionStats_txt;
        private TriStateTreeView todolist_lst;
        private MenuStrip menuStrip4;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openListToolStripMenuItem;
        private ToolStripMenuItem openListInCurrentWindowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveListToolStripMenuItem;
        private ToolStripMenuItem saveListAsToolStripMenuItem;
        private ToolStripMenuItem enableAutoSaveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem closeListToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem clearListToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem toggleAllItemsCompletedToolStripMenuItem;
        private ToolStripMenuItem markAllItemsIncompleteToolStripMenuItem;
        private ToolStripMenuItem toggleItemStateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem moveCurrentItemUpToolStripMenuItem;
        private ToolStripMenuItem moveCurrentItemDownToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem addNewItemToolStripMenuItem;
        private ToolStripMenuItem addNewChildItemToolStripMenuItem1;
        private ToolStripMenuItem editCurrentItemToolStripMenuItem;
        private ToolStripMenuItem deleteCurrentItemToolStripMenuItem1;
        private ToolStripMenuItem copyCurrentItemToolStripMenuItem1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toggleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toggleExpandAllItemsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem unselectCurrentSelectedItemToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem reportBugToolStripMenuItem;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private MenuStrip menuStrip3;
        private ToolStripTextBox inputText_txt;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem addNewChildItemMainStrip;
        private ToolStripMenuItem editCurrentItemMainStrip;
        private ToolStripMenuItem deleteCurrentItemToolStripMenuItem;
        private ToolStripMenuItem moveItemUpMainStrip;
        private ToolStripMenuItem moveItemDownMainStrip;
        private ToolStripMenuItem copyCurrentItemToolStripMenuItem;
        private ToolStripMenuItem unselectCurrentItemToolStripMenuItem;
        private ToolStripMenuItem toggleExpandAllItemsToolStripMenuItem1;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem addChildItemToolStripMenuItem;
        private ToolStripMenuItem copyItemToolStripMenuItem;
        private ToolStripMenuItem editItemToolStripMenuItem;
        private ToolStripMenuItem deleteItemToolStripMenuItem;
        private ToolStripMenuItem moveItemUpToolStripMenuItem;
        private ToolStripMenuItem moveItemDownToolStripMenuItem;
    }
}

