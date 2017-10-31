$(function () {
    $(".toggable").click(function () {
        $(this).parent().children('.toBeToggled').slideToggle();
    });
    
    $(".toggable").parent().children('.toBeToggled').toggle();
});