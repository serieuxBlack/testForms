namespace LVTest
{
    partial class Form1
    {
        private System.Windows.Forms.ListView listView;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            // Initialize listView and set basic properties
            this.listView = new System.Windows.Forms.ListView();
            this.listView.Location = new System.Drawing.Point(10, 10);
            this.listView.Size = new System.Drawing.Size(780, 430);
            this.listView.View = System.Windows.Forms.View.Details; // Set view to show columns and details

            // Adding Columns to the ListView
            this.listView.Columns.Add("IP Address", -2, System.Windows.Forms.HorizontalAlignment.Left);
            this.listView.Columns.Add("Country", -2, System.Windows.Forms.HorizontalAlignment.Left);
            this.listView.Columns.Add("City", -2, System.Windows.Forms.HorizontalAlignment.Left);

            // Add the ListView to the Form's controls
            this.Controls.Add(this.listView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
