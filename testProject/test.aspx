<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>



</head>
<body>
    <form id="form1" runat="server">
        <div id="myDiv">
        </div>
    </form>
    <script type="text/javascript" src="Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript">

        $(function () {
            $("#Button1").click(function () {

                $.ajax({
                    type: 'get',
                    url: "WebService.asmx/test",
                    contentType: "application/json;utf-8",
                    dataType: "json",

                    success: function (result) {
                        alert(result.d);
                    }

                });

            });
        });

    </script>
    <button id="Button1">获得 JSON 数据</button>
    <p id="pp"></p>
</body>
</html>
