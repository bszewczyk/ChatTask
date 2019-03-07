$(document).ready(function () {
	$("#btnAdd").on("click", function () {
		var room = {};
		room.RoomName = $("#txtRoomName").val();
		$.ajax({
			type: "POST",
			url: "/Home/AddRoom",
			data: JSON.stringify(room),
			contentType: "application/json; charset=utf-8",
			dataType: "json",
			success: function (r) {
				location.reload();
			}
		});
	});
});