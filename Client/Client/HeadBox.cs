using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxShockwaveFlashObjects;
using ShockwaveFlashObjects;

namespace Client
{
    public partial class HeadBox : UserControl
    {
        public AxShockwaveFlash flashObj= new AxShockwaveFlash(); 
        public HeadBox()
        {
            InitializeComponent();
        }
      
        public void InitialFlash()
        {
            
            Controls.Add(flashObj);
            flashObj.BeginInit();
            flashObj.Location = new System.Drawing.Point(0, 0);
            //flashObj.Location = new System.Drawing.Point(0, 0);
            //flashObj.Name = "Testina";
            //flashObj.TabIndex = 0;
            //flashObj.WMode = "Transparent";
            //flashObj.Size = new System.Drawing.Size(610, 394);
            flashObj.EndInit();
            flashObj.LoadMovie(0, Application.StartupPath + "\\player.swf");
            string para = "<invoke" +
                " name=\"loadAndPlayVideo\" returntype=\"xml\">" +
                "<arguments><string>" +
                Application.StartupPath + "\\test.flv" +
                "</string></arguments></invoke>";
            flashObj.CallFunction(para);
            flashObj.Play();
        }
        
    }
}
