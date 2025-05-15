    //---------------------------------HOME--------------------------------------
//------------------Initialize Swiper
    
var swiper = new Swiper('.singleContainer', {
    slidesPerView: 'auto',
    centeredSlides: true,
    loop: true,
    autoplay: true,
    speed: 2000,

});
var swiper2 = new Swiper('.cardContainer', {
    slidesPerView: 6,
    spaceBetween: 5,
    slidesPerGroup: 2,
    autoplay: true,
    loop: true,
    speed: 2000,
    pagination: {
        el: '.swiper-pagination',
        clickable: true,
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
    breakpoints: {
        '@0.00': {
            slidesPerView: 2,
            spaceBetween: 10,
        },
        '@0.75': {
            slidesPerView: 2,
            spaceBetween: 10,
        },
        '@1.00': {
            slidesPerView: 3,
            spaceBetween: 10,
        },
        '@1.50': {
            slidesPerView: 5,
            spaceBetween: 5,
        },
    }
});
var swiper3 = new Swiper('.categoryContainer', {
    slidesPerView: 6,
    spaceBetween: 5,
    slidesPerGroup: 2,
    autoplay: true,
    loop: true,
    speed: 2000,
    pagination: {
        el: '.swiper-pagination',
        clickable: true,
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
    breakpoints: {
        '@0.00': {
            slidesPerView: 2,
            spaceBetween: 10,
        },
        '@0.75': {
            slidesPerView: 2,
            spaceBetween: 10,
        },
        '@1.00': {
            slidesPerView: 3,
            spaceBetween: 10,
        },
        '@1.50': {
            slidesPerView: 5,
            spaceBetween: 20,
        },
    }
});


//      var swiper = new Swiper('.swiper-container', {
//        slidesPerView: 'auto',
//        spaceBetween: 10,
//        // init: false,
//        pagination: {
//            el: '.swiper-pagination',
//            clickable: true,
//        },
//        breakpoints: {
//            640: {
//                slidesPerView: 'auto',
//                spaceBetween: 20,
//            },
//            768: {
//                slidesPerView: 'auto',
//                spaceBetween: 25,
//            },
//            1024: {
//                slidesPerView: 'auto',
//                spaceBetween: 30,
//            },
//        }
//    });
//    </script > -->
//    < !-- < script >
//    $('#play-video').on('click', function (e) {
//        e.preventDefault();
//        $('#video-overlay').addClass('open');
//        // $("#video-overlay").append('<iframe width="560" height="315" src="https://www.youtube.com/embed/ngElkyQ6Rhs" frameborder="0" allowfullscreen></iframe>');
//    });

//$('.video-overlay, .video-overlay-close').on('click', function (e) {
//    e.preventDefault();
//    close_video();
//});

//$(document).keyup(function (e) {
//    if (e.keyCode === 27) { close_video(); }
//});

//function close_video() {
//    $('.video-overlay.open').removeClass('open').find('iframe').remove();
//};
   //---------------------------------------HOME END---------------------------------------

//------------------------------------------Single Video--------------------------------
var swiperSingleVideo = new Swiper('.swiperSingleContainer', {
    slidesPerView: 6,
    spaceBetween: 5,
    slidesPerGroup: 2,
    autoplay: true,
    loop: true,
    pagination: {
        el: '.swiper-pagination',
        clickable: true,
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
    breakpoints: {
        '@0.00': {
            slidesPerView: 2,
            spaceBetween: 10,
        },
        '@0.75': {
            slidesPerView: 2,
            spaceBetween: 10,
        },
        '@1.00': {
            slidesPerView: 3,
            spaceBetween: 10,
        },
        '@1.50': {
            slidesPerView: 6,
            spaceBetween: 5,
        },
    }
});
$(".singleContainer").hover(function () {
    (this).swiper.autoplay.stop();
}, function () {
    (this).swiper.autoplay.start();
});
$(".cardContainer").hover(function () {
    (this).swiper.autoplay.stop();
}, function () {
    (this).swiper.autoplay.start();
});
$(".categoryContainer").hover(function () {
    (this).swiper.autoplay.stop();
}, function () {
    (this).swiper.autoplay.start();
});
$(".swiperSingleContainer").hover(function () {
    (this).swiper.autoplay.stop();
}, function () {
    (this).swiper.autoplay.start();
});

