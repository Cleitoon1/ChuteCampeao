/* 
    Custom Methods Validation
*/

$.validator.addMethod("daterangeformat", function (value, element, params) {
    var m = moment(value, params.format, true);
    var minDate = moment(params.minimumdate, params.format, true);
    var maxDate = moment(params.maximumdate, params.format, true);
    if (m.isValid() == false)
        return false;

    return m.toDate() >= minDate.toDate() && m.toDate() <= maxDate.toDate();
});

$.validator.unobtrusive.adapters.add("daterangeformat", ["minimumdate", "maximumdate", "format"], function (options) {
    var params = {
        minimumdate: options.params.minimumdate,
        maximumdate: options.params.maximumdate,
        format: (options.params.format).toUpperCase()
    };
    options.rules["daterangeformat"] = params;
    options.messages["daterangeformat"] = options.message;
});
