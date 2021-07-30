<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CSS" runat="Server">
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        #loginPage{
            border: 3px solid #f1f1f1;
            width: 50%;
            margin: auto;
        }

        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        button, input[type=submit] {
            background-color: blue;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
        }

            button:hover {
                opacity: 0.8;
            }

        .cancelbtn {
            width: auto;
            padding: 10px 18px;
            background-color: #f44336;
        }

        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }

        img.avatar {
            width: 40%;
            border-radius: 50%;
        }

        .container {
            padding: 16px;
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }

        /* Change styles for span and cancel button on extra small screens */
        @media screen and (max-width: 300px) {
            span.psw {
                display: block;
                float: none;
            }

            .cancelbtn {
                width: 100%;
            }
        }
    </style>
    <script runat="server">

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool hasUser = MemberUtility.CheckMemberByUserNamePassword(TextBox1.Text, TextBox2.Text);

            if (hasUser)
            {
                Session["Login"] = true;
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Label1.Text = "帳號或密碼不正確";
            }
        }

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!Page.IsPostBack)
        //    {
        //        Session["Login"] = false;
        //    }
        //}
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Html" runat="Server">
    <div id="loginPage">
        <div class="imgcontainer">
            <img src="/Images/img_avatar2.png" alt="Avatar" class="avatar" />
        </div>

        <div class="container">
            <label for="uname"><b>Username</b></label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


            <label for="psw"><b>Password</b></label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>

        <div class="container" style="background-color: #f1f1f1">
            <button type="button" class="cancelbtn">Cancel</button>
            <span class="psw">Forgot <a href="#">password?</a></span>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="js" runat="Server">
</asp:Content>

