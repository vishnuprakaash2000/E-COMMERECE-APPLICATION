protected void btnSubmit_Click(object sender, EventArgs e)  
{  
   Session["FirstName"] = txtfName.Text;  
   Response.Redirect("Default2.aspx");   
}  
Second Page
// Get Session values   
  
if (Session["FirstName"]!= null)  
{  
   lblString.Text = Session["FirstName"];  
}  
