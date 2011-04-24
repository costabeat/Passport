namespace Passport
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Пароли");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.passTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PutValueButton = new System.Windows.Forms.ToolStripButton();
            this.ShowValueButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.SettingsButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.locationStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolbarImages = new System.Windows.Forms.ImageList(this.components);
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditionToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AddToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьМастерпарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // passTree
            // 
            this.passTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passTree.ImageIndex = 0;
            this.passTree.ImageList = this.imageList1;
            this.passTree.Indent = 19;
            this.passTree.Location = new System.Drawing.Point(0, 63);
            this.passTree.Name = "passTree";
            treeNode1.Name = "rootNode";
            treeNode1.Text = "Пароли";
            this.passTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.passTree.PathSeparator = " - ";
            this.passTree.SelectedImageIndex = 0;
            this.passTree.Size = new System.Drawing.Size(325, 362);
            this.passTree.TabIndex = 0;
            this.passTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.PassTreeAfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "encrypted.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            this.imageList1.Images.SetKeyName(2, "directory_listing.png");
            this.imageList1.Images.SetKeyName(3, "password.png");
            this.imageList1.Images.SetKeyName(4, "identity.png");
            this.imageList1.Images.SetKeyName(5, "irc_normal.png");
            this.imageList1.Images.SetKeyName(6, "jabber_away.png");
            this.imageList1.Images.SetKeyName(7, "dayview.png");
            this.imageList1.Images.SetKeyName(8, "pda alt.png");
            this.imageList1.Images.SetKeyName(9, "mail_generic.png");
            this.imageList1.Images.SetKeyName(10, "icq_online.png");
            this.imageList1.Images.SetKeyName(11, "skype.png");
            this.imageList1.Images.SetKeyName(12, "jabber_protocol.png");
            this.imageList1.Images.SetKeyName(13, "important.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PutValueButton,
            this.ShowValueButton,
            this.toolStripSeparator2,
            this.AddButton,
            this.DeleteButton,
            this.EditButton,
            this.toolStripSeparator1,
            this.SaveButton,
            this.SettingsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(325, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PutValueButton
            // 
            this.PutValueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PutValueButton.Image = ((System.Drawing.Image)(resources.GetObject("PutValueButton.Image")));
            this.PutValueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PutValueButton.Name = "PutValueButton";
            this.PutValueButton.Size = new System.Drawing.Size(36, 36);
            this.PutValueButton.Text = "Копировать в буфер обмена";
            this.PutValueButton.Click += new System.EventHandler(this.PutValueButtonClick);
            // 
            // ShowValueButton
            // 
            this.ShowValueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowValueButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowValueButton.Image")));
            this.ShowValueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowValueButton.Name = "ShowValueButton";
            this.ShowValueButton.Size = new System.Drawing.Size(36, 36);
            this.ShowValueButton.Text = "Показать значение";
            this.ShowValueButton.Click += new System.EventHandler(this.ShowValueButtonClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(36, 36);
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(36, 36);
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(36, 36);
            this.EditButton.Text = "Редактировать";
            this.EditButton.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(36, 36);
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // SettingsButton
            // 
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(36, 36);
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.Click += new System.EventHandler(SettingsButtonClick);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationStrip,
            this.timerStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 425);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(325, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // locationStrip
            // 
            this.locationStrip.Name = "locationStrip";
            this.locationStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // timerStrip
            // 
            this.timerStrip.Name = "timerStrip";
            this.timerStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // toolbarImages
            // 
            this.toolbarImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.toolbarImages.ImageSize = new System.Drawing.Size(32, 32);
            this.toolbarImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimerTick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolItem,
            this.EditionToolItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(325, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolItem
            // 
            this.FileToolItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьМастерпарольToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolItem});
            this.FileToolItem.Name = "FileToolItem";
            this.FileToolItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolItem.Text = "Файл";
            // 
            // EditionToolItem
            // 
            this.EditionToolItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolItem,
            this.DeleteToolItem,
            this.EditToolItem});
            this.EditionToolItem.Name = "EditionToolItem";
            this.EditionToolItem.Size = new System.Drawing.Size(108, 20);
            this.EditionToolItem.Text = "Редактирование";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Controls.Add(this.passTree);
            this.MainPanel.Controls.Add(this.toolStrip1);
            this.MainPanel.Controls.Add(this.menuStrip1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(325, 425);
            this.MainPanel.TabIndex = 2;
            // 
            // AddToolItem
            // 
            this.AddToolItem.Name = "AddToolItem";
            this.AddToolItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.AddToolItem.Size = new System.Drawing.Size(173, 22);
            this.AddToolItem.Text = "Добавить";
            // 
            // DeleteToolItem
            // 
            this.DeleteToolItem.Name = "DeleteToolItem";
            this.DeleteToolItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolItem.Size = new System.Drawing.Size(173, 22);
            this.DeleteToolItem.Text = "Удалить";
            // 
            // EditToolItem
            // 
            this.EditToolItem.Name = "EditToolItem";
            this.EditToolItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.EditToolItem.Size = new System.Drawing.Size(173, 22);
            this.EditToolItem.Text = "Редактировать";
            // 
            // изменитьМастерпарольToolStripMenuItem
            // 
            this.изменитьМастерпарольToolStripMenuItem.Name = "изменитьМастерпарольToolStripMenuItem";
            this.изменитьМастерпарольToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.изменитьМастерпарольToolStripMenuItem.Text = "Изменить мастер-пароль...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // ExitToolItem
            // 
            this.ExitToolItem.Name = "ExitToolItem";
            this.ExitToolItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ExitToolItem.Size = new System.Drawing.Size(224, 22);
            this.ExitToolItem.Text = "Выход";
            this.ExitToolItem.Click += new System.EventHandler(ExitToolItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 447);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Passport";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView passTree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton PutValueButton;
        private System.Windows.Forms.ToolStripButton ShowValueButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ImageList toolbarImages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel locationStrip;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SettingsButton;
        private System.Windows.Forms.ToolStripStatusLabel timerStrip;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolItem;
        private System.Windows.Forms.ToolStripMenuItem EditionToolItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem AddToolItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьМастерпарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolItem;
    }
}

