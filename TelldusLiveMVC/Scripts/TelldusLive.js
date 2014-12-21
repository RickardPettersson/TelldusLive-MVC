function TurnOn(deviceId) {
    var jqxhr = $.ajax("/TelldusLive/TurnOnAndOffDevice/" + deviceId + "?on=true")
    .done(function (data) {
        if (data == "OK") {
            alert("success");
        } else {
            alert("error1 - " + data);
        }
        console.log('data', data);
    })
    .fail(function (data) {
        alert("error2 - " + data);
        console.log('data', data);
    });
}

function TurnOff(deviceId) {
    var jqxhr = $.ajax("/TelldusLive/TurnOnAndOffDevice/" + deviceId + "?on=false")
    .done(function (data) {
        if (data == "OK") {
            alert("success");
        } else {
            alert("error1 - " + data);
        }
        console.log('data', data);
    })
    .fail(function (data) {
        alert("error2 - " + data);
        console.log('data', data);
    });
}

function Learn(deviceId) {
    var jqxhr = $.ajax("/TelldusLive/Learn/" + deviceId)
    .done(function (data) {
        if (data == "OK") {
            alert("success");
        } else {
            alert("error1 - " + data);
        }
        console.log('data', data);
    })
    .fail(function (data) {
        alert("error2 - " + data);
        console.log('data', data);
    });
}