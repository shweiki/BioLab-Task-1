$(function () {
    $('.daterange').daterangepicker();

    $("#SelcetBonusesOpponent").select2();
    jQuery('#date-range').datepicker({
        toggleActive: true
    });
    $('.input-daterange-datepicker').daterangepicker({
        buttonClasses: ['btn', 'btn-sm'],
        applyClass: 'btn-danger',
        cancelClass: 'btn-inverse'
    });
});