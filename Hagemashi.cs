using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace AliceBlue
{
    public partial class Hagemashi
    {
        private void Hagemashi_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_ganbare_Click(object sender, RibbonControlEventArgs e)
        {
            SharedService.PlaySound("AliceBlue.Sounds.hagemashi1.wav");
            
        }
    }
}
