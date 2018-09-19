$(document).ready(function () {
    $("#DataFundacao").mask("99/99/9999");
    $("#DataFundacao").datepicker(Utils.DatePickerUtils.onlyDatePtBr());
});