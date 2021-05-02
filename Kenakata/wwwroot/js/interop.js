//window.Tooltipstoggle = () => {
//    $('[data-toggle="tooltip"]').tooltip({
//        trigger: 'hover'
//    });
//    $('[data-toggle="tooltip"]').on('mouseleave', function () {
//        $(this).tooltip('hide');
//    });
//    $('[data-toggle="tooltip"]').on('click', function () {
//        $(this).tooltip('dispose');
//    });

//}




function showhidecolors() {

    var circles = document.getElementsByClassName('ul2');
    var input = document.getElementsByClassName('colors');

    for (i = 0; i < input.length; i++) {
        (function (index) {
            input[index].onclick = function () {
                
                if (circles[index].style.display == 'flex')
                    circles[index].style.display = 'none';
                else
                    circles[index].style.display = 'flex'

            }
        }(i));

    }

};


function wishlistheart1() {
    console.log("hej");
    var el = document.getElementById('wishlistheart');

    el.children.style.color = "red";
}

window.removetoolTips = () => {
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));

    console.log(tooltipTriggerList)

    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {

        console.log(tooltipTriggerEl)
    });
}

window.toolTips = () => {
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));



    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {

        return new bootstrap.Tooltip(tooltipTriggerEl)
    });

    
    
}



window.shopcartcarousel = () => {
    const nextIcon = '<div id="carouselarrows" ><i class="fas fa-chevron-right"></i></div>';
    const prevIcon = '<div id="carouselarrows" ><i class="fas fa-chevron-left"></i></div>';
    $('.cart-carousel').owlCarousel({
        loop: false,
        margin: 10,
        nav: true,
        navText: [
            prevIcon,
            nextIcon
        ],
        responsive: {
            0: {
                items: 1   
            },
            576: {
                items: 2
            },
            700: {
                items: 2,
                margin: 50
            },
            820: {
                items: 3
            },
            1400: {
                items: 4
            }
        }

    });
}


window.initializeCarousel = () => {

    const nextIcon = '<div id="carouselarrows" ><i class="fas fa-chevron-right"></i></div>';
    const prevIcon = '<div id="carouselarrows" ><i class="fas fa-chevron-left"></i></div>';
    $('.owl-carousel').owlCarousel({
        loop: true,
        margin: 10,
        nav: true,
        navText: [
            prevIcon,
            nextIcon
        ],
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 2
            },
            860: {
                items: 2,
                margin: 50
            },
            1200: {
                items: 3
            }
        }

    });




    $('#categorycarousel1').carousel({ interval: 3000 });
    $('#categorycarousel2').carousel({ interval: 3400 });
    $('#categorycarousel3').carousel({ interval: 3800 });
    $('#categorycarousel4').carousel({ interval: 3000 });
    $('#categorycarousel5').carousel({ interval: 3400 });
    $('#categorycarousel6').carousel({ interval: 3800 });
    $('#categorycarousel7').carousel({ interval: 3200 });

};
