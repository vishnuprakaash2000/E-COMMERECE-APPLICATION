// session management applied architecture 

protected void btnSubmit_Click(object sender, EventArgs e)  
{  
   Session["FirstName"] = txtfName.Text;  
   Response.Redirect("Default2.aspx");   
}  
// Get Session values   
  
if (Session["FirstName"]!= null)  
{  
   lblString.Text = Session["FirstName"];  
}  


//camel case

public string GetPosts(string postId  
{  
   int numberOfPost = 0;   
}

//Pascal case naming convention

private int _salary = 100;  
public int Salary  
{  
    get  
    {  
        return _salary;  
    }  
    set  
    {  
        _salary = value;  
    }  
}  
                       
                      
                       
                     



















































































