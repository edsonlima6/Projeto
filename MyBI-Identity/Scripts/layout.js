$(document).ready(function () {
    //ClientServer();
    HabilitaLink();
    //RemoveLink();
});

function ClientServer() {
    $("#vldAcess").click(function (e) {
        e.preventDefault();

        
        var dataMo = {};
        dataMo.Login = $('#lgn').val().trim();
        dataMo.Senha = $('#pwd').val();
        console.log(dataMo.Login);

        $.ajax({
            type: "POST",
            url: "Home/Login",
            content: "application/json",
            dataType: "json",
            data: {Login:"rola", Senha:"buceta"},
            success: function (d) {
                //if (d.success == true)
                //    window.location = "index.html";
                //else { }x
                alert("Sucesso");
            },
            error: function (xhr, textStatus, errorThrown) {
                // TODO: Show error
            }




        });




    });





}

function HabilitaLink()
{
    var n = $("form");
    if (n.length > 0) {
        $("#fix").addClass("vai");
        console.log("passou rola");
        return;
    }
    $("#fix").addClass("vai2");
    console.log("fudeo");

    //$('#navbarNav').on('shown.bs.collapse', function () {
    //    console.log("Show");
    //    $("#fix").addClass("vai");
    //});
}
function RemoveLink() {
    $('#navbarNav').on('hidden.bs.collapse', function () {
        console.log("Saiu");
        $("#fix").css("position", "inherit");
    });
}