<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectQs.aspx.cs" Inherits="GraphProject.Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script type="text/javascript">
        window.history.forward();
        function noBack() { window.history.forward(); }
    </script>
    <link href="includes/Default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        html,body,form
        {
            font-family:arial;
        }
    </style>
</head>
<body onload="noBack();" onpageshow="if (event.persisted) noBack();" onunload="">
    <form id="form1" runat="server">
        <p>
            <span style=" padding-left:595px; position:fixed;">
                <asp:ImageButton ID="imgA" runat="server" ImageUrl="~/ClickImages/AR.jpg" 
                    Width="65px" />
            &nbsp;
            </span>
            </p>
        <p>
            <asp:Image ID="lnA1" runat="server" style="border-width: 0px; position:fixed; padding-left: 170px; margin-top: 30px;" ImageUrl="~/Images/LA1.GIF"  />
        </p>
        <p>
            <span style=" margin-left:125px; margin-top:68px; position:fixed;">
                <asp:ImageButton ID="imgA1" runat="server" ImageUrl="~/Image/A1.jpg" OnClick="imgA1_Click" 
                    Width="65px" />
            </span>    
            &nbsp;&nbsp;
            <p>
                <asp:Image ID="lnA2" runat="server" style="border-width: 0px; position:fixed; padding-left: 469px; margin-top: -5px;" ImageUrl="~/Images/LA2.GIF"  />
            </p>
            <span style=" margin-left:434px; margin-top:32px; position:fixed;">
                <asp:ImageButton ID="imgA2" runat="server" ImageUrl="~/Image/A2.jpg" OnClick="imgA2_Click" 
                    Width="65px" />
            </span>  
            <p>
                <asp:Image ID="lnA3" runat="server" style="border-width: 0px; position:fixed; padding-left: 621px; margin-top: -5px;" ImageUrl="~/Images/LA3.GIF"  />
            </p>  
            <span style=" margin-left:745px; margin-top:32px; position:fixed;">
                <asp:ImageButton ID="imgA3" runat="server" ImageUrl="~/Image/A3.jpg" OnClick="imgA3_Click"
                Width="65px" />
            </span>
            <p>
                <asp:Image ID="lnA4" runat="server" style="border-width: 0px; position:fixed; padding-left: 629px; margin-top: -6px;" ImageUrl="~/Images/LA4.GIF"  />
            </p>    
            <span style=" margin-left:1070px; margin-top:32px; position:fixed;">
                <asp:ImageButton ID="imgA4" runat="server" ImageUrl="~/Image/A4.jpg" OnClick="imgA4_Click"
            Width="65px" />
            </span>
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            <asp:Image ID="lnA11" runat="server" style="border-width: 0px; position:fixed; padding-left: 86px; margin-top: 26px;" ImageUrl="~/Images/LA11.GIF"  />
        </p>    
        <p>
            <span style=" margin-left:50px; margin-top:112px; position:fixed;">
                <asp:ImageButton ID="imgA11" runat="server" ImageUrl="~/Image/A11.jpg" OnClick="imgA11_Click" 
                    Width="65px" />
            </span>
            &nbsp;
            <p>
                <asp:Image ID="lnA12" runat="server" style="border-width: 0px; position:fixed; padding-left: 156px; margin-top: -10px;" ImageUrl="~/Images/LA12.GIF"  />
            </p>    
            <span style=" margin-left:190px; margin-top:75px; position:fixed;">
                <asp:ImageButton ID="imgA12" runat="server" ImageUrl="~/Image/A12.jpg" OnClick="imgA12_Click" 
                    Width="65px" />
            </span>
            &nbsp;
            <p>
                <asp:Image ID="lnA21" runat="server" style="border-width: 0px; position:fixed; padding-left: 390px; margin-top: -44px;" ImageUrl="~/Images/LA21.GIF"  />
            </p>    
                <span style=" margin-left:350px; margin-top:40px; position:fixed;">
                    <asp:ImageButton ID="imgA21" runat="server" ImageUrl="~/Image/A21.jpg" OnClick="imgA21_Click"
                        Width="65px" />
                </span>
                &nbsp;
            <p>
            <asp:Image ID="lnA22" runat="server" style="border-width: 0px; position:fixed; padding-left:458px; margin-top: -80px;" ImageUrl="~/Images/LA22.GIF"  />
            </p>    
            <span style=" margin-left:505px; margin-top:3px; position:fixed;">
                <asp:ImageButton ID="imgA22" runat="server" Height="31px" OnClick="imgA22_Click"
                    ImageUrl="~/Image/A22.jpg" Width="65px" />
            </span>
            &nbsp;
            <p>
                <asp:Image ID="lnA31" runat="server" style="border-width: 0px; position:fixed; padding-left: 700px; margin-top: -118px;" ImageUrl="~/Images/LA31.GIF"  />
            </p>    
            <span style=" margin-left:657px; margin-top:-34px; position:fixed;">
                <asp:ImageButton ID="imgA31" runat="server" ImageUrl="~/Image/A31.jpg" OnClick="imgA31_Click"
                    Width="65px" />
            </span>
            &nbsp;
            <p>
                <asp:Image ID="lnA32" runat="server" style="border-width: 0px; position:fixed; padding-left: 771px; margin-top: -154px;" ImageUrl="~/Images/LA32.GIF"  />
            </p>    
            <span style=" margin-left:821px; margin-top:-72px; position:fixed;">
                <asp:ImageButton ID="imgA32" runat="server" ImageUrl="~/Image/A32.jpg" OnClick="imgA32_Click"
                    Width="65px" />
            </span>
&nbsp;
            <p>
                <asp:Image ID="lnA41" runat="server" style="border-width: 0px; position:fixed; padding-left: 1030px; margin-top: -190px;" ImageUrl="~/Images/LA41.GIF"  />
            </p>    
            <span style=" margin-left:992px; margin-top:-109px; position:fixed;">
                <asp:ImageButton ID="imgA41" runat="server" ImageUrl="~/Image/A41.jpg" OnClick="imgA41_Click"
                Width="65px" />
            </span>
&nbsp;
            <p>
                <asp:Image ID="lnA42" runat="server" style="border-width: 0px; position:fixed; padding-left: 1102px; margin-top: -228px;" ImageUrl="~/Images/LA42.GIF"  />
            </p>    
            <span style=" margin-left:1151px; margin-top:-142px; position:fixed;">
                <asp:ImageButton ID="imgA42" runat="server" ImageUrl="~/Image/A42.jpg" OnClick="imgA42_Click"
                    Width="65px" />
            </span>
        </p>
        <p>
            &nbsp;
        </p>
    <p>
        <p>
            <asp:Image ID="lnA111" runat="server" style="border-width: 0px; position:fixed; padding-left:41px; margin-top: -146px;" ImageUrl="~/Images/LA111.GIF"  />
        </p>  
        <span style=" margin-left:10px; margin-top:-61px; position:fixed; ">
            <asp:ImageButton ID="imgA111" runat="server" ImageUrl="~/Image/A111.jpg" OnClick="imgA111_Click"
            Width="65px" Height="30px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA112" runat="server" style="border-width: 0px; position:fixed; padding-left:77px; margin-top: -182px;" ImageUrl="~/Images/LA112.GIF"  />
        </p>  
        <span style=" margin-left:80px; margin-top:-97px; position:fixed;">
            <asp:ImageButton ID="imgA112" runat="server" ImageUrl="~/Image/A112.jpg" OnClick="imgA112_Click"
                Width="65px" />
        </span>
&nbsp;
        <p>
        <asp:Image ID="lnA121" runat="server" style="border-width: 0px; position:fixed; padding-left:187px; margin-top: -219px;" ImageUrl="~/Images/LA121.GIF"  />
        </p>  
        <span style=" margin-left:150px; margin-top:-134px; position:fixed;">
            <asp:ImageButton ID="imgA121" runat="server" ImageUrl="~/Image/A121.jpg" OnClick="imgA121_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA122" runat="server" style="border-width: 0px; position:fixed; padding-left:222px; margin-top: -255px;" ImageUrl="~/Images/LA122.GIF"  />
        </p>  
        <span style=" margin-left:220px; margin-top:-171px; position:fixed;">
            <asp:ImageButton ID="imgA122" runat="server" ImageUrl="~/Image/A122.jpg" OnClick="imgA122_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA211" runat="server" style="border-width: 0px; position:fixed; padding-left:344px; margin-top: -289px;" ImageUrl="~/Images/LA111.GIF"  />
        </p>  
        <span style=" margin-left:300px; margin-top:-206px; position:fixed;">
            <asp:ImageButton ID="imgA211" runat="server" ImageUrl="~/Image/A211.jpg" OnClick="imgA211_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA212" runat="server" style="border-width: 0px; position:fixed; padding-left:381px; margin-top: -325px;" ImageUrl="~/Images/LA112.GIF"  />
        </p>  
        <span style=" margin-left:370px; margin-top:-243px; position:fixed;">
            <asp:ImageButton ID="imgA212" runat="server" ImageUrl="~/Image/A212.jpg" OnClick="imgA212_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA221" runat="server" style="border-width: 0px; position:fixed; padding-left:500px; margin-top: -363px;" ImageUrl="~/Images/LA121.GIF"  />
        </p>  
        <span style=" margin-left:462px; margin-top:-279px; position:fixed;">
            <asp:ImageButton ID="imgA221" runat="server" ImageUrl="~/Image/A221.jpg" OnClick="imgA221_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA222" runat="server" style="border-width: 0px; position:fixed; padding-left:533px; margin-top: -399px;" ImageUrl="~/Images/LA122.GIF"  />
        </p>  
        <span style=" margin-left:540px; margin-top:-315px; position:fixed;">
            <asp:ImageButton ID="imgA222" runat="server" ImageUrl="~/Image/A222.jpg" OnClick="imgA222_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA311" runat="server" style="border-width: 0px; position:fixed; padding-left:645px; margin-top: -435px;" ImageUrl="~/Images/LA111.GIF"  />
        </p>  
        <span style=" margin-left:611px; margin-top:-351px; position:fixed;">
            <asp:ImageButton ID="imgA311" runat="server" ImageUrl="~/Image/A311.jpg" OnClick="imgA311_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA312" runat="server" style="border-width: 0px; position:fixed; padding-left:681px; margin-top: -473px;" ImageUrl="~/Images/LA112.GIF"  />
        </p>  
        <span style=" margin-left:682px; margin-top:-388px; position:fixed;">
            <asp:ImageButton ID="imgA312" runat="server" ImageUrl="~/Image/A312.jpg" OnClick="imgA312_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA321" runat="server" style="border-width: 0px; position:fixed; padding-left:813px; margin-top: -510px;" ImageUrl="~/Images/LA121.GIF"  />
        </p>  
        <span style=" margin-left:780px; margin-top:-425px; position:fixed;">
            <asp:ImageButton ID="imgA321" runat="server" ImageUrl="~/Image/A321.jpg" OnClick="imgA321_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA322" runat="server" style="border-width: 0px; position:fixed; padding-left:848px; margin-top: -547px;" ImageUrl="~/Images/LA122.GIF"  />
        </p>  
        <span style=" margin-left:861px; margin-top:-461px; position:fixed;">
            <asp:ImageButton ID="imgA322" runat="server" ImageUrl="~/Image/A322.jpg" OnClick="imgA322_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA411" runat="server" style="border-width: 0px; position:fixed; padding-left:980px; margin-top: -582px;" ImageUrl="~/Images/LA111.GIF"  />
        </p>  
        <span style=" margin-left:943px; margin-top:-497px; position:fixed;">
            <asp:ImageButton ID="imgA411" runat="server" ImageUrl="~/Image/A411.jpg" OnClick="imgA411_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA412" runat="server" style="border-width: 0px; position:fixed; padding-left:1017px; margin-top: -618px;" ImageUrl="~/Images/LA112.GIF"  />
        </p>  
        <span style=" margin-left:1019px; margin-top:-533px; position:fixed;">
            <asp:ImageButton ID="imgA412" runat="server" ImageUrl="~/Image/A412.jpg" OnClick="imgA412_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA421" runat="server" style="border-width: 0px; position:fixed; padding-left:1147px; margin-top: -651px;" ImageUrl="~/Images/LA121.GIF"  />
        </p>  
        <span style=" margin-left:1100px; margin-top:-569px; position:fixed;">
            <asp:ImageButton ID="imgA421" runat="server" ImageUrl="~/Image/A421.jpg" OnClick="imgA421_Click"
            Width="65px" />
        </span>
&nbsp;
        <p>
            <asp:Image ID="lnA422" runat="server" style="border-width: 0px; position:fixed; padding-left:1182px; margin-top: -690px;" ImageUrl="~/Images/LA122.GIF"  />
        </p>  
        <span style=" margin-left:1180px; margin-top:-605px; position:fixed;">
            <asp:ImageButton ID="imgA422" runat="server" ImageUrl="~/Image/A422.jpg" OnClick="imgA422_Click"
            Width="65px" />
        </span>
    </p>
    <div style="position:fixed;margin-top:-540px;left:40%;">
        <asp:Button ID="btnBack" runat="server" Text="Back to Home" CssClass="btn" 
            onclick="btnBack_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn" 
            onclick="btnClear_Click" OnClientClick="return confirm('Are you sure you want to clear selected questions?')" />
        <asp:Button ID="btnNext" runat="server" Text="Next" CssClass="btn" OnClientClick="return confirm('Are you sure you want to set selected buttons as questions?')"
            onclick="btnNext_Click" />
    </div>
    </form>
</body>
</html>
