﻿using System.Windows.Forms;
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addChildItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.duplicateItemToTop_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToBottomContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.copyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paste_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToTopOfParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAboveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteBelowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.moveItemToTop_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.currentItemToTop_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.moveCurrentItemUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveCurrentItemDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentItemToBottom_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewChildItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.duplicateToTop_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToBottomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.copyCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToTopOfParentNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAboveCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteBelowCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToBottomOfParentNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleExpandAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.unselectCurrentSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.checkedFontStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleBoldChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleItalicChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleStrikethroughChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleUnderlineChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.regularFontStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleBold = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleStrikethrough = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleUnderline = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toTop_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemUpMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.moveItemDownMainStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toBottom_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAboveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteBelowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToBottomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectCurrentItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleExpandAllItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todolist_lst = new SIL.FieldWorks.Common.Controls.TriStateTreeView();
            this.duplicateToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1279, 702);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1279, 778);
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
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChildItemToolStripMenuItem,
            this.toolStripSeparator10,
            this.editItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.toolStripSeparator11,
            this.duplicateItemToTop_btn,
            this.duplicateToBottomContextMenuItem,
            this.toolStripSeparator13,
            this.copyItem,
            this.paste_btn,
            this.toolStripSeparator12,
            this.moveItemToTop_btn,
            this.moveItemUpToolStripMenuItem,
            this.moveItemDownToolStripMenuItem,
            this.moveItemToBottomToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(209, 270);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // addChildItemToolStripMenuItem
            // 
            this.addChildItemToolStripMenuItem.Name = "addChildItemToolStripMenuItem";
            this.addChildItemToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addChildItemToolStripMenuItem.Text = "Add Child Item";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(205, 6);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(205, 6);
            // 
            // duplicateItemToTop_btn
            // 
            this.duplicateItemToTop_btn.Name = "duplicateItemToTop_btn";
            this.duplicateItemToTop_btn.Size = new System.Drawing.Size(208, 22);
            this.duplicateItemToTop_btn.Text = "Duplicate Item to Top";
            // 
            // duplicateToBottomContextMenuItem
            // 
            this.duplicateToBottomContextMenuItem.Name = "duplicateToBottomContextMenuItem";
            this.duplicateToBottomContextMenuItem.Size = new System.Drawing.Size(208, 22);
            this.duplicateToBottomContextMenuItem.Text = "Duplicate Item to Bottom";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(205, 6);
            // 
            // copyItem
            // 
            this.copyItem.Name = "copyItem";
            this.copyItem.Size = new System.Drawing.Size(208, 22);
            this.copyItem.Text = "Copy Item";
            // 
            // paste_btn
            // 
            this.paste_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToTopOfParentToolStripMenuItem,
            this.pasteAboveToolStripMenuItem,
            this.pasteBelowToolStripMenuItem,
            this.pasteToBottomToolStripMenuItem});
            this.paste_btn.Name = "paste_btn";
            this.paste_btn.Size = new System.Drawing.Size(208, 22);
            this.paste_btn.Text = "Paste";
            // 
            // pasteToTopOfParentToolStripMenuItem
            // 
            this.pasteToTopOfParentToolStripMenuItem.Name = "pasteToTopOfParentToolStripMenuItem";
            this.pasteToTopOfParentToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pasteToTopOfParentToolStripMenuItem.Text = "Paste to Top";
            // 
            // pasteAboveToolStripMenuItem
            // 
            this.pasteAboveToolStripMenuItem.Name = "pasteAboveToolStripMenuItem";
            this.pasteAboveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pasteAboveToolStripMenuItem.Text = "Paste Above";
            // 
            // pasteBelowToolStripMenuItem
            // 
            this.pasteBelowToolStripMenuItem.Name = "pasteBelowToolStripMenuItem";
            this.pasteBelowToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pasteBelowToolStripMenuItem.Text = "Paste Below";
            // 
            // pasteToBottomToolStripMenuItem
            // 
            this.pasteToBottomToolStripMenuItem.Name = "pasteToBottomToolStripMenuItem";
            this.pasteToBottomToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pasteToBottomToolStripMenuItem.Text = "Paste to Bottom";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(205, 6);
            // 
            // moveItemToTop_btn
            // 
            this.moveItemToTop_btn.Name = "moveItemToTop_btn";
            this.moveItemToTop_btn.Size = new System.Drawing.Size(208, 22);
            this.moveItemToTop_btn.Text = "Move Item to Top";
            // 
            // moveItemUpToolStripMenuItem
            // 
            this.moveItemUpToolStripMenuItem.Name = "moveItemUpToolStripMenuItem";
            this.moveItemUpToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.moveItemUpToolStripMenuItem.Text = "Move Item Up";
            // 
            // moveItemDownToolStripMenuItem
            // 
            this.moveItemDownToolStripMenuItem.Name = "moveItemDownToolStripMenuItem";
            this.moveItemDownToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.moveItemDownToolStripMenuItem.Text = "Move Item Down";
            // 
            // moveItemToBottomToolStripMenuItem
            // 
            this.moveItemToBottomToolStripMenuItem.Name = "moveItemToBottomToolStripMenuItem";
            this.moveItemToBottomToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.moveItemToBottomToolStripMenuItem.Text = "Move Item to Bottom";
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
            this.menuStrip4.Size = new System.Drawing.Size(1279, 24);
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
            this.currentItemToTop_btn,
            this.moveCurrentItemUpToolStripMenuItem,
            this.moveCurrentItemDownToolStripMenuItem,
            this.currentItemToBottom_btn,
            this.toolStripSeparator8,
            this.addNewItemToolStripMenuItem,
            this.addNewChildItemToolStripMenuItem1,
            this.editCurrentItemToolStripMenuItem,
            this.deleteCurrentItemToolStripMenuItem1,
            this.toolStripSeparator5,
            this.duplicateToTop_btn,
            this.duplicateToBottomMenuItem,
            this.toolStripSeparator14,
            this.copyCurrentItemToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(248, 6);
            // 
            // toggleAllItemsCompletedToolStripMenuItem
            // 
            this.toggleAllItemsCompletedToolStripMenuItem.Name = "toggleAllItemsCompletedToolStripMenuItem";
            this.toggleAllItemsCompletedToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.toggleAllItemsCompletedToolStripMenuItem.Text = "Mark All Items Completed";
            // 
            // markAllItemsIncompleteToolStripMenuItem
            // 
            this.markAllItemsIncompleteToolStripMenuItem.Name = "markAllItemsIncompleteToolStripMenuItem";
            this.markAllItemsIncompleteToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.markAllItemsIncompleteToolStripMenuItem.Text = "Mark All Items Incomplete";
            // 
            // toggleItemStateToolStripMenuItem
            // 
            this.toggleItemStateToolStripMenuItem.Name = "toggleItemStateToolStripMenuItem";
            this.toggleItemStateToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.toggleItemStateToolStripMenuItem.Text = "Toggle All Items State";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(248, 6);
            // 
            // currentItemToTop_btn
            // 
            this.currentItemToTop_btn.Name = "currentItemToTop_btn";
            this.currentItemToTop_btn.Size = new System.Drawing.Size(251, 22);
            this.currentItemToTop_btn.Text = "Move Current Item to Top";
            // 
            // moveCurrentItemUpToolStripMenuItem
            // 
            this.moveCurrentItemUpToolStripMenuItem.Name = "moveCurrentItemUpToolStripMenuItem";
            this.moveCurrentItemUpToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.moveCurrentItemUpToolStripMenuItem.Text = "Move Current Item Up";
            // 
            // moveCurrentItemDownToolStripMenuItem
            // 
            this.moveCurrentItemDownToolStripMenuItem.Name = "moveCurrentItemDownToolStripMenuItem";
            this.moveCurrentItemDownToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.moveCurrentItemDownToolStripMenuItem.Text = "Move Current Item Down";
            // 
            // currentItemToBottom_btn
            // 
            this.currentItemToBottom_btn.Name = "currentItemToBottom_btn";
            this.currentItemToBottom_btn.Size = new System.Drawing.Size(251, 22);
            this.currentItemToBottom_btn.Text = "Move Current Item to Bottom";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(248, 6);
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addNewItemToolStripMenuItem.Text = "Add New Item";
            // 
            // addNewChildItemToolStripMenuItem1
            // 
            this.addNewChildItemToolStripMenuItem1.Name = "addNewChildItemToolStripMenuItem1";
            this.addNewChildItemToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.addNewChildItemToolStripMenuItem1.Text = "Add New Child Item";
            // 
            // editCurrentItemToolStripMenuItem
            // 
            this.editCurrentItemToolStripMenuItem.Name = "editCurrentItemToolStripMenuItem";
            this.editCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.editCurrentItemToolStripMenuItem.Text = "Edit Current Item";
            // 
            // deleteCurrentItemToolStripMenuItem1
            // 
            this.deleteCurrentItemToolStripMenuItem1.Name = "deleteCurrentItemToolStripMenuItem1";
            this.deleteCurrentItemToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.deleteCurrentItemToolStripMenuItem1.Text = "Delete Current Item";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(248, 6);
            // 
            // duplicateToTop_btn
            // 
            this.duplicateToTop_btn.Name = "duplicateToTop_btn";
            this.duplicateToTop_btn.Size = new System.Drawing.Size(251, 22);
            this.duplicateToTop_btn.Text = "Duplicate Current Item to Top";
            // 
            // duplicateToBottomMenuItem
            // 
            this.duplicateToBottomMenuItem.Name = "duplicateToBottomMenuItem";
            this.duplicateToBottomMenuItem.Size = new System.Drawing.Size(251, 22);
            this.duplicateToBottomMenuItem.Text = "Duplicate Current Item to Bottom";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(248, 6);
            // 
            // copyCurrentItemToolStripMenuItem
            // 
            this.copyCurrentItemToolStripMenuItem.Name = "copyCurrentItemToolStripMenuItem";
            this.copyCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.copyCurrentItemToolStripMenuItem.Text = "Copy Current Item";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToTopOfParentNodeToolStripMenuItem,
            this.pasteAboveCurrentItemToolStripMenuItem,
            this.pasteBelowCurrentItemToolStripMenuItem,
            this.pasteToBottomOfParentNodeToolStripMenuItem});
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.pasteToolStripMenuItem.Text = "Paste Item";
            // 
            // pasteToTopOfParentNodeToolStripMenuItem
            // 
            this.pasteToTopOfParentNodeToolStripMenuItem.Name = "pasteToTopOfParentNodeToolStripMenuItem";
            this.pasteToTopOfParentNodeToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.pasteToTopOfParentNodeToolStripMenuItem.Text = "Paste to Top of Parent Item";
            // 
            // pasteAboveCurrentItemToolStripMenuItem
            // 
            this.pasteAboveCurrentItemToolStripMenuItem.Name = "pasteAboveCurrentItemToolStripMenuItem";
            this.pasteAboveCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.pasteAboveCurrentItemToolStripMenuItem.Text = "Paste Above Current Item";
            // 
            // pasteBelowCurrentItemToolStripMenuItem
            // 
            this.pasteBelowCurrentItemToolStripMenuItem.Name = "pasteBelowCurrentItemToolStripMenuItem";
            this.pasteBelowCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.pasteBelowCurrentItemToolStripMenuItem.Text = "Paste Below Current Item";
            // 
            // pasteToBottomOfParentNodeToolStripMenuItem
            // 
            this.pasteToBottomOfParentNodeToolStripMenuItem.Name = "pasteToBottomOfParentNodeToolStripMenuItem";
            this.pasteToBottomOfParentNodeToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.pasteToBottomOfParentNodeToolStripMenuItem.Text = "Paste to Bottom of Parent Item";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleToolStripMenuItem,
            this.toolStripSeparator2,
            this.toggleExpandAllItemsToolStripMenuItem,
            this.toolStripSeparator4,
            this.unselectCurrentSelectedItemToolStripMenuItem,
            this.toolStripSeparator15,
            this.fontToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toggleToolStripMenuItem
            // 
            this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            this.toggleToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.toggleToolStripMenuItem.Text = "Toggle Window on Top ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // toggleExpandAllItemsToolStripMenuItem
            // 
            this.toggleExpandAllItemsToolStripMenuItem.Name = "toggleExpandAllItemsToolStripMenuItem";
            this.toggleExpandAllItemsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.toggleExpandAllItemsToolStripMenuItem.Text = "Toggle Expand All Items";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(232, 6);
            // 
            // unselectCurrentSelectedItemToolStripMenuItem
            // 
            this.unselectCurrentSelectedItemToolStripMenuItem.Name = "unselectCurrentSelectedItemToolStripMenuItem";
            this.unselectCurrentSelectedItemToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.unselectCurrentSelectedItemToolStripMenuItem.Text = "Deselect Current Selected Item";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(232, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentFontSize,
            this.increaseFontSize,
            this.decreaseFontSize,
            this.toolStripSeparator18,
            this.checkedFontStyle,
            this.toggleBoldChecked,
            this.toggleItalicChecked,
            this.toggleStrikethroughChecked,
            this.toggleUnderlineChecked,
            this.toolStripSeparator19,
            this.regularFontStyle,
            this.toggleBold,
            this.toggleItalic,
            this.toggleStrikethrough,
            this.toggleUnderline});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // currentFontSize
            // 
            this.currentFontSize.Name = "currentFontSize";
            this.currentFontSize.Size = new System.Drawing.Size(218, 22);
            this.currentFontSize.Text = "Current Font Size: 10";
            // 
            // increaseFontSize
            // 
            this.increaseFontSize.Name = "increaseFontSize";
            this.increaseFontSize.Size = new System.Drawing.Size(218, 22);
            this.increaseFontSize.Text = "Increase Font Size";
            // 
            // decreaseFontSize
            // 
            this.decreaseFontSize.Name = "decreaseFontSize";
            this.decreaseFontSize.Size = new System.Drawing.Size(218, 22);
            this.decreaseFontSize.Text = "Decrease Font Size";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(215, 6);
            // 
            // checkedFontStyle
            // 
            this.checkedFontStyle.Name = "checkedFontStyle";
            this.checkedFontStyle.Size = new System.Drawing.Size(218, 22);
            this.checkedFontStyle.Text = "Checked Font Style Toggles";
            // 
            // toggleBoldChecked
            // 
            this.toggleBoldChecked.Name = "toggleBoldChecked";
            this.toggleBoldChecked.Size = new System.Drawing.Size(218, 22);
            this.toggleBoldChecked.Text = "Toggle Bold";
            // 
            // toggleItalicChecked
            // 
            this.toggleItalicChecked.Name = "toggleItalicChecked";
            this.toggleItalicChecked.Size = new System.Drawing.Size(218, 22);
            this.toggleItalicChecked.Text = "Toggle Italic";
            // 
            // toggleStrikethroughChecked
            // 
            this.toggleStrikethroughChecked.Name = "toggleStrikethroughChecked";
            this.toggleStrikethroughChecked.Size = new System.Drawing.Size(218, 22);
            this.toggleStrikethroughChecked.Text = "Toggle Strikeout";
            // 
            // toggleUnderlineChecked
            // 
            this.toggleUnderlineChecked.Name = "toggleUnderlineChecked";
            this.toggleUnderlineChecked.Size = new System.Drawing.Size(218, 22);
            this.toggleUnderlineChecked.Text = "Toggle Underline";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(215, 6);
            // 
            // regularFontStyle
            // 
            this.regularFontStyle.Name = "regularFontStyle";
            this.regularFontStyle.Size = new System.Drawing.Size(218, 22);
            this.regularFontStyle.Text = "Regular Font Style Toggles";
            // 
            // toggleBold
            // 
            this.toggleBold.Name = "toggleBold";
            this.toggleBold.Size = new System.Drawing.Size(218, 22);
            this.toggleBold.Text = "Toggle Bold";
            // 
            // toggleItalic
            // 
            this.toggleItalic.Name = "toggleItalic";
            this.toggleItalic.Size = new System.Drawing.Size(218, 22);
            this.toggleItalic.Text = "Toggle Italic";
            // 
            // toggleStrikethrough
            // 
            this.toggleStrikethrough.Name = "toggleStrikethrough";
            this.toggleStrikethrough.Size = new System.Drawing.Size(218, 22);
            this.toggleStrikethrough.Text = "Toggle Strikeout";
            // 
            // toggleUnderline
            // 
            this.toggleUnderline.Name = "toggleUnderline";
            this.toggleUnderline.Size = new System.Drawing.Size(218, 22);
            this.toggleUnderline.Text = "Toggle Underline";
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
            this.toTop_btn,
            this.moveItemUpMainStrip,
            this.moveItemDownMainStrip,
            this.toBottom_btn,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem1,
            this.duplicateToolStripMenuItem,
            this.unselectCurrentItemToolStripMenuItem,
            this.toggleExpandAllItemsToolStripMenuItem1});
            this.menuStrip3.Location = new System.Drawing.Point(0, 24);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1279, 27);
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
            // toTop_btn
            // 
            this.toTop_btn.Name = "toTop_btn";
            this.toTop_btn.Size = new System.Drawing.Size(39, 23);
            this.toTop_btn.Text = "/\\/\\";
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
            // toBottom_btn
            // 
            this.toBottom_btn.Name = "toBottom_btn";
            this.toBottom_btn.Size = new System.Drawing.Size(39, 23);
            this.toBottom_btn.Text = "\\/\\/";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToTopToolStripMenuItem,
            this.pasteAboveToolStripMenuItem1,
            this.pasteBelowToolStripMenuItem1,
            this.pasteToBottomToolStripMenuItem1});
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(47, 23);
            this.pasteToolStripMenuItem1.Text = "Paste";
            // 
            // pasteToTopToolStripMenuItem
            // 
            this.pasteToTopToolStripMenuItem.Name = "pasteToTopToolStripMenuItem";
            this.pasteToTopToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pasteToTopToolStripMenuItem.Text = "Paste to Top";
            // 
            // pasteAboveToolStripMenuItem1
            // 
            this.pasteAboveToolStripMenuItem1.Name = "pasteAboveToolStripMenuItem1";
            this.pasteAboveToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.pasteAboveToolStripMenuItem1.Text = "Paste Above";
            // 
            // pasteBelowToolStripMenuItem1
            // 
            this.pasteBelowToolStripMenuItem1.Name = "pasteBelowToolStripMenuItem1";
            this.pasteBelowToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.pasteBelowToolStripMenuItem1.Text = "Paste Below";
            // 
            // pasteToBottomToolStripMenuItem1
            // 
            this.pasteToBottomToolStripMenuItem1.Name = "pasteToBottomToolStripMenuItem1";
            this.pasteToBottomToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.pasteToBottomToolStripMenuItem1.Text = "Paste to Bottom";
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateToTopToolStripMenuItem,
            this.duplicateToBottomToolStripMenuItem});
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            // 
            // unselectCurrentItemToolStripMenuItem
            // 
            this.unselectCurrentItemToolStripMenuItem.Name = "unselectCurrentItemToolStripMenuItem";
            this.unselectCurrentItemToolStripMenuItem.Size = new System.Drawing.Size(133, 23);
            this.unselectCurrentItemToolStripMenuItem.Text = "Deselect Current Item";
            // 
            // toggleExpandAllItemsToolStripMenuItem1
            // 
            this.toggleExpandAllItemsToolStripMenuItem1.Name = "toggleExpandAllItemsToolStripMenuItem1";
            this.toggleExpandAllItemsToolStripMenuItem1.Size = new System.Drawing.Size(145, 23);
            this.toggleExpandAllItemsToolStripMenuItem1.Text = "Toggle Expand All Items";
            // 
            // todolist_lst
            // 
            this.todolist_lst.ContextMenuStrip = this.contextMenu;
            this.todolist_lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todolist_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todolist_lst.ImageIndex = 1;
            this.todolist_lst.Location = new System.Drawing.Point(0, 0);
            this.todolist_lst.Name = "todolist_lst";
            this.todolist_lst.SelectedImageIndex = 1;
            this.todolist_lst.ShowRootLines = false;
            this.todolist_lst.Size = new System.Drawing.Size(1279, 702);
            this.todolist_lst.TabIndex = 2;
            // 
            // duplicateToTopToolStripMenuItem
            // 
            this.duplicateToTopToolStripMenuItem.Name = "duplicateToTopToolStripMenuItem";
            this.duplicateToTopToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.duplicateToTopToolStripMenuItem.Text = "Duplicate to Top";
            // 
            // duplicateToBottomToolStripMenuItem
            // 
            this.duplicateToBottomToolStripMenuItem.Name = "duplicateToBottomToolStripMenuItem";
            this.duplicateToBottomToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.duplicateToBottomToolStripMenuItem.Text = "Duplicate to Bottom";
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 778);
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
        private ToolStripMenuItem duplicateToBottomMenuItem;
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
        private ToolStripMenuItem unselectCurrentItemToolStripMenuItem;
        private ToolStripMenuItem toggleExpandAllItemsToolStripMenuItem1;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem addChildItemToolStripMenuItem;
        private ToolStripMenuItem duplicateToBottomContextMenuItem;
        private ToolStripMenuItem editItemToolStripMenuItem;
        private ToolStripMenuItem deleteItemToolStripMenuItem;
        private ToolStripMenuItem moveItemUpToolStripMenuItem;
        private ToolStripMenuItem moveItemDownToolStripMenuItem;
        private ToolStripMenuItem moveItemToTop_btn;
        private ToolStripMenuItem moveItemToBottomToolStripMenuItem;
        private ToolStripMenuItem currentItemToTop_btn;
        private ToolStripMenuItem currentItemToBottom_btn;
        private ToolStripMenuItem toTop_btn;
        private ToolStripMenuItem toBottom_btn;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem duplicateItemToTop_btn;
        private ToolStripMenuItem duplicateToTop_btn;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem copyItem;
        private ToolStripMenuItem paste_btn;
        private ToolStripMenuItem pasteToTopOfParentToolStripMenuItem;
        private ToolStripMenuItem pasteAboveToolStripMenuItem;
        private ToolStripMenuItem pasteBelowToolStripMenuItem;
        private ToolStripMenuItem pasteToBottomToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem copyCurrentItemToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem pasteToTopOfParentNodeToolStripMenuItem;
        private ToolStripMenuItem pasteAboveCurrentItemToolStripMenuItem;
        private ToolStripMenuItem pasteBelowCurrentItemToolStripMenuItem;
        private ToolStripMenuItem pasteToBottomOfParentNodeToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripMenuItem pasteToTopToolStripMenuItem;
        private ToolStripMenuItem pasteAboveToolStripMenuItem1;
        private ToolStripMenuItem pasteBelowToolStripMenuItem1;
        private ToolStripMenuItem pasteToBottomToolStripMenuItem1;
        private ToolStripMenuItem duplicateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem currentFontSize;
        private ToolStripMenuItem increaseFontSize;
        private ToolStripMenuItem decreaseFontSize;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripMenuItem checkedFontStyle;
        private ToolStripMenuItem toggleBoldChecked;
        private ToolStripMenuItem toggleItalicChecked;
        private ToolStripMenuItem toggleStrikethroughChecked;
        private ToolStripMenuItem toggleUnderlineChecked;
        private ToolStripSeparator toolStripSeparator19;
        private ToolStripMenuItem regularFontStyle;
        private ToolStripMenuItem toggleBold;
        private ToolStripMenuItem toggleItalic;
        private ToolStripMenuItem toggleStrikethrough;
        private ToolStripMenuItem toggleUnderline;
        private ToolStripMenuItem duplicateToTopToolStripMenuItem;
        private ToolStripMenuItem duplicateToBottomToolStripMenuItem;
    }
}

