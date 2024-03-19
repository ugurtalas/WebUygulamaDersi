$(function () {
	$(document).delegate(".AjaxCalistir", "click", function () {
		alert("Tıkandı");
		$.ajax({
			url: "/ornek/AjaxDeneme",
			type: 'post',
			dataType: 'html',
			success: function (result) {
				alert("AJAx Çalıştı");
			}
		});
	});

	$(document).delegate(".AjaxVeriGonder", "click", function () {
		alert("Tıkandı");

		Veri = {
			Ad: "Ugur",
			No:5
		}
		$.ajax({
			url: "/ornek/AjaxNesne",
			data: Veri,
			type: 'post',
			dataType: 'html',
			success: function (result) {
				alert(result);
			}
		});
	});


});