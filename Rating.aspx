<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rating.aspx.cs" Inherits="StarRating.Rating" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rating</title>
    <style>
        .star-rating{
            width:50px;
            height:50px;
            cursor:pointer;
            background-repeat:no-repeat;
            display:block;
            background-size: cover;
        }
        .div-class{
            margin-left:450px;
            margin-top:300px;
            margin-right:690px;
            display:flex;
            border:2px solid black;
            flex-direction:row;

        }
        .Filled-Star{
            background-image:url("Images/FilledStar.jpg");
        }
        .Empty-Star{
            background-image:url("Images/EmptyStar.png");
        }
        .Waiting-Star{
            background-image:url("Images/WaitingStar.png");
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Star Rating System</h1>
        <div class="div-class">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <ajaxToolkit:Rating ID="Rating1" runat="server" StarCssClass="star-rating" FilledStarCssClass="Filled-Star" EmptyStarCssClass="Empty-Star" WaitingStarCssClass="Waiting-Star"></ajaxToolkit:Rating><br />
                    Your Selected Rating : <asp:Label ID="Label1" runat="server"></asp:Label><br />
                    <asp:Button ID="Button1" runat="server" Text="Submit Rating" OnClick="Button1_Click1"/>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
