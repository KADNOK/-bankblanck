namespace appk
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientPage = new System.Windows.Forms.TabPage();
            this.habPage = new System.Windows.Forms.TabPage();
            this.accPage = new System.Windows.Forms.TabPage();
            this.cardPage = new System.Windows.Forms.TabPage();
            this.numPage = new System.Windows.Forms.TabPage();
            this.clientGridView = new System.Windows.Forms.DataGridView();
            this.habitationGridView = new System.Windows.Forms.DataGridView();
            this.accountGridView = new System.Windows.Forms.DataGridView();
            this.cardGridView = new System.Windows.Forms.DataGridView();
            this.numberGridView = new System.Windows.Forms.DataGridView();
            this.CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accommodation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccommodationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountcodeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.clientPage.SuspendLayout();
            this.habPage.SuspendLayout();
            this.accPage.SuspendLayout();
            this.cardPage.SuspendLayout();
            this.numPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientPage);
            this.tabControl1.Controls.Add(this.habPage);
            this.tabControl1.Controls.Add(this.accPage);
            this.tabControl1.Controls.Add(this.cardPage);
            this.tabControl1.Controls.Add(this.numPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 562);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // clientPage
            // 
            this.clientPage.Controls.Add(this.clientGridView);
            this.clientPage.Location = new System.Drawing.Point(4, 22);
            this.clientPage.Name = "clientPage";
            this.clientPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientPage.Size = new System.Drawing.Size(977, 536);
            this.clientPage.TabIndex = 0;
            this.clientPage.Text = "Клиент";
            this.clientPage.UseVisualStyleBackColor = true;
            // 
            // habPage
            // 
            this.habPage.Controls.Add(this.habitationGridView);
            this.habPage.Location = new System.Drawing.Point(4, 22);
            this.habPage.Name = "habPage";
            this.habPage.Padding = new System.Windows.Forms.Padding(3);
            this.habPage.Size = new System.Drawing.Size(977, 536);
            this.habPage.TabIndex = 1;
            this.habPage.Text = "Проживание";
            this.habPage.UseVisualStyleBackColor = true;
            // 
            // accPage
            // 
            this.accPage.Controls.Add(this.accountGridView);
            this.accPage.Location = new System.Drawing.Point(4, 22);
            this.accPage.Name = "accPage";
            this.accPage.Size = new System.Drawing.Size(977, 536);
            this.accPage.TabIndex = 2;
            this.accPage.Text = "Счет";
            this.accPage.UseVisualStyleBackColor = true;
            // 
            // cardPage
            // 
            this.cardPage.Controls.Add(this.cardGridView);
            this.cardPage.Location = new System.Drawing.Point(4, 22);
            this.cardPage.Name = "cardPage";
            this.cardPage.Size = new System.Drawing.Size(977, 536);
            this.cardPage.TabIndex = 3;
            this.cardPage.Text = "Карточка";
            this.cardPage.UseVisualStyleBackColor = true;
            // 
            // numPage
            // 
            this.numPage.Controls.Add(this.numberGridView);
            this.numPage.Location = new System.Drawing.Point(4, 22);
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(977, 536);
            this.numPage.TabIndex = 4;
            this.numPage.Text = "Номер";
            this.numPage.UseVisualStyleBackColor = true;
            // 
            // clientGridView
            // 
            this.clientGridView.AllowUserToAddRows = false;
            this.clientGridView.AllowUserToDeleteRows = false;
            this.clientGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.clientGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientsId,
            this.name,
            this.passport,
            this.contact});
            this.clientGridView.Location = new System.Drawing.Point(0, 0);
            this.clientGridView.Name = "clientGridView";
            this.clientGridView.ReadOnly = true;
            this.clientGridView.Size = new System.Drawing.Size(977, 324);
            this.clientGridView.TabIndex = 0;
            // 
            // habitationGridView
            // 
            this.habitationGridView.AllowUserToAddRows = false;
            this.habitationGridView.AllowUserToDeleteRows = false;
            this.habitationGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.habitationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.habitationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.habitationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccommodationId,
            this.client,
            this.checkin,
            this.checkout,
            this.roomtupe});
            this.habitationGridView.Location = new System.Drawing.Point(0, 0);
            this.habitationGridView.Name = "habitationGridView";
            this.habitationGridView.ReadOnly = true;
            this.habitationGridView.Size = new System.Drawing.Size(977, 324);
            this.habitationGridView.TabIndex = 1;
            // 
            // accountGridView
            // 
            this.accountGridView.AllowUserToAddRows = false;
            this.accountGridView.AllowUserToDeleteRows = false;
            this.accountGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.accountGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountcodeId,
            this.habitation,
            this.theamount,
            this.detail});
            this.accountGridView.Location = new System.Drawing.Point(0, 0);
            this.accountGridView.Name = "accountGridView";
            this.accountGridView.ReadOnly = true;
            this.accountGridView.Size = new System.Drawing.Size(977, 324);
            this.accountGridView.TabIndex = 1;
            // 
            // cardGridView
            // 
            this.cardGridView.AllowUserToAddRows = false;
            this.cardGridView.AllowUserToDeleteRows = false;
            this.cardGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cardGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardId,
            this.Accommodation,
            this.registration});
            this.cardGridView.Location = new System.Drawing.Point(0, 0);
            this.cardGridView.Name = "cardGridView";
            this.cardGridView.ReadOnly = true;
            this.cardGridView.Size = new System.Drawing.Size(977, 324);
            this.cardGridView.TabIndex = 1;
            // 
            // numberGridView
            // 
            this.numberGridView.AllowUserToAddRows = false;
            this.numberGridView.AllowUserToDeleteRows = false;
            this.numberGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.numberGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numberGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberId,
            this.type,
            this.cost,
            this.available});
            this.numberGridView.Location = new System.Drawing.Point(0, 0);
            this.numberGridView.Name = "numberGridView";
            this.numberGridView.ReadOnly = true;
            this.numberGridView.Size = new System.Drawing.Size(977, 324);
            this.numberGridView.TabIndex = 1;
            // 
            // CardId
            // 
            this.CardId.DataPropertyName = "CardId";
            this.CardId.HeaderText = "CardId";
            this.CardId.Name = "CardId";
            this.CardId.ReadOnly = true;
            this.CardId.Width = 75;
            // 
            // Accommodation
            // 
            this.Accommodation.DataPropertyName = "Accommodation";
            this.Accommodation.HeaderText = "Accommodation";
            this.Accommodation.Name = "Accommodation";
            this.Accommodation.ReadOnly = true;
            this.Accommodation.Width = 250;
            // 
            // registration
            // 
            this.registration.DataPropertyName = "registration date";
            this.registration.HeaderText = "registration date";
            this.registration.Name = "registration";
            this.registration.ReadOnly = true;
            this.registration.Width = 250;
            // 
            // numberId
            // 
            this.numberId.DataPropertyName = "The code numberId";
            this.numberId.HeaderText = "The code numberId";
            this.numberId.Name = "numberId";
            this.numberId.ReadOnly = true;
            this.numberId.Width = 125;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 250;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "of cost";
            this.cost.HeaderText = "of cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 250;
            // 
            // available
            // 
            this.available.DataPropertyName = "available";
            this.available.HeaderText = "available";
            this.available.Name = "available";
            this.available.ReadOnly = true;
            this.available.Width = 250;
            // 
            // ClientsId
            // 
            this.ClientsId.DataPropertyName = "ClientsId";
            this.ClientsId.HeaderText = "ClientsId";
            this.ClientsId.Name = "ClientsId";
            this.ClientsId.ReadOnly = true;
            this.ClientsId.Width = 75;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // passport
            // 
            this.passport.DataPropertyName = "passport details";
            this.passport.HeaderText = "passport details";
            this.passport.Name = "passport";
            this.passport.ReadOnly = true;
            this.passport.Width = 250;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact information";
            this.contact.HeaderText = "contact information";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Width = 250;
            // 
            // AccommodationId
            // 
            this.AccommodationId.DataPropertyName = "AccommodationId";
            this.AccommodationId.HeaderText = "AccommodationId";
            this.AccommodationId.Name = "AccommodationId";
            this.AccommodationId.ReadOnly = true;
            this.AccommodationId.Width = 125;
            // 
            // client
            // 
            this.client.DataPropertyName = "client";
            this.client.HeaderText = "Client";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            this.client.Width = 75;
            // 
            // checkin
            // 
            this.checkin.DataPropertyName = "check-in date";
            this.checkin.HeaderText = "check-in date";
            this.checkin.Name = "checkin";
            this.checkin.ReadOnly = true;
            this.checkin.Width = 250;
            // 
            // checkout
            // 
            this.checkout.DataPropertyName = "check-out date";
            this.checkout.HeaderText = "check-out date";
            this.checkout.Name = "checkout";
            this.checkout.ReadOnly = true;
            this.checkout.Width = 250;
            // 
            // roomtupe
            // 
            this.roomtupe.DataPropertyName = "room tupe";
            this.roomtupe.HeaderText = "room tupe";
            this.roomtupe.Name = "roomtupe";
            this.roomtupe.ReadOnly = true;
            this.roomtupe.Width = 200;
            // 
            // AccountcodeId
            // 
            this.AccountcodeId.DataPropertyName = "Account codeId";
            this.AccountcodeId.HeaderText = "Account codeId";
            this.AccountcodeId.Name = "AccountcodeId";
            this.AccountcodeId.ReadOnly = true;
            this.AccountcodeId.Width = 75;
            // 
            // habitation
            // 
            this.habitation.DataPropertyName = "habitation";
            this.habitation.HeaderText = "habitation";
            this.habitation.Name = "habitation";
            this.habitation.ReadOnly = true;
            this.habitation.Width = 250;
            // 
            // theamount
            // 
            this.theamount.DataPropertyName = "the amount";
            this.theamount.HeaderText = "the amount";
            this.theamount.Name = "theamount";
            this.theamount.ReadOnly = true;
            this.theamount.Width = 250;
            // 
            // detail
            // 
            this.detail.DataPropertyName = "of the detail";
            this.detail.HeaderText = "of the detail";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проживание";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.clientPage.ResumeLayout(false);
            this.habPage.ResumeLayout(false);
            this.accPage.ResumeLayout(false);
            this.cardPage.ResumeLayout(false);
            this.numPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientPage;
        private System.Windows.Forms.TabPage habPage;
        private System.Windows.Forms.TabPage accPage;
        private System.Windows.Forms.TabPage cardPage;
        private System.Windows.Forms.TabPage numPage;
        private System.Windows.Forms.DataGridView clientGridView;
        private System.Windows.Forms.DataGridView habitationGridView;
        private System.Windows.Forms.DataGridView accountGridView;
        private System.Windows.Forms.DataGridView cardGridView;
        private System.Windows.Forms.DataGridView numberGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accommodation;
        private System.Windows.Forms.DataGridViewTextBoxColumn registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccommodationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountcodeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitation;
        private System.Windows.Forms.DataGridViewTextBoxColumn theamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
    }
}

