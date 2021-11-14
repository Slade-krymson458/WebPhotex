using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebAppPhotEX
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UploadImage();
        }

        public void UploadImage()
        {
            foreach (string strFileName in Directory.GetFiles(Server.MapPath("~/Data/")))
            {
                ImageButton imageButton = new ImageButton();
                FileInfo fileInfo = new FileInfo(strFileName);
                imageButton.ImageUrl = "~/Data/" + fileInfo.Name;

                imageButton.Width = Unit.Pixel(100);
                imageButton.Height = Unit.Pixel(100);
                imageButton.Style.Add("padding", "5px");
                imageButton.Click += new ImageClickEventHandler(imageButton_Click);
                Panel1.Controls.Add(imageButton);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {       //These lines of code adds image in panel
                string fileName = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Data/" + fileName));
            }

            Response.Redirect("~/WebForm3.aspx");
           


            // Will look through each File in the data folder you created

        }


        void imageButton_Click(object sender, ImageClickEventArgs e)
        {
            
            Response.Redirect("~/WebForm4.aspx?ImageURL="+((ImageButton)sender).ImageUrl);   //("Button Clicked");
        }

     

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Webform5.aspx");
        }
    }
}