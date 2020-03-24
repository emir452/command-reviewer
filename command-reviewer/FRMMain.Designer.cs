using System.Windows.Forms;
namespace command_reviewer
{
    partial class FRMMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "command reviewer";
            txtResults = new RichTextBox();
            txtCommand = new TextBox();
            txtCommand.KeyUp += new KeyEventHandler(txtCommand_enter);
           
            tlp = new TableLayoutPanel();
            tlp.RowCount = 2;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 66f));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
            tlp.ColumnCount = 1;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tlp.Controls.Add(txtResults, 0, 0);
            tlp.Controls.Add(txtCommand, 0, 1);
            this.Controls.Add(tlp);
            //finish 
        }

        #endregion
        private TableLayoutPanel tlp;
private RichTextBox txtResults;
        private TextBox txtCommand;
    }
}

