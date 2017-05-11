namespace CreateSamurai {
    window.onload = () => {
        var element = document.getElementById("AddQuotesInput");
        element.hidden = true;
        var btn = document.getElementById("AddQuotesBtn") as HTMLElement;
        btn.onclick = () => {
            if (element.hidden) element.hidden = false;
            else element.hidden = true;
        }


    };



}