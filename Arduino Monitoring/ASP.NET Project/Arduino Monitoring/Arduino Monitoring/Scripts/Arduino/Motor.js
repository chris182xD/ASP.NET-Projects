function SwitchMotor() {
    $.ajax({
        type: 'GET',
        url: "/arduino/switchMotor",
        data: '{ }',
        dataType: "json",
        success: function (temperatura) {


        }

    });
}