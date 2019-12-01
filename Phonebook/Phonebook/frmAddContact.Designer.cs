namespace Phonebook
{
    partial class frmAddContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddContact));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtPhone = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtAddress = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.inFriend = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Friend = new System.Windows.Forms.Label();
            this.inCowokers = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Coworker = new System.Windows.Forms.Label();
            this.family = new System.Windows.Forms.Label();
            this.inFamily = new Bunifu.Framework.UI.BunifuCheckbox();
            this.busnis = new System.Windows.Forms.Label();
            this.inBussiness = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnAddContact = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(451, 13);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(48, 54);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtName.BorderRadius = 30;
            this.txtName.BorderThickness = 2;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = null;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(69, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(111, 43);
            this.txtName.Modified = false;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(384, 43);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "Name";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtEmail.BorderRadius = 30;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmail.Location = new System.Drawing.Point(69, 172);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(111, 43);
            this.txtEmail.Modified = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ReadOnly = false;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(384, 43);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginLeft = 5;
            this.txtEmail.TextPlaceholder = "Email";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.TextChange += new System.EventHandler(this.TxtEmail_TextChange);
            // 
            // txtPhone
            // 
            this.txtPhone.AcceptsReturn = false;
            this.txtPhone.AcceptsTab = false;
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPhone.BackgroundImage")));
            this.txtPhone.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtPhone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPhone.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPhone.BorderRadius = 30;
            this.txtPhone.BorderThickness = 2;
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhone.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtPhone.DefaultText = "";
            this.txtPhone.FillColor = System.Drawing.Color.White;
            this.txtPhone.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPhone.HideSelection = true;
            this.txtPhone.IconLeft = null;
            this.txtPhone.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.IconPadding = 10;
            this.txtPhone.IconRight = null;
            this.txtPhone.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.Location = new System.Drawing.Point(69, 243);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MinimumSize = new System.Drawing.Size(111, 43);
            this.txtPhone.Modified = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ReadOnly = false;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(384, 43);
            this.txtPhone.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.TextMarginLeft = 5;
            this.txtPhone.TextPlaceholder = "Phone";
            this.txtPhone.UseSystemPasswordChar = false;
            this.txtPhone.TextChange += new System.EventHandler(this.BunifuTextBox3_TextChange);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = false;
            this.txtAddress.AcceptsTab = false;
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAddress.BackgroundImage")));
            this.txtAddress.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtAddress.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAddress.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtAddress.BorderRadius = 30;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtAddress.DefaultText = "";
            this.txtAddress.FillColor = System.Drawing.Color.White;
            this.txtAddress.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAddress.HideSelection = true;
            this.txtAddress.IconLeft = null;
            this.txtAddress.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.IconPadding = 10;
            this.txtAddress.IconRight = null;
            this.txtAddress.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.Location = new System.Drawing.Point(69, 315);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MinimumSize = new System.Drawing.Size(111, 43);
            this.txtAddress.Modified = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(384, 48);
            this.txtAddress.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextMarginLeft = 5;
            this.txtAddress.TextPlaceholder = "Address";
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // inFriend
            // 
            this.inFriend.BackColor = System.Drawing.Color.Fuchsia;
            this.inFriend.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.inFriend.Checked = true;
            this.inFriend.CheckedOnColor = System.Drawing.Color.Fuchsia;
            this.inFriend.ForeColor = System.Drawing.Color.White;
            this.inFriend.Location = new System.Drawing.Point(121, 399);
            this.inFriend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inFriend.Name = "inFriend";
            this.inFriend.Size = new System.Drawing.Size(20, 20);
            this.inFriend.TabIndex = 8;
            // 
            // Friend
            // 
            this.Friend.AutoSize = true;
            this.Friend.Location = new System.Drawing.Point(148, 394);
            this.Friend.Name = "Friend";
            this.Friend.Size = new System.Drawing.Size(61, 25);
            this.Friend.TabIndex = 9;
            this.Friend.Text = "Friend";
            // 
            // inCowokers
            // 
            this.inCowokers.BackColor = System.Drawing.Color.Fuchsia;
            this.inCowokers.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.inCowokers.Checked = true;
            this.inCowokers.CheckedOnColor = System.Drawing.Color.Fuchsia;
            this.inCowokers.ForeColor = System.Drawing.Color.White;
            this.inCowokers.Location = new System.Drawing.Point(121, 446);
            this.inCowokers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inCowokers.Name = "inCowokers";
            this.inCowokers.Size = new System.Drawing.Size(20, 20);
            this.inCowokers.TabIndex = 10;
            // 
            // Coworker
            // 
            this.Coworker.AutoSize = true;
            this.Coworker.Location = new System.Drawing.Point(148, 441);
            this.Coworker.Name = "Coworker";
            this.Coworker.Size = new System.Drawing.Size(98, 25);
            this.Coworker.TabIndex = 11;
            this.Coworker.Text = "Co-Worker";
            // 
            // family
            // 
            this.family.AutoSize = true;
            this.family.Location = new System.Drawing.Point(316, 396);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(62, 25);
            this.family.TabIndex = 13;
            this.family.Text = "Family";
            // 
            // inFamily
            // 
            this.inFamily.BackColor = System.Drawing.Color.Fuchsia;
            this.inFamily.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.inFamily.Checked = true;
            this.inFamily.CheckedOnColor = System.Drawing.Color.Fuchsia;
            this.inFamily.ForeColor = System.Drawing.Color.White;
            this.inFamily.Location = new System.Drawing.Point(289, 399);
            this.inFamily.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.inFamily.Name = "inFamily";
            this.inFamily.Size = new System.Drawing.Size(20, 20);
            this.inFamily.TabIndex = 12;
            // 
            // busnis
            // 
            this.busnis.AutoSize = true;
            this.busnis.Location = new System.Drawing.Point(316, 441);
            this.busnis.Name = "busnis";
            this.busnis.Size = new System.Drawing.Size(87, 25);
            this.busnis.TabIndex = 15;
            this.busnis.Text = "Bussiness";
            // 
            // inBussiness
            // 
            this.inBussiness.BackColor = System.Drawing.Color.Fuchsia;
            this.inBussiness.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.inBussiness.Checked = true;
            this.inBussiness.CheckedOnColor = System.Drawing.Color.Fuchsia;
            this.inBussiness.ForeColor = System.Drawing.Color.White;
            this.inBussiness.Location = new System.Drawing.Point(289, 446);
            this.inBussiness.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.inBussiness.Name = "inBussiness";
            this.inBussiness.Size = new System.Drawing.Size(20, 20);
            this.inBussiness.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(177, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "Add Contact";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(63, 70);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(400, 26);
            this.bunifuSeparator1.TabIndex = 17;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.Transparent;
            this.btnAddContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddContact.BackgroundImage")));
            this.btnAddContact.ButtonText = "Add Contact";
            this.btnAddContact.ButtonTextMarginLeft = 0;
            this.btnAddContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContact.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddContact.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddContact.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddContact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddContact.ForeColor = System.Drawing.Color.White;
            this.btnAddContact.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContact.IconPadding = 10;
            this.btnAddContact.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContact.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddContact.IdleBorderRadius = 35;
            this.btnAddContact.IdleBorderThickness = 1;
            this.btnAddContact.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddContact.IdleIconLeftImage = null;
            this.btnAddContact.IdleIconRightImage = null;
            this.btnAddContact.Location = new System.Drawing.Point(86, 496);
            this.btnAddContact.Name = "btnAddContact";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddContact.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAddContact.OnPressedState = stateProperties2;
            this.btnAddContact.Size = new System.Drawing.Size(317, 58);
            this.btnAddContact.TabIndex = 18;
            this.btnAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // frmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 585);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.busnis);
            this.Controls.Add(this.inBussiness);
            this.Controls.Add(this.family);
            this.Controls.Add(this.inFamily);
            this.Controls.Add(this.Coworker);
            this.Controls.Add(this.inCowokers);
            this.Controls.Add(this.Friend);
            this.Controls.Add(this.inFriend);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddContact";
            this.Load += new System.EventHandler(this.FrmAddContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtEmail;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPhone;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAddress;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label busnis;
        private Bunifu.Framework.UI.BunifuCheckbox inBussiness;
        private System.Windows.Forms.Label family;
        private Bunifu.Framework.UI.BunifuCheckbox inFamily;
        private System.Windows.Forms.Label Coworker;
        private Bunifu.Framework.UI.BunifuCheckbox inCowokers;
        private System.Windows.Forms.Label Friend;
        private Bunifu.Framework.UI.BunifuCheckbox inFriend;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddContact;
    }
}