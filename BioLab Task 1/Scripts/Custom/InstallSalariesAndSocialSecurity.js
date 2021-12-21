
$(function () {

    $("#SelectEmpNo").select2();
    $("#SelectBranch").select2();
    $("#SelcetDepartment").select2();
    
    $("#FromEmpNo").TouchSpin({
        min: 1,
        max: 9999,
        step: 1,
        decimals: 0,
        boostat: 5,
        maxboostedstep: 10,
    });
    $("#ToEmpNo").TouchSpin({
        min: 1,
        max: 9999,
        step: 1,
        decimals: 0,
        boostat: 5,
        maxboostedstep: 10,
    });
});