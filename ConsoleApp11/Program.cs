using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebapplicationPractice
{
    public partial class Assigment1 ;
    System.Web.UI.Page
        {
        protected void Page_Load(object sender,EventArgs e)
    {

    }
    protected void Select_change(object sender,EventArgs e)
    {

    }
    protected void CheckBtn_Click(object sender,EventArgs e)
    {
        string productId = DropDownList1.Text;
    }
    protected void DropDownList1_SelectIndexChanged(object sender,EventArgs e)
    {
        string productId = DropDownList1.Text;
        Label1.Text = "Change";
        if(productId == "s22")
        {
            Lable1.Text = "Product name:Samsung S22 Ultra,produt price:11478";
            productimg.ImageUrl = "https:www.sammobile.com/wp-content/uploads/2021/01/galaxy-s21-ultra-review-31.jpg";
        }
        if(productId=="N1")
        {
            Lable1.Text = "Product Name: Nothing 1,Product Price:36000";
            productimg.ImageUrl = "https://www.gofindbiz.com/wp-content/uploads/2022/07/nothing-smartphone-1.jpeg";
        }
        if (productId == "13 Pro")
        {
            Lable1.Text = "Product Name:Iphone 13 PRO,product price:114000";
            productimg.Imageurl = "https://mk0appletrackvxmbhbl.kinstacdn.com/wp-content/uploads/2021/05/iphone-13-pro-max-unbox-therapy-scaled.jpg";
        }
        }
    }
}

    
