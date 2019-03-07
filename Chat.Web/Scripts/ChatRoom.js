$(document).ready(function () {

	setTimeout("RefreshMessages();", 3000);
	$("#btnSend").click(function () {
		var text = $("#txtArea").val();
		var roomId = $("#RoomId").val();
		if (text) {
			$.ajax({
				type: "POST",
				url: "/Room/SaveMessage",
				data: JSON.stringify({ "message": text, "roomId": roomId }),
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				success: function (r) {
					location.reload();
				},
				error : function ()
				{
					location.reload();
				}
			});

			$("#txtArea").val('').focus();
		}
	});
});

function RefreshMessages() {
	var roomId = $("#RoomId").val();
	$("#chatMessages").load('/Room/GetMessages?roomId=' + roomId);
	setTimeout("RefreshMessages();", 3000);
}