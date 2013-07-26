using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;

namespace AliceBlue
{
    public partial class ThisAddIn
    {
       
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            SharedService.PlaySound("AliceBlue.Sounds.kidou.wav");
            
            this.Application.Startup+=()=>
            {
                
            };
            this.Application.DocumentSync += (s,eve) =>
            {
                
            };

            this.Application.DocumentOpen += (eve) =>
            {
                SharedService.PlaySound("AliceBlue.Sounds.open.wav");
                
            };


            this.Application.ActiveDocument.New += () =>
                {
                    SharedService.PlaySound("AliceBlue.Sounds.create.wav");
                };


            this.Application.DocumentBeforeSave +=Application_DocumentBeforeSave;

            
        }

        private void Application_DocumentBeforeSave(Word.Document Doc, ref bool SaveAsUI, ref bool Cancel)
        {
            SharedService.PlaySound("AliceBlue.Sounds.save.wav");
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
