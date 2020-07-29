$(document).ready(function () {

    $("#newItemButton").on("click", function () {

        $.get("LoadPartialViewDynamically",
            null,
            function (partialView) {
                $("#items").append(partialView);
            });
    });
});
