$(document).ready(function () {

    HabilitaLink();
    //RemoveLink();
});



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