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
                       
//partial view in mvc 
            
public ActionResult PartialViewExample()  
{  
    return PartialView();  
}                       
                     

//Exceptional handling
                       
using System;
class MyClass
{
    public void Method()
    {
        try
        {
            int x = 0;
            int sum = 100 / x;
        }
        catch (DivideByZeroException)
        {
            throw;
        }
    }
}
class MyClient
{
    public static void Main()
    {
        MyClass mc = new MyClass();
        try
        {
            mc.Method();
        }
        catch (Exception)
        {
            Console.WriteLine("Exception caught here");
        }
        Console.WriteLine("LAST STATEMENT");
    }
}

















































































