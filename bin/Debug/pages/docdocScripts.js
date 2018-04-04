
$(function () {
    $(document).ready(function () {
       // alert("In Jquery");
        $('[id$=DropDownList1]').hide();
      

        if ($('[id$=CheckBox1]').is(':checked'))
            $('[id$=DropDownList1]').hide();  // checked
        else
            $('[id$=DropDownList1]').show();  // unchecked

        
        

    });
});



$(function () {
    $('input[id$=CheckBox1]').click(function () {
        //alert("Hello ch22!");

        if ($('[id$=CheckBox1]').is(':checked'))
            $('[id$=DropDownList1]').hide();  // checked
        else
            $('[id$=DropDownList1]').show();  // unchecked

        // show(); $("[id*=txt1]").hide();
    });
});







