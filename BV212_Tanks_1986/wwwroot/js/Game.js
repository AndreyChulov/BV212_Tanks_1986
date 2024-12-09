ResizeDiv(".GameField", ".GameFightField")
$("#NewGameButton").on("click", StartGameBtnClicked)

function StartGameBtnClicked(event){
    $.post("/StartGame")
        .done(function (data) {
            $(".GameField").remove();
            const element = $(".GameContainer");
            const html = element.html();
            element.html(html + data);
            
            $("#NewGameButton").on("click", StartGameBtnClicked)
        })
        .fail(function (data) {
            console.error("Cannot proceed [POST /StartGame]", data)
        })
}
function ResizeDiv(sourceSelector, targetSelector) {
    const source = $(sourceSelector)
    const width = source.css("width")
    const height = source.css("height")
    $(targetSelector).css("width", width)
    $(targetSelector).css("height", height)
}