namespace DataStructure
{
    partial class FormPage
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
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.buttonClearALL = new System.Windows.Forms.Button();
            this.buttonFront = new System.Windows.Forms.Button();
            this.buttonRear = new System.Windows.Forms.Button();
            this.buttonDelQueue = new System.Windows.Forms.Button();
            this.buttonAddQueue = new System.Windows.Forms.Button();
            this.groupBoxQueue = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonBringStack = new System.Windows.Forms.Button();
            this.buttonClearAllStack = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonTopCount = new System.Windows.Forms.Button();
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.groupStack = new System.Windows.Forms.GroupBox();
            this.groupItems = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxItems1 = new System.Windows.Forms.TextBox();
            this.textBoxItems2 = new System.Windows.Forms.TextBox();
            this.textBoxItems3 = new System.Windows.Forms.TextBox();
            this.textBoxItems4 = new System.Windows.Forms.TextBox();
            this.textBoxItems5 = new System.Windows.Forms.TextBox();
            this.textBoxItems6 = new System.Windows.Forms.TextBox();
            this.textBoxItems7 = new System.Windows.Forms.TextBox();
            this.textBoxItems8 = new System.Windows.Forms.TextBox();
            this.textBoxItems9 = new System.Windows.Forms.TextBox();
            this.textBoxItems10 = new System.Windows.Forms.TextBox();
            this.textBoxItems11 = new System.Windows.Forms.TextBox();
            this.textBoxItems12 = new System.Windows.Forms.TextBox();
            this.textBoxItems13 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxQueue = new System.Windows.Forms.TextBox();
            this.restart = new System.Windows.Forms.Label();
            this.groupActions.SuspendLayout();
            this.groupBoxQueue.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupItems.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupActions
            // 
            this.groupActions.Controls.Add(this.buttonClearALL);
            this.groupActions.Controls.Add(this.buttonFront);
            this.groupActions.Controls.Add(this.buttonRear);
            this.groupActions.Controls.Add(this.buttonDelQueue);
            this.groupActions.Controls.Add(this.buttonAddQueue);
            this.groupActions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupActions.Location = new System.Drawing.Point(585, 6);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(177, 486);
            this.groupActions.TabIndex = 0;
            this.groupActions.TabStop = false;
            this.groupActions.Text = "Actions";
            // 
            // buttonClearALL
            // 
            this.buttonClearALL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearALL.Location = new System.Drawing.Point(6, 322);
            this.buttonClearALL.Name = "buttonClearALL";
            this.buttonClearALL.Size = new System.Drawing.Size(165, 157);
            this.buttonClearALL.TabIndex = 4;
            this.buttonClearALL.Text = "Clear All";
            this.buttonClearALL.UseVisualStyleBackColor = true;
            this.buttonClearALL.Click += new System.EventHandler(this.buttonClearALL_Click);
            // 
            // buttonFront
            // 
            this.buttonFront.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFront.Location = new System.Drawing.Point(6, 247);
            this.buttonFront.Name = "buttonFront";
            this.buttonFront.Size = new System.Drawing.Size(165, 69);
            this.buttonFront.TabIndex = 3;
            this.buttonFront.Text = "Front = 0";
            this.buttonFront.UseVisualStyleBackColor = true;
            this.buttonFront.Click += new System.EventHandler(this.buttonFront_Click);
            // 
            // buttonRear
            // 
            this.buttonRear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRear.Location = new System.Drawing.Point(6, 171);
            this.buttonRear.Name = "buttonRear";
            this.buttonRear.Size = new System.Drawing.Size(165, 69);
            this.buttonRear.TabIndex = 2;
            this.buttonRear.Text = "Rear = 0";
            this.buttonRear.UseVisualStyleBackColor = true;
            this.buttonRear.Click += new System.EventHandler(this.buttonRear_Click);
            // 
            // buttonDelQueue
            // 
            this.buttonDelQueue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelQueue.Location = new System.Drawing.Point(6, 96);
            this.buttonDelQueue.Name = "buttonDelQueue";
            this.buttonDelQueue.Size = new System.Drawing.Size(165, 69);
            this.buttonDelQueue.TabIndex = 1;
            this.buttonDelQueue.Text = "Delete Queue";
            this.buttonDelQueue.UseVisualStyleBackColor = true;
            this.buttonDelQueue.Click += new System.EventHandler(this.buttonDelQueue_Click);
            // 
            // buttonAddQueue
            // 
            this.buttonAddQueue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQueue.Location = new System.Drawing.Point(6, 20);
            this.buttonAddQueue.Name = "buttonAddQueue";
            this.buttonAddQueue.Size = new System.Drawing.Size(165, 69);
            this.buttonAddQueue.TabIndex = 0;
            this.buttonAddQueue.Text = "Add Queue";
            this.buttonAddQueue.UseVisualStyleBackColor = true;
            this.buttonAddQueue.Click += new System.EventHandler(this.buttonAddQueue_Click);
            // 
            // groupBoxQueue
            // 
            this.groupBoxQueue.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxQueue.Location = new System.Drawing.Point(6, 324);
            this.groupBoxQueue.Name = "groupBoxQueue";
            this.groupBoxQueue.Size = new System.Drawing.Size(573, 168);
            this.groupBoxQueue.TabIndex = 1;
            this.groupBoxQueue.TabStop = false;
            this.groupBoxQueue.Text = "Queue";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 126);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 542);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxActions);
            this.tabPage1.Controls.Add(this.groupStack);
            this.tabPage1.Controls.Add(this.groupItems);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 510);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Stack";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonBringStack);
            this.groupBoxActions.Controls.Add(this.buttonClearAllStack);
            this.groupBoxActions.Controls.Add(this.buttonMove);
            this.groupBoxActions.Controls.Add(this.buttonTopCount);
            this.groupBoxActions.Controls.Add(this.buttonPop);
            this.groupBoxActions.Controls.Add(this.buttonPush);
            this.groupBoxActions.Location = new System.Drawing.Point(480, 6);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(282, 486);
            this.groupBoxActions.TabIndex = 4;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonBringStack
            // 
            this.buttonBringStack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonBringStack.Location = new System.Drawing.Point(61, 392);
            this.buttonBringStack.Name = "buttonBringStack";
            this.buttonBringStack.Size = new System.Drawing.Size(161, 62);
            this.buttonBringStack.TabIndex = 5;
            this.buttonBringStack.Text = "Bring All";
            this.buttonBringStack.UseVisualStyleBackColor = true;
            this.buttonBringStack.Click += new System.EventHandler(this.buttonBringStack_Click);
            // 
            // buttonClearAllStack
            // 
            this.buttonClearAllStack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonClearAllStack.Location = new System.Drawing.Point(61, 323);
            this.buttonClearAllStack.Name = "buttonClearAllStack";
            this.buttonClearAllStack.Size = new System.Drawing.Size(161, 62);
            this.buttonClearAllStack.TabIndex = 4;
            this.buttonClearAllStack.Text = "Clear All or Restore";
            this.buttonClearAllStack.UseVisualStyleBackColor = true;
            this.buttonClearAllStack.Click += new System.EventHandler(this.buttonClearAllStack_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonMove.Location = new System.Drawing.Point(61, 254);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(161, 62);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonTopCount
            // 
            this.buttonTopCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonTopCount.Location = new System.Drawing.Point(61, 185);
            this.buttonTopCount.Name = "buttonTopCount";
            this.buttonTopCount.Size = new System.Drawing.Size(161, 62);
            this.buttonTopCount.TabIndex = 2;
            this.buttonTopCount.Text = "Top = 0";
            this.buttonTopCount.UseVisualStyleBackColor = true;
            // 
            // buttonPop
            // 
            this.buttonPop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonPop.Location = new System.Drawing.Point(61, 116);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(161, 62);
            this.buttonPop.TabIndex = 1;
            this.buttonPop.Text = "Pop Stack";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonPush.Location = new System.Drawing.Point(61, 47);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(161, 62);
            this.buttonPush.TabIndex = 0;
            this.buttonPush.Text = "Push Stack";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // groupStack
            // 
            this.groupStack.Location = new System.Drawing.Point(211, 6);
            this.groupStack.Name = "groupStack";
            this.groupStack.Size = new System.Drawing.Size(263, 486);
            this.groupStack.TabIndex = 3;
            this.groupStack.TabStop = false;
            this.groupStack.Text = "Stack";
            // 
            // groupItems
            // 
            this.groupItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupItems.Controls.Add(this.flowLayoutPanel2);
            this.groupItems.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupItems.Location = new System.Drawing.Point(6, 6);
            this.groupItems.Name = "groupItems";
            this.groupItems.Size = new System.Drawing.Size(181, 486);
            this.groupItems.TabIndex = 2;
            this.groupItems.TabStop = false;
            this.groupItems.Text = "Items";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems1);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems2);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems3);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems4);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems5);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems6);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems7);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems8);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems9);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems10);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems11);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems12);
            this.flowLayoutPanel2.Controls.Add(this.textBoxItems13);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 27);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(169, 453);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // textBoxItems1
            // 
            this.textBoxItems1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems1.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems1.Location = new System.Drawing.Point(3, 3);
            this.textBoxItems1.Multiline = true;
            this.textBoxItems1.Name = "textBoxItems1";
            this.textBoxItems1.ReadOnly = true;
            this.textBoxItems1.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems1.TabIndex = 0;
            this.textBoxItems1.Text = "Disc 00";
            this.textBoxItems1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems2
            // 
            this.textBoxItems2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems2.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems2.Location = new System.Drawing.Point(3, 37);
            this.textBoxItems2.Multiline = true;
            this.textBoxItems2.Name = "textBoxItems2";
            this.textBoxItems2.ReadOnly = true;
            this.textBoxItems2.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems2.TabIndex = 1;
            this.textBoxItems2.Text = "Disc 01";
            this.textBoxItems2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems3
            // 
            this.textBoxItems3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems3.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems3.Location = new System.Drawing.Point(3, 71);
            this.textBoxItems3.Multiline = true;
            this.textBoxItems3.Name = "textBoxItems3";
            this.textBoxItems3.ReadOnly = true;
            this.textBoxItems3.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems3.TabIndex = 2;
            this.textBoxItems3.Text = "Disc 02";
            this.textBoxItems3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems4
            // 
            this.textBoxItems4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems4.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems4.Location = new System.Drawing.Point(3, 105);
            this.textBoxItems4.Multiline = true;
            this.textBoxItems4.Name = "textBoxItems4";
            this.textBoxItems4.ReadOnly = true;
            this.textBoxItems4.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems4.TabIndex = 3;
            this.textBoxItems4.Text = "Disc 03";
            this.textBoxItems4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems5
            // 
            this.textBoxItems5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems5.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems5.Location = new System.Drawing.Point(3, 139);
            this.textBoxItems5.Multiline = true;
            this.textBoxItems5.Name = "textBoxItems5";
            this.textBoxItems5.ReadOnly = true;
            this.textBoxItems5.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems5.TabIndex = 4;
            this.textBoxItems5.Text = "Disc 04";
            this.textBoxItems5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems6
            // 
            this.textBoxItems6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems6.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems6.Location = new System.Drawing.Point(3, 173);
            this.textBoxItems6.Multiline = true;
            this.textBoxItems6.Name = "textBoxItems6";
            this.textBoxItems6.ReadOnly = true;
            this.textBoxItems6.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems6.TabIndex = 5;
            this.textBoxItems6.Text = "Disc 05";
            this.textBoxItems6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems7
            // 
            this.textBoxItems7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems7.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems7.Location = new System.Drawing.Point(3, 207);
            this.textBoxItems7.Multiline = true;
            this.textBoxItems7.Name = "textBoxItems7";
            this.textBoxItems7.ReadOnly = true;
            this.textBoxItems7.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems7.TabIndex = 6;
            this.textBoxItems7.Text = "Disc 06";
            this.textBoxItems7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems8
            // 
            this.textBoxItems8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems8.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems8.Location = new System.Drawing.Point(3, 241);
            this.textBoxItems8.Multiline = true;
            this.textBoxItems8.Name = "textBoxItems8";
            this.textBoxItems8.ReadOnly = true;
            this.textBoxItems8.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems8.TabIndex = 7;
            this.textBoxItems8.Text = "Disc 07";
            this.textBoxItems8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems9
            // 
            this.textBoxItems9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems9.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems9.Location = new System.Drawing.Point(3, 275);
            this.textBoxItems9.Multiline = true;
            this.textBoxItems9.Name = "textBoxItems9";
            this.textBoxItems9.ReadOnly = true;
            this.textBoxItems9.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems9.TabIndex = 8;
            this.textBoxItems9.Text = "Disc 08";
            this.textBoxItems9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems10
            // 
            this.textBoxItems10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems10.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems10.Location = new System.Drawing.Point(3, 309);
            this.textBoxItems10.Multiline = true;
            this.textBoxItems10.Name = "textBoxItems10";
            this.textBoxItems10.ReadOnly = true;
            this.textBoxItems10.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems10.TabIndex = 9;
            this.textBoxItems10.Text = "Disc 09";
            this.textBoxItems10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems11
            // 
            this.textBoxItems11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems11.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems11.Location = new System.Drawing.Point(3, 343);
            this.textBoxItems11.Multiline = true;
            this.textBoxItems11.Name = "textBoxItems11";
            this.textBoxItems11.ReadOnly = true;
            this.textBoxItems11.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems11.TabIndex = 10;
            this.textBoxItems11.Text = "Disc 10";
            this.textBoxItems11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems12
            // 
            this.textBoxItems12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems12.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems12.Location = new System.Drawing.Point(3, 377);
            this.textBoxItems12.Multiline = true;
            this.textBoxItems12.Name = "textBoxItems12";
            this.textBoxItems12.ReadOnly = true;
            this.textBoxItems12.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems12.TabIndex = 11;
            this.textBoxItems12.Text = "Disc 11";
            this.textBoxItems12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxItems13
            // 
            this.textBoxItems13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItems13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems13.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxItems13.Location = new System.Drawing.Point(3, 411);
            this.textBoxItems13.Multiline = true;
            this.textBoxItems13.Name = "textBoxItems13";
            this.textBoxItems13.ReadOnly = true;
            this.textBoxItems13.Size = new System.Drawing.Size(163, 28);
            this.textBoxItems13.TabIndex = 12;
            this.textBoxItems13.Text = "Disc 12";
            this.textBoxItems13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxQueue);
            this.tabPage2.Controls.Add(this.groupBoxQueue);
            this.tabPage2.Controls.Add(this.groupActions);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 510);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Queue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxQueue
            // 
            this.textBoxQueue.Location = new System.Drawing.Point(6, 6);
            this.textBoxQueue.Multiline = true;
            this.textBoxQueue.Name = "textBoxQueue";
            this.textBoxQueue.ReadOnly = true;
            this.textBoxQueue.Size = new System.Drawing.Size(573, 315);
            this.textBoxQueue.TabIndex = 3;
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.Location = new System.Drawing.Point(717, -4);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(37, 14);
            this.restart.TabIndex = 3;
            this.restart.Text = "restart";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // FormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPage";
            this.Text = "Stack&Queue";
            this.groupActions.ResumeLayout(false);
            this.groupBoxQueue.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupItems.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.GroupBox groupBoxQueue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonClearALL;
        private System.Windows.Forms.Button buttonFront;
        private System.Windows.Forms.Button buttonRear;
        private System.Windows.Forms.Button buttonDelQueue;
        private System.Windows.Forms.Button buttonAddQueue;
        private System.Windows.Forms.TextBox textBoxQueue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupStack;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonBringStack;
        private System.Windows.Forms.Button buttonClearAllStack;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonTopCount;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.TextBox textBoxItems1;
        private System.Windows.Forms.TextBox textBoxItems2;
        private System.Windows.Forms.TextBox textBoxItems3;
        private System.Windows.Forms.TextBox textBoxItems4;
        private System.Windows.Forms.TextBox textBoxItems5;
        private System.Windows.Forms.TextBox textBoxItems6;
        private System.Windows.Forms.TextBox textBoxItems7;
        private System.Windows.Forms.TextBox textBoxItems8;
        private System.Windows.Forms.TextBox textBoxItems9;
        private System.Windows.Forms.TextBox textBoxItems10;
        private System.Windows.Forms.TextBox textBoxItems11;
        private System.Windows.Forms.TextBox textBoxItems12;
        private System.Windows.Forms.TextBox textBoxItems13;
        private System.Windows.Forms.Label restart;
    }
}

