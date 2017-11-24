namespace WorkshopPublisherForm
{
    partial class Form1
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
            this.grpboxMode = new System.Windows.Forms.GroupBox();
            this.rdbtnExtract = new System.Windows.Forms.RadioButton();
            this.rdbtnUpdate = new System.Windows.Forms.RadioButton();
            this.rdbtnGMA = new System.Windows.Forms.RadioButton();
            this.rdbtnCreate = new System.Windows.Forms.RadioButton();
            this.grpboxApplyingMode = new System.Windows.Forms.GroupBox();
            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.grpboxExtract = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFolderExtract = new System.Windows.Forms.Button();
            this.texbExtractOutput = new System.Windows.Forms.TextBox();
            this.btnFileExtract = new System.Windows.Forms.Button();
            this.texbFileExtract = new System.Windows.Forms.TextBox();
            this.lblFileExtract = new System.Windows.Forms.Label();
            this.btnSelectGMAOutput = new System.Windows.Forms.Button();
            this.texbGMAOutput = new System.Windows.Forms.TextBox();
            this.lblGMAOutput = new System.Windows.Forms.Label();
            this.texbChanges = new System.Windows.Forms.TextBox();
            this.lblChanges = new System.Windows.Forms.Label();
            this.grpboxIconPreview = new System.Windows.Forms.GroupBox();
            this.picBoxIconPreview = new System.Windows.Forms.PictureBox();
            this.grpboxAddonjson = new System.Windows.Forms.GroupBox();
            this.texbIgnore = new System.Windows.Forms.TextBox();
            this.lblIgnore = new System.Windows.Forms.Label();
            this.grpboxTags = new System.Windows.Forms.GroupBox();
            this.chkboxBuild = new System.Windows.Forms.CheckBox();
            this.chkboxComic = new System.Windows.Forms.CheckBox();
            this.chkboxWater = new System.Windows.Forms.CheckBox();
            this.chkboxCartoon = new System.Windows.Forms.CheckBox();
            this.chkboxRealism = new System.Windows.Forms.CheckBox();
            this.chkboxMovie = new System.Windows.Forms.CheckBox();
            this.chkboxScenic = new System.Windows.Forms.CheckBox();
            this.chkboxRoleplay = new System.Windows.Forms.CheckBox();
            this.chkboxFun = new System.Windows.Forms.CheckBox();
            this.grpboxType = new System.Windows.Forms.GroupBox();
            this.rdbtnServerContent = new System.Windows.Forms.RadioButton();
            this.rdbtnModel = new System.Windows.Forms.RadioButton();
            this.rdbtnEffects = new System.Windows.Forms.RadioButton();
            this.rdbtnTool = new System.Windows.Forms.RadioButton();
            this.rdbtnNPC = new System.Windows.Forms.RadioButton();
            this.rdbtnVehicle = new System.Windows.Forms.RadioButton();
            this.rdbtnWeapon = new System.Windows.Forms.RadioButton();
            this.rdbtnMap = new System.Windows.Forms.RadioButton();
            this.rdbtnGamemode = new System.Windows.Forms.RadioButton();
            this.texbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUploadIcon = new System.Windows.Forms.Button();
            this.lblIcon = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.texbFileorFolder = new System.Windows.Forms.TextBox();
            this.lblFileorFolder = new System.Windows.Forms.Label();
            this.grpboxAddonList = new System.Windows.Forms.GroupBox();
            this.dgvAddonsList = new System.Windows.Forms.DataGridView();
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.grpboxQueue = new System.Windows.Forms.GroupBox();
            this.btnQueueExecute = new System.Windows.Forms.Button();
            this.btnQueueClear = new System.Windows.Forms.Button();
            this.grpboxLog = new System.Windows.Forms.GroupBox();
            this.texbLog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpboxMode.SuspendLayout();
            this.grpboxApplyingMode.SuspendLayout();
            this.grpboxExtract.SuspendLayout();
            this.grpboxIconPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconPreview)).BeginInit();
            this.grpboxAddonjson.SuspendLayout();
            this.grpboxTags.SuspendLayout();
            this.grpboxType.SuspendLayout();
            this.grpboxAddonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddonsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.grpboxQueue.SuspendLayout();
            this.grpboxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxMode
            // 
            this.grpboxMode.Controls.Add(this.rdbtnExtract);
            this.grpboxMode.Controls.Add(this.rdbtnUpdate);
            this.grpboxMode.Controls.Add(this.rdbtnGMA);
            this.grpboxMode.Controls.Add(this.rdbtnCreate);
            this.grpboxMode.Location = new System.Drawing.Point(12, 12);
            this.grpboxMode.Name = "grpboxMode";
            this.grpboxMode.Size = new System.Drawing.Size(302, 65);
            this.grpboxMode.TabIndex = 1;
            this.grpboxMode.TabStop = false;
            this.grpboxMode.Text = "Mode";
            this.grpboxMode.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbtnExtract
            // 
            this.rdbtnExtract.AutoSize = true;
            this.rdbtnExtract.Location = new System.Drawing.Point(227, 20);
            this.rdbtnExtract.Name = "rdbtnExtract";
            this.rdbtnExtract.Size = new System.Drawing.Size(58, 17);
            this.rdbtnExtract.TabIndex = 3;
            this.rdbtnExtract.Text = "Extract";
            this.rdbtnExtract.UseVisualStyleBackColor = true;
            this.rdbtnExtract.CheckedChanged += new System.EventHandler(this.rdbtnExtract_CheckedChanged);
            // 
            // rdbtnUpdate
            // 
            this.rdbtnUpdate.AutoSize = true;
            this.rdbtnUpdate.Location = new System.Drawing.Point(160, 20);
            this.rdbtnUpdate.Name = "rdbtnUpdate";
            this.rdbtnUpdate.Size = new System.Drawing.Size(60, 17);
            this.rdbtnUpdate.TabIndex = 2;
            this.rdbtnUpdate.Text = "Update";
            this.rdbtnUpdate.UseVisualStyleBackColor = true;
            this.rdbtnUpdate.CheckedChanged += new System.EventHandler(this.rdbtnUpdate_CheckedChanged);
            // 
            // rdbtnGMA
            // 
            this.rdbtnGMA.AutoSize = true;
            this.rdbtnGMA.Location = new System.Drawing.Point(70, 20);
            this.rdbtnGMA.Name = "rdbtnGMA";
            this.rdbtnGMA.Size = new System.Drawing.Size(83, 17);
            this.rdbtnGMA.TabIndex = 1;
            this.rdbtnGMA.Text = "Create GMA";
            this.rdbtnGMA.UseVisualStyleBackColor = true;
            this.rdbtnGMA.CheckedChanged += new System.EventHandler(this.rdbtnGMA_CheckedChanged);
            // 
            // rdbtnCreate
            // 
            this.rdbtnCreate.AutoSize = true;
            this.rdbtnCreate.Checked = true;
            this.rdbtnCreate.Location = new System.Drawing.Point(7, 20);
            this.rdbtnCreate.Name = "rdbtnCreate";
            this.rdbtnCreate.Size = new System.Drawing.Size(56, 17);
            this.rdbtnCreate.TabIndex = 0;
            this.rdbtnCreate.TabStop = true;
            this.rdbtnCreate.Text = "Create";
            this.rdbtnCreate.UseVisualStyleBackColor = true;
            this.rdbtnCreate.CheckedChanged += new System.EventHandler(this.rdbtnCreate_CheckedChanged);
            // 
            // grpboxApplyingMode
            // 
            this.grpboxApplyingMode.Controls.Add(this.btnAddToQueue);
            this.grpboxApplyingMode.Controls.Add(this.grpboxExtract);
            this.grpboxApplyingMode.Controls.Add(this.btnSelectGMAOutput);
            this.grpboxApplyingMode.Controls.Add(this.texbGMAOutput);
            this.grpboxApplyingMode.Controls.Add(this.lblGMAOutput);
            this.grpboxApplyingMode.Controls.Add(this.texbChanges);
            this.grpboxApplyingMode.Controls.Add(this.lblChanges);
            this.grpboxApplyingMode.Controls.Add(this.grpboxIconPreview);
            this.grpboxApplyingMode.Controls.Add(this.grpboxAddonjson);
            this.grpboxApplyingMode.Controls.Add(this.btnUploadIcon);
            this.grpboxApplyingMode.Controls.Add(this.lblIcon);
            this.grpboxApplyingMode.Controls.Add(this.btnFolder);
            this.grpboxApplyingMode.Controls.Add(this.btnFile);
            this.grpboxApplyingMode.Controls.Add(this.texbFileorFolder);
            this.grpboxApplyingMode.Controls.Add(this.lblFileorFolder);
            this.grpboxApplyingMode.Controls.Add(this.grpboxAddonList);
            this.grpboxApplyingMode.Location = new System.Drawing.Point(12, 84);
            this.grpboxApplyingMode.Name = "grpboxApplyingMode";
            this.grpboxApplyingMode.Size = new System.Drawing.Size(542, 625);
            this.grpboxApplyingMode.TabIndex = 2;
            this.grpboxApplyingMode.TabStop = false;
            this.grpboxApplyingMode.Text = "Create\\Create GMA\\Update\\Extract";
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.Location = new System.Drawing.Point(420, 594);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(101, 23);
            this.btnAddToQueue.TabIndex = 16;
            this.btnAddToQueue.Text = "Add to Queue";
            this.btnAddToQueue.UseVisualStyleBackColor = true;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);
            // 
            // grpboxExtract
            // 
            this.grpboxExtract.Controls.Add(this.label1);
            this.grpboxExtract.Controls.Add(this.btnFolderExtract);
            this.grpboxExtract.Controls.Add(this.texbExtractOutput);
            this.grpboxExtract.Controls.Add(this.btnFileExtract);
            this.grpboxExtract.Controls.Add(this.texbFileExtract);
            this.grpboxExtract.Controls.Add(this.lblFileExtract);
            this.grpboxExtract.Location = new System.Drawing.Point(7, 509);
            this.grpboxExtract.Name = "grpboxExtract";
            this.grpboxExtract.Size = new System.Drawing.Size(529, 79);
            this.grpboxExtract.TabIndex = 15;
            this.grpboxExtract.TabStop = false;
            this.grpboxExtract.Text = "Extract";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output:";
            // 
            // btnFolderExtract
            // 
            this.btnFolderExtract.Location = new System.Drawing.Point(448, 49);
            this.btnFolderExtract.Name = "btnFolderExtract";
            this.btnFolderExtract.Size = new System.Drawing.Size(75, 23);
            this.btnFolderExtract.TabIndex = 5;
            this.btnFolderExtract.Text = "Folder";
            this.btnFolderExtract.UseVisualStyleBackColor = true;
            this.btnFolderExtract.Click += new System.EventHandler(this.btnFolderExtract_Click);
            // 
            // texbExtractOutput
            // 
            this.texbExtractOutput.Location = new System.Drawing.Point(56, 46);
            this.texbExtractOutput.Name = "texbExtractOutput";
            this.texbExtractOutput.Size = new System.Drawing.Size(385, 20);
            this.texbExtractOutput.TabIndex = 4;
            // 
            // btnFileExtract
            // 
            this.btnFileExtract.Location = new System.Drawing.Point(447, 19);
            this.btnFileExtract.Name = "btnFileExtract";
            this.btnFileExtract.Size = new System.Drawing.Size(75, 23);
            this.btnFileExtract.TabIndex = 2;
            this.btnFileExtract.Text = "File";
            this.btnFileExtract.UseVisualStyleBackColor = true;
            this.btnFileExtract.Click += new System.EventHandler(this.btnFileExtract_Click);
            // 
            // texbFileExtract
            // 
            this.texbFileExtract.Location = new System.Drawing.Point(40, 20);
            this.texbFileExtract.Name = "texbFileExtract";
            this.texbFileExtract.Size = new System.Drawing.Size(401, 20);
            this.texbFileExtract.TabIndex = 1;
            // 
            // lblFileExtract
            // 
            this.lblFileExtract.AutoSize = true;
            this.lblFileExtract.Location = new System.Drawing.Point(7, 20);
            this.lblFileExtract.Name = "lblFileExtract";
            this.lblFileExtract.Size = new System.Drawing.Size(26, 13);
            this.lblFileExtract.TabIndex = 0;
            this.lblFileExtract.Text = "File:";
            // 
            // btnSelectGMAOutput
            // 
            this.btnSelectGMAOutput.Location = new System.Drawing.Point(455, 478);
            this.btnSelectGMAOutput.Name = "btnSelectGMAOutput";
            this.btnSelectGMAOutput.Size = new System.Drawing.Size(75, 23);
            this.btnSelectGMAOutput.TabIndex = 14;
            this.btnSelectGMAOutput.Text = "Select";
            this.btnSelectGMAOutput.UseVisualStyleBackColor = true;
            this.btnSelectGMAOutput.Click += new System.EventHandler(this.btnSelectGMAOutput_Click);
            // 
            // texbGMAOutput
            // 
            this.texbGMAOutput.Location = new System.Drawing.Point(83, 478);
            this.texbGMAOutput.Name = "texbGMAOutput";
            this.texbGMAOutput.Size = new System.Drawing.Size(365, 20);
            this.texbGMAOutput.TabIndex = 13;
            // 
            // lblGMAOutput
            // 
            this.lblGMAOutput.AutoSize = true;
            this.lblGMAOutput.Location = new System.Drawing.Point(7, 478);
            this.lblGMAOutput.Name = "lblGMAOutput";
            this.lblGMAOutput.Size = new System.Drawing.Size(69, 13);
            this.lblGMAOutput.TabIndex = 12;
            this.lblGMAOutput.Text = "GMA Output:";
            // 
            // texbChanges
            // 
            this.texbChanges.Location = new System.Drawing.Point(65, 451);
            this.texbChanges.Name = "texbChanges";
            this.texbChanges.Size = new System.Drawing.Size(465, 20);
            this.texbChanges.TabIndex = 11;
            // 
            // lblChanges
            // 
            this.lblChanges.AutoSize = true;
            this.lblChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChanges.Location = new System.Drawing.Point(6, 451);
            this.lblChanges.Name = "lblChanges";
            this.lblChanges.Size = new System.Drawing.Size(52, 13);
            this.lblChanges.TabIndex = 10;
            this.lblChanges.Text = "Changes:";
            // 
            // grpboxIconPreview
            // 
            this.grpboxIconPreview.Controls.Add(this.picBoxIconPreview);
            this.grpboxIconPreview.Location = new System.Drawing.Point(387, 214);
            this.grpboxIconPreview.Name = "grpboxIconPreview";
            this.grpboxIconPreview.Size = new System.Drawing.Size(143, 155);
            this.grpboxIconPreview.TabIndex = 9;
            this.grpboxIconPreview.TabStop = false;
            this.grpboxIconPreview.Text = "Icon Preview";
            // 
            // picBoxIconPreview
            // 
            this.picBoxIconPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxIconPreview.Location = new System.Drawing.Point(3, 16);
            this.picBoxIconPreview.Name = "picBoxIconPreview";
            this.picBoxIconPreview.Size = new System.Drawing.Size(137, 136);
            this.picBoxIconPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxIconPreview.TabIndex = 0;
            this.picBoxIconPreview.TabStop = false;
            // 
            // grpboxAddonjson
            // 
            this.grpboxAddonjson.Controls.Add(this.texbIgnore);
            this.grpboxAddonjson.Controls.Add(this.lblIgnore);
            this.grpboxAddonjson.Controls.Add(this.grpboxTags);
            this.grpboxAddonjson.Controls.Add(this.grpboxType);
            this.grpboxAddonjson.Controls.Add(this.texbTitle);
            this.grpboxAddonjson.Controls.Add(this.lblTitle);
            this.grpboxAddonjson.Location = new System.Drawing.Point(7, 214);
            this.grpboxAddonjson.Name = "grpboxAddonjson";
            this.grpboxAddonjson.Size = new System.Drawing.Size(374, 234);
            this.grpboxAddonjson.TabIndex = 8;
            this.grpboxAddonjson.TabStop = false;
            this.grpboxAddonjson.Text = "Addon.json";
            // 
            // texbIgnore
            // 
            this.texbIgnore.Location = new System.Drawing.Point(56, 205);
            this.texbIgnore.Name = "texbIgnore";
            this.texbIgnore.Size = new System.Drawing.Size(304, 20);
            this.texbIgnore.TabIndex = 5;
            this.texbIgnore.Text = "\"*.psd\",\"*.vcproj\",\"*.svn*\"";
            // 
            // lblIgnore
            // 
            this.lblIgnore.AutoSize = true;
            this.lblIgnore.Location = new System.Drawing.Point(9, 205);
            this.lblIgnore.Name = "lblIgnore";
            this.lblIgnore.Size = new System.Drawing.Size(40, 13);
            this.lblIgnore.TabIndex = 4;
            this.lblIgnore.Text = "Ignore:";
            // 
            // grpboxTags
            // 
            this.grpboxTags.Controls.Add(this.chkboxBuild);
            this.grpboxTags.Controls.Add(this.chkboxComic);
            this.grpboxTags.Controls.Add(this.chkboxWater);
            this.grpboxTags.Controls.Add(this.chkboxCartoon);
            this.grpboxTags.Controls.Add(this.chkboxRealism);
            this.grpboxTags.Controls.Add(this.chkboxMovie);
            this.grpboxTags.Controls.Add(this.chkboxScenic);
            this.grpboxTags.Controls.Add(this.chkboxRoleplay);
            this.grpboxTags.Controls.Add(this.chkboxFun);
            this.grpboxTags.Location = new System.Drawing.Point(7, 120);
            this.grpboxTags.Name = "grpboxTags";
            this.grpboxTags.Size = new System.Drawing.Size(361, 78);
            this.grpboxTags.TabIndex = 3;
            this.grpboxTags.TabStop = false;
            this.grpboxTags.Text = "Tags";
            // 
            // chkboxBuild
            // 
            this.chkboxBuild.AutoSize = true;
            this.chkboxBuild.Location = new System.Drawing.Point(203, 44);
            this.chkboxBuild.Name = "chkboxBuild";
            this.chkboxBuild.Size = new System.Drawing.Size(49, 17);
            this.chkboxBuild.TabIndex = 8;
            this.chkboxBuild.Tag = "build";
            this.chkboxBuild.Text = "Build";
            this.chkboxBuild.UseVisualStyleBackColor = true;
            // 
            // chkboxComic
            // 
            this.chkboxComic.AutoSize = true;
            this.chkboxComic.Location = new System.Drawing.Point(141, 44);
            this.chkboxComic.Name = "chkboxComic";
            this.chkboxComic.Size = new System.Drawing.Size(55, 17);
            this.chkboxComic.TabIndex = 7;
            this.chkboxComic.Tag = "comic";
            this.chkboxComic.Text = "Comic";
            this.chkboxComic.UseVisualStyleBackColor = true;
            // 
            // chkboxWater
            // 
            this.chkboxWater.AutoSize = true;
            this.chkboxWater.Location = new System.Drawing.Point(79, 44);
            this.chkboxWater.Name = "chkboxWater";
            this.chkboxWater.Size = new System.Drawing.Size(55, 17);
            this.chkboxWater.TabIndex = 6;
            this.chkboxWater.Tag = "water";
            this.chkboxWater.Text = "Water";
            this.chkboxWater.UseVisualStyleBackColor = true;
            // 
            // chkboxCartoon
            // 
            this.chkboxCartoon.AutoSize = true;
            this.chkboxCartoon.Location = new System.Drawing.Point(9, 44);
            this.chkboxCartoon.Name = "chkboxCartoon";
            this.chkboxCartoon.Size = new System.Drawing.Size(63, 17);
            this.chkboxCartoon.TabIndex = 5;
            this.chkboxCartoon.Tag = "cartoon";
            this.chkboxCartoon.Text = "Cartoon";
            this.chkboxCartoon.UseVisualStyleBackColor = true;
            // 
            // chkboxRealism
            // 
            this.chkboxRealism.AutoSize = true;
            this.chkboxRealism.Location = new System.Drawing.Point(262, 20);
            this.chkboxRealism.Name = "chkboxRealism";
            this.chkboxRealism.Size = new System.Drawing.Size(63, 17);
            this.chkboxRealism.TabIndex = 4;
            this.chkboxRealism.Tag = "realism";
            this.chkboxRealism.Text = "Realism";
            this.chkboxRealism.UseVisualStyleBackColor = true;
            // 
            // chkboxMovie
            // 
            this.chkboxMovie.AutoSize = true;
            this.chkboxMovie.Location = new System.Drawing.Point(200, 20);
            this.chkboxMovie.Name = "chkboxMovie";
            this.chkboxMovie.Size = new System.Drawing.Size(55, 17);
            this.chkboxMovie.TabIndex = 3;
            this.chkboxMovie.Tag = "movie";
            this.chkboxMovie.Text = "Movie";
            this.chkboxMovie.UseVisualStyleBackColor = true;
            // 
            // chkboxScenic
            // 
            this.chkboxScenic.AutoSize = true;
            this.chkboxScenic.Location = new System.Drawing.Point(134, 20);
            this.chkboxScenic.Name = "chkboxScenic";
            this.chkboxScenic.Size = new System.Drawing.Size(59, 17);
            this.chkboxScenic.TabIndex = 2;
            this.chkboxScenic.Tag = "scenic";
            this.chkboxScenic.Text = "Scenic";
            this.chkboxScenic.UseVisualStyleBackColor = true;
            // 
            // chkboxRoleplay
            // 
            this.chkboxRoleplay.AutoSize = true;
            this.chkboxRoleplay.Location = new System.Drawing.Point(60, 20);
            this.chkboxRoleplay.Name = "chkboxRoleplay";
            this.chkboxRoleplay.Size = new System.Drawing.Size(67, 17);
            this.chkboxRoleplay.TabIndex = 1;
            this.chkboxRoleplay.Tag = "roleplay";
            this.chkboxRoleplay.Text = "Roleplay";
            this.chkboxRoleplay.UseVisualStyleBackColor = true;
            // 
            // chkboxFun
            // 
            this.chkboxFun.AutoSize = true;
            this.chkboxFun.Location = new System.Drawing.Point(9, 20);
            this.chkboxFun.Name = "chkboxFun";
            this.chkboxFun.Size = new System.Drawing.Size(44, 17);
            this.chkboxFun.TabIndex = 0;
            this.chkboxFun.Tag = "fun";
            this.chkboxFun.Text = "Fun";
            this.chkboxFun.UseVisualStyleBackColor = true;
            // 
            // grpboxType
            // 
            this.grpboxType.Controls.Add(this.rdbtnServerContent);
            this.grpboxType.Controls.Add(this.rdbtnModel);
            this.grpboxType.Controls.Add(this.rdbtnEffects);
            this.grpboxType.Controls.Add(this.rdbtnTool);
            this.grpboxType.Controls.Add(this.rdbtnNPC);
            this.grpboxType.Controls.Add(this.rdbtnVehicle);
            this.grpboxType.Controls.Add(this.rdbtnWeapon);
            this.grpboxType.Controls.Add(this.rdbtnMap);
            this.grpboxType.Controls.Add(this.rdbtnGamemode);
            this.grpboxType.Location = new System.Drawing.Point(9, 42);
            this.grpboxType.Name = "grpboxType";
            this.grpboxType.Size = new System.Drawing.Size(359, 71);
            this.grpboxType.TabIndex = 2;
            this.grpboxType.TabStop = false;
            this.grpboxType.Text = "Type";
            // 
            // rdbtnServerContent
            // 
            this.rdbtnServerContent.AutoSize = true;
            this.rdbtnServerContent.Location = new System.Drawing.Point(240, 44);
            this.rdbtnServerContent.Name = "rdbtnServerContent";
            this.rdbtnServerContent.Size = new System.Drawing.Size(93, 17);
            this.rdbtnServerContent.TabIndex = 8;
            this.rdbtnServerContent.TabStop = true;
            this.rdbtnServerContent.Tag = "ServerContent";
            this.rdbtnServerContent.Text = "ServerContent";
            this.rdbtnServerContent.UseVisualStyleBackColor = true;
            // 
            // rdbtnModel
            // 
            this.rdbtnModel.AutoSize = true;
            this.rdbtnModel.Location = new System.Drawing.Point(179, 44);
            this.rdbtnModel.Name = "rdbtnModel";
            this.rdbtnModel.Size = new System.Drawing.Size(54, 17);
            this.rdbtnModel.TabIndex = 7;
            this.rdbtnModel.TabStop = true;
            this.rdbtnModel.Tag = "model";
            this.rdbtnModel.Text = "Model";
            this.rdbtnModel.UseVisualStyleBackColor = true;
            // 
            // rdbtnEffects
            // 
            this.rdbtnEffects.AutoSize = true;
            this.rdbtnEffects.Location = new System.Drawing.Point(114, 44);
            this.rdbtnEffects.Name = "rdbtnEffects";
            this.rdbtnEffects.Size = new System.Drawing.Size(58, 17);
            this.rdbtnEffects.TabIndex = 6;
            this.rdbtnEffects.TabStop = true;
            this.rdbtnEffects.Tag = "effects";
            this.rdbtnEffects.Text = "Effects";
            this.rdbtnEffects.UseVisualStyleBackColor = true;
            // 
            // rdbtnTool
            // 
            this.rdbtnTool.AutoSize = true;
            this.rdbtnTool.Location = new System.Drawing.Point(61, 44);
            this.rdbtnTool.Name = "rdbtnTool";
            this.rdbtnTool.Size = new System.Drawing.Size(46, 17);
            this.rdbtnTool.TabIndex = 5;
            this.rdbtnTool.TabStop = true;
            this.rdbtnTool.Tag = "tool";
            this.rdbtnTool.Text = "Tool";
            this.rdbtnTool.UseVisualStyleBackColor = true;
            // 
            // rdbtnNPC
            // 
            this.rdbtnNPC.AutoSize = true;
            this.rdbtnNPC.Location = new System.Drawing.Point(7, 44);
            this.rdbtnNPC.Name = "rdbtnNPC";
            this.rdbtnNPC.Size = new System.Drawing.Size(47, 17);
            this.rdbtnNPC.TabIndex = 4;
            this.rdbtnNPC.TabStop = true;
            this.rdbtnNPC.Tag = "npc";
            this.rdbtnNPC.Text = "NPC";
            this.rdbtnNPC.UseVisualStyleBackColor = true;
            // 
            // rdbtnVehicle
            // 
            this.rdbtnVehicle.AutoSize = true;
            this.rdbtnVehicle.Location = new System.Drawing.Point(219, 20);
            this.rdbtnVehicle.Name = "rdbtnVehicle";
            this.rdbtnVehicle.Size = new System.Drawing.Size(60, 17);
            this.rdbtnVehicle.TabIndex = 3;
            this.rdbtnVehicle.TabStop = true;
            this.rdbtnVehicle.Tag = "vehicle";
            this.rdbtnVehicle.Text = "Vehicle";
            this.rdbtnVehicle.UseVisualStyleBackColor = true;
            // 
            // rdbtnWeapon
            // 
            this.rdbtnWeapon.AutoSize = true;
            this.rdbtnWeapon.Location = new System.Drawing.Point(146, 20);
            this.rdbtnWeapon.Name = "rdbtnWeapon";
            this.rdbtnWeapon.Size = new System.Drawing.Size(66, 17);
            this.rdbtnWeapon.TabIndex = 2;
            this.rdbtnWeapon.TabStop = true;
            this.rdbtnWeapon.Tag = "weapon";
            this.rdbtnWeapon.Text = "Weapon";
            this.rdbtnWeapon.UseVisualStyleBackColor = true;
            // 
            // rdbtnMap
            // 
            this.rdbtnMap.AutoSize = true;
            this.rdbtnMap.Location = new System.Drawing.Point(93, 20);
            this.rdbtnMap.Name = "rdbtnMap";
            this.rdbtnMap.Size = new System.Drawing.Size(46, 17);
            this.rdbtnMap.TabIndex = 1;
            this.rdbtnMap.TabStop = true;
            this.rdbtnMap.Tag = "map";
            this.rdbtnMap.Text = "Map";
            this.rdbtnMap.UseVisualStyleBackColor = true;
            // 
            // rdbtnGamemode
            // 
            this.rdbtnGamemode.AutoSize = true;
            this.rdbtnGamemode.Location = new System.Drawing.Point(7, 20);
            this.rdbtnGamemode.Name = "rdbtnGamemode";
            this.rdbtnGamemode.Size = new System.Drawing.Size(79, 17);
            this.rdbtnGamemode.TabIndex = 0;
            this.rdbtnGamemode.TabStop = true;
            this.rdbtnGamemode.Tag = "gamemode";
            this.rdbtnGamemode.Text = "Gamemode";
            this.rdbtnGamemode.UseVisualStyleBackColor = true;
            // 
            // texbTitle
            // 
            this.texbTitle.Location = new System.Drawing.Point(42, 16);
            this.texbTitle.Name = "texbTitle";
            this.texbTitle.Size = new System.Drawing.Size(318, 20);
            this.texbTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // btnUploadIcon
            // 
            this.btnUploadIcon.Location = new System.Drawing.Point(455, 188);
            this.btnUploadIcon.Name = "btnUploadIcon";
            this.btnUploadIcon.Size = new System.Drawing.Size(66, 23);
            this.btnUploadIcon.TabIndex = 7;
            this.btnUploadIcon.Text = "Load";
            this.btnUploadIcon.UseVisualStyleBackColor = true;
            this.btnUploadIcon.Click += new System.EventHandler(this.btnUploadIcon_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(417, 193);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(31, 13);
            this.lblIcon.TabIndex = 6;
            this.lblIcon.Text = "Icon:";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(373, 164);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 20);
            this.btnFolder.TabIndex = 5;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(308, 164);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(59, 20);
            this.btnFile.TabIndex = 4;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // texbFileorFolder
            // 
            this.texbFileorFolder.Location = new System.Drawing.Point(84, 163);
            this.texbFileorFolder.Name = "texbFileorFolder";
            this.texbFileorFolder.Size = new System.Drawing.Size(218, 20);
            this.texbFileorFolder.TabIndex = 3;
            // 
            // lblFileorFolder
            // 
            this.lblFileorFolder.AutoSize = true;
            this.lblFileorFolder.Location = new System.Drawing.Point(7, 163);
            this.lblFileorFolder.Name = "lblFileorFolder";
            this.lblFileorFolder.Size = new System.Drawing.Size(70, 13);
            this.lblFileorFolder.TabIndex = 2;
            this.lblFileorFolder.Text = "File or Folder:";
            // 
            // grpboxAddonList
            // 
            this.grpboxAddonList.Controls.Add(this.dgvAddonsList);
            this.grpboxAddonList.Location = new System.Drawing.Point(7, 20);
            this.grpboxAddonList.Name = "grpboxAddonList";
            this.grpboxAddonList.Size = new System.Drawing.Size(529, 136);
            this.grpboxAddonList.TabIndex = 0;
            this.grpboxAddonList.TabStop = false;
            this.grpboxAddonList.Text = "Addon list";
            // 
            // dgvAddonsList
            // 
            this.dgvAddonsList.AllowUserToAddRows = false;
            this.dgvAddonsList.AllowUserToDeleteRows = false;
            this.dgvAddonsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddonsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAddonsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddonsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddonsList.Location = new System.Drawing.Point(3, 16);
            this.dgvAddonsList.MultiSelect = false;
            this.dgvAddonsList.Name = "dgvAddonsList";
            this.dgvAddonsList.ReadOnly = true;
            this.dgvAddonsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAddonsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddonsList.ShowEditingIcon = false;
            this.dgvAddonsList.Size = new System.Drawing.Size(523, 117);
            this.dgvAddonsList.TabIndex = 0;
            this.dgvAddonsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAddonsList_CellClick);
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.AllowUserToDeleteRows = false;
            this.dgvQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQueue.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvQueue.Location = new System.Drawing.Point(3, 16);
            this.dgvQueue.MultiSelect = false;
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.ReadOnly = true;
            this.dgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueue.ShowEditingIcon = false;
            this.dgvQueue.ShowRowErrors = false;
            this.dgvQueue.Size = new System.Drawing.Size(614, 212);
            this.dgvQueue.TabIndex = 3;
            this.dgvQueue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // grpboxQueue
            // 
            this.grpboxQueue.Controls.Add(this.btnQueueExecute);
            this.grpboxQueue.Controls.Add(this.btnQueueClear);
            this.grpboxQueue.Controls.Add(this.dgvQueue);
            this.grpboxQueue.Location = new System.Drawing.Point(611, 12);
            this.grpboxQueue.Name = "grpboxQueue";
            this.grpboxQueue.Size = new System.Drawing.Size(620, 285);
            this.grpboxQueue.TabIndex = 4;
            this.grpboxQueue.TabStop = false;
            this.grpboxQueue.Text = "Queue";
            // 
            // btnQueueExecute
            // 
            this.btnQueueExecute.Location = new System.Drawing.Point(515, 236);
            this.btnQueueExecute.Name = "btnQueueExecute";
            this.btnQueueExecute.Size = new System.Drawing.Size(99, 42);
            this.btnQueueExecute.TabIndex = 5;
            this.btnQueueExecute.Text = "Execute";
            this.btnQueueExecute.UseVisualStyleBackColor = true;
            this.btnQueueExecute.Click += new System.EventHandler(this.btnQueueExecute_Click);
            // 
            // btnQueueClear
            // 
            this.btnQueueClear.Location = new System.Drawing.Point(6, 236);
            this.btnQueueClear.Name = "btnQueueClear";
            this.btnQueueClear.Size = new System.Drawing.Size(98, 42);
            this.btnQueueClear.TabIndex = 4;
            this.btnQueueClear.Text = "Clear";
            this.btnQueueClear.UseVisualStyleBackColor = true;
            // 
            // grpboxLog
            // 
            this.grpboxLog.Controls.Add(this.texbLog);
            this.grpboxLog.Location = new System.Drawing.Point(614, 340);
            this.grpboxLog.Name = "grpboxLog";
            this.grpboxLog.Size = new System.Drawing.Size(614, 293);
            this.grpboxLog.TabIndex = 5;
            this.grpboxLog.TabStop = false;
            this.grpboxLog.Text = "Log";
            // 
            // texbLog
            // 
            this.texbLog.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.texbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texbLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texbLog.Location = new System.Drawing.Point(3, 16);
            this.texbLog.Multiline = true;
            this.texbLog.Name = "texbLog";
            this.texbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.texbLog.Size = new System.Drawing.Size(608, 274);
            this.texbLog.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "test for queue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 713);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpboxLog);
            this.Controls.Add(this.grpboxQueue);
            this.Controls.Add(this.grpboxApplyingMode);
            this.Controls.Add(this.grpboxMode);
            this.Name = "Form1";
            this.Text = "Shadow2hel\'s Workshop Publisher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxMode.ResumeLayout(false);
            this.grpboxMode.PerformLayout();
            this.grpboxApplyingMode.ResumeLayout(false);
            this.grpboxApplyingMode.PerformLayout();
            this.grpboxExtract.ResumeLayout(false);
            this.grpboxExtract.PerformLayout();
            this.grpboxIconPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconPreview)).EndInit();
            this.grpboxAddonjson.ResumeLayout(false);
            this.grpboxAddonjson.PerformLayout();
            this.grpboxTags.ResumeLayout(false);
            this.grpboxTags.PerformLayout();
            this.grpboxType.ResumeLayout(false);
            this.grpboxType.PerformLayout();
            this.grpboxAddonList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddonsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.grpboxQueue.ResumeLayout(false);
            this.grpboxLog.ResumeLayout(false);
            this.grpboxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpboxMode;
        private System.Windows.Forms.RadioButton rdbtnExtract;
        private System.Windows.Forms.RadioButton rdbtnUpdate;
        private System.Windows.Forms.RadioButton rdbtnGMA;
        private System.Windows.Forms.RadioButton rdbtnCreate;
        private System.Windows.Forms.GroupBox grpboxApplyingMode;
        private System.Windows.Forms.GroupBox grpboxAddonList;
        private System.Windows.Forms.DataGridView dgvAddonsList;
        private System.Windows.Forms.GroupBox grpboxIconPreview;
        private System.Windows.Forms.GroupBox grpboxAddonjson;
        private System.Windows.Forms.TextBox texbIgnore;
        private System.Windows.Forms.Label lblIgnore;
        private System.Windows.Forms.GroupBox grpboxTags;
        private System.Windows.Forms.CheckBox chkboxBuild;
        private System.Windows.Forms.CheckBox chkboxComic;
        private System.Windows.Forms.CheckBox chkboxWater;
        private System.Windows.Forms.CheckBox chkboxCartoon;
        private System.Windows.Forms.CheckBox chkboxRealism;
        private System.Windows.Forms.CheckBox chkboxMovie;
        private System.Windows.Forms.CheckBox chkboxScenic;
        private System.Windows.Forms.CheckBox chkboxRoleplay;
        private System.Windows.Forms.CheckBox chkboxFun;
        private System.Windows.Forms.GroupBox grpboxType;
        private System.Windows.Forms.RadioButton rdbtnServerContent;
        private System.Windows.Forms.RadioButton rdbtnModel;
        private System.Windows.Forms.RadioButton rdbtnEffects;
        private System.Windows.Forms.RadioButton rdbtnTool;
        private System.Windows.Forms.RadioButton rdbtnNPC;
        private System.Windows.Forms.RadioButton rdbtnVehicle;
        private System.Windows.Forms.RadioButton rdbtnWeapon;
        private System.Windows.Forms.RadioButton rdbtnMap;
        private System.Windows.Forms.RadioButton rdbtnGamemode;
        private System.Windows.Forms.TextBox texbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUploadIcon;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox texbFileorFolder;
        private System.Windows.Forms.Label lblFileorFolder;
        private System.Windows.Forms.GroupBox grpboxExtract;
        private System.Windows.Forms.Button btnFolderExtract;
        private System.Windows.Forms.TextBox texbExtractOutput;
        private System.Windows.Forms.Button btnFileExtract;
        private System.Windows.Forms.TextBox texbFileExtract;
        private System.Windows.Forms.Label lblFileExtract;
        private System.Windows.Forms.Button btnSelectGMAOutput;
        private System.Windows.Forms.TextBox texbGMAOutput;
        private System.Windows.Forms.Label lblGMAOutput;
        private System.Windows.Forms.TextBox texbChanges;
        private System.Windows.Forms.Label lblChanges;
        private System.Windows.Forms.PictureBox picBoxIconPreview;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.GroupBox grpboxQueue;
        private System.Windows.Forms.GroupBox grpboxLog;
        private System.Windows.Forms.TextBox texbLog;
        private System.Windows.Forms.Button btnQueueExecute;
        private System.Windows.Forms.Button btnQueueClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddToQueue;
        private System.Windows.Forms.Label label1;
    }
}

