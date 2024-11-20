
$(document).on("keydown", null,
    /**@param eventObject KeyboardEvent*/ (eventObject)  => {
        switch (eventObject.key) {
            case "ArrowLeft":
                console.log("left")
                break
            case "ArrowRight":
                console.log("right")
                break
            case "ArrowUp":
                console.log("up")
                break
            case "ArrowDown":
                console.log("down")
                break
        }
    console.log(eventObject);
})
