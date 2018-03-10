$(document).ready(
    CarregaModal
            );

function CarregaModal() {
    
    $("#myBtn").click(function () {
            $("#myModal").modal();
    });

    ValidaForm();
    ValidaModal();
    
}


function ValidaModal()
{
    var divSummary = $(".validation-summary-errors").find("ul");
    var countErrors = divSummary.html();

    var n = (countErrors === undefined);

    if (!(countErrors === undefined) && countErrors.length > 16)
    {
        $("#myModal").modal();
    }
}

function ValidaForm() {
    $("#btnSubmit").click(function ()
    {
        $("form").submit(function ()
        {
            var txtEmail = $("#txtEmail").val();
            var txtSenha = $("#txtSenha").val();
            if (txtEmail == "" || txtSenha == "")
            {
                $(".erroLogin").text("LOGIN/SENHA EM BRANCO.");
                $(".erroLogin").css("display", "block");
                return false;
            }

            $(".erroLogin").text("");
            $(".erroLogin").css("display", "none");
            return true;
        });

    });
   
}