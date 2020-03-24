using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace command_reviewer
{
    public partial class FRMMain : Form
    {
        private CMDExecutor executor;
        public FRMMain()
        {
            InitializeComponent();
            executor = new CMDExecutor();
        }
        private void txtCommand_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                executor.command = txtCommand.Text;
                executor.ExecuteProces();
                txtResults.AppendText(Environment.NewLine);
                this.txtResults.AppendText(executor.command);
                txtResults.AppendText(Environment.NewLine);
                txtResults.AppendText(executor.result);
                AdaptatibeText();
}
}
 private void AdaptatibeText()
{
                int newWidth = 0;
                int newHeigth = 0;
                Graphics g = txtResults.CreateGraphics();
                Font font = txtResults.Font;
                newWidth = (int)g.MeasureString(txtResults.Text, font).Width;
                newHeigth= (int)g.MeasureString(txtResults.Text, font).Height;
                txtResults.Width = newWidth;
                txtResults.Height = newHeigth;
            txtResults.Refresh();

}

}
}
