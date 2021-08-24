$(window).scroll(() =>{
    if($(this).scrollTop() > 60){
        $(".navbar").removeClass("bg-transparent").addClass("navbar-color shadow-sm")
        $(".collapse").attr({id: "navbarSupportedContent"}).removeClass("d-none")
    }
    else{
        $(".navbar").removeClass("nav-color shadow-sm").addClass("bg-transparent")
        $(".collapse").attr({id: ""}).addClass("d-none");
    }
})