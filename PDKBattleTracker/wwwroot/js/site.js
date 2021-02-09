// JQuery code to toggle scoringArea by pressing scoringButton

$(document).ready(function () {
    $(".scoringArea").hide();

    $("#scoringButton").click(function () {
        $(".scoringArea").toggle();
    });
});
