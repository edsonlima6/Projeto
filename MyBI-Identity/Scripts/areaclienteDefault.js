$( document ).ready(function() {
    MasksEnable();
    HideShowMenu();
    HabilitaMensalidade();
    $("#click").click(function(e){
        HabilitaSubMenu(e);
    });
});




function MasksEnable() {
    console.log("Entrou otario");
    $("#idDocument").mask("999.999.999-99");
    $("#idNumberPhone").mask("(99) 99999-9999");
    $("#idValueMensal").mask('000.000.000.000.000,00', { reverse: true });
    $("#idCEP").mask("99999-999");
    //$('.money2').mask("#.##0,00", { reverse: true });
}


function HabilitaSubMenu(e)
{
    $("li > ul").toggle(500);
    e.preventDefault();
}
function HideShowMenu(){
    $("#btnRowMenuMobile").click(function(){

        $("#navbarSupportedContent15").toggle(500); 
        
    });
  }

function HabilitaMensalidade() {

    $("#idCorrente").click(function () {
        $("#month").hide(500);
    });

    $("#idCapital").click(function () {
        $("#month").show(500);
    });
}