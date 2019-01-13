using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            ServiceReference1.LoginRequest s = new ServiceReference1.LoginRequest(new ServiceReference1.LoginRequestBody { userName = "sdkpezeshki", password = "sdkpezeshki" });
            //سلام مهندس کافی کد زیر را از کامنت در بیاری و بعد کنترل نقطه رو بزنی مشاهده می کنی که فقط متده های لاگین قابل دسترسی هست 
          //ServiceReference1.
            
        }
    }
}
