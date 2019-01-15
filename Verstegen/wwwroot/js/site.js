// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
!function (a) {
    "use strict";
    a(".menu-toggle").click(function (e) {
        e.preventDefault(), a("#sidebar-wrapper").toggleClass("active"), a(".menu-toggle > .fa-bars, .menu-toggle > .fa-times").toggleClass("fa-bars fa-times"), a(this).toggleClass("active");
    }), a('a.js-scroll-trigger[href*="#"]:not([href="#"])').click(function () {
        if (location.pathname.replace(/^\//, "") == this.pathname.replace(/^\//, "") && location.hostname == this.hostname) {
            var e = a(this.hash);
            if ((e = e.length ? e : a("[name=" + this.hash.slice(1) + "]")).length) return a("html, body").animate({
                scrollTop: e.offset().top
            }, 1e3, "easeInOutExpo"), !1;
        }
    }), a("#sidebar-wrapper .js-scroll-trigger").click(function () {
        a("#sidebar-wrapper").removeClass("active"), a(".menu-toggle").removeClass("active"), a(".menu-toggle > .fa-bars, .menu-toggle > .fa-times").toggleClass("fa-bars fa-times");
    }), a(document).scroll(function () {
        100 < a(this).scrollTop() ? a(".scroll-to-top").fadeIn() : a(".scroll-to-top").fadeOut();
    })
}(jQuery);


var locations = [
    ["Den Haag", 52.0704978, 4.3006999, 2],
    ["Amsterdam", 52.3702157, 4.8951679, 5],
    ["Utrecht", 52.0907374, 5.1214201, 3],
    ["Groningen", 53.2193835, 6.5665018, 4],
    ["Rotterdam", 51.9244201, 4.4777325, 1]
];

var map = new google.maps.Map(document.getElementById("map"), {
    zoom: 7,
    center: new google.maps.LatLng(52.132633, 5.291266),
    disableDefaultUI: true,
    mapTypeId: google.maps.MapTypeId.ROADMAP
});

var infowindow = new google.maps.InfoWindow();
var marker, i;

for (i = 0; i < locations.length; i++) {
    marker = new google.maps.Marker({
        position: new google.maps.LatLng(locations[i][1], locations[i][2]),
        map: map
    });
    google.maps.event.addListener(
        marker,
        "click",
        (function (marker, i) {
            return function () {
                infowindow.setContent(locations[i][0]);
                infowindow.open(map, marker);
            };
        })(marker, i)
    );
}

$(function () {
    $('#cat-filter').change(function () {
        $('.products').hide();
        $('#' + $(this).val()).show();
    });
});