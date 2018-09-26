function SwitchLed() {
    $.ajax({
        type: 'GET',
        url: "/arduino/switchLed",
        data: '{ }',
        dataType: "json",
        success: function (temperatura) {


        }

    });
}