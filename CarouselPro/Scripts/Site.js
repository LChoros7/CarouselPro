$("#load").click(function () {
    var uri = 'api/slides';
    $.getJSON(uri)
        .done(function (data) {
            if ($.trim(data)) {
                $.each(data, function (key, item) {
                    $('<div class="item"><img src="' + item.Path + '" alt="' + item.AltText + '"> <div class="carousel-caption">' + item.CaptionText + '</div>').appendTo($('#slides'));
                });
                $(".item:first-child").addClass("active");
                $("#carousel-generic").slideToggle("slow");
                $("#load").prop("disabled", true)
            } else {
                $('#carousel-warning-modal').modal('show');
            }
        });
});