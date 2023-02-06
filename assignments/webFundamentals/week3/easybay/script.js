function alertEmpty() {
    alert("Your Cart is empty!");
}

function hideCookie() {
    var x = document.getElementById("cookie");
    if (x.style.display === "none") {
        x.style.display = "flex";
    } else {
        x.style.display = "none";
    }
}

function hover(img) {
    img.src = "images/succulents-2.jpg"
    img.alt = "after hover succulent pic"
}

function hoverOut(img) {
    img.src = "images/succulents-1.jpg"
    img.alt = "before hover pic of succulent"
}