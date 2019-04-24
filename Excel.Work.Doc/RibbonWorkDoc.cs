using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Excel.Work.Doc
{
    public partial class RibbonWorkDoc
    {
        private void RibbonWorkDoc_Load(object sender, RibbonUIEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Load ribbon");
        }

        private void Button1_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void EditBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
