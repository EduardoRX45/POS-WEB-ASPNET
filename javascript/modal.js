var modal = document.getElementById("modal");
var btn_open = document.getElementById("btn_modal_open");
var btn_close = document.getElementById("btn_modal_close");

btn_open.onclick = function () {
	modal.style.display = "block";
}

btn_close.onclick = function () {
	modal.style.display = "none";
}

window.onclick = function (event) {
	if (event.target == modal) {
		modal.style.display = "none";
	}
}