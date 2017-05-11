var CreateSamurai;
(function (CreateSamurai) {
    window.onload = function () {
        var element = document.getElementById("AddQuotesInput");
        element.hidden = true;
        var btn = document.getElementById("AddQuotesBtn");
        btn.onclick = function () {
            if (element.hidden)
                element.hidden = false;
            else
                element.hidden = true;
        };
    };
})(CreateSamurai || (CreateSamurai = {}));
