<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>No</td>
            <td>Name</td>
            <td>class</td>
            <td>img</td>
            <td>date</td>
        </tr>
        
    </table>

    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/ko.js"></script>

    <script type="text/javascript">
        window.onload = function () {
            $.post("About.aspx", {}, function (res) {
                $(res).each(function (i, e) {
                    var item = e;
                    var tr = $("<tr>");
                    var td1 = $("<td>").text(e.ID).appendTo(tr);
                    var td2 = $("<td>").text(e.Name).appendTo(tr);
                    var td3 = $("<td>").text(e.Class).appendTo(tr);
                    var img = $("<img>").attr("src", e.imgstr).height(100);
                    var td4 = $("<td>").append(img).appendTo(tr);
                    var td5 = $("<td>").text(e.date).appendTo(tr);
                    tr.appendTo($("tbody"));
                });
            });
        }

    </script>
</asp:Content>
