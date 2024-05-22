using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataStructure
{
    public partial class FormPage : Form
    {

        Queue<string> queue = new Queue<string>(); // تعریف صف
        int rear = 0; // شمارنده Rear
        int front = 0; // شمارنده Front
        int discCount = 0; // تعداد تکست باکس‌های ایجاد شده

        public FormPage()
        {
            InitializeComponent();
            // تنظیمات برای FlowLayoutPanel
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft; // تنظیم جهت جریان افقی
            flowLayoutPanel1.WrapContents = false; // غیرفعال کردن قرار دادن موارد در خط جدید
        }
        private void buttonAddQueue_Click(object sender, EventArgs e)
        {
            if (queue.Count < 5 && (rear - front) < 5) // بررسی لیمیت اضافه شدن و حفظ FIFO
            {
                string car = "Car " + rear; // ایجاد متن
                queue.Enqueue(car); // اضافه کردن متن به صف
                textBoxQueue.AppendText(car + " Added in Queue" + Environment.NewLine); // نمایش متن در textBoxQueue
                AddButtonToGroupBox(car); // ایجاد دکمه جدید در groupBoxQueue
                rear++; // افزایش Rear
                buttonRear.Text = "Rear = " + rear; // تغییر متن دکمه به Rear جدید
            }
            else
            {
                MessageBox.Show("Limit reached! Cannot add more cars.");
            }
        }

        private void buttonDelQueue_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                string removedCar = queue.Dequeue(); // حذف متن از ابتدای صف
                RemoveFirstButtonFromGroupBox(); // حذف اولین دکمه از groupBoxQueue
                textBoxQueue.AppendText("Removed " + removedCar + " from Queue" + Environment.NewLine); // نمایش متن در textBoxQueue
                front++; // افزایش Front
                buttonFront.Text = "Front = " + front; // تغییر متن دکمه به Front جدید
            }
            else
            {
                MessageBox.Show("Queue is empty"); // نمایش پیام خالی بودن صف
            }
        }

        private void buttonRear_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                MessageBox.Show("Rear: " + rear); // نمایش Rear
            }
            else
            {
                MessageBox.Show("Queue is empty"); // نمایش پیام خالی بودن صف
            }
        }

        private void buttonClearALL_Click(object sender, EventArgs e)
        {
            queue.Clear(); // پاک کردن تمامی عناصر صف
            rear = 0; // بازنشانی Rear به وضعیت اولیه
            front = 0; // بازنشانی Front به وضعیت اولیه
            buttonFront.Text = "Front = " + front;
            buttonRear.Text = "Rear = " + rear;

            textBoxQueue.Clear(); // پاک کردن متن‌ها در textBoxQueue

            // حذف تمامی دکمه‌های اضافه شده به groupBoxQueue
            foreach (Control control in flowLayoutPanel1.Controls.OfType<Button>().ToList())
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose(); // تخلیه منابع
            }
        }

        private void AddButtonToGroupBox(string car)
        {
            Button button = new Button(); // ایجاد یک دکمه جدید
            button.Text = car; // تنظیم متن دکمه
            button.Size = new Size(100, 100); // تنظیم اندازه دکمه
            flowLayoutPanel1.Controls.Add(button); // اضافه کردن دکمه به FlowLayoutPanel
        }

        private void RemoveFirstButtonFromGroupBox()
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control firstControl = flowLayoutPanel1.Controls[0]; // گرفتن اولین کنترل از groupBoxQueue
                flowLayoutPanel1.Controls.Remove(firstControl); // حذف اولین کنترل از groupBoxQueue
                firstControl.Dispose(); // تخلیه منابع
            }
        }

        private void buttonFront_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                string frontCar = queue.Peek(); // گرفتن متن از ابتدای صف بدون حذف آن
                MessageBox.Show("Front: " + frontCar); // نمایش متن در پیام
            }
            else
            {
                MessageBox.Show("Queue is empty"); // نمایش خالی بودن صف
            }
        }

        bool buttonsEnabled = true; // متغیری برای نگهداری وضعیت فعال یا غیرفعال بودن دکمه‌ها

        private void buttonPush_Click(object sender, EventArgs e)
        {
            if (buttonsEnabled)
            {
                // اجازه استفاده از دکمه buttonMove و BringStack را نمی‌دهیم
                buttonMove.Enabled = false;
                buttonBringStack.Enabled = false;

                // بررسی لیمیت تعداد تکست باکس ها
                if (discCount <= 12)
                {
                    // ایجاد یک تکست باکس جدید
                    TextBox newTextBox = new TextBox();

                    // تنظیمات متناسب با تکست باکس جدید
                    newTextBox.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    newTextBox.ReadOnly = true;
                    newTextBox.Size = new Size(163, 28);
                    newTextBox.Text = "Disc " + discCount.ToString("00");
                    newTextBox.TextAlign = HorizontalAlignment.Center; // تنظیم متن در وسط

                    // محاسبه مکان جدید برای تکست باکس
                    int x = 54;
                    int y = 438 - (discCount * 30); // فاصله عمودی بین تکست باکس‌ها

                    // تنظیم مکان جدید برای تکست باکس
                    newTextBox.Location = new Point(x, y);

                    // افزودن تکست باکس جدید به groupStack
                    groupStack.Controls.Add(newTextBox);

                    // افزایش شماره تکست باکس برای استفاده در تکست باکس بعدی
                    discCount++;

                    // تغییر متن دکمه buttonTopCount
                    buttonTopCount.Text = "Top = " + discCount;
                }
                else
                {
                    MessageBox.Show("Maximum number of discs reached. Cannot add more."); // نمایش پیام پر بودن ظرفیت
                }
            }
        }
        private void buttonPop_Click(object sender, EventArgs e)
        {
            if (buttonsEnabled)
            {
                // اجازه استفاده از دکمه buttonMove را نمی‌دهیم
                buttonMove.Enabled = false;

                if (groupStack.Controls.Count > 0)
                {
                    // حذف آخرین تکست باکس از groupStack
                    Control lastControl = groupStack.Controls[groupStack.Controls.Count - 1];
                    groupStack.Controls.Remove(lastControl);
                    lastControl.Dispose(); // تخلیه منابع

                    // کاهش شماره تکست باکس برای استفاده در تکست باکس بعدی
                    discCount--;

                    // تغییر متن دکمه buttonTopCount
                    buttonTopCount.Text = "Top = " + discCount;
                }
                else
                {
                    MessageBox.Show("Stack is empty. Cannot pop."); // نمایش پیام خالی بودن استک
                }
                if (discCount == 0) // اگر دیسکی وجود نداشت دکمه ButtonMove و BringStack فعال شود
                {
                    buttonMove.Enabled = true;
                    buttonBringStack.Enabled = true;
                }
            }
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            // غیرفعال کردن دکمه‌های buttonPush و buttonPop و BringStack
            buttonPush.Enabled = false;
            buttonPop.Enabled = false;
            buttonBringStack.Enabled = false;

            if (flowLayoutPanel2.Controls.Count > 0)
            {
                // یافتن اولین تکست باکس در flowLayoutPanel2
                TextBox firstTextBox = (TextBox)flowLayoutPanel2.Controls[0];

                // حذف اولین تکست باکس از flowLayoutPanel2
                flowLayoutPanel2.Controls.Remove(firstTextBox);

                // محاسبه مختصات موقعیت جدید برای تکست باکس
                int x = 54; // مختصات x
                int y = 438 - (groupStack.Controls.Count * (28 + 6)); // مختصات y با توجه به تعداد تکست باکس‌ها

                // تنظیم موقعیت جدید برای تکست باکس
                firstTextBox.Location = new Point(x, y);

                // اضافه کردن اولین تکست باکس به groupStack
                groupStack.Controls.Add(firstTextBox);

                // بروزرسانی متن دکمه Top
                buttonTopCount.Text = "Top = " + groupStack.Controls.Count;
            }
            else
            {
                MessageBox.Show("No discs to move."); // نمایش پیام عدم وجود دیسک برای جا به جایی
            }
        }

        private void buttonClearAllStack_Click(object sender, EventArgs e)
        {
            // اگر flowLayoutPanel2 خالی بود
            if (flowLayoutPanel2.Controls.Count == 0)
            {
                // اضافه کردن تمامی textBoxItems به flowLayoutPanel2
                for (int i = 0; i <= 12; i++)
                {
                    TextBox textBox = new TextBox();

                    // تنظیمات متناسب با textBox
                    textBox.Name = "textBoxItems" + i.ToString("00");
                    textBox.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    textBox.ReadOnly = true;
                    textBox.Size = new Size(163, 28);
                    textBox.Text = "Disc " + i.ToString("00");
                    textBox.TextAlign = HorizontalAlignment.Center;

                    // اضافه کردن textBox به flowLayoutPanel2
                    flowLayoutPanel2.Controls.Add(textBox);
                    // فعال کردن دکمه‌های buttonPush و buttonPop
                    buttonPush.Enabled = true;
                    buttonPop.Enabled = true;
                    buttonBringStack.Enabled = true;
                }
            }
            // پاک کردن تمامی تکست باکس‌ها از groupStack
            groupStack.Controls.Clear();

            // بازنشانی متغیر discCount به مقدار اولیه
            discCount = 0;

            // تغییر متن دکمه Top به مقدار اولیه
            buttonTopCount.Text = "Top = " + discCount;

            // فعال کردن دکمه buttonMove و BringStack
            buttonMove.Enabled = true;
            buttonBringStack.Enabled = true;
        }

        private void buttonBringStack_Click(object sender, EventArgs e)
        {
            // غیرفعال کردن دکمه‌های buttonPush و buttonPop
            buttonPush.Enabled = false;
            buttonPop.Enabled = false;

            // اضافه کردن تمامی تکست باکس‌های flowLayoutPanel2 به groupStack
            while (flowLayoutPanel2.Controls.Count > 0)
            {
                // پیدا کردن اولین تکست باکس در flowLayoutPanel2
                TextBox firstTextBox = (TextBox)flowLayoutPanel2.Controls[0];

                // حذف اولین تکست باکس از flowLayoutPanel2
                flowLayoutPanel2.Controls.Remove(firstTextBox);

                // محاسبه مختصات موقعیت جدید برای تکست باکس
                int x = 54; // مختصات x
                int y = 438 - (groupStack.Controls.Count * (28 + 6)); // مختصات y با توجه به تعداد تکست باکس‌ها

                // تنظیم موقعیت جدید برای تکست باکس
                firstTextBox.Location = new Point(x, y);

                // اضافه کردن اولین تکست باکس به groupStack
                groupStack.Controls.Add(firstTextBox);
            }

            // بروزرسانی متن دکمه Top
            buttonTopCount.Text = "Top = " + groupStack.Controls.Count;

            if(discCount == 0) { buttonMove.Enabled = false; } // اگر دیسکی وجود نداشت دکمه ButtonMove غیرفعال شود
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}